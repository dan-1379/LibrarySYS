namespace LibrarySYS
{
    partial class frmViewBook
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
            this.components = new System.ComponentModel.Container();
            this.mnuViewBook = new System.Windows.Forms.MenuStrip();
            this.mnuViewBookExit = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtpViewBookPublication = new System.Windows.Forms.DateTimePicker();
            this.txtViewBookPublisher = new System.Windows.Forms.TextBox();
            this.cboViewBookGenre = new System.Windows.Forms.ComboBox();
            this.txtViewBookDescription = new System.Windows.Forms.TextBox();
            this.txtViewBookAuthor = new System.Windows.Forms.TextBox();
            this.txtViewBookTitle = new System.Windows.Forms.TextBox();
            this.lblViewBookISBN = new System.Windows.Forms.Label();
            this.lblViewBookTitle = new System.Windows.Forms.Label();
            this.grpViewBook = new System.Windows.Forms.GroupBox();
            this.cboViewBookStatus = new System.Windows.Forms.ComboBox();
            this.lblViewBookStatus = new System.Windows.Forms.Label();
            this.lblViewBookPublication = new System.Windows.Forms.Label();
            this.lblViewBookPublisher = new System.Windows.Forms.Label();
            this.lblViewBookGenre = new System.Windows.Forms.Label();
            this.lblViewBookDescription = new System.Windows.Forms.Label();
            this.lblViewBookAuthor = new System.Windows.Forms.Label();
            this.btnViewBookSearch = new System.Windows.Forms.Button();
            this.txtViewBookISBN = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mnuViewBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grpViewBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuViewBook
            // 
            this.mnuViewBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewBookExit});
            this.mnuViewBook.Location = new System.Drawing.Point(0, 0);
            this.mnuViewBook.Name = "mnuViewBook";
            this.mnuViewBook.Size = new System.Drawing.Size(348, 24);
            this.mnuViewBook.TabIndex = 0;
            this.mnuViewBook.Text = "menuStrip1";
            // 
            // mnuViewBookExit
            // 
            this.mnuViewBookExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuViewBookExit.Name = "mnuViewBookExit";
            this.mnuViewBookExit.Size = new System.Drawing.Size(37, 20);
            this.mnuViewBookExit.Text = "Exit";
            this.mnuViewBookExit.Click += new System.EventHandler(this.mnuViewBookExit_Click);
            // 
            // dtpViewBookPublication
            // 
            this.dtpViewBookPublication.Location = new System.Drawing.Point(79, 270);
            this.dtpViewBookPublication.Name = "dtpViewBookPublication";
            this.dtpViewBookPublication.Size = new System.Drawing.Size(200, 20);
            this.dtpViewBookPublication.TabIndex = 12;
            // 
            // txtViewBookPublisher
            // 
            this.txtViewBookPublisher.Location = new System.Drawing.Point(78, 232);
            this.txtViewBookPublisher.Name = "txtViewBookPublisher";
            this.txtViewBookPublisher.ReadOnly = true;
            this.txtViewBookPublisher.Size = new System.Drawing.Size(201, 20);
            this.txtViewBookPublisher.TabIndex = 11;
            // 
            // cboViewBookGenre
            // 
            this.cboViewBookGenre.FormattingEnabled = true;
            this.cboViewBookGenre.Items.AddRange(new object[] {
            "Young Adult",
            "Fantasy",
            "Horror",
            "Mystery",
            "Thriller",
            "Romance",
            "Science Fiction",
            "Action",
            "Historical"});
            this.cboViewBookGenre.Location = new System.Drawing.Point(78, 195);
            this.cboViewBookGenre.Name = "cboViewBookGenre";
            this.cboViewBookGenre.Size = new System.Drawing.Size(201, 21);
            this.cboViewBookGenre.TabIndex = 10;
            // 
            // txtViewBookDescription
            // 
            this.txtViewBookDescription.Location = new System.Drawing.Point(78, 105);
            this.txtViewBookDescription.Multiline = true;
            this.txtViewBookDescription.Name = "txtViewBookDescription";
            this.txtViewBookDescription.ReadOnly = true;
            this.txtViewBookDescription.Size = new System.Drawing.Size(201, 68);
            this.txtViewBookDescription.TabIndex = 9;
            // 
            // txtViewBookAuthor
            // 
            this.txtViewBookAuthor.Location = new System.Drawing.Point(78, 67);
            this.txtViewBookAuthor.Name = "txtViewBookAuthor";
            this.txtViewBookAuthor.ReadOnly = true;
            this.txtViewBookAuthor.Size = new System.Drawing.Size(201, 20);
            this.txtViewBookAuthor.TabIndex = 8;
            // 
            // txtViewBookTitle
            // 
            this.txtViewBookTitle.Location = new System.Drawing.Point(78, 34);
            this.txtViewBookTitle.Name = "txtViewBookTitle";
            this.txtViewBookTitle.ReadOnly = true;
            this.txtViewBookTitle.Size = new System.Drawing.Size(201, 20);
            this.txtViewBookTitle.TabIndex = 7;
            // 
            // lblViewBookISBN
            // 
            this.lblViewBookISBN.AutoSize = true;
            this.lblViewBookISBN.Location = new System.Drawing.Point(12, 38);
            this.lblViewBookISBN.Name = "lblViewBookISBN";
            this.lblViewBookISBN.Size = new System.Drawing.Size(63, 13);
            this.lblViewBookISBN.TabIndex = 5;
            this.lblViewBookISBN.Text = "Enter ISBN:";
            // 
            // lblViewBookTitle
            // 
            this.lblViewBookTitle.AutoSize = true;
            this.lblViewBookTitle.Location = new System.Drawing.Point(7, 34);
            this.lblViewBookTitle.Name = "lblViewBookTitle";
            this.lblViewBookTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblViewBookTitle.Size = new System.Drawing.Size(30, 13);
            this.lblViewBookTitle.TabIndex = 0;
            this.lblViewBookTitle.Text = "Title:";
            // 
            // grpViewBook
            // 
            this.grpViewBook.Controls.Add(this.cboViewBookStatus);
            this.grpViewBook.Controls.Add(this.lblViewBookStatus);
            this.grpViewBook.Controls.Add(this.dtpViewBookPublication);
            this.grpViewBook.Controls.Add(this.txtViewBookPublisher);
            this.grpViewBook.Controls.Add(this.cboViewBookGenre);
            this.grpViewBook.Controls.Add(this.txtViewBookDescription);
            this.grpViewBook.Controls.Add(this.txtViewBookAuthor);
            this.grpViewBook.Controls.Add(this.txtViewBookTitle);
            this.grpViewBook.Controls.Add(this.lblViewBookPublication);
            this.grpViewBook.Controls.Add(this.lblViewBookPublisher);
            this.grpViewBook.Controls.Add(this.lblViewBookGenre);
            this.grpViewBook.Controls.Add(this.lblViewBookDescription);
            this.grpViewBook.Controls.Add(this.lblViewBookAuthor);
            this.grpViewBook.Controls.Add(this.lblViewBookTitle);
            this.grpViewBook.Location = new System.Drawing.Point(15, 74);
            this.grpViewBook.Name = "grpViewBook";
            this.grpViewBook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpViewBook.Size = new System.Drawing.Size(306, 360);
            this.grpViewBook.TabIndex = 8;
            this.grpViewBook.TabStop = false;
            this.grpViewBook.Text = "View Book";
            // 
            // cboViewBookStatus
            // 
            this.cboViewBookStatus.FormattingEnabled = true;
            this.cboViewBookStatus.Items.AddRange(new object[] {
            "A",
            "C",
            "H",
            "T",
            "D",
            "S"});
            this.cboViewBookStatus.Location = new System.Drawing.Point(78, 309);
            this.cboViewBookStatus.Name = "cboViewBookStatus";
            this.cboViewBookStatus.Size = new System.Drawing.Size(201, 21);
            this.cboViewBookStatus.TabIndex = 14;
            // 
            // lblViewBookStatus
            // 
            this.lblViewBookStatus.AutoSize = true;
            this.lblViewBookStatus.Location = new System.Drawing.Point(13, 312);
            this.lblViewBookStatus.Name = "lblViewBookStatus";
            this.lblViewBookStatus.Size = new System.Drawing.Size(40, 13);
            this.lblViewBookStatus.TabIndex = 13;
            this.lblViewBookStatus.Text = "Status:";
            // 
            // lblViewBookPublication
            // 
            this.lblViewBookPublication.AutoSize = true;
            this.lblViewBookPublication.Location = new System.Drawing.Point(10, 276);
            this.lblViewBookPublication.Name = "lblViewBookPublication";
            this.lblViewBookPublication.Size = new System.Drawing.Size(62, 13);
            this.lblViewBookPublication.TabIndex = 5;
            this.lblViewBookPublication.Text = "Publication:";
            // 
            // lblViewBookPublisher
            // 
            this.lblViewBookPublisher.AutoSize = true;
            this.lblViewBookPublisher.Location = new System.Drawing.Point(10, 235);
            this.lblViewBookPublisher.Name = "lblViewBookPublisher";
            this.lblViewBookPublisher.Size = new System.Drawing.Size(53, 13);
            this.lblViewBookPublisher.TabIndex = 4;
            this.lblViewBookPublisher.Text = "Publisher:";
            // 
            // lblViewBookGenre
            // 
            this.lblViewBookGenre.AutoSize = true;
            this.lblViewBookGenre.Location = new System.Drawing.Point(10, 198);
            this.lblViewBookGenre.Name = "lblViewBookGenre";
            this.lblViewBookGenre.Size = new System.Drawing.Size(39, 13);
            this.lblViewBookGenre.TabIndex = 3;
            this.lblViewBookGenre.Text = "Genre:";
            // 
            // lblViewBookDescription
            // 
            this.lblViewBookDescription.AutoSize = true;
            this.lblViewBookDescription.Location = new System.Drawing.Point(6, 108);
            this.lblViewBookDescription.Name = "lblViewBookDescription";
            this.lblViewBookDescription.Size = new System.Drawing.Size(63, 13);
            this.lblViewBookDescription.TabIndex = 2;
            this.lblViewBookDescription.Text = "Description:";
            // 
            // lblViewBookAuthor
            // 
            this.lblViewBookAuthor.AutoSize = true;
            this.lblViewBookAuthor.Location = new System.Drawing.Point(7, 70);
            this.lblViewBookAuthor.Name = "lblViewBookAuthor";
            this.lblViewBookAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblViewBookAuthor.TabIndex = 1;
            this.lblViewBookAuthor.Text = "Author:";
            // 
            // btnViewBookSearch
            // 
            this.btnViewBookSearch.Location = new System.Drawing.Point(233, 33);
            this.btnViewBookSearch.Name = "btnViewBookSearch";
            this.btnViewBookSearch.Size = new System.Drawing.Size(88, 20);
            this.btnViewBookSearch.TabIndex = 7;
            this.btnViewBookSearch.Text = "Search";
            this.btnViewBookSearch.UseVisualStyleBackColor = true;
            this.btnViewBookSearch.Click += new System.EventHandler(this.btnViewBookSearch_Click);
            // 
            // txtViewBookISBN
            // 
            this.txtViewBookISBN.Location = new System.Drawing.Point(83, 34);
            this.txtViewBookISBN.Name = "txtViewBookISBN";
            this.txtViewBookISBN.Size = new System.Drawing.Size(131, 20);
            this.txtViewBookISBN.TabIndex = 6;
            // 
            // frmViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.lblViewBookISBN);
            this.Controls.Add(this.grpViewBook);
            this.Controls.Add(this.btnViewBookSearch);
            this.Controls.Add(this.txtViewBookISBN);
            this.Controls.Add(this.mnuViewBook);
            this.MainMenuStrip = this.mnuViewBook;
            this.Name = "frmViewBook";
            this.Text = "Books - [View Book]";
            this.Load += new System.EventHandler(this.frmViewBook_Load);
            this.mnuViewBook.ResumeLayout(false);
            this.mnuViewBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grpViewBook.ResumeLayout(false);
            this.grpViewBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuViewBook;
        private System.Windows.Forms.ToolStripMenuItem mnuViewBookExit;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DateTimePicker dtpViewBookPublication;
        private System.Windows.Forms.TextBox txtViewBookPublisher;
        private System.Windows.Forms.ComboBox cboViewBookGenre;
        private System.Windows.Forms.TextBox txtViewBookDescription;
        private System.Windows.Forms.TextBox txtViewBookAuthor;
        private System.Windows.Forms.TextBox txtViewBookTitle;
        private System.Windows.Forms.Label lblViewBookISBN;
        private System.Windows.Forms.Label lblViewBookTitle;
        private System.Windows.Forms.GroupBox grpViewBook;
        private System.Windows.Forms.Label lblViewBookPublication;
        private System.Windows.Forms.Label lblViewBookPublisher;
        private System.Windows.Forms.Label lblViewBookGenre;
        private System.Windows.Forms.Label lblViewBookDescription;
        private System.Windows.Forms.Label lblViewBookAuthor;
        private System.Windows.Forms.Button btnViewBookSearch;
        private System.Windows.Forms.TextBox txtViewBookISBN;
        private System.Windows.Forms.Label lblViewBookStatus;
        private System.Windows.Forms.ComboBox cboViewBookStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}