using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace RfpTool.Business.Components
{
    public class RtfConverter
    {
        private string _rtfText;

        public RtfConverter(string rtfText)
        {
            _rtfText = rtfText;
        }

        /// <summary>
        /// Sets the line height of the currently selected RTF code to specified value and sets margins to 0;
        /// </summary>
        /// <param name="lineHeight"></param>
        /// <returns></returns>
        public string SetLineHeight(double lineHeight)
        {
            var documentBytes = Encoding.UTF8.GetBytes(_rtfText);
            using (var reader = new MemoryStream(documentBytes))
            {
                System.Windows.Controls.RichTextBox richTextBox = new System.Windows.Controls.RichTextBox();
                richTextBox.SelectAll();
                richTextBox.Selection.Load(reader, DataFormats.Rtf);
                richTextBox.SelectAll();

                foreach (Block block in richTextBox.Document.Blocks)
                {
                    if (block is Paragraph)
                    {
                        Paragraph paragraph = (Paragraph)block;
                        paragraph.LineHeight = lineHeight;
                        paragraph.Margin = new System.Windows.Thickness(0);
                    }
                }

                TextRange textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                MemoryStream memoryStream = new MemoryStream();
                textRange.Save(memoryStream, DataFormats.Rtf);

                return ASCIIEncoding.Default.GetString(memoryStream.ToArray());
            }
        }

        public string ConvertToXaml()
        {
            System.Windows.Controls.RichTextBox richTextBox = new System.Windows.Controls.RichTextBox();

            if (string.IsNullOrEmpty(_rtfText))
            {
                return string.Empty;
            }

            TextRange textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);

            using (var rtfMemoryStream = new MemoryStream())
            {
                using (var rtfStreamWriter = new StreamWriter(rtfMemoryStream))
                {
                    rtfStreamWriter.Write(_rtfText);
                    rtfStreamWriter.Flush();
                    rtfMemoryStream.Seek(0, SeekOrigin.Begin);
                    textRange.Load(rtfMemoryStream, DataFormats.Rtf);
                }
            }

            using (var rtfMemoryStream = new MemoryStream())
            {
                textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                textRange.Save(rtfMemoryStream, DataFormats.Xaml);
                rtfMemoryStream.Seek(0, SeekOrigin.Begin);
                using (var rtfStreamReader = new StreamReader(rtfMemoryStream))
                {
                    return rtfStreamReader.ReadToEnd();
                }
            }
        }
    }
}
