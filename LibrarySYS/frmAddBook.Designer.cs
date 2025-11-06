namespace LibrarySYS
{
    partial class frmAddBook
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
            this.mnuAddBook = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAddBook = new System.Windows.Forms.GroupBox();
            this.dtpAddBookPublication = new System.Windows.Forms.DateTimePicker();
            this.cboAddBookGenre = new System.Windows.Forms.ComboBox();
            this.txtAddBookPublisher = new System.Windows.Forms.TextBox();
            this.txtAddBookISBN = new System.Windows.Forms.TextBox();
            this.txtAddBookDescription = new System.Windows.Forms.TextBox();
            this.txtAddBookAuthor = new System.Windows.Forms.TextBox();
            this.txtAddBookTitle = new System.Windows.Forms.TextBox();
            this.btnAddBookSave = new System.Windows.Forms.Button();
            this.lblAddBookPublication = new System.Windows.Forms.Label();
            this.lblAddBookPublisher = new System.Windows.Forms.Label();
            this.lblAddBookGenre = new System.Windows.Forms.Label();
            this.lblAddBookISBN = new System.Windows.Forms.Label();
            this.lblAddBookDescription = new System.Windows.Forms.Label();
            this.lblAddBookAuthor = new System.Windows.Forms.Label();
            this.lblAddBookTitle = new System.Windows.Forms.Label();
            this.mnuAddBook.SuspendLayout();
            this.grpAddBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAddBook
            // 
            this.mnuAddBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuAddBook.Location = new System.Drawing.Point(0, 0);
            this.mnuAddBook.Name = "mnuAddBook";
            this.mnuAddBook.Size = new System.Drawing.Size(368, 24);
            this.mnuAddBook.TabIndex = 0;
            this.mnuAddBook.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // grpAddBook
            // 
            this.grpAddBook.Controls.Add(this.dtpAddBookPublication);
            this.grpAddBook.Controls.Add(this.cboAddBookGenre);
            this.grpAddBook.Controls.Add(this.txtAddBookPublisher);
            this.grpAddBook.Controls.Add(this.txtAddBookISBN);
            this.grpAddBook.Controls.Add(this.txtAddBookDescription);
            this.grpAddBook.Controls.Add(this.txtAddBookAuthor);
            this.grpAddBook.Controls.Add(this.txtAddBookTitle);
            this.grpAddBook.Controls.Add(this.btnAddBookSave);
            this.grpAddBook.Controls.Add(this.lblAddBookPublication);
            this.grpAddBook.Controls.Add(this.lblAddBookPublisher);
            this.grpAddBook.Controls.Add(this.lblAddBookGenre);
            this.grpAddBook.Controls.Add(this.lblAddBookISBN);
            this.grpAddBook.Controls.Add(this.lblAddBookDescription);
            this.grpAddBook.Controls.Add(this.lblAddBookAuthor);
            this.grpAddBook.Controls.Add(this.lblAddBookTitle);
            this.grpAddBook.Location = new System.Drawing.Point(13, 28);
            this.grpAddBook.Name = "grpAddBook";
            this.grpAddBook.Size = new System.Drawing.Size(343, 390);
            this.grpAddBook.TabIndex = 1;
            this.grpAddBook.TabStop = false;
            this.grpAddBook.Text = "Add Book";
            // 
            // dtpAddBookPublication
            // 
            this.dtpAddBookPublication.CustomFormat = "DD/MM/YYYY";
            this.dtpAddBookPublication.Location = new System.Drawing.Point(78, 288);
            this.dtpAddBookPublication.Name = "dtpAddBookPublication";
            this.dtpAddBookPublication.Size = new System.Drawing.Size(247, 20);
            this.dtpAddBookPublication.TabIndex = 15;
            this.dtpAddBookPublication.Value = new System.DateTime(2025, 10, 30, 0, 0, 0, 0);
            // 
            // cboAddBookGenre
            // 
            this.cboAddBookGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddBookGenre.FormattingEnabled = true;
            this.cboAddBookGenre.Items.AddRange(new object[] {
            "Young Adult",
            "Fantasy",
            "Horror",
            "Mystery",
            "Thriller",
            "Romance",
            "Science Fiction",
            "Action",
            "Historical"});
            this.cboAddBookGenre.Location = new System.Drawing.Point(78, 206);
            this.cboAddBookGenre.Name = "cboAddBookGenre";
            this.cboAddBookGenre.Size = new System.Drawing.Size(247, 21);
            this.cboAddBookGenre.TabIndex = 14;
            this.cboAddBookGenre.SelectedIndexChanged += new System.EventHandler(this.cboAddBookGenre_SelectedIndexChanged);
            // 
            // txtAddBookPublisher
            // 
            this.txtAddBookPublisher.Location = new System.Drawing.Point(78, 249);
            this.txtAddBookPublisher.Name = "txtAddBookPublisher";
            this.txtAddBookPublisher.Size = new System.Drawing.Size(247, 20);
            this.txtAddBookPublisher.TabIndex = 13;
            // 
            // txtAddBookISBN
            // 
            this.txtAddBookISBN.Location = new System.Drawing.Point(78, 170);
            this.txtAddBookISBN.Name = "txtAddBookISBN";
            this.txtAddBookISBN.Size = new System.Drawing.Size(247, 20);
            this.txtAddBookISBN.TabIndex = 11;
            // 
            // txtAddBookDescription
            // 
            this.txtAddBookDescription.Location = new System.Drawing.Point(78, 97);
            this.txtAddBookDescription.Multiline = true;
            this.txtAddBookDescription.Name = "txtAddBookDescription";
            this.txtAddBookDescription.Size = new System.Drawing.Size(247, 57);
            this.txtAddBookDescription.TabIndex = 10;
            // 
            // txtAddBookAuthor
            // 
            this.txtAddBookAuthor.Location = new System.Drawing.Point(78, 64);
            this.txtAddBookAuthor.Name = "txtAddBookAuthor";
            this.txtAddBookAuthor.Size = new System.Drawing.Size(247, 20);
            this.txtAddBookAuthor.TabIndex = 9;
            // 
            // txtAddBookTitle
            // 
            this.txtAddBookTitle.Location = new System.Drawing.Point(78, 27);
            this.txtAddBookTitle.Name = "txtAddBookTitle";
            this.txtAddBookTitle.Size = new System.Drawing.Size(247, 20);
            this.txtAddBookTitle.TabIndex = 8;
            // 
            // btnAddBookSave
            // 
            this.btnAddBookSave.Location = new System.Drawing.Point(14, 335);
            this.btnAddBookSave.Name = "btnAddBookSave";
            this.btnAddBookSave.Size = new System.Drawing.Size(311, 37);
            this.btnAddBookSave.TabIndex = 7;
            this.btnAddBookSave.Text = "Save Book";
            this.btnAddBookSave.UseVisualStyleBackColor = true;
            this.btnAddBookSave.Click += new System.EventHandler(this.btnAddBookSave_Click);
            // 
            // lblAddBookPublication
            // 
            this.lblAddBookPublication.AutoSize = true;
            this.lblAddBookPublication.Location = new System.Drawing.Point(11, 294);
            this.lblAddBookPublication.Name = "lblAddBookPublication";
            this.lblAddBookPublication.Size = new System.Drawing.Size(62, 13);
            this.lblAddBookPublication.TabIndex = 6;
            this.lblAddBookPublication.Text = "Publication:";
            // 
            // lblAddBookPublisher
            // 
            this.lblAddBookPublisher.AutoSize = true;
            this.lblAddBookPublisher.Location = new System.Drawing.Point(9, 252);
            this.lblAddBookPublisher.Name = "lblAddBookPublisher";
            this.lblAddBookPublisher.Size = new System.Drawing.Size(53, 13);
            this.lblAddBookPublisher.TabIndex = 5;
            this.lblAddBookPublisher.Text = "Publisher:";
            // 
            // lblAddBookGenre
            // 
            this.lblAddBookGenre.AutoSize = true;
            this.lblAddBookGenre.Location = new System.Drawing.Point(11, 209);
            this.lblAddBookGenre.Name = "lblAddBookGenre";
            this.lblAddBookGenre.Size = new System.Drawing.Size(39, 13);
            this.lblAddBookGenre.TabIndex = 4;
            this.lblAddBookGenre.Text = "Genre:";
            // 
            // lblAddBookISBN
            // 
            this.lblAddBookISBN.AutoSize = true;
            this.lblAddBookISBN.Location = new System.Drawing.Point(9, 173);
            this.lblAddBookISBN.Name = "lblAddBookISBN";
            this.lblAddBookISBN.Size = new System.Drawing.Size(35, 13);
            this.lblAddBookISBN.TabIndex = 3;
            this.lblAddBookISBN.Text = "ISBN:";
            // 
            // lblAddBookDescription
            // 
            this.lblAddBookDescription.AutoSize = true;
            this.lblAddBookDescription.Location = new System.Drawing.Point(11, 100);
            this.lblAddBookDescription.Name = "lblAddBookDescription";
            this.lblAddBookDescription.Size = new System.Drawing.Size(63, 13);
            this.lblAddBookDescription.TabIndex = 2;
            this.lblAddBookDescription.Text = "Description:";
            // 
            // lblAddBookAuthor
            // 
            this.lblAddBookAuthor.AutoSize = true;
            this.lblAddBookAuthor.Location = new System.Drawing.Point(9, 67);
            this.lblAddBookAuthor.Name = "lblAddBookAuthor";
            this.lblAddBookAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAddBookAuthor.TabIndex = 1;
            this.lblAddBookAuthor.Text = "Author:";
            // 
            // lblAddBookTitle
            // 
            this.lblAddBookTitle.AutoSize = true;
            this.lblAddBookTitle.Location = new System.Drawing.Point(11, 30);
            this.lblAddBookTitle.Name = "lblAddBookTitle";
            this.lblAddBookTitle.Size = new System.Drawing.Size(30, 13);
            this.lblAddBookTitle.TabIndex = 0;
            this.lblAddBookTitle.Text = "Title:";
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(368, 437);
            this.Controls.Add(this.grpAddBook);
            this.Controls.Add(this.mnuAddBook);
            this.MainMenuStrip = this.mnuAddBook;
            this.Name = "frmAddBook";
            this.Text = "Books - [Add Book]";
            this.Load += new System.EventHandler(this.frmAddBook_Load);
            this.Shown += new System.EventHandler(this.frmAddBook_Shown);
            this.mnuAddBook.ResumeLayout(false);
            this.mnuAddBook.PerformLayout();
            this.grpAddBook.ResumeLayout(false);
            this.grpAddBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAddBook;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpAddBook;
        private System.Windows.Forms.Label lblAddBookPublication;
        private System.Windows.Forms.Label lblAddBookPublisher;
        private System.Windows.Forms.Label lblAddBookGenre;
        private System.Windows.Forms.Label lblAddBookISBN;
        private System.Windows.Forms.Label lblAddBookDescription;
        private System.Windows.Forms.Label lblAddBookAuthor;
        private System.Windows.Forms.Label lblAddBookTitle;
        private System.Windows.Forms.TextBox txtAddBookISBN;
        private System.Windows.Forms.TextBox txtAddBookDescription;
        private System.Windows.Forms.TextBox txtAddBookAuthor;
        private System.Windows.Forms.TextBox txtAddBookTitle;
        private System.Windows.Forms.Button btnAddBookSave;
        private System.Windows.Forms.DateTimePicker dtpAddBookPublication;
        private System.Windows.Forms.ComboBox cboAddBookGenre;
        private System.Windows.Forms.TextBox txtAddBookPublisher;
    }
}