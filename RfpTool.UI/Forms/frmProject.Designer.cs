namespace RfpTool.UI.Forms
{
    partial class frmProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProject));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFormHeader = new System.Windows.Forms.Panel();
            this.lblFormMinimize = new System.Windows.Forms.Label();
            this.lblFormClose = new System.Windows.Forms.Label();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.pnlBodySummary = new System.Windows.Forms.Panel();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.lblDetail = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.RichTextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDueDate = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.RichTextBox();
            this.btnExportProject = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblMenuSummary = new System.Windows.Forms.Label();
            this.lblMenuQuestion = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.tabQuestions = new System.Windows.Forms.TabPage();
            this.pnlQuestionBody = new System.Windows.Forms.Panel();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnRemoveQuestion = new System.Windows.Forms.Button();
            this.lblAssociatedQuestions = new System.Windows.Forms.Label();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.pnlFormHeader.SuspendLayout();
            this.pnlBodySummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.tabQuestions.SuspendLayout();
            this.pnlQuestionBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlFormHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormHeader.Controls.Add(this.lblFormMinimize);
            this.pnlFormHeader.Controls.Add(this.lblFormClose);
            this.pnlFormHeader.Controls.Add(this.lblFormHeader);
            this.pnlFormHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(646, 30);
            this.pnlFormHeader.TabIndex = 5;
            // 
            // lblFormMinimize
            // 
            this.lblFormMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormMinimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblFormMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormMinimize.ForeColor = System.Drawing.Color.White;
            this.lblFormMinimize.Location = new System.Drawing.Point(591, 2);
            this.lblFormMinimize.Name = "lblFormMinimize";
            this.lblFormMinimize.Size = new System.Drawing.Size(25, 25);
            this.lblFormMinimize.TabIndex = 1;
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
            this.lblFormClose.Location = new System.Drawing.Point(619, 2);
            this.lblFormClose.Name = "lblFormClose";
            this.lblFormClose.Size = new System.Drawing.Size(25, 25);
            this.lblFormClose.TabIndex = 0;
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
            this.lblFormHeader.Size = new System.Drawing.Size(122, 19);
            this.lblFormHeader.TabIndex = 1;
            this.lblFormHeader.Text = "Proposal Project";
            // 
            // pnlBodySummary
            // 
            this.pnlBodySummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBodySummary.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlBodySummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBodySummary.Controls.Add(this.pbLoading);
            this.pnlBodySummary.Controls.Add(this.lblDetail);
            this.pnlBodySummary.Controls.Add(this.txtDetail);
            this.pnlBodySummary.Controls.Add(this.lblDueDate);
            this.pnlBodySummary.Controls.Add(this.lblName);
            this.pnlBodySummary.Controls.Add(this.txtDueDate);
            this.pnlBodySummary.Controls.Add(this.txtName);
            this.pnlBodySummary.Controls.Add(this.btnExportProject);
            this.pnlBodySummary.Controls.Add(this.btnSubmit);
            this.pnlBodySummary.Location = new System.Drawing.Point(0, 0);
            this.pnlBodySummary.Name = "pnlBodySummary";
            this.pnlBodySummary.Size = new System.Drawing.Size(646, 291);
            this.pnlBodySummary.TabIndex = 4;
            // 
            // pbLoading
            // 
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(376, 250);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(67, 19);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoading.TabIndex = 33;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // lblDetail
            // 
            this.lblDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDetail.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(7, 31);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(97, 20);
            this.lblDetail.TabIndex = 32;
            this.lblDetail.Text = "Detail";
            this.lblDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDetail
            // 
            this.txtDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetail.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetail.Location = new System.Drawing.Point(110, 32);
            this.txtDetail.Multiline = false;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtDetail.Size = new System.Drawing.Size(523, 174);
            this.txtDetail.TabIndex = 1;
            this.txtDetail.Text = "";
            this.txtDetail.WordWrap = false;
            // 
            // lblDueDate
            // 
            this.lblDueDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDueDate.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(7, 207);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(97, 20);
            this.lblDueDate.TabIndex = 32;
            this.lblDueDate.Text = "Due On";
            this.lblDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblName.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 20);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDueDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDueDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDueDate.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueDate.Location = new System.Drawing.Point(110, 208);
            this.txtDueDate.Multiline = false;
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtDueDate.Size = new System.Drawing.Size(523, 20);
            this.txtDueDate.TabIndex = 2;
            this.txtDueDate.Text = "";
            this.txtDueDate.WordWrap = false;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(110, 10);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtName.Size = new System.Drawing.Size(523, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "";
            this.txtName.WordWrap = false;
            // 
            // btnExportProject
            // 
            this.btnExportProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExportProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportProject.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportProject.ForeColor = System.Drawing.Color.Black;
            this.btnExportProject.Location = new System.Drawing.Point(449, 238);
            this.btnExportProject.Name = "btnExportProject";
            this.btnExportProject.Size = new System.Drawing.Size(89, 40);
            this.btnExportProject.TabIndex = 3;
            this.btnExportProject.Text = "Export";
            this.btnExportProject.UseVisualStyleBackColor = false;
            this.btnExportProject.Click += new System.EventHandler(this.btnExportProject_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.Location = new System.Drawing.Point(544, 238);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 40);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.Color.Silver;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.lblMenuSummary);
            this.pnlMenu.Controls.Add(this.lblMenuQuestion);
            this.pnlMenu.Location = new System.Drawing.Point(0, 311);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(646, 50);
            this.pnlMenu.TabIndex = 33;
            // 
            // lblMenuSummary
            // 
            this.lblMenuSummary.AutoSize = true;
            this.lblMenuSummary.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuSummary.Location = new System.Drawing.Point(5, 12);
            this.lblMenuSummary.Name = "lblMenuSummary";
            this.lblMenuSummary.Size = new System.Drawing.Size(99, 25);
            this.lblMenuSummary.TabIndex = 4;
            this.lblMenuSummary.Text = "Summary";
            this.lblMenuSummary.Click += new System.EventHandler(this.lblMenuSummary_Click);
            this.lblMenuSummary.MouseEnter += new System.EventHandler(this.labelMenu_MouseEnter);
            this.lblMenuSummary.MouseLeave += new System.EventHandler(this.labelMenu_MouseLeave);
            // 
            // lblMenuQuestion
            // 
            this.lblMenuQuestion.AutoSize = true;
            this.lblMenuQuestion.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuQuestion.Location = new System.Drawing.Point(110, 12);
            this.lblMenuQuestion.Name = "lblMenuQuestion";
            this.lblMenuQuestion.Size = new System.Drawing.Size(105, 25);
            this.lblMenuQuestion.TabIndex = 4;
            this.lblMenuQuestion.Text = "Questions";
            this.lblMenuQuestion.Click += new System.EventHandler(this.lblMenuQuestion_Click);
            this.lblMenuQuestion.MouseEnter += new System.EventHandler(this.labelMenu_MouseEnter);
            this.lblMenuQuestion.MouseLeave += new System.EventHandler(this.labelMenu_MouseLeave);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSummary);
            this.tabMain.Controls.Add(this.tabQuestions);
            this.tabMain.Location = new System.Drawing.Point(-4, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(655, 317);
            this.tabMain.TabIndex = 35;
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.pnlBodySummary);
            this.tabSummary.Location = new System.Drawing.Point(4, 22);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(647, 291);
            this.tabSummary.TabIndex = 1;
            this.tabSummary.Text = "Summary";
            this.tabSummary.UseVisualStyleBackColor = true;
            // 
            // tabQuestions
            // 
            this.tabQuestions.Controls.Add(this.pnlQuestionBody);
            this.tabQuestions.Location = new System.Drawing.Point(4, 22);
            this.tabQuestions.Name = "tabQuestions";
            this.tabQuestions.Size = new System.Drawing.Size(647, 291);
            this.tabQuestions.TabIndex = 2;
            this.tabQuestions.Text = "Questions";
            this.tabQuestions.UseVisualStyleBackColor = true;
            // 
            // pnlQuestionBody
            // 
            this.pnlQuestionBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQuestionBody.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlQuestionBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuestionBody.Controls.Add(this.btnAddQuestion);
            this.pnlQuestionBody.Controls.Add(this.btnRemoveQuestion);
            this.pnlQuestionBody.Controls.Add(this.lblAssociatedQuestions);
            this.pnlQuestionBody.Controls.Add(this.dgvQuestions);
            this.pnlQuestionBody.Location = new System.Drawing.Point(0, 0);
            this.pnlQuestionBody.Name = "pnlQuestionBody";
            this.pnlQuestionBody.Size = new System.Drawing.Size(646, 291);
            this.pnlQuestionBody.TabIndex = 5;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQuestion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.Location = new System.Drawing.Point(501, 7);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(63, 25);
            this.btnAddQuestion.TabIndex = 7;
            this.btnAddQuestion.Text = "Add";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveQuestion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveQuestion.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveQuestion.Location = new System.Drawing.Point(570, 7);
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.Size = new System.Drawing.Size(63, 25);
            this.btnRemoveQuestion.TabIndex = 7;
            this.btnRemoveQuestion.Text = "Remove";
            this.btnRemoveQuestion.UseVisualStyleBackColor = false;
            this.btnRemoveQuestion.Click += new System.EventHandler(this.btnRemoveQuestion_Click);
            // 
            // lblAssociatedQuestions
            // 
            this.lblAssociatedQuestions.AutoSize = true;
            this.lblAssociatedQuestions.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssociatedQuestions.Location = new System.Drawing.Point(6, 10);
            this.lblAssociatedQuestions.Name = "lblAssociatedQuestions";
            this.lblAssociatedQuestions.Size = new System.Drawing.Size(150, 19);
            this.lblAssociatedQuestions.TabIndex = 5;
            this.lblAssociatedQuestions.Text = "Associated Questions";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuestions.ColumnHeadersHeight = 20;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQuestions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvQuestions.EnableHeadersVisualStyles = false;
            this.dgvQuestions.Location = new System.Drawing.Point(11, 38);
            this.dgvQuestions.MultiSelect = false;
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.RowHeadersVisible = false;
            this.dgvQuestions.Size = new System.Drawing.Size(622, 240);
            this.dgvQuestions.TabIndex = 1;
            this.dgvQuestions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestions_CellDoubleClick);
            this.dgvQuestions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestions_CellEndEdit);
            this.dgvQuestions.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvQuestions_DataError);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Location = new System.Drawing.Point(0, 360);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(647, 18);
            this.pnlStatus.TabIndex = 36;
            // 
            // frmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 378);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlFormHeader);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.pnlBodySummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabSummary.ResumeLayout(false);
            this.tabQuestions.ResumeLayout(false);
            this.pnlQuestionBody.ResumeLayout(false);
            this.pnlQuestionBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormHeader;
        private System.Windows.Forms.Label lblFormMinimize;
        private System.Windows.Forms.Label lblFormClose;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Panel pnlBodySummary;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox txtName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.RichTextBox txtDetail;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.RichTextBox txtDueDate;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenuSummary;
        private System.Windows.Forms.Label lblMenuQuestion;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.TabPage tabQuestions;
        private System.Windows.Forms.Panel pnlQuestionBody;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Label lblAssociatedQuestions;
        private System.Windows.Forms.Button btnRemoveQuestion;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnExportProject;
        private System.Windows.Forms.PictureBox pbLoading;
    }
}