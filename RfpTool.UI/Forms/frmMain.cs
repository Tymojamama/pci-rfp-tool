using DataIntegrationHub.Business.Entities;
using RfpTool.Business.Components;
using RfpTool.Business.Entities;
using RfpTool.Security;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WpfWindow = System.Windows;
using System.Windows.Forms;

namespace RfpTool.UI.Forms
{
    public partial class frmMain : Form, IMessageFilter
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

        public User CurrentUser;
        internal SecurityComponent Security;

        public frmMain()
        {
            this.Enabled = false;

            InitializeComponent();

            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

            #region IMessageFilter Methods

            //Add controls to move the form
            Application.AddMessageFilter(this);
            controlsToMove.Add(this.lblFormHeader);
            controlsToMove.Add(this.pnlFormHeader);
            controlsToMove.Add(this.pnlProjectHeader);
            controlsToMove.Add(this.pnlProjectBody);
            controlsToMove.Add(this.pnlQuestionHeader);
            controlsToMove.Add(this.pnlQuestionBody);
            controlsToMove.Add(this.pnlCategoryHeader);
            controlsToMove.Add(this.pnlCategoryBody);

            #endregion

            SetMenuUnderLine();

            VerifyDatabaseConnection();
            LogInCurrentUser();
            ProcessSecurityComponent();

            if (!Security.IsAdmin())
            {
                MessageBox.Show("You do not have the required permissions to use this tool. Please see your systems administrator.", "Attention", MessageBoxButtons.OK);
                this.Enabled = false;
                return;
            }

            lblLoginStatus.Text += CurrentUser.DomainName;

            cboQuestionViews.SelectedIndex = 0;
            cboCategoryViews.SelectedIndex = 0;
            cboProjectViews.SelectedIndex = 0;
        }

