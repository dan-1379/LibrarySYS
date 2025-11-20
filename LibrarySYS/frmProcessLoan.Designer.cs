namespace LibrarySYS
{
    partial class frmProcessLoan
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
            this.mnuProcessLoan = new System.Windows.Forms.MenuStrip();
            this.mnuProcessLoanExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblProcessLoanMemberID = new System.Windows.Forms.Label();
            this.txtProcessLoanMemberID = new System.Windows.Forms.TextBox();
            this.btnProcessLoanSearchID = new System.Windows.Forms.Button();
            this.grpProcessLoan = new System.Windows.Forms.GroupBox();
            this.btnProcessLoanLoanBooks = new System.Windows.Forms.Button();
            this.btnProcessLoanRemove = new System.Windows.Forms.Button();
            this.btnProcessLoanSearchISBN = new System.Windows.Forms.Button();
            this.txtProcessLoanISBN = new System.Windows.Forms.TextBox();
            this.lblProcessLoanISBN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clbProcessLoan = new System.Windows.Forms.CheckedListBox();
            this.btnProcessLoanAdd = new System.Windows.Forms.Button();
            this.dtpProcessLoanPublication = new System.Windows.Forms.DateTimePicker();
            this.cboProcessLoanStatus = new System.Windows.Forms.ComboBox();
            this.cboProcessLoanGenre = new System.Windows.Forms.ComboBox();
            this.txtProcessLoanPublisher = new System.Windows.Forms.TextBox();
            this.txtProcessLoanDescription = new System.Windows.Forms.TextBox();
            this.txtProcessLoanAuthor = new System.Windows.Forms.TextBox();
            this.txtProcessLoanTitle = new System.Windows.Forms.TextBox();
            this.lblProcessLoanStatus = new System.Windows.Forms.Label();
            this.lblProcessLoanPublication = new System.Windows.Forms.Label();
            this.lblProcessLoanPublisher = new System.Windows.Forms.Label();
            this.lblProcessLoanGenre = new System.Windows.Forms.Label();
            this.lblProcessLoanDescription = new System.Windows.Forms.Label();
            this.lblProcessLoanAuthor = new System.Windows.Forms.Label();
            this.lblProcessLoanTitle = new System.Windows.Forms.Label();
            this.mnuProcessLoan.SuspendLayout();
            this.grpProcessLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuProcessLoan
            // 
            this.mnuProcessLoan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProcessLoanExit});
            this.mnuProcessLoan.Location = new System.Drawing.Point(0, 0);
            this.mnuProcessLoan.Name = "mnuProcessLoan";
            this.mnuProcessLoan.Size = new System.Drawing.Size(800, 24);
            this.mnuProcessLoan.TabIndex = 0;
            this.mnuProcessLoan.Text = "mnuProcessLoan";
            // 
            // mnuProcessLoanExit
            // 
            this.mnuProcessLoanExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuProcessLoanExit.Name = "mnuProcessLoanExit";
            this.mnuProcessLoanExit.Size = new System.Drawing.Size(37, 20);
            this.mnuProcessLoanExit.Text = "Exit";
            this.mnuProcessLoanExit.Click += new System.EventHandler(this.mnuProcessLoanExit_Click);
            // 
            // lblProcessLoanMemberID
            // 
            this.lblProcessLoanMemberID.AutoSize = true;
            this.lblProcessLoanMemberID.Location = new System.Drawing.Point(12, 31);
            this.lblProcessLoanMemberID.Name = "lblProcessLoanMemberID";
            this.lblProcessLoanMemberID.Size = new System.Drawing.Size(62, 13);
            this.lblProcessLoanMemberID.TabIndex = 1;
            this.lblProcessLoanMemberID.Text = "Member ID:";
            // 
            // txtProcessLoanMemberID
            // 
            this.txtProcessLoanMemberID.Location = new System.Drawing.Point(80, 28);
            this.txtProcessLoanMemberID.Name = "txtProcessLoanMemberID";
            this.txtProcessLoanMemberID.Size = new System.Drawing.Size(129, 20);
            this.txtProcessLoanMemberID.TabIndex = 2;
            // 
            // btnProcessLoanSearchID
            // 
            this.btnProcessLoanSearchID.Location = new System.Drawing.Point(225, 26);
            this.btnProcessLoanSearchID.Name = "btnProcessLoanSearchID";
            this.btnProcessLoanSearchID.Size = new System.Drawing.Size(75, 23);
            this.btnProcessLoanSearchID.TabIndex = 3;
            this.btnProcessLoanSearchID.Text = "Search";
            this.btnProcessLoanSearchID.UseVisualStyleBackColor = true;
            this.btnProcessLoanSearchID.Click += new System.EventHandler(this.btnProcessLoanSearchID_Click);
            // 
            // grpProcessLoan
            // 
            this.grpProcessLoan.Controls.Add(this.btnProcessLoanLoanBooks);
            this.grpProcessLoan.Controls.Add(this.btnProcessLoanRemove);
            this.grpProcessLoan.Controls.Add(this.btnProcessLoanSearchISBN);
            this.grpProcessLoan.Controls.Add(this.txtProcessLoanISBN);
            this.grpProcessLoan.Controls.Add(this.lblProcessLoanISBN);
            this.grpProcessLoan.Controls.Add(this.label1);
            this.grpProcessLoan.Controls.Add(this.clbProcessLoan);
            this.grpProcessLoan.Controls.Add(this.btnProcessLoanAdd);
            this.grpProcessLoan.Controls.Add(this.dtpProcessLoanPublication);
            this.grpProcessLoan.Controls.Add(this.cboProcessLoanStatus);
            this.grpProcessLoan.Controls.Add(this.cboProcessLoanGenre);
            this.grpProcessLoan.Controls.Add(this.txtProcessLoanPublisher);
            this.grpProcessLoan.Controls.Add(this.txtProcessLoanDescription);
            this.grpProcessLoan.Controls.Add(this.txtProcessLoanAuthor);
            this.grpProcessLoan.Controls.Add(this.txtProcessLoanTitle);
            this.grpProcessLoan.Controls.Add(this.lblProcessLoanStatus);
            this.grpProcessLoan.Controls.Add(this.lblProcessLoanPublication);
            this.grpProcessLoan.Controls.Add(this.lblProcessLoanPublisher);
            this.grpProcessLoan.Controls.Add(this.lblProcessLoanGenre);
            this.grpProcessLoan.Controls.Add(this.lblProcessLoanDescription);
            this.grpProcessLoan.Controls.Add(this.lblProcessLoanAuthor);
            this.grpProcessLoan.Controls.Add(this.lblProcessLoanTitle);
            this.grpProcessLoan.Location = new System.Drawing.Point(15, 81);
            this.grpProcessLoan.Name = "grpProcessLoan";
            this.grpProcessLoan.Size = new System.Drawing.Size(773, 463);
            this.grpProcessLoan.TabIndex = 4;
            this.grpProcessLoan.TabStop = false;
            this.grpProcessLoan.Text = "Process Loan";
            // 
            // btnProcessLoanLoanBooks
            // 
            this.btnProcessLoanLoanBooks.Location = new System.Drawing.Point(637, 362);
            this.btnProcessLoanLoanBooks.Name = "btnProcessLoanLoanBooks";
            this.btnProcessLoanLoanBooks.Size = new System.Drawing.Size(118, 37);
            this.btnProcessLoanLoanBooks.TabIndex = 21;
            this.btnProcessLoanLoanBooks.Text = "Loan Books";
            this.btnProcessLoanLoanBooks.UseVisualStyleBackColor = true;
            this.btnProcessLoanLoanBooks.Click += new System.EventHandler(this.btnProcessLoanLoanBooks_Click);
            // 
            // btnProcessLoanRemove
            // 
            this.btnProcessLoanRemove.Location = new System.Drawing.Point(560, 362);
            this.btnProcessLoanRemove.Name = "btnProcessLoanRemove";
            this.btnProcessLoanRemove.Size = new System.Drawing.Size(60, 37);
            this.btnProcessLoanRemove.TabIndex = 20;
            this.btnProcessLoanRemove.Text = "Remove";
            this.btnProcessLoanRemove.UseVisualStyleBackColor = true;
            this.btnProcessLoanRemove.Click += new System.EventHandler(this.btnProcessLoanRemove_Click);
            // 
            // btnProcessLoanSearchISBN
            // 
            this.btnProcessLoanSearchISBN.Location = new System.Drawing.Point(210, 31);
            this.btnProcessLoanSearchISBN.Name = "btnProcessLoanSearchISBN";
            this.btnProcessLoanSearchISBN.Size = new System.Drawing.Size(75, 23);
            this.btnProcessLoanSearchISBN.TabIndex = 19;
            this.btnProcessLoanSearchISBN.Text = "Search";
            this.btnProcessLoanSearchISBN.UseVisualStyleBackColor = true;
            this.btnProcessLoanSearchISBN.Click += new System.EventHandler(this.btnProcessLoanSearchISBN_Click);
            // 
            // txtProcessLoanISBN
            // 
            this.txtProcessLoanISBN.Location = new System.Drawing.Point(65, 34);
            this.txtProcessLoanISBN.Name = "txtProcessLoanISBN";
            this.txtProcessLoanISBN.Size = new System.Drawing.Size(129, 20);
            this.txtProcessLoanISBN.TabIndex = 18;
            // 
            // lblProcessLoanISBN
            // 
            this.lblProcessLoanISBN.AutoSize = true;
            this.lblProcessLoanISBN.Location = new System.Drawing.Point(14, 35);
            this.lblProcessLoanISBN.Name = "lblProcessLoanISBN";
            this.lblProcessLoanISBN.Size = new System.Drawing.Size(35, 13);
            this.lblProcessLoanISBN.TabIndex = 17;
            this.lblProcessLoanISBN.Text = "ISBN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Current Cart";
            // 
            // clbProcessLoan
            // 
            this.clbProcessLoan.FormattingEnabled = true;
            this.clbProcessLoan.Location = new System.Drawing.Point(560, 51);
            this.clbProcessLoan.Name = "clbProcessLoan";
            this.clbProcessLoan.Size = new System.Drawing.Size(195, 289);
            this.clbProcessLoan.TabIndex = 15;
            this.clbProcessLoan.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnProcessLoanAdd
            // 
            this.btnProcessLoanAdd.Location = new System.Drawing.Point(96, 362);
            this.btnProcessLoanAdd.Name = "btnProcessLoanAdd";
            this.btnProcessLoanAdd.Size = new System.Drawing.Size(200, 37);
            this.btnProcessLoanAdd.TabIndex = 14;
            this.btnProcessLoanAdd.Text = "Add to Loan";
            this.btnProcessLoanAdd.UseVisualStyleBackColor = true;
            this.btnProcessLoanAdd.Click += new System.EventHandler(this.btnProcessLoanAdd_Click);
            // 
            // dtpProcessLoanPublication
            // 
            this.dtpProcessLoanPublication.Enabled = false;
            this.dtpProcessLoanPublication.Location = new System.Drawing.Point(96, 287);
            this.dtpProcessLoanPublication.Name = "dtpProcessLoanPublication";
            this.dtpProcessLoanPublication.Size = new System.Drawing.Size(200, 20);
            this.dtpProcessLoanPublication.TabIndex = 13;
            // 
            // cboProcessLoanStatus
            // 
            this.cboProcessLoanStatus.Enabled = false;
            this.cboProcessLoanStatus.FormattingEnabled = true;
            this.cboProcessLoanStatus.Location = new System.Drawing.Point(96, 317);
            this.cboProcessLoanStatus.Name = "cboProcessLoanStatus";
            this.cboProcessLoanStatus.Size = new System.Drawing.Size(200, 21);
            this.cboProcessLoanStatus.TabIndex = 12;
            // 
            // cboProcessLoanGenre
            // 
            this.cboProcessLoanGenre.Enabled = false;
            this.cboProcessLoanGenre.FormattingEnabled = true;
            this.cboProcessLoanGenre.Location = new System.Drawing.Point(96, 210);
            this.cboProcessLoanGenre.Name = "cboProcessLoanGenre";
            this.cboProcessLoanGenre.Size = new System.Drawing.Size(200, 21);
            this.cboProcessLoanGenre.TabIndex = 11;
            // 
            // txtProcessLoanPublisher
            // 
            this.txtProcessLoanPublisher.Enabled = false;
            this.txtProcessLoanPublisher.Location = new System.Drawing.Point(96, 248);
            this.txtProcessLoanPublisher.Name = "txtProcessLoanPublisher";
            this.txtProcessLoanPublisher.Size = new System.Drawing.Size(200, 20);
            this.txtProcessLoanPublisher.TabIndex = 10;
            // 
            // txtProcessLoanDescription
            // 
            this.txtProcessLoanDescription.Enabled = false;
            this.txtProcessLoanDescription.Location = new System.Drawing.Point(96, 176);
            this.txtProcessLoanDescription.Name = "txtProcessLoanDescription";
            this.txtProcessLoanDescription.Size = new System.Drawing.Size(200, 20);
            this.txtProcessLoanDescription.TabIndex = 9;
            // 
            // txtProcessLoanAuthor
            // 
            this.txtProcessLoanAuthor.Enabled = false;
            this.txtProcessLoanAuthor.Location = new System.Drawing.Point(96, 136);
            this.txtProcessLoanAuthor.Name = "txtProcessLoanAuthor";
            this.txtProcessLoanAuthor.Size = new System.Drawing.Size(200, 20);
            this.txtProcessLoanAuthor.TabIndex = 8;
            // 
            // txtProcessLoanTitle
            // 
            this.txtProcessLoanTitle.Enabled = false;
            this.txtProcessLoanTitle.Location = new System.Drawing.Point(96, 100);
            this.txtProcessLoanTitle.Name = "txtProcessLoanTitle";
            this.txtProcessLoanTitle.Size = new System.Drawing.Size(200, 20);
            this.txtProcessLoanTitle.TabIndex = 7;
            // 
            // lblProcessLoanStatus
            // 
            this.lblProcessLoanStatus.AutoSize = true;
            this.lblProcessLoanStatus.Location = new System.Drawing.Point(11, 325);
            this.lblProcessLoanStatus.Name = "lblProcessLoanStatus";
            this.lblProcessLoanStatus.Size = new System.Drawing.Size(40, 13);
            this.lblProcessLoanStatus.TabIndex = 6;
            this.lblProcessLoanStatus.Text = "Status:";
            // 
            // lblProcessLoanPublication
            // 
            this.lblProcessLoanPublication.AutoSize = true;
            this.lblProcessLoanPublication.Location = new System.Drawing.Point(11, 287);
            this.lblProcessLoanPublication.Name = "lblProcessLoanPublication";
            this.lblProcessLoanPublication.Size = new System.Drawing.Size(62, 13);
            this.lblProcessLoanPublication.TabIndex = 5;
            this.lblProcessLoanPublication.Text = "Publication:";
            // 
            // lblProcessLoanPublisher
            // 
            this.lblProcessLoanPublisher.AutoSize = true;
            this.lblProcessLoanPublisher.Location = new System.Drawing.Point(11, 248);
            this.lblProcessLoanPublisher.Name = "lblProcessLoanPublisher";
            this.lblProcessLoanPublisher.Size = new System.Drawing.Size(53, 13);
            this.lblProcessLoanPublisher.TabIndex = 4;
            this.lblProcessLoanPublisher.Text = "Publisher:";
            // 
            // lblProcessLoanGenre
            // 
            this.lblProcessLoanGenre.AutoSize = true;
            this.lblProcessLoanGenre.Location = new System.Drawing.Point(11, 213);
            this.lblProcessLoanGenre.Name = "lblProcessLoanGenre";
            this.lblProcessLoanGenre.Size = new System.Drawing.Size(39, 13);
            this.lblProcessLoanGenre.TabIndex = 3;
            this.lblProcessLoanGenre.Text = "Genre:";
            // 
            // lblProcessLoanDescription
            // 
            this.lblProcessLoanDescription.AutoSize = true;
            this.lblProcessLoanDescription.Location = new System.Drawing.Point(11, 176);
            this.lblProcessLoanDescription.Name = "lblProcessLoanDescription";
            this.lblProcessLoanDescription.Size = new System.Drawing.Size(63, 13);
            this.lblProcessLoanDescription.TabIndex = 2;
            this.lblProcessLoanDescription.Text = "Description:";
            // 
            // lblProcessLoanAuthor
            // 
            this.lblProcessLoanAuthor.AutoSize = true;
            this.lblProcessLoanAuthor.Location = new System.Drawing.Point(11, 136);
            this.lblProcessLoanAuthor.Name = "lblProcessLoanAuthor";
            this.lblProcessLoanAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblProcessLoanAuthor.TabIndex = 1;
            this.lblProcessLoanAuthor.Text = "Author:";
            // 
            // lblProcessLoanTitle
            // 
            this.lblProcessLoanTitle.AutoSize = true;
            this.lblProcessLoanTitle.Location = new System.Drawing.Point(11, 100);
            this.lblProcessLoanTitle.Name = "lblProcessLoanTitle";
            this.lblProcessLoanTitle.Size = new System.Drawing.Size(30, 13);
            this.lblProcessLoanTitle.TabIndex = 0;
            this.lblProcessLoanTitle.Text = "Title:";
            // 
            // frmProcessLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.grpProcessLoan);
            this.Controls.Add(this.btnProcessLoanSearchID);
            this.Controls.Add(this.txtProcessLoanMemberID);
            this.Controls.Add(this.lblProcessLoanMemberID);
            this.Controls.Add(this.mnuProcessLoan);
            this.MainMenuStrip = this.mnuProcessLoan;
            this.Name = "frmProcessLoan";
            this.Text = "Loans - [Process Loan]";
            this.Load += new System.EventHandler(this.frmProcessLoan_Load);
            this.mnuProcessLoan.ResumeLayout(false);
            this.mnuProcessLoan.PerformLayout();
            this.grpProcessLoan.ResumeLayout(false);
            this.grpProcessLoan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuProcessLoan;
        private System.Windows.Forms.ToolStripMenuItem mnuProcessLoanExit;
        private System.Windows.Forms.Label lblProcessLoanMemberID;
        private System.Windows.Forms.TextBox txtProcessLoanMemberID;
        private System.Windows.Forms.Button btnProcessLoanSearchID;
        private System.Windows.Forms.GroupBox grpProcessLoan;
        private System.Windows.Forms.Label lblProcessLoanTitle;
        private System.Windows.Forms.Label lblProcessLoanDescription;
        private System.Windows.Forms.Label lblProcessLoanAuthor;
        private System.Windows.Forms.Label lblProcessLoanGenre;
        private System.Windows.Forms.Label lblProcessLoanPublisher;
        private System.Windows.Forms.Label lblProcessLoanPublication;
        private System.Windows.Forms.Label lblProcessLoanStatus;
        private System.Windows.Forms.TextBox txtProcessLoanAuthor;
        private System.Windows.Forms.TextBox txtProcessLoanTitle;
        private System.Windows.Forms.TextBox txtProcessLoanPublisher;
        private System.Windows.Forms.TextBox txtProcessLoanDescription;
        private System.Windows.Forms.DateTimePicker dtpProcessLoanPublication;
        private System.Windows.Forms.ComboBox cboProcessLoanStatus;
        private System.Windows.Forms.ComboBox cboProcessLoanGenre;
        private System.Windows.Forms.Button btnProcessLoanAdd;
        private System.Windows.Forms.CheckedListBox clbProcessLoan;
        private System.Windows.Forms.Label lblProcessLoanISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcessLoanLoanBooks;
        private System.Windows.Forms.Button btnProcessLoanRemove;
        private System.Windows.Forms.Button btnProcessLoanSearchISBN;
        private System.Windows.Forms.TextBox txtProcessLoanISBN;
    }
}