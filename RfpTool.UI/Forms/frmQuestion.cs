using DW.RtfWriter;
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

namespace RfpTool.UI.Forms
{
    public partial class frmQuestion_OLD : Form, IMessageFilter
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

        public readonly Question CurrentQuestion;
        private User CurrentUser;
        private bool _unsavedChanges = false;

        public frmQuestion_OLD(User _currentUser)
        {
            InitializeComponent();

            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

            #region IMessageFilter Methods

            //Add controls to move the form
            Application.AddMessageFilter(this);
            controlsToMove.Add(this.lblFormHeader);
            controlsToMove.Add(this.pnlFormHeader);
            controlsToMove.Add(this.pnlBodySummary);

            #endregion

            CurrentUser = _currentUser;
            CurrentQuestion = new Question();

            LoadCategoryCbo();

            this.Show();
        }

        public frmQuestion_OLD(User _currentUser, Question _question)
        {
            InitializeComponent();

            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

            #region IMessageFilter Methods

            //Add controls to move the form
            Application.AddMessageFilter(this);
            controlsToMove.Add(this.lblFormHeader);
            controlsToMove.Add(this.pnlFormHeader);
            controlsToMove.Add(this.pnlBodySummary);
            
            #endregion

            CurrentUser = _currentUser;
            CurrentQuestion = _question;

            txtQuestion.Text = CurrentQuestion.Subject;

            RtfConverter rtfConverter = new RtfConverter(CurrentQuestion.Response);
            txtResponse.Rtf = rtfConverter.SetLineHeight(10.0);

            LoadCategoryCbo();
            SelectValueInCategoryCbo(CurrentQuestion.CategoryId);

            this.Show();
        }

        private void lblFormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblFormClose_Click(object sender, EventArgs e)
        {

            if (_unsavedChanges)
            {
                DialogResult _dialogResult = MessageBox.Show("Are you sure you wish to exit? Any unsaved changes will be lost.", "Attention", MessageBoxButtons.YesNoCancel);
                if (_dialogResult != DialogResult.Yes)
                {
                    return;
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
            if (cboCategory.SelectedIndex == -1)
            {
                CurrentQuestion.CategoryId = null;
            }
            else
            {
                CurrentQuestion.CategoryId = ((StringMap)((ListItem)cboCategory.SelectedItem).HiddenObject).StringMapId;
            }

            CurrentQuestion.Subject = txtQuestion.Text;
            CurrentQuestion.Response = txtResponse.Rtf;
            CurrentQuestion.SaveToDataBase(CurrentUser.UserId);
            this.Close();
        }

        private void SelectValueInCategoryCbo(Guid? _categoryId)
        {
            foreach (var _item in cboCategory.Items)
            {
                ListItem _listItem = (ListItem)_item;
                StringMap _stringMap = (StringMap)_listItem.HiddenObject;
                
                if (_stringMap.StringMapId == _categoryId)
                {
                    cboCategory.SelectedItem = _item;
                    break;
                }
            }
        }

        private void LoadCategoryCbo()
        {
            cboCategory.Items.Clear();

            foreach (StringMap _stringMap in StringMap.GetListAssociatedFromColumn("Question", "CategoryId"))
            {
                cboCategory.Items.Add(new ListItem(_stringMap.StringValue, _stringMap));
            }
        }

        private void AutoFormatFont(RichTextBox _richTextBox)
        {
            _richTextBox.Font = new Font(_richTextBox.Font, System.Drawing.FontStyle.Regular);
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            RichTextBox _richTextBox = (RichTextBox)sender;
            AutoFormatFont(_richTextBox);
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

        private void txtResponse_Enter(object sender, EventArgs e)
        {
            _unsavedChanges = true;

            //RtfConverter rtfConverter = new RtfConverter(txtResponse.Rtf);
            //txtResponse.Rtf = rtfConverter.SetLineHeight(10.0);
        }

        private void txtResponse_KeyDown(object sender, KeyEventArgs e)
        {
            //RtfConverter rtfConverter = new RtfConverter(txtResponse.Rtf);
            //txtResponse.Rtf = rtfConverter.SetLineHeight(10.0);
        }

        private void txtResponse_Leave(object sender, EventArgs e)
        {
            //RtfConverter rtfConverter = new RtfConverter(txtResponse.Rtf);
            //txtResponse.Rtf = rtfConverter.SetLineHeight(10.0);
        }
    }
}