        private void VerifyDatabaseConnection()
        {
            if (Database.ConnectionSucceeded())
            {
                this.Enabled = true;
            }
            else
            {
                this.Enabled = false;
                try
                {
                    Database.RfpTool.ExecuteStoredProcedureQuery("[dbo].[usp_ProjectGetAll]");
                }
                catch (Exception ex)
                {
                    var message = "An error occurred connecting to the database: ";
                    message += ex.Message;
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK);
                }
                this.Close();
            }
        }

        private void LogInCurrentUser()
        {
            string _userName = Environment.UserDomainName + "\\" + Environment.UserName;
            CurrentUser = new User(_userName);
        }

        private void ProcessSecurityComponent()
        {
            Security = new SecurityComponent(CurrentUser);
        }

        private void lblFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblFormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            label.BackColor = System.Drawing.Color.DarkBlue;
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

        private void SetMenuUnderLine()
        {
            if (tabMain.SelectedTab == tabMain.TabPages["tabQuestion"])
            {
                lblMenuProject.Font = new Font(lblMenuProject.Font, FontStyle.Regular);
                lblMenuQuestion.Font = new Font(lblMenuQuestion.Font, FontStyle.Underline);
                lblMenuCategory.Font = new Font(lblMenuCategory.Font, FontStyle.Regular);
            }
            else if (tabMain.SelectedTab == tabMain.TabPages["tabCategory"])
            {
                lblMenuProject.Font = new Font(lblMenuProject.Font, FontStyle.Regular);
                lblMenuQuestion.Font = new Font(lblMenuQuestion.Font, FontStyle.Regular);
                lblMenuCategory.Font = new Font(lblMenuCategory.Font, FontStyle.Underline);
            }
            else if (tabMain.SelectedTab == tabMain.TabPages["tabProject"])
            {
                lblMenuProject.Font = new Font(lblMenuProject.Font, FontStyle.Underline);
                lblMenuQuestion.Font = new Font(lblMenuQuestion.Font, FontStyle.Regular);
                lblMenuCategory.Font = new Font(lblMenuCategory.Font, FontStyle.Regular);
            }
        }

        private void cboQuestionViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadQuestionsDgv();
        }

        private void LoadQuestionsDgv()
        {
            dgvQuestions.Columns.Clear();
            dgvQuestions.DataSource = Question.GetAllQuestions();
            dgvQuestions.Columns["QuestionId"].Visible = false;

            dgvQuestions.Columns["Category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvQuestions.Columns["Subject"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            wpfQuestion wpfQuestion = new wpfQuestion();
            wpfQuestion.CurrentWindow.Closed += wpfQuestion_Closed;

            RTFEditor.RTFBox box = new RTFEditor.RTFBox();
            WpfWindow.Window window = new WpfWindow.Window();
            window.Content = box;
        }

        void wpfQuestion_Closed(object sender, EventArgs e)
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

        private void SelectQuestionFromCategoryDgv(StringMap stringMap)
        {
            foreach (DataGridViewRow dataRow in dgvCategories.Rows)
            {
                if (new Guid(dataRow.Cells["StringMapId"].Value.ToString()) == stringMap.StringMapId)
                {
                    dgvCategories.CurrentCell = dgvCategories.Rows[dataRow.Index].Cells["StringValue"];
                    break;
                }
            }
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow == null)
            {
                MessageBox.Show("You have not selected a question to edit. Please correct and try again.", "Error", MessageBoxButtons.OK);
                return;
            }

            int _index = dgvQuestions.CurrentRow.Index;
            Guid _questionId = new Guid(dgvQuestions.Rows[_index].Cells["QuestionId"].Value.ToString());
            Question _question = new Question(_questionId);

            wpfQuestion wpfQuestion = new wpfQuestion(_question);
            wpfQuestion.CurrentWindow.Closed += wpfQuestion_Closed;
        }

        private void lblMenuQuestion_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabMain.TabPages["tabQuestion"];
            SetMenuUnderLine();
        }

        private void lblMenuCategory_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabMain.TabPages["tabCategory"];
            SetMenuUnderLine();
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow == null)
            {
                MessageBox.Show("You have not selected a question to edit. Please correct and try again.", "Error", MessageBoxButtons.OK);
                return;
            }

            int _index = dgvQuestions.CurrentRow.Index;
            Guid _questionId = new Guid(dgvQuestions.Rows[_index].Cells["QuestionId"].Value.ToString());
            Question _question = new Question(_questionId);

            DialogResult _dialogResult = MessageBox.Show("Are you sure you wish to delete the selected question \"" + _question.Subject + "\"?", "Attention", MessageBoxButtons.YesNoCancel);
            if (_dialogResult != DialogResult.Yes)
                return;

            _question.DeleteFromDatabase();
            LoadQuestionsDgv();
        }

        private void cboCategoryViews_Click(object sender, EventArgs e)
        {
            LoadCategoryDgv();
        }

        private void LoadCategoryDgv()
        {
            dgvCategories.Columns.Clear();
            dgvCategories.DataSource = StringMap.GetDataTableAssociatedFromColumn("Question", "CategoryId");

            dgvCategories.Columns["StringMapId"].Visible = false;

            dgvCategories.Columns["StringValue"].HeaderText = "Category";
            dgvCategories.Columns["ModifiedOn"].HeaderText = "Modified On";
            dgvCategories.Columns["CreatedOn"].HeaderText = "Created On";

            dgvCategories.Columns["StringValue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCategories.Columns["ModifiedOn"].Width = 125;
            dgvCategories.Columns["CreatedOn"].Width = 125;
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            frmCategory _frmCategory = new frmCategory(CurrentUser);
            _frmCategory.FormClosed += frmCategory_FormClosed;
        }

        private void frmCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCategory frmCategory = (frmCategory)sender;
            LoadCategoryDgv();
            SelectQuestionFromCategoryDgv(frmCategory.CurrentStringMap);
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null)
            {
                MessageBox.Show("You have not selected a category to edit. Please correct and try again.", "Error", MessageBoxButtons.OK);
                return;
            }

            int _index = dgvCategories.CurrentRow.Index;
            Guid _stringMapId = new Guid(dgvCategories.Rows[_index].Cells["StringMapId"].Value.ToString());
            StringMap _stringMap = new StringMap(_stringMapId);

            frmCategory _frmCategory = new frmCategory(CurrentUser, _stringMap);
            _frmCategory.FormClosed += frmCategory_FormClosed;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null)
            {
                MessageBox.Show("You have not selected a category to edit. Please correct and try again.", "Error", MessageBoxButtons.OK);
                return;
            }

            int _index = dgvCategories.CurrentRow.Index;
            Guid _stringMapId = new Guid(dgvCategories.Rows[_index].Cells["StringMapId"].Value.ToString());
            StringMap _stringMap = new StringMap(_stringMapId);

            DialogResult _dialogResult = MessageBox.Show("Are you sure you wish to delete the selected category \"" + _stringMap.StringValue + "\"?", "Attention", MessageBoxButtons.YesNoCancel);
            if (_dialogResult != DialogResult.Yes)
                return;

            _stringMap.DeleteFromDatabase();
            LoadCategoryDgv();
        }

        private void cboCategoryViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCategoryDgv();
        }

        private void dgvQuestions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int _index = dgvQuestions.CurrentRow.Index;
            Guid _questionId = new Guid(dgvQuestions.Rows[_index].Cells["QuestionId"].Value.ToString());
            Question _question = new Question(_questionId);

            wpfQuestion wpfQuestion = new wpfQuestion(_question);
            wpfQuestion.CurrentWindow.Closed += wpfQuestion_Closed;
        }

        private void dgvCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int _index = dgvCategories.CurrentRow.Index;
            Guid _stringMapId = new Guid(dgvCategories.Rows[_index].Cells["StringMapId"].Value.ToString());
            StringMap _stringMap = new StringMap(_stringMapId);

            frmCategory _frmCategory = new frmCategory(CurrentUser, _stringMap);
            _frmCategory.FormClosed += frmCategory_FormClosed;
        }

        private void pnlFormHeader_DoubleClick(object sender, EventArgs e)
        {
            MaximizeForm();
        }

        private void MaximizeForm()
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

            // We have to refresh ComboBoxes because they don't draw well after performing this function.
            foreach (ComboBox comboBox in GetAll(this, typeof(ComboBox)))
            {
                comboBox.Refresh();
            }
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
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

        private void lblMenuProject_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabMain.TabPages["tabProject"];
            SetMenuUnderLine();
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            frmProject frmProject = new frmProject(CurrentUser);
            frmProject.FormClosed += frmProject_FormClosed;
        }

        private void frmProject_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmProject frmProject = (frmProject)sender;
            LoadProjectDgv();
            SelectProjectFromProjectDgv(frmProject.CurrentProject);
        }

        private void cboProjectViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProjectDgv();
        }

        private void LoadProjectDgv()
        {
            dgvProjects.DataSource = Project.GetAll();
            dgvProjects.Columns["ProjectId"].Visible = false;

            dgvProjects.Columns["DueDate"].HeaderText = "Due On";

            dgvProjects.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvProjects.Columns["DueDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvProjects.Columns["Detail"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void SelectProjectFromProjectDgv(Project project)
        {
            foreach (DataGridViewRow dataRow in dgvProjects.Rows)
            {
                if (new Guid(dataRow.Cells["ProjectId"].Value.ToString()) == project.ProjectId)
                {
                    dgvProjects.CurrentCell = dgvProjects.Rows[dataRow.Index].Cells["Name"];
                    break;
                }
            }
        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {
            if (dgvProjects.CurrentRow == null)
            {
                MessageBox.Show("You have not selected a project to edit. Please correct and try again.", "Error", MessageBoxButtons.OK);
                return;
            }

            int index = dgvProjects.CurrentRow.Index;
            Guid projectId = new Guid(dgvProjects.Rows[index].Cells["ProjectId"].Value.ToString());
            Project project = new Project(projectId);

            frmProject frmProject = new frmProject(CurrentUser, project);
            frmProject.FormClosed += frmProject_FormClosed;
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            if (dgvProjects.CurrentRow == null)
            {
                MessageBox.Show("You have not selected a project to delete. Please correct and try again.", "Error", MessageBoxButtons.OK);
                return;
            }

            int index = dgvProjects.CurrentRow.Index;
            Guid projectId = new Guid(dgvProjects.Rows[index].Cells["ProjectId"].Value.ToString());
            Project project = new Project(projectId);

            DialogResult _dialogResult = MessageBox.Show("Are you sure you wish to delete the selected question \"" + project.Name + "\"?", "Attention", MessageBoxButtons.YesNoCancel);
            if (_dialogResult == DialogResult.Yes)
            {
                project.DeleteFromDatabase();
                LoadProjectDgv();
            }
        }

        private void dgvProjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            int index = e.RowIndex;
            Guid projectId = new Guid(dgvProjects.Rows[index].Cells["ProjectId"].Value.ToString());
            Project project = new Project(projectId);

            frmProject frmProject = new frmProject(CurrentUser, project);
            frmProject.FormClosed += frmProject_FormClosed;
        }
    }
}
