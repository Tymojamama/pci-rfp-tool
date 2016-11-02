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
    public partial class frmSelectQuestion : Form, IMessageFilter
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

        private User CurrentUser;
        private Project CurrentProject;

        public frmSelectQuestion(User user, Project project)
        {
            InitializeComponent();

            #region IMessageFilter Methods

            //Add controls to move the form
            Application.AddMessageFilter(this);
            controlsToMove.Add(this.lblFormHeader);
            controlsToMove.Add(this.pnlFormHeader);
            controlsToMove.Add(this.pnlBodySummary);

            #endregion

            CurrentUser = user;
            CurrentProject = project;

            this.Show();
        }

        private void LoadQuestionsDgv()
        {
            dgvQuestions.Columns.Clear();
            dgvQuestions.DataSource = Question.Search(txtQuestionSearch.Text);
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
            if (dgvQuestions.SelectedRows == null)
            {
                MessageBox.Show("You must select atleast one question to continue. Please correct and try again.", "Error", MessageBoxButtons.OK);
                return;
            }

            foreach (DataGridViewRow dataGridViewRow in dgvQuestions.SelectedRows)
            {
                int index = dgvQuestions.CurrentRow.Index;
                Guid questionId = new Guid(dataGridViewRow.Cells["QuestionId"].Value.ToString());

                ProjectQuestion projectQuestion = new ProjectQuestion();
                projectQuestion.ProjectId = CurrentProject.ProjectId;
                projectQuestion.QuestionId = questionId;
                projectQuestion.SaveToDataBase(CurrentUser.UserId);
            }

            this.Close();
        }

        private void dgvQuestions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuestions.CurrentRow == null)
            {
                MessageBox.Show("You must select a question to continue. Please correct and try again.", "Error", MessageBoxButtons.OK);
                return;
            }

            int index = dgvQuestions.CurrentRow.Index;
            Guid questionId = new Guid(dgvQuestions.Rows[index].Cells["QuestionId"].Value.ToString());

            ProjectQuestion projectQuestion = new ProjectQuestion();
            projectQuestion.ProjectId = CurrentProject.ProjectId;
            projectQuestion.QuestionId = questionId;
            projectQuestion.SaveToDataBase(CurrentUser.UserId);

            this.Close();
        }

        private void frmQuestion_FormClosed(object sender, FormClosedEventArgs e)
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

        private void txtQuestionSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                if (!String.IsNullOrEmpty(txtQuestionSearch.Text))
                {
                    dgvQuestions.Columns.Clear();
                    dgvQuestions.DataSource = Question.Search(txtQuestionSearch.Text);
                    dgvQuestions.Columns["QuestionId"].Visible = false;

                    dgvQuestions.Columns["Category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvQuestions.Columns["Subject"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
    }
}
