namespace LibrarySYS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoans = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcessLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcessReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduceFineReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduceGenreReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBooks,
            this.mnuMembers,
            this.mnuLoans,
            this.mnuAdmin,
            this.mnuExit});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(771, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "Main Menu";
            // 
            // mnuBooks
            // 
            this.mnuBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBook,
            this.mnuDeleteBook,
            this.mnuUpdateBook,
            this.mnuViewBook});
            this.mnuBooks.Name = "mnuBooks";
            this.mnuBooks.Size = new System.Drawing.Size(51, 20);
            this.mnuBooks.Text = "Books";
            // 
            // mnuAddBook
            // 
            this.mnuAddBook.Name = "mnuAddBook";
            this.mnuAddBook.Size = new System.Drawing.Size(142, 22);
            this.mnuAddBook.Text = "Add Book";
            this.mnuAddBook.Click += new System.EventHandler(this.mnuAddBook_Click);
            // 
            // mnuDeleteBook
            // 
            this.mnuDeleteBook.Name = "mnuDeleteBook";
            this.mnuDeleteBook.Size = new System.Drawing.Size(142, 22);
            this.mnuDeleteBook.Text = "Delete Book";
            this.mnuDeleteBook.Click += new System.EventHandler(this.mnuDeleteBook_Click);
            // 
            // mnuUpdateBook
            // 
            this.mnuUpdateBook.Name = "mnuUpdateBook";
            this.mnuUpdateBook.Size = new System.Drawing.Size(142, 22);
            this.mnuUpdateBook.Text = "Update Book";
            this.mnuUpdateBook.Click += new System.EventHandler(this.mnuUpdateBook_Click);
            // 
            // mnuViewBook
            // 
            this.mnuViewBook.Name = "mnuViewBook";
            this.mnuViewBook.Size = new System.Drawing.Size(142, 22);
            this.mnuViewBook.Text = "View Book";
            this.mnuViewBook.Click += new System.EventHandler(this.mnuViewBook_Click);
            // 
            // mnuMembers
            // 
            this.mnuMembers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMember,
            this.mnuDeleteMember,
            this.mnuUpdateMember,
            this.mnuViewMember});
            this.mnuMembers.Name = "mnuMembers";
            this.mnuMembers.Size = new System.Drawing.Size(69, 20);
            this.mnuMembers.Text = "Members";
            // 
            // mnuAddMember
            // 
            this.mnuAddMember.Name = "mnuAddMember";
            this.mnuAddMember.Size = new System.Drawing.Size(160, 22);
            this.mnuAddMember.Text = "Add Member";
            this.mnuAddMember.Click += new System.EventHandler(this.mnuAddMember_Click);
            // 
            // mnuDeleteMember
            // 
            this.mnuDeleteMember.Name = "mnuDeleteMember";
            this.mnuDeleteMember.Size = new System.Drawing.Size(160, 22);
            this.mnuDeleteMember.Text = "Delete Member";
            this.mnuDeleteMember.Click += new System.EventHandler(this.mnuDeleteMember_Click);
            // 
            // mnuUpdateMember
            // 
            this.mnuUpdateMember.Name = "mnuUpdateMember";
            this.mnuUpdateMember.Size = new System.Drawing.Size(160, 22);
            this.mnuUpdateMember.Text = "Update Member";
            this.mnuUpdateMember.Click += new System.EventHandler(this.mnuUpdateMember_Click);
            // 
            // mnuViewMember
            // 
            this.mnuViewMember.Name = "mnuViewMember";
            this.mnuViewMember.Size = new System.Drawing.Size(160, 22);
            this.mnuViewMember.Text = "View Member";
            this.mnuViewMember.Click += new System.EventHandler(this.mnuViewMember_Click);
            // 
            // mnuLoans
            // 
            this.mnuLoans.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProcessLoan,
            this.mnuProcessReturn});
            this.mnuLoans.Name = "mnuLoans";
            this.mnuLoans.Size = new System.Drawing.Size(50, 20);
            this.mnuLoans.Text = "Loans";
            // 
            // mnuProcessLoan
            // 
            this.mnuProcessLoan.Name = "mnuProcessLoan";
            this.mnuProcessLoan.Size = new System.Drawing.Size(152, 22);
            this.mnuProcessLoan.Text = "Process Loan";
            this.mnuProcessLoan.Click += new System.EventHandler(this.mnuProcessLoan_Click);
            // 
            // mnuProcessReturn
            // 
            this.mnuProcessReturn.Name = "mnuProcessReturn";
            this.mnuProcessReturn.Size = new System.Drawing.Size(152, 22);
            this.mnuProcessReturn.Text = "Process Return";
            this.mnuProcessReturn.Click += new System.EventHandler(this.mnuProcessReturn_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProduceFineReport,
            this.mnuProduceGenreReport});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuProduceFineReport
            // 
            this.mnuProduceFineReport.Name = "mnuProduceFineReport";
            this.mnuProduceFineReport.Size = new System.Drawing.Size(190, 22);
            this.mnuProduceFineReport.Text = "Produce Fine Report";
            this.mnuProduceFineReport.Click += new System.EventHandler(this.mnuProduceFineReport_Click);
            // 
            // mnuProduceGenreReport
            // 
            this.mnuProduceGenreReport.Name = "mnuProduceGenreReport";
            this.mnuProduceGenreReport.Size = new System.Drawing.Size(190, 22);
            this.mnuProduceGenreReport.Text = "Produce Genre Report";
            this.mnuProduceGenreReport.Click += new System.EventHandler(this.mnuProduceGenreReport_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 364);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainMenu";
            this.Text = "LibrarySYS - [Main Menu]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuBooks;
        private System.Windows.Forms.ToolStripMenuItem mnuMembers;
        private System.Windows.Forms.ToolStripMenuItem mnuLoans;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBook;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteBook;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuViewBook;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMember;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteMember;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMember;
        private System.Windows.Forms.ToolStripMenuItem mnuViewMember;
        private System.Windows.Forms.ToolStripMenuItem mnuProcessLoan;
        private System.Windows.Forms.ToolStripMenuItem mnuProcessReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuProduceFineReport;
        private System.Windows.Forms.ToolStripMenuItem mnuProduceGenreReport;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

