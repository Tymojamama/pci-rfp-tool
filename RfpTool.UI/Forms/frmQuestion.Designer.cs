namespace RfpTool.UI.Forms
{
    partial class frmQuestion_OLD
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
            this.pnlFormHeader = new System.Windows.Forms.Panel();
            this.lblFormMinimize = new System.Windows.Forms.Label();
            this.lblFormClose = new System.Windows.Forms.Label();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.pnlBodySummary = new System.Windows.Forms.Panel();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtResponse = new RicherTextBox.RicherTextBox();
            this.pnlFormHeader.SuspendLayout();
            this.pnlBodySummary.SuspendLayout();
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
            this.pnlFormHeader.Size = new System.Drawing.Size(956, 30);
            this.pnlFormHeader.TabIndex = 5;
            this.pnlFormHeader.DoubleClick += new System.EventHandler(this.pnlFormHeader_DoubleClick);
            // 
            // lblFormMinimize
            // 
            this.lblFormMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormMinimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblFormMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormMinimize.ForeColor = System.Drawing.Color.White;
            this.lblFormMinimize.Location = new System.Drawing.Point(901, 2);
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
            this.lblFormClose.Location = new System.Drawing.Point(929, 2);
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
            this.lblFormHeader.Size = new System.Drawing.Size(137, 19);
            this.lblFormHeader.TabIndex = 1;
            this.lblFormHeader.Text = "Proposal Question";
            // 
            // pnlBodySummary
            // 
            this.pnlBodySummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBodySummary.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlBodySummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBodySummary.Controls.Add(this.txtResponse);
            this.pnlBodySummary.Controls.Add(this.cboCategory);
            this.pnlBodySummary.Controls.Add(this.lblResponse);
            this.pnlBodySummary.Controls.Add(this.lblCategory);
            this.pnlBodySummary.Controls.Add(this.lblQuestion);
            this.pnlBodySummary.Controls.Add(this.txtQuestion);
            this.pnlBodySummary.Controls.Add(this.btnSubmit);
            this.pnlBodySummary.Location = new System.Drawing.Point(0, 29);
            this.pnlBodySummary.Name = "pnlBodySummary";
            this.pnlBodySummary.Size = new System.Drawing.Size(956, 480);
            this.pnlBodySummary.TabIndex = 4;
            // 
            // cboCategory
            // 
            this.cboCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(110, 11);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(833, 21);
            this.cboCategory.TabIndex = 0;
            // 
            // lblResponse
            // 
            this.lblResponse.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblResponse.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponse.Location = new System.Drawing.Point(7, 89);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(97, 20);
            this.lblResponse.TabIndex = 34;
            this.lblResponse.Text = "Response";
            this.lblResponse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            this.lblCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCategory.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(7, 11);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(97, 20);
            this.lblCategory.TabIndex = 32;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblQuestion.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(7, 37);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(97, 20);
            this.lblQuestion.TabIndex = 32;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestion.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(110, 38);
            this.txtQuestion.MaxLength = 2000;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtQuestion.Size = new System.Drawing.Size(833, 48);
            this.txtQuestion.TabIndex = 1;
            this.txtQuestion.Text = "";
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.Location = new System.Drawing.Point(854, 430);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 40);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.AlignCenterVisible = true;
            this.txtResponse.AlignLeftVisible = true;
            this.txtResponse.AlignRightVisible = true;
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.BackColor = System.Drawing.Color.Gainsboro;
            this.txtResponse.BoldVisible = true;
            this.txtResponse.BulletsVisible = true;
            this.txtResponse.ChooseFontVisible = true;
            this.txtResponse.FindReplaceVisible = false;
            this.txtResponse.FontColorVisible = true;
            this.txtResponse.FontFamilyVisible = true;
            this.txtResponse.FontSizeVisible = true;
            this.txtResponse.GroupAlignmentVisible = true;
            this.txtResponse.GroupBoldUnderlineItalicVisible = true;
            this.txtResponse.GroupFontColorVisible = true;
            this.txtResponse.GroupFontNameAndSizeVisible = true;
            this.txtResponse.GroupIndentationAndBulletsVisible = true;
            this.txtResponse.GroupInsertVisible = true;
            this.txtResponse.GroupSaveAndLoadVisible = false;
            this.txtResponse.GroupZoomVisible = false;
            this.txtResponse.INDENT = 10;
            this.txtResponse.IndentVisible = true;
            this.txtResponse.InsertPictureVisible = true;
            this.txtResponse.ItalicVisible = true;
            this.txtResponse.LoadVisible = false;
            this.txtResponse.Location = new System.Drawing.Point(110, 93);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.OutdentVisible = true;
            this.txtResponse.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset204 Microsoft" +
    " Sans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs18\\par\r\n}\r\n";
            this.txtResponse.SaveVisible = false;
            this.txtResponse.SeparatorAlignVisible = true;
            this.txtResponse.SeparatorBoldUnderlineItalicVisible = true;
            this.txtResponse.SeparatorFontColorVisible = true;
            this.txtResponse.SeparatorFontVisible = true;
            this.txtResponse.SeparatorIndentAndBulletsVisible = true;
            this.txtResponse.SeparatorInsertVisible = true;
            this.txtResponse.SeparatorSaveLoadVisible = true;
            this.txtResponse.Size = new System.Drawing.Size(833, 331);
            this.txtResponse.TabIndex = 2;
            this.txtResponse.ToolStripVisible = true;
            this.txtResponse.UnderlineVisible = true;
            this.txtResponse.WordWrapVisible = true;
            this.txtResponse.ZoomFactorTextVisible = false;
            this.txtResponse.ZoomInVisible = true;
            this.txtResponse.ZoomOutVisible = true;
            this.txtResponse.Enter += new System.EventHandler(this.txtResponse_Enter);
            this.txtResponse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResponse_KeyDown);
            this.txtResponse.Leave += new System.EventHandler(this.txtResponse_Leave);
            // 
            // frmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 509);
            this.Controls.Add(this.pnlFormHeader);
            this.Controls.Add(this.pnlBodySummary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.pnlBodySummary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormHeader;
        private System.Windows.Forms.Label lblFormMinimize;
        private System.Windows.Forms.Label lblFormClose;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Panel pnlBodySummary;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RichTextBox txtQuestion;
        private System.Windows.Forms.Button btnSubmit;
        private RicherTextBox.RicherTextBox txtResponse;
    }
}