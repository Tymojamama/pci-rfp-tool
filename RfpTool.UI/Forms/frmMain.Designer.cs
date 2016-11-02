namespace RfpTool.UI.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFormHeader = new System.Windows.Forms.Panel();
            this.lblFormMinimize = new System.Windows.Forms.Label();
            this.lblFormClose = new System.Windows.Forms.Label();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabProject = new System.Windows.Forms.TabPage();
            this.pnlProjectBody = new System.Windows.Forms.Panel();
            this.pnlProjectHeader = new System.Windows.Forms.Panel();
            this.lblProjectHeader = new System.Windows.Forms.Label();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.btnEditProject = new System.Windows.Forms.Button();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.cboProjectViews = new System.Windows.Forms.ComboBox();
            this.lblProjectViews = new System.Windows.Forms.Label();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.tabQuestion = new System.Windows.Forms.TabPage();
            this.pnlQuestionBody = new System.Windows.Forms.Panel();
            this.txtQuestionSearch = new System.Windows.Forms.TextBox();
            this.pnlQuestionHeader = new System.Windows.Forms.Panel();
            this.lblQuestionHeader = new System.Windows.Forms.Label();
            this.btnNewQuestion = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.cboQuestionViews = new System.Windows.Forms.ComboBox();
            this.lblQuestionSearch = new System.Windows.Forms.Label();
            this.lblQuestionViews = new System.Windows.Forms.Label();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.pnlCategoryBody = new System.Windows.Forms.Panel();
            this.pnlCategoryHeader = new System.Windows.Forms.Panel();
            this.lblCategoryHeader = new System.Windows.Forms.Label();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.cboCategoryViews = new System.Windows.Forms.ComboBox();
            this.lblCategoryViews = new System.Windows.Forms.Label();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblMenuCategory = new System.Windows.Forms.Label();
            this.lblMenuProject = new System.Windows.Forms.Label();
            this.lblMenuQuestion = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblLoginStatus = new System.Windows.Forms.Label();
            this.pnlFormHeader.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabProject.SuspendLayout();
            this.pnlProjectBody.SuspendLayout();
            this.pnlProjectHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.tabQuestion.SuspendLayout();
            this.pnlQuestionBody.SuspendLayout();
            this.pnlQuestionHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.tabCategory.SuspendLayout();
            this.pnlCategoryBody.SuspendLayout();
            this.pnlCategoryHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormHeader.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlFormHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormHeader.Controls.Add(this.lblFormMinimize);
            this.pnlFormHeader.Controls.Add(this.lblFormClose);
            this.pnlFormHeader.Controls.Add(this.lblFormHeader);
            this.pnlFormHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(910, 30);
            this.pnlFormHeader.TabIndex = 4;
            this.pnlFormHeader.DoubleClick += new System.EventHandler(this.pnlFormHeader_DoubleClick);
            // 
            // lblFormMinimize
            // 
            this.lblFormMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormMinimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblFormMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormMinimize.ForeColor = System.Drawing.Color.White;
            this.lblFormMinimize.Location = new System.Drawing.Point(855, 2);
            this.lblFormMinimize.Name = "lblFormMinimize";
            this.lblFormMinimize.Size = new System.Drawing.Size(25, 25);
            this.lblFormMinimize.TabIndex = 23;
            this.lblFormMinimize.Text = "-";
            this.lblFormMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblFormMinimize.Click += new System.EventHandler(this.lblFormMinimize_Click);
            this.lblFormMinimize.MouseEnter += new System.EventHandler(this.labelGray_MouseEnter);
            this.lblFormMinimize.MouseLeave += new System.EventHandler(this.labelGray_MouseLeave);
            // 
            // lblFormClose
            // 
            this.lblFormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblFormClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormClose.ForeColor = System.Drawing.Color.White;
            this.lblFormClose.Location = new System.Drawing.Point(883, 2);
            this.lblFormClose.Name = "lblFormClose";
            this.lblFormClose.Size = new System.Drawing.Size(25, 25);
            this.lblFormClose.TabIndex = 24;
            this.lblFormClose.Text = "x";
            this.lblFormClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormClose.Click += new System.EventHandler(this.lblFormClose_Click);
            this.lblFormClose.MouseEnter += new System.EventHandler(this.labelGray_MouseEnter);
            this.lblFormClose.MouseLeave += new System.EventHandler(this.labelGray_MouseLeave);
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.White;
            this.lblFormHeader.Location = new System.Drawing.Point(6, 5);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(221, 19);
            this.lblFormHeader.TabIndex = 1;
            this.lblFormHeader.Text = "Proposal Management System";
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabProject);
            this.tabMain.Controls.Add(this.tabQuestion);
            this.tabMain.Controls.Add(this.tabCategory);
            this.tabMain.Location = new System.Drawing.Point(-4, 5);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(922, 484);
            this.tabMain.TabIndex = 10;
            // 
            // tabProject
            // 
            this.tabProject.Controls.Add(this.pnlProjectBody);
            this.tabProject.Location = new System.Drawing.Point(4, 22);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabProject.Size = new System.Drawing.Size(914, 458);
            this.tabProject.TabIndex = 2;
            this.tabProject.Text = "Projects";
            this.tabProject.UseVisualStyleBackColor = true;
            // 
            // pnlProjectBody
            // 
            this.pnlProjectBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProjectBody.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlProjectBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProjectBody.Controls.Add(this.pnlProjectHeader);
            this.pnlProjectBody.Controls.Add(this.btnNewProject);
            this.pnlProjectBody.Controls.Add(this.btnEditProject);
            this.pnlProjectBody.Controls.Add(this.btnDeleteProject);
            this.pnlProjectBody.Controls.Add(this.cboProjectViews);
            this.pnlProjectBody.Controls.Add(this.lblProjectViews);
            this.pnlProjectBody.Controls.Add(this.dgvProjects);
            this.pnlProjectBody.Location = new System.Drawing.Point(0, 0);
            this.pnlProjectBody.Name = "pnlProjectBody";
            this.pnlProjectBody.Size = new System.Drawing.Size(910, 455);
            this.pnlProjectBody.TabIndex = 5;
            // 
            // pnlProjectHeader
            // 
            this.pnlProjectHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProjectHeader.BackColor = System.Drawing.SystemColors.Control;
            this.pnlProjectHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProjectHeader.Controls.Add(this.lblProjectHeader);
            this.pnlProjectHeader.Location = new System.Drawing.Point(-1, 1);
            this.pnlProjectHeader.Name = "pnlProjectHeader";
            this.pnlProjectHeader.Size = new System.Drawing.Size(910, 36);
            this.pnlProjectHeader.TabIndex = 13;
            // 
            // lblProjectHeader
            // 
            this.lblProjectHeader.AutoSize = true;
            this.lblProjectHeader.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectHeader.Location = new System.Drawing.Point(5, 4);
            this.lblProjectHeader.Name = "lblProjectHeader";
            this.lblProjectHeader.Size = new System.Drawing.Size(85, 25);
            this.lblProjectHeader.TabIndex = 4;
            this.lblProjectHeader.Text = "Projects";
            // 
            // btnNewProject
            // 
            this.btnNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProject.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProject.Location = new System.Drawing.Point(681, 43);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(68, 25);
            this.btnNewProject.TabIndex = 6;
            this.btnNewProject.Text = "New";
            this.btnNewProject.UseVisualStyleBackColor = false;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // btnEditProject
            // 
            this.btnEditProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProject.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProject.Location = new System.Drawing.Point(755, 43);
            this.btnEditProject.Name = "btnEditProject";
            this.btnEditProject.Size = new System.Drawing.Size(68, 25);
            this.btnEditProject.TabIndex = 7;
            this.btnEditProject.Text = "Edit";
            this.btnEditProject.UseVisualStyleBackColor = false;
            this.btnEditProject.Click += new System.EventHandler(this.btnEditProject_Click);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProject.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProject.Location = new System.Drawing.Point(829, 43);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(68, 25);
            this.btnDeleteProject.TabIndex = 8;
            this.btnDeleteProject.Text = "Delete";
            this.btnDeleteProject.UseVisualStyleBackColor = false;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // cboProjectViews
            // 
            this.cboProjectViews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProjectViews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProjectViews.FormattingEnabled = true;
            this.cboProjectViews.Items.AddRange(new object[] {
            "All Projects"});
            this.cboProjectViews.Location = new System.Drawing.Point(65, 46);
            this.cboProjectViews.Name = "cboProjectViews";
            this.cboProjectViews.Size = new System.Drawing.Size(141, 21);
            this.cboProjectViews.TabIndex = 5;
            this.cboProjectViews.SelectedIndexChanged += new System.EventHandler(this.cboProjectViews_SelectedIndexChanged);
            // 
            // lblProjectViews
            // 
            this.lblProjectViews.AutoSize = true;
            this.lblProjectViews.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectViews.Location = new System.Drawing.Point(12, 47);
            this.lblProjectViews.Name = "lblProjectViews";
            this.lblProjectViews.Size = new System.Drawing.Size(47, 19);
            this.lblProjectViews.TabIndex = 4;
            this.lblProjectViews.Text = "Views";
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.AllowUserToResizeRows = false;
            this.dgvProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjects.ColumnHeadersHeight = 20;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProjects.EnableHeadersVisualStyles = false;
            this.dgvProjects.Location = new System.Drawing.Point(10, 74);
            this.dgvProjects.MultiSelect = false;
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.ReadOnly = true;
            this.dgvProjects.RowHeadersVisible = false;
            this.dgvProjects.Size = new System.Drawing.Size(887, 372);
            this.dgvProjects.TabIndex = 0;
            this.dgvProjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellDoubleClick);
            // 
            // tabQuestion
            // 
            this.tabQuestion.Controls.Add(this.pnlQuestionBody);
            this.tabQuestion.Location = new System.Drawing.Point(4, 22);
            this.tabQuestion.Name = "tabQuestion";
            this.tabQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuestion.Size = new System.Drawing.Size(914, 458);
            this.tabQuestion.TabIndex = 0;
            this.tabQuestion.Text = "Questions";
            this.tabQuestion.UseVisualStyleBackColor = true;
            // 
            // pnlQuestionBody
            // 
            this.pnlQuestionBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQuestionBody.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlQuestionBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuestionBody.Controls.Add(this.txtQuestionSearch);
            this.pnlQuestionBody.Controls.Add(this.pnlQuestionHeader);
            this.pnlQuestionBody.Controls.Add(this.btnNewQuestion);
            this.pnlQuestionBody.Controls.Add(this.btnEditQuestion);
            this.pnlQuestionBody.Controls.Add(this.btnDeleteQuestion);
            this.pnlQuestionBody.Controls.Add(this.cboQuestionViews);
            this.pnlQuestionBody.Controls.Add(this.lblQuestionSearch);
            this.pnlQuestionBody.Controls.Add(this.lblQuestionViews);
            this.pnlQuestionBody.Controls.Add(this.dgvQuestions);
            this.pnlQuestionBody.Location = new System.Drawing.Point(0, 0);
            this.pnlQuestionBody.Name = "pnlQuestionBody";
            this.pnlQuestionBody.Size = new System.Drawing.Size(910, 455);
            this.pnlQuestionBody.TabIndex = 4;
            // 
            // txtQuestionSearch
            // 
            this.txtQuestionSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestionSearch.Location = new System.Drawing.Point(271, 46);
            this.txtQuestionSearch.Name = "txtQuestionSearch";
            this.txtQuestionSearch.Size = new System.Drawing.Size(404, 20);
            this.txtQuestionSearch.TabIndex = 14;
            this.txtQuestionSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuestionSearch_KeyDown);
            // 
            // pnlQuestionHeader
            // 
            this.pnlQuestionHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQuestionHeader.BackColor = System.Drawing.SystemColors.Control;
            this.pnlQuestionHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuestionHeader.Controls.Add(this.lblQuestionHeader);
            this.pnlQuestionHeader.Location = new System.Drawing.Point(-1, 1);
            this.pnlQuestionHeader.Name = "pnlQuestionHeader";
            this.pnlQuestionHeader.Size = new System.Drawing.Size(910, 36);
            this.pnlQuestionHeader.TabIndex = 13;
            // 
            // lblQuestionHeader
            // 
            this.lblQuestionHeader.AutoSize = true;
            this.lblQuestionHeader.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionHeader.Location = new System.Drawing.Point(5, 4);
            this.lblQuestionHeader.Name = "lblQuestionHeader";
            this.lblQuestionHeader.Size = new System.Drawing.Size(105, 25);
            this.lblQuestionHeader.TabIndex = 4;
            this.lblQuestionHeader.Text = "Questions";
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewQuestion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewQuestion.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewQuestion.Location = new System.Drawing.Point(681, 43);
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(68, 25);
            this.btnNewQuestion.TabIndex = 6;
            this.btnNewQuestion.Text = "New";
            this.btnNewQuestion.UseVisualStyleBackColor = false;
            this.btnNewQuestion.Click += new System.EventHandler(this.btnNewQuestion_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditQuestion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditQuestion.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditQuestion.Location = new System.Drawing.Point(755, 43);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(68, 25);
            this.btnEditQuestion.TabIndex = 7;
            this.btnEditQuestion.Text = "Edit";
            this.btnEditQuestion.UseVisualStyleBackColor = false;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteQuestion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteQuestion.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteQuestion.Location = new System.Drawing.Point(829, 43);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(68, 25);
            this.btnDeleteQuestion.TabIndex = 8;
            this.btnDeleteQuestion.Text = "Delete";
            this.btnDeleteQuestion.UseVisualStyleBackColor = false;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // cboQuestionViews
            // 
            this.cboQuestionViews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuestionViews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboQuestionViews.FormattingEnabled = true;
            this.cboQuestionViews.Items.AddRange(new object[] {
            "All Questions"});
            this.cboQuestionViews.Location = new System.Drawing.Point(65, 46);
            this.cboQuestionViews.Name = "cboQuestionViews";
            this.cboQuestionViews.Size = new System.Drawing.Size(141, 21);
            this.cboQuestionViews.TabIndex = 5;
            this.cboQuestionViews.SelectedIndexChanged += new System.EventHandler(this.cboQuestionViews_SelectedIndexChanged);
            // 
            // lblQuestionSearch
            // 
            this.lblQuestionSearch.AutoSize = true;
            this.lblQuestionSearch.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionSearch.Location = new System.Drawing.Point(212, 47);
            this.lblQuestionSearch.Name = "lblQuestionSearch";
            this.lblQuestionSearch.Size = new System.Drawing.Size(53, 19);
            this.lblQuestionSearch.TabIndex = 4;
            this.lblQuestionSearch.Text = "Search";
            // 
            // lblQuestionViews
            // 
            this.lblQuestionViews.AutoSize = true;
            this.lblQuestionViews.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionViews.Location = new System.Drawing.Point(12, 47);
            this.lblQuestionViews.Name = "lblQuestionViews";
            this.lblQuestionViews.Size = new System.Drawing.Size(47, 19);
            this.lblQuestionViews.TabIndex = 4;
            this.lblQuestionViews.Text = "Views";
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.AllowUserToResizeRows = false;
            this.dgvQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuestions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuestions.ColumnHeadersHeight = 20;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQuestions.EnableHeadersVisualStyles = false;
            this.dgvQuestions.Location = new System.Drawing.Point(10, 74);
            this.dgvQuestions.MultiSelect = false;
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowHeadersVisible = false;
            this.dgvQuestions.Size = new System.Drawing.Size(887, 372);
            this.dgvQuestions.TabIndex = 0;
            this.dgvQuestions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestions_CellDoubleClick);
            // 
            // tabCategory
            // 
            this.tabCategory.Controls.Add(this.pnlCategoryBody);
            this.tabCategory.Location = new System.Drawing.Point(4, 22);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.Size = new System.Drawing.Size(914, 458);
            this.tabCategory.TabIndex = 1;
            this.tabCategory.Text = "Category";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // pnlCategoryBody
            // 
            this.pnlCategoryBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCategoryBody.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlCategoryBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategoryBody.Controls.Add(this.pnlCategoryHeader);
            this.pnlCategoryBody.Controls.Add(this.btnNewCategory);
            this.pnlCategoryBody.Controls.Add(this.btnEditCategory);
            this.pnlCategoryBody.Controls.Add(this.btnDeleteCategory);
            this.pnlCategoryBody.Controls.Add(this.cboCategoryViews);
            this.pnlCategoryBody.Controls.Add(this.lblCategoryViews);
            this.pnlCategoryBody.Controls.Add(this.dgvCategories);
            this.pnlCategoryBody.Location = new System.Drawing.Point(0, 0);
            this.pnlCategoryBody.Name = "pnlCategoryBody";
            this.pnlCategoryBody.Size = new System.Drawing.Size(910, 455);
            this.pnlCategoryBody.TabIndex = 5;
            // 
            // pnlCategoryHeader
            // 
            this.pnlCategoryHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCategoryHeader.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCategoryHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategoryHeader.Controls.Add(this.lblCategoryHeader);
            this.pnlCategoryHeader.Location = new System.Drawing.Point(-1, 1);
            this.pnlCategoryHeader.Name = "pnlCategoryHeader";
            this.pnlCategoryHeader.Size = new System.Drawing.Size(910, 36);
            this.pnlCategoryHeader.TabIndex = 12;
            // 
            // lblCategoryHeader
            // 
            this.lblCategoryHeader.AutoSize = true;
            this.lblCategoryHeader.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryHeader.Location = new System.Drawing.Point(5, 4);
            this.lblCategoryHeader.Name = "lblCategoryHeader";
            this.lblCategoryHeader.Size = new System.Drawing.Size(110, 25);
            this.lblCategoryHeader.TabIndex = 4;
            this.lblCategoryHeader.Text = "Categories";
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCategory.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCategory.Location = new System.Drawing.Point(681, 43);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(68, 25);
            this.btnNewCategory.TabIndex = 6;
            this.btnNewCategory.Text = "New";
            this.btnNewCategory.UseVisualStyleBackColor = false;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategory.Location = new System.Drawing.Point(755, 43);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(68, 25);
            this.btnEditCategory.TabIndex = 7;
            this.btnEditCategory.Text = "Edit";
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.Location = new System.Drawing.Point(829, 43);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(68, 25);
            this.btnDeleteCategory.TabIndex = 8;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // cboCategoryViews
            // 
            this.cboCategoryViews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoryViews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoryViews.FormattingEnabled = true;
            this.cboCategoryViews.Items.AddRange(new object[] {
            "All Categories"});
            this.cboCategoryViews.Location = new System.Drawing.Point(65, 46);
            this.cboCategoryViews.Name = "cboCategoryViews";
            this.cboCategoryViews.Size = new System.Drawing.Size(141, 21);
            this.cboCategoryViews.TabIndex = 5;
            this.cboCategoryViews.SelectedIndexChanged += new System.EventHandler(this.cboCategoryViews_SelectedIndexChanged);
            this.cboCategoryViews.Click += new System.EventHandler(this.cboCategoryViews_Click);
            // 
            // lblCategoryViews
            // 
            this.lblCategoryViews.AutoSize = true;
            this.lblCategoryViews.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryViews.Location = new System.Drawing.Point(12, 47);
            this.lblCategoryViews.Name = "lblCategoryViews";
            this.lblCategoryViews.Size = new System.Drawing.Size(47, 19);
            this.lblCategoryViews.TabIndex = 4;
            this.lblCategoryViews.Text = "Views";
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AllowUserToResizeRows = false;
            this.dgvCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategories.ColumnHeadersHeight = 20;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategories.EnableHeadersVisualStyles = false;
            this.dgvCategories.Location = new System.Drawing.Point(10, 74);
            this.dgvCategories.MultiSelect = false;
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.Size = new System.Drawing.Size(887, 371);
            this.dgvCategories.TabIndex = 0;
            this.dgvCategories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellDoubleClick);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.Color.Silver;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.lblMenuCategory);
            this.pnlMenu.Controls.Add(this.lblMenuProject);
            this.pnlMenu.Controls.Add(this.lblMenuQuestion);
            this.pnlMenu.Location = new System.Drawing.Point(0, 480);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(910, 50);
            this.pnlMenu.TabIndex = 11;
            // 
            // lblMenuCategory
            // 
            this.lblMenuCategory.AutoSize = true;
            this.lblMenuCategory.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuCategory.Location = new System.Drawing.Point(207, 12);
            this.lblMenuCategory.Name = "lblMenuCategory";
            this.lblMenuCategory.Size = new System.Drawing.Size(110, 25);
            this.lblMenuCategory.TabIndex = 4;
            this.lblMenuCategory.Text = "Categories";
            this.lblMenuCategory.Click += new System.EventHandler(this.lblMenuCategory_Click);
            this.lblMenuCategory.MouseEnter += new System.EventHandler(this.labelMenu_MouseEnter);
            this.lblMenuCategory.MouseLeave += new System.EventHandler(this.labelMenu_MouseLeave);
            // 
            // lblMenuProject
            // 
            this.lblMenuProject.AutoSize = true;
            this.lblMenuProject.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuProject.Location = new System.Drawing.Point(5, 12);
            this.lblMenuProject.Name = "lblMenuProject";
            this.lblMenuProject.Size = new System.Drawing.Size(85, 25);
            this.lblMenuProject.TabIndex = 4;
            this.lblMenuProject.Text = "Projects";
            this.lblMenuProject.Click += new System.EventHandler(this.lblMenuProject_Click);
            this.lblMenuProject.MouseEnter += new System.EventHandler(this.labelMenu_MouseEnter);
            this.lblMenuProject.MouseLeave += new System.EventHandler(this.labelMenu_MouseLeave);
            // 
            // lblMenuQuestion
            // 
            this.lblMenuQuestion.AutoSize = true;
            this.lblMenuQuestion.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuQuestion.Location = new System.Drawing.Point(96, 12);
            this.lblMenuQuestion.Name = "lblMenuQuestion";
            this.lblMenuQuestion.Size = new System.Drawing.Size(105, 25);
            this.lblMenuQuestion.TabIndex = 4;
            this.lblMenuQuestion.Text = "Questions";
            this.lblMenuQuestion.Click += new System.EventHandler(this.lblMenuQuestion_Click);
            this.lblMenuQuestion.MouseEnter += new System.EventHandler(this.labelMenu_MouseEnter);
            this.lblMenuQuestion.MouseLeave += new System.EventHandler(this.labelMenu_MouseLeave);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Controls.Add(this.lblLoginStatus);
            this.pnlStatus.Location = new System.Drawing.Point(0, 528);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(910, 18);
            this.pnlStatus.TabIndex = 12;
            // 
            // lblLoginStatus
            // 
            this.lblLoginStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginStatus.Location = new System.Drawing.Point(617, 0);
            this.lblLoginStatus.Name = "lblLoginStatus";
            this.lblLoginStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoginStatus.Size = new System.Drawing.Size(280, 16);
            this.lblLoginStatus.TabIndex = 0;
            this.lblLoginStatus.Text = "You are logged in as:";
            this.lblLoginStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 546);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlFormHeader);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proposal Management System";
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabProject.ResumeLayout(false);
            this.pnlProjectBody.ResumeLayout(false);
            this.pnlProjectBody.PerformLayout();
            this.pnlProjectHeader.ResumeLayout(false);
            this.pnlProjectHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.tabQuestion.ResumeLayout(false);
            this.pnlQuestionBody.ResumeLayout(false);
            this.pnlQuestionBody.PerformLayout();
            this.pnlQuestionHeader.ResumeLayout(false);
            this.pnlQuestionHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.tabCategory.ResumeLayout(false);
            this.pnlCategoryBody.ResumeLayout(false);
            this.pnlCategoryBody.PerformLayout();
            this.pnlCategoryHeader.ResumeLayout(false);
            this.pnlCategoryHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormHeader;
        private System.Windows.Forms.Label lblFormMinimize;
        private System.Windows.Forms.Label lblFormClose;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabQuestion;
        private System.Windows.Forms.Panel pnlQuestionBody;
        private System.Windows.Forms.Button btnNewQuestion;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.ComboBox cboQuestionViews;
        private System.Windows.Forms.Label lblQuestionViews;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenuCategory;
        private System.Windows.Forms.Label lblMenuQuestion;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Panel pnlCategoryBody;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.ComboBox cboCategoryViews;
        private System.Windows.Forms.Label lblCategoryViews;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Label lblLoginStatus;
        private System.Windows.Forms.Panel pnlCategoryHeader;
        private System.Windows.Forms.Label lblCategoryHeader;
        private System.Windows.Forms.Panel pnlQuestionHeader;
        private System.Windows.Forms.Label lblQuestionHeader;
        private System.Windows.Forms.TextBox txtQuestionSearch;
        private System.Windows.Forms.Label lblQuestionSearch;
        private System.Windows.Forms.TabPage tabProject;
        private System.Windows.Forms.Panel pnlProjectBody;
        private System.Windows.Forms.Panel pnlProjectHeader;
        private System.Windows.Forms.Label lblProjectHeader;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Button btnEditProject;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.ComboBox cboProjectViews;
        private System.Windows.Forms.Label lblProjectViews;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.Label lblMenuProject;

    }
}

