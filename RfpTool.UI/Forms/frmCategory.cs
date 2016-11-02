using DataIntegrationHub.Business.Entities;
using RfpTool.Business.Components;
using RfpTool.Business.Entities;
using RfpTool.UI.Utilities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfWindow = System.Windows;

namespace RfpTool.UI.Forms
{
    public partial class frmCategory : Form, IMessageFilter
    {
        #region IMessageFilter Members

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private HashSet<Control> controlsToMove = new HashSet<Control>();

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN &&
                 controlsToMove.Contains(Control.FromHandle(m.HWnd)))
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }

        #endregion

        public readonly StringMap CurrentStringMap;
        private User CurrentUser;

        public frmCategory(User _currentUser)
        {
            InitializeComponent();

            #region IMessageFilter Methods

            //Add controls to move the form
            Application.AddMessageFilter(this);
            controlsToMove.Add(this.lblFormHeader);
            controlsToMove.Add(this.pnlFormHeader);
            controlsToMove.Add(this.pnlBodySummary);

            #endregion

            CurrentUser = _currentUser;
            CurrentStringMap = new StringMap();
            CurrentStringMap.TableName = "Question";
            CurrentStringMap.ColumnName = "CategoryId";

            this.Show();
        }

        public frmCategory(User _currentUser, StringMap _stringMap)
        {
            InitializeComponent();

            #region IMessageFilter Methods

            //Add controls to move the form
            Application.AddMessageFilter(this);
            controlsToMove.Add(this.lblFormHeader);
            controlsToMove.Add(this.pnlFormHeader);
            controlsToMove.Add(this.pnlBodySummary);
            
            #endregion

            CurrentUser = _currentUser;
            CurrentStringMap = _stringMap;
            CurrentStringMap.TableName = "Question";
            CurrentStringMap.ColumnName = "CategoryId";

            txtStringValue.Text = CurrentStringMap.StringValue;

            LoadQuestionsDgv();

            this.Show();
        }

        private void LoadQuestionsDgv()
        {
            dgvQuestions.Columns.Clear();
            dgvQuestions.DataSource = Question.GetAssociated(CurrentStringMap);
            dgvQuestions.Columns["QuestionId"].Visible = false;

            dgvQuestions.Columns["Category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvQuestions.Columns["Subject"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void lblFormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelGray_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = System.Drawing.Color.Black;
            label.BackColor = System.Drawing.Color.DarkGray;
        }

        private void labelGray_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = System.Drawing.Color.White;
            label.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CurrentStringMap.StringValue = txtStringValue.Text;
            CurrentStringMap.SaveToDataBase(CurrentUser.UserId);
            this.Close();
        }

        private void txtStringValue_TextChanged(object sender, EventArgs e)
        {
            RichTextBox _richTextBox = (RichTextBox)sender;
            AutoFormatFont(_richTextBox);
        }

        private void AutoFormatFont(RichTextBox _richTextBox)
        {
            _richTextBox.Font = new Font(_richTextBox.Font, FontStyle.Regular);
        }

        private void dgvQuestions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int _index = dgvQuestions.CurrentRow.Index;
            Guid _questionId = new Guid(dgvQuestions.Rows[_index].Cells["QuestionId"].Value.ToString());
            Question _question = new Question(_questionId);

            wpfQuestion _frmQuestion = new wpfQuestion(_question);
            _frmQuestion.CurrentWindow.Closed += frmQuestion_FormClosed;
        }

        private void frmQuestion_FormClosed(object sender, EventArgs e)
        {
            WpfWindow.Window window = (WpfWindow.Window)sender;
            wpfQuestion wpfQuestion = (wpfQuestion)window.Content;
            LoadQuestionsDgv();
            SelectQuestionFromQuestionsDgv(wpfQuestion.CurrentQuestion);
        }

        private void SelectQuestionFromQuestionsDgv(Question question)
        {
            foreach (DataGridViewRow dataRow in dgvQuestions.Rows)
            {
                if (new Guid(dataRow.Cells["QuestionId"].Value.ToString()) == question.QuestionId)
                {
                    dgvQuestions.CurrentCell = dgvQuestions.Rows[dataRow.Index].Cells["Subject"];
                    break;
                }
            }
        }
    }
}
