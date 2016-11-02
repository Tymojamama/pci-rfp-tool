using Microsoft.Office.Interop.Word;
using Novacode;
using RfpTool.Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace RfpTool.Business.Components
{
    /// <summary>
    /// Builds Request for Proposal Documents from a given project's questions.
    /// </summary>
    public class DocumentBuilder
    {
        /// <summary>
        /// Gets a boolean that indicates if the document is in the process of being created.
        /// </summary>
        public bool Processing { get; private set; }

        /// <summary>
        /// Occurs when document has been successfully created and saved to <see cref="DocumentPath"/>.
        /// </summary>
        public EventHandler ProcessCompleted;

        /// <summary>
        /// Gets the name of the created document.
        /// </summary>
        public string DocumentName { get; private set; }

        /// <summary>
        /// Gets the path of the created document.
        /// </summary>
        public string DocumentPath { get; private set; }

        private Microsoft.Office.Interop.Word.Application _wordApplication = null;
        private BackgroundWorker _backgroundWorker;
        private Document _documentWord;
        private Project _currentProject;
        private string _documentName;
        private string _documentPath;
        private string _documentRtf;
        private string _temporaryDocxPath;
        private string _temporaryRtfPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBuilder"/> class.
        /// </summary>
        /// <param name="project">Used to get project questions.</param>
        public DocumentBuilder(Project project)
        {
            _currentProject = project;
            _documentName = "RFP " + _currentProject.Name + " - " + DateTime.Now.ToString("yyyyMMdd");
            _documentPath = "C:\\Users\\" + Environment.UserName + "\\Desktop\\" + _documentName + ".docx";
            
            Processing = false;
            DocumentName = null;
            DocumentPath = null;

            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += backgroundWorker_DoWork;
            _backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
        }

        /// <summary>
        /// Creates a .docx document from a project's questions on a seperate thread.
        /// </summary>
        public void CreateDocument()
        {
            _backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Processing = true;

            CreateDocumentRtfString();
            CreateDocxDocumentFromDocumentRtfString();
            AddHeadersAndFooters();
            CopyAndSaveToPath();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Processing = false;

            Close();

            EventArgs eventArgs = new EventArgs();
            ProcessCompleted.Invoke(this, eventArgs);
        }

        private void Close()
        {
            if (_wordApplication != null)
            {
                _wordApplication.Quit(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);
            }

            if (File.Exists(_temporaryRtfPath))
            {
                File.Delete(_temporaryRtfPath);
            }

            if (File.Exists(_temporaryDocxPath))
            {
                File.Delete(_temporaryDocxPath);
            }
        }

        /// <summary>
        /// Copies file at <see cref="_temporaryDocxPath"/> to <see cref="DocumentPath"/> and sets
        /// <see cref="DocumentName"/> and <see cref="DocumentPath"/>.
        /// </summary>
        private void CopyAndSaveToPath()
        {
            if (File.Exists(_documentPath))
            {
                AppendToFileName(1);
            }
            else
            {
                DocumentName = _documentName;
                DocumentPath = _documentPath;
            }
            
            File.Copy(_temporaryDocxPath, DocumentPath, false);
        }

        /// <summary>
        /// Recursive method that appends "(n)" to the end of document name in <see cref="DocumentPath"/> if the file already exists.
        /// </summary>
        /// <param name="n">First value used to check or set the name of the file.</param>
        private void AppendToFileName(int n)
        {
            _documentName = "RFP " + _currentProject.Name + " - " + DateTime.Now.ToString("yyyyMMdd") + " (" + n.ToString() + ")";
            _documentPath = "C:\\Users\\" + Environment.UserName + "\\Desktop\\" + _documentName + ".docx";

            if (File.Exists(_documentPath))
            {
                n++;
                AppendToFileName(n);
            }
            else
            {
                DocumentName = _documentName;
                DocumentPath = _documentPath;
                return;
            }
        }

        /// <summary>
        /// Creates <see cref="_documentRtf"/> code in .rtf format using the project's questions.
        /// </summary>
        /// <remarks>
        /// This method creates question-response sections from templates in the <see cref="Properties.Resources"/>
        /// class and merges rtf files using the <see cref="Merge"/> method.
        /// </remarks>
        private void CreateDocumentRtfString()
        {
            string previousCategory = null;

            string frontPageRtf = Properties.Resources.ExportFrontPage;
            string questionaireResponseRtf = Properties.Resources.ExportQuestionaireResponsesRtf;
            string disclosureRtf = Properties.Resources.ExportDisclosure;
            string appendixRtf = Properties.Resources.ExportAppendix;

            if (_currentProject.DueDate != null)
            {
                frontPageRtf = frontPageRtf.Replace("__CURRENT_DATE__", ((DateTime)_currentProject.DueDate).ToString("MMMM dd, yyyy"));
            }
            else
            {
                frontPageRtf = frontPageRtf.Replace("__CURRENT_DATE__", "");
            }

            foreach (DataRow dataRow in Question.GetAssociated(_currentProject).Rows)
            {
                Guid projectQuestionId = new Guid(dataRow["ProjectQuestionId"].ToString());
                ProjectQuestion projectQuestion = new ProjectQuestion(projectQuestionId);
                Question question = new Question(projectQuestion.QuestionId);
                StringMap category;

                if (question.CategoryId == null)
                {
                    category = null;
                }
                else
                {
                    category = new StringMap((Guid)question.CategoryId);
                }

                string categoryRtf = Properties.Resources.ExportQuestionCategoryRtf;
                string questionRtf = Properties.Resources.ExportQuestionRtf;

                questionRtf = questionRtf.Replace("__QUESTION_NUMBER__", projectQuestion.Ordinal.ToString());
                questionRtf = questionRtf.Replace("__QUESTION_SUBJECT__", question.Subject);
                //questionRtf = questionRtf.Replace("__QUESTION_RESPONSE__", question.Response);
                questionRtf = Merge(questionRtf, question.Response);

                if (category == null)
                {
                    categoryRtf = categoryRtf.Replace("__QUESTION_CATEGORY__", "Uncategorized");
                    questionRtf = Merge(categoryRtf, questionRtf);
                    previousCategory = null;
                }
                else if (previousCategory != category.StringValue)
                {
                    categoryRtf = categoryRtf.Replace("__QUESTION_CATEGORY__", category.StringValue);
                    questionRtf = Merge(categoryRtf, questionRtf);
                    previousCategory = category.StringValue;
                }

                if (String.IsNullOrWhiteSpace(_documentRtf))
                {
                    _documentRtf = questionRtf;
                }
                else
                {
                    _documentRtf = Merge(_documentRtf, questionRtf);
                }
            }

            _documentRtf = Merge(questionaireResponseRtf, _documentRtf);
            _documentRtf = Merge(frontPageRtf, _documentRtf);
            _documentRtf = Merge(_documentRtf, disclosureRtf);
        }

        /// <summary>
        /// Converts <see cref="_documentRtf"/> to a temprary file, applies formatting, converts to
        /// .docx file format, and saves to a new temporary file.
        /// </summary>
        private void CreateDocxDocumentFromDocumentRtfString()
        {
            // Save file in temporary folder
            _temporaryRtfPath = Path.GetTempPath() + "\\" + _currentProject.ProjectId.ToString() + ".rtf";
            _temporaryDocxPath = Path.GetTempPath() + "\\" + _currentProject.ProjectId.ToString() + ".docx";

            File.WriteAllText(_temporaryRtfPath, _documentRtf);

            _wordApplication = new Microsoft.Office.Interop.Word.Application();
            _wordApplication.Visible = false;

            _documentWord = _wordApplication.Documents.Open(_temporaryRtfPath);

            bool inQuestions = false;
            bool pastQuestionaireResponses = false;
            bool pastTableOfContents = false;

            foreach (Microsoft.Office.Interop.Word.Paragraph paragraph in _documentWord.Content.Paragraphs)
            {
                if (paragraph.Range.ListFormat.ListType == WdListType.wdListBullet)
                {
                    paragraph.Range.ListFormat.RemoveNumbers();
                    paragraph.Range.ListFormat.ApplyBulletDefault();
                }

                if (pastTableOfContents)
                {
                    paragraph.SpaceAfter = 6f;

                    if (paragraph.Range.Text == "\r")
                    {
                        paragraph.Range.Delete();
                    }
                }

                if (inQuestions && pastQuestionaireResponses)
                {
                    paragraph.LineSpacing = 13.8f;

                    int n = 0;
                    if ((int.TryParse(paragraph.Range.Text[0].ToString(), out n) == false || paragraph.Range.Font.Bold != -1)
                        && paragraph.Range.Font.ColorIndex != WdColorIndex.wdDarkBlue && paragraph.Range.Font.ColorIndex != WdColorIndex.wdDarkRed)
                    {
                        if (paragraph.Range.ListFormat.ListType == WdListType.wdListBullet)
                        {
                            paragraph.LeftIndent = 54f;
                        }
                        else
                        {
                            paragraph.LeftIndent = 18f;
                        }
                    }
                }

                if (paragraph.Range.Font.Bold == -1 && paragraph.Range.Font.ColorIndex == WdColorIndex.wdDarkBlue && pastQuestionaireResponses)
                {
                    inQuestions = true;
                }
                else if (paragraph.Range.Text.Contains("Questionnaire Responses\r"))
                {
                    inQuestions = true;
                    pastQuestionaireResponses = true;
                    paragraph.Range.Bold = 1;
                }
                else if (paragraph.Range.Text.Contains("Disclosures\r"))
                {
                    inQuestions = false;
                    paragraph.Range.Bold = 1;
                }
                else if (paragraph.Range.Text.Contains("Table of Contents\r"))
                {
                    pastTableOfContents = true;
                    paragraph.Range.Bold = 1;
                }
            }

            _documentWord.SaveAs2(_temporaryDocxPath, Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocumentDefault);
            _documentWord.Close();
        }

        /// <summary>
        /// Adds headers and footers to the existing temporary .docx file and overwrites changes to the existing temporary file.
        /// </summary>
        private void AddHeadersAndFooters()
        {
            using (DocX docxDocument = DocX.Load(_temporaryDocxPath))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    System.Drawing.Image headerImage = System.Drawing.Image.FromHbitmap(Properties.Resources.header.GetHbitmap());
                    headerImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);  // Save your picture in a memory stream.
                    memoryStream.Seek(0, SeekOrigin.Begin);

                    Novacode.Image novacodeHeaderImage = docxDocument.AddImage(memoryStream); // Create image.
                    Picture headerPicture = novacodeHeaderImage.CreatePicture();     // Create picture.
                    headerPicture.Width = 756;
                    headerPicture.Height = 55;

                    docxDocument.AddHeaders();
                    Novacode.Paragraph headerParagraph = docxDocument.Headers.odd.Paragraphs[0];
                    headerParagraph.Direction = Novacode.Direction.LeftToRight;
                    headerParagraph.AppendPicture(headerPicture);
                    headerParagraph.IndentationBefore = -1.6f;
                }

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    System.Drawing.Image footerImage = System.Drawing.Image.FromHbitmap(Properties.Resources.footer.GetHbitmap());
                    footerImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);  // Save your picture in a memory stream.
                    memoryStream.Seek(0, SeekOrigin.Begin);

                    Novacode.Image novacodeFooterImage = docxDocument.AddImage(memoryStream); // Create image.
                    Picture footerPicture = novacodeFooterImage.CreatePicture();     // Create picture.
                    footerPicture.Width = 756;
                    footerPicture.Height = 55;

                    docxDocument.AddFooters();
                    Novacode.Paragraph footerParagraph = docxDocument.Footers.odd.Paragraphs[0];
                    footerParagraph.Direction = Novacode.Direction.LeftToRight;
                    footerParagraph.AppendPicture(footerPicture);
                    footerParagraph.IndentationBefore = -1.6f;
                    footerParagraph.Alignment = Alignment.right;
                    footerParagraph.AppendPageNumber(Novacode.PageNumberFormat.normal);
                }

                docxDocument.SaveAs(_temporaryDocxPath);
            }
        }

        /// <summary>
        /// Merges two rtf code strings into one rtf code string.
        /// </summary>
        /// <param name="firstRtfString">Rtf code to be displayed first in merged code.</param>
        /// <param name="secondRtfString">Rtf code to be displayed second in merged code.</param>
        /// <returns>Merged rtf code string.</returns>
        private string Merge(string firstRtfString, string secondRtfString)
        {
            using (RichTextBox temporary = new RichTextBox())
            {
                using (RichTextBox merged = new RichTextBox())
                {
                    temporary.Rtf = firstRtfString;
                    temporary.SelectAll();
                    temporary.Cut();
                    merged.Paste();

                    merged.AppendText(Environment.NewLine);
                    merged.AppendText(Environment.NewLine);

                    temporary.Rtf = secondRtfString;
                    temporary.SelectAll();
                    temporary.Cut();
                    merged.Paste();

                    return merged.Rtf;
                }
            }
        }
    }
}