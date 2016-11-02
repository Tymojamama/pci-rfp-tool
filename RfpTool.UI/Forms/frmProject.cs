using DataIntegrationHub.Business.Entities;
using RfpTool.Business.Components;
using RfpTool.Business.Entities;
using RfpTool.UI.Utilities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfWindow = System.Windows;

namespace RfpTool.UI.Forms
{
    public partial class frmProject : Form, IMessageFilter
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

        public readonly Project CurrentProject;
        private User CurrentUser;

        public frmProject(User currentUser)
        {
            InitializeComponent();
            InitializeControlsToMove();
            SetMenuUnderLine();

            CurrentProject = new Project();
            CurrentUser = currentUser;

            this.Show();
        }

        public frmProject(User currentUser, Project project)
        {
            InitializeComponent();
            InitializeControlsToMove();
            SetMenuUnderLine();

            CurrentUser = currentUser;
            CurrentProject = project;

            txtName.Text = CurrentProject.Name;
            txtDetail.Text = CurrentProject.Detail;

            if (CurrentProject.DueDate != null)
            {
                txtDueDate.Text = ((DateTime)CurrentProject.DueDate).ToString("M/d/yyyy");
            }

            LoadQuestionDgv();

            this.Show();
        }

        private void InitializeControlsToMove()
        {
            Application.AddMessageFilter(this);
            controlsToMove.Add(this.lblFormHeader);
            controlsToMove.Add(this.pnlFormHeader);
            controlsToMove.Add(this.pnlBodySummary);
            controlsToMove.Add(this.pnlQuestionBody);
        }

        private void LoadQuestionDgv()
        {
            dgvQuestions.Columns.Clear();
            dgvQuestions.DataSource = Question.GetAssociated(CurrentProject);

            dgvQuestions.Columns["ProjectQuestionId"].Visible = false;
            dgvQuestions.Columns["QuestionId"].Visible = false;

            dgvQuestions.Columns["Ordinal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvQuestions.Columns["Category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvQuestions.Columns["Subject"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvQuestions.Columns["Ordinal"].ReadOnly = false;
            dgvQuestions.Columns["Category"].ReadOnly = true;
            dgvQuestions.Columns["Subject"].ReadOnly = true;
        }

        private void lblFormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblFormClose_Click(object sender, EventArgs e)
        {
            if (!CurrentProject.IsExistingRecord)
            {
                DialogResult _dialogResult = MessageBox.Show("Are you sure you wish to exit without saving?", "Attention", MessageBoxButtons.YesNoCancel);
                if (_dialogResult == DialogResult.Yes)
                {
                    CurrentProject.DeleteFromDatabase();
                }
            }

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
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name field cannot be blank. Please correct and try again.", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                CurrentProject.Name = txtName.Text;
            }

            CurrentProject.Detail = txtDetail.Text;

            if (String.IsNullOrWhiteSpace(txtDueDate.Text))
            {
                CurrentProject.DueDate = null;
            }
            else
            {
                try
                {
                    CurrentProject.DueDate = DateTime.Parse(txtDueDate.Text);
                }
                catch
                {
                    MessageBox.Show("Due on field is not in a recognizable date format. Please correct and try again.", "Error", MessageBoxButtons.OK);
                    return;
                }
            }

            CurrentProject.SaveToDataBase(CurrentUser.UserId);
            this.Close();
        }

        private void labelMenu_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = System.Drawing.Color.DimGray;
        }

        private void labelMenu_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = System.Drawing.Color.Black;
        }

        private void lblMenuSummary_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabMain.TabPages["tabSummary"];
            SetMenuUnderLine();
        }

        private void SetMenuUnderLine()
        {
            if (tabMain.SelectedTab == tabMain.TabPages["tabSummary"])
            {
                lblMenuSummary.Font = new Font(lblMenuSummary.Font, FontStyle.Underline);
                lblMenuQuestion.Font = new Font(lblMenuQuestion.Font, FontStyle.Regular);
            }
            else if (tabMain.SelectedTab == tabMain.TabPages["tabQuestions"])
            {
                lblMenuSummary.Font = new Font(lblMenuSummary.Font, FontStyle.Regular);
                lblMenuQuestion.Font = new Font(lblMenuQuestion.Font, FontStyle.Underline);
            }
        }

        private void lblMenuQuestion_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabMain.TabPages["tabQuestions"];
            SetMenuUnderLine();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            frmSelectQuestion frmSelectQuestion = new frmSelectQuestion(CurrentUser, CurrentProject);
            frmSelectQuestion.FormClosed += frmSelectQuestion_FormClosed;
        }

        void frmSelectQuestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadQuestionDgv();
        }

        private void btnRemoveQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow == null)
            {
                return;
            }

            int index = dgvQuestions.CurrentRow.Index;
            Guid questionId = new Guid(dgvQuestions.Rows[index].Cells["QuestionId"].Value.ToString());
            ProjectQuestion projectQuestion = new ProjectQuestion(CurrentProject.ProjectId, questionId);

            projectQuestion.DeleteFromDatabase();
            LoadQuestionDgv();

            //UpdateOrdinals();
        }

        private void dgvQuestions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuestions.CurrentRow == null)
            {
                MessageBox.Show("You have not selected a question to edit. Please correct and try again.", "Error", MessageBoxButtons.OK);
                return;
            }

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
            LoadQuestionDgv();
            SelectQuestionFromProjectQuestionDgv(wpfQuestion.CurrentQuestion);
        }

        private void SelectQuestionFromProjectQuestionDgv(Question question)
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

        private void SelectProjectQuestionFromProjectQuestionDgv(ProjectQuestion projectQuestion)
        {
            foreach (DataGridViewRow dataRow in dgvQuestions.Rows)
            {
                if (new Guid(dataRow.Cells["ProjectQuestionId"].Value.ToString()) == projectQuestion.ProjectQuestionId)
                {
                    dgvQuestions.CurrentCell = dgvQuestions.Rows[dataRow.Index].Cells["Subject"];
                    break;
                }
            }
        }

        private void dgvQuestions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuestions.Columns[e.ColumnIndex].Name != "Ordinal")
            {
                return;
            }

            DataGridViewCell dataGridViewCell = dgvQuestions.Rows[e.RowIndex].Cells[e.ColumnIndex];
            int ordinal = Int32.Parse(dataGridViewCell.Value.ToString());
            
            Guid projectQuestionId = new Guid(dgvQuestions.Rows[e.RowIndex].Cells["ProjectQuestionId"].Value.ToString());
            ProjectQuestion projectQuestion = new ProjectQuestion(projectQuestionId);
            projectQuestion.Ordinal = ordinal;
            projectQuestion.SaveToDataBase(CurrentUser.UserId);
        }

        private void dgvQuestions_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == dgvQuestions.Columns["Ordinal"].Index)
            {
                MessageBox.Show("Ordinal value is not in an integer format. Please correct and try again.", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnExportProject_Click(object sender, EventArgs e)
        {
            DocumentBuilder documentBuilder = new DocumentBuilder(CurrentProject);
            documentBuilder.CreateDocument();
            documentBuilder.ProcessCompleted += documentBuilder_ProcessCompleted;

            pbLoading.Visible = true;
            btnExportProject.Enabled = false;
        }

        private void documentBuilder_ProcessCompleted(object sender, EventArgs e)
        {
            DocumentBuilder documentBuilder = (DocumentBuilder)sender;
            Process.Start(documentBuilder.DocumentPath);
            pbLoading.Visible = false;
            btnExportProject.Enabled = true;
        }
    }
}
