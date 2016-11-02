using DataIntegrationHub.Business.Entities;
using RfpTool.Business.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RfpTool.UI.Forms
{
    /// <summary>
    /// Interaction logic for wpfQuestion.xaml
    /// </summary>
    public partial class wpfQuestion : UserControl
    {
        public Window CurrentWindow = new Window();
        public User CurrentUser;
        public Question CurrentQuestion;

        public wpfQuestion()
        {
            InitializeComponent();
            this.CurrentQuestion = new Question();
            this.CurrentUser = this.GetUser();
            this.LoadCategoryItems();
            this.Show();
        }

        public wpfQuestion(Question question)
        {
            InitializeComponent();
            InitializeComponent(question);
            LogInCurrentUser();

            this.Show();
        }

        private void InitializeComponent(Question question)
        {
            CurrentQuestion = question;
            LoadCategoryItems();

            if (CurrentQuestion.CategoryId != null)
            {
                SelectCategory((Guid)CurrentQuestion.CategoryId);
            }

            txtComplianceId.Text = CurrentQuestion.ComplianceId;
            txtQuestion.Text = CurrentQuestion.Subject;
            LoadResponse();
        }

        private User GetUser()
        {
            string _userName = Environment.UserDomainName + "\\" + Environment.UserName;
            return new User(_userName);
        }
        
        public void Show()
        {
            CurrentWindow.Topmost = false;
            CurrentWindow.Title = "Question";
            CurrentWindow.Width = 956;
            CurrentWindow.Height = 509;
            CurrentWindow.MinWidth = 956;
            CurrentWindow.MinHeight = 509;
            CurrentWindow.MinWidth = 956;
            System.Windows.Forms.Integration.ElementHost.EnableModelessKeyboardInterop(CurrentWindow);
            CurrentWindow.Content = this;
            CurrentWindow.Show();
        }

        private void LogInCurrentUser()
        {
            string _userName = Environment.UserDomainName + "\\" + Environment.UserName;
            CurrentUser = new User(_userName);
        }

        private void SelectCategory(Guid stringMapId)
        {
            foreach(RfpTool.UI.Utilities.ListItem listItem in cboCategory.Items)
            {
                if (listItem.HiddenObject == null)
                {
                    continue;
                }

                StringMap stringMap = (StringMap)listItem.HiddenObject;
                if (stringMap.StringMapId == stringMapId)
                {
                    cboCategory.SelectedItem = listItem;
                }
            }
        }

        private void LoadResponse()
        {
            this.rtfResponse.SetRTF(CurrentQuestion.Response);
        }

        private void LoadCategoryItems()
        {
            cboCategory.Items.Clear();

            cboCategory.Items.Add(new RfpTool.UI.Utilities.ListItem("", null));

            foreach (StringMap _stringMap in StringMap.GetListAssociatedFromColumn("Question", "CategoryId"))
            {
                RfpTool.UI.Utilities.ListItem listItem = new RfpTool.UI.Utilities.ListItem(_stringMap.StringValue, _stringMap);
                cboCategory.Items.Add(listItem);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Window parent = Window.GetWindow(this);
            parent.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cboCategory.SelectedIndex == -1 || cboCategory.SelectedIndex == 0)
            {
                CurrentQuestion.CategoryId = null;
            }
            else
            {
                RfpTool.UI.Utilities.ListItem listItem = (RfpTool.UI.Utilities.ListItem)cboCategory.SelectedItem;
                StringMap stringMap = (StringMap)listItem.HiddenObject;
                CurrentQuestion.CategoryId = stringMap.StringMapId;
            }

            CurrentQuestion.Subject = txtQuestion.Text;
            CurrentQuestion.ComplianceId = txtComplianceId.Text;
            CurrentQuestion.Response = rtfResponse.GetRTF();
            CurrentQuestion.SaveToDataBase(CurrentUser.UserId);

            Window parent = Window.GetWindow(this);
            parent.Close();
        }
    }
}
