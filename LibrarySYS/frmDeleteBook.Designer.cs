namespace LibrarySYS
{
    partial class frmDeleteBook
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
            this.mnuDeleteBook = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDeleteBookISBN = new System.Windows.Forms.Label();
            this.txtDeleteBookISBN = new System.Windows.Forms.TextBox();
            this.btnDeleteBookSearch = new System.Windows.Forms.Button();
            this.grpDeleteBookDetails = new System.Windows.Forms.GroupBox();
            this.lblDeleteBookTitle = new System.Windows.Forms.Label();
            this.lblDeleteBookAuthor = new System.Windows.Forms.Label();
            this.lblDeleteBookDescription = new System.Windows.Forms.Label();
            this.lblDeleteBookGenre = new System.Windows.Forms.Label();
            this.lblDeleteBookPublisher = new System.Windows.Forms.Label();
            this.lblDeleteBookPublication = new System.Windows.Forms.Label();
            this.lblDeleteBookStatus = new System.Windows.Forms.Label();
            this.btnDeleteBookDelete = new System.Windows.Forms.Button();
            this.txtDeleteBookTitle = new System.Windows.Forms.TextBox();
            this.txtDeleteBookAuthor = new System.Windows.Forms.TextBox();
            this.txtDeleteBookDescription = new System.Windows.Forms.TextBox();
            this.txtDeleteBookGenre = new System.Windows.Forms.TextBox();
            this.txtDeleteBookPublisher = new System.Windows.Forms.TextBox();
            this.txtDeleteBookPublication = new System.Windows.Forms.TextBox();
            this.txtDeleteBookStatus = new System.Windows.Forms.TextBox();
            this.mnuDeleteBook.SuspendLayout();
            this.grpDeleteBookDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuDeleteBook
            // 
            this.mnuDeleteBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuDeleteBook.Location = new System.Drawing.Point(0, 0);
            this.mnuDeleteBook.Name = "mnuDeleteBook";
            this.mnuDeleteBook.Size = new System.Drawing.Size(327, 24);
            this.mnuDeleteBook.TabIndex = 0;
            this.mnuDeleteBook.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblDeleteBookISBN
            // 
            this.lblDeleteBookISBN.AutoSize = true;
            this.lblDeleteBookISBN.Location = new System.Drawing.Point(12, 38);
            this.lblDeleteBookISBN.Name = "lblDeleteBookISBN";
            this.lblDeleteBookISBN.Size = new System.Drawing.Size(63, 13);
            this.lblDeleteBookISBN.TabIndex = 1;
            this.lblDeleteBookISBN.Text = "Enter ISBN:";
            // 
            // txtDeleteBookISBN
            // 
            this.txtDeleteBookISBN.Location = new System.Drawing.Point(82, 35);
            this.txtDeleteBookISBN.Name = "txtDeleteBookISBN";
            this.txtDeleteBookISBN.Size = new System.Drawing.Size(124, 20);
            this.txtDeleteBookISBN.TabIndex = 2;
            // 
            // btnDeleteBookSearch
            // 
            this.btnDeleteBookSearch.Location = new System.Drawing.Point(226, 35);
            this.btnDeleteBookSearch.Name = "btnDeleteBookSearch";
            this.btnDeleteBookSearch.Size = new System.Drawing.Size(84, 20);
            this.btnDeleteBookSearch.TabIndex = 3;
            this.btnDeleteBookSearch.Text = "Search";
            this.btnDeleteBookSearch.UseVisualStyleBackColor = true;
            this.btnDeleteBookSearch.Click += new System.EventHandler(this.btnDeleteBookSearch_Click);
            // 
            // grpDeleteBookDetails
            // 
            this.grpDeleteBookDetails.Controls.Add(this.txtDeleteBookStatus);
            this.grpDeleteBookDetails.Controls.Add(this.txtDeleteBookPublication);
            this.grpDeleteBookDetails.Controls.Add(this.txtDeleteBookPublisher);
            this.grpDeleteBookDetails.Controls.Add(this.txtDeleteBookGenre);
            this.grpDeleteBookDetails.Controls.Add(this.txtDeleteBookDescription);
            this.grpDeleteBookDetails.Controls.Add(this.txtDeleteBookAuthor);
            this.grpDeleteBookDetails.Controls.Add(this.txtDeleteBookTitle);
            this.grpDeleteBookDetails.Controls.Add(this.btnDeleteBookDelete);
            this.grpDeleteBookDetails.Controls.Add(this.lblDeleteBookStatus);
            this.grpDeleteBookDetails.Controls.Add(this.lblDeleteBookPublication);
            this.grpDeleteBookDetails.Controls.Add(this.lblDeleteBookPublisher);
            this.grpDeleteBookDetails.Controls.Add(this.lblDeleteBookGenre);
            this.grpDeleteBookDetails.Controls.Add(this.lblDeleteBookDescription);
            this.grpDeleteBookDetails.Controls.Add(this.lblDeleteBookAuthor);
            this.grpDeleteBookDetails.Controls.Add(this.lblDeleteBookTitle);
            this.grpDeleteBookDetails.Location = new System.Drawing.Point(13, 82);
            this.grpDeleteBookDetails.Name = "grpDeleteBookDetails";
            this.grpDeleteBookDetails.Size = new System.Drawing.Size(297, 398);
            this.grpDeleteBookDetails.TabIndex = 4;
            this.grpDeleteBookDetails.TabStop = false;
            this.grpDeleteBookDetails.Text = "Book Details";
            // 
            // lblDeleteBookTitle
            // 
            this.lblDeleteBookTitle.AutoSize = true;
            this.lblDeleteBookTitle.Location = new System.Drawing.Point(6, 33);
            this.lblDeleteBookTitle.Name = "lblDeleteBookTitle";
            this.lblDeleteBookTitle.Size = new System.Drawing.Size(30, 13);
            this.lblDeleteBookTitle.TabIndex = 0;
            this.lblDeleteBookTitle.Text = "Title:";
            // 
            // lblDeleteBookAuthor
            // 
            this.lblDeleteBookAuthor.AutoSize = true;
            this.lblDeleteBookAuthor.Location = new System.Drawing.Point(6, 71);
            this.lblDeleteBookAuthor.Name = "lblDeleteBookAuthor";
            this.lblDeleteBookAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblDeleteBookAuthor.TabIndex = 1;
            this.lblDeleteBookAuthor.Text = "Author:";
            // 
            // lblDeleteBookDescription
            // 
            this.lblDeleteBookDescription.AutoSize = true;
            this.lblDeleteBookDescription.Location = new System.Drawing.Point(6, 109);
            this.lblDeleteBookDescription.Name = "lblDeleteBookDescription";
            this.lblDeleteBookDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDeleteBookDescription.TabIndex = 2;
            this.lblDeleteBookDescription.Text = "Description:";
            // 
            // lblDeleteBookGenre
            // 
            this.lblDeleteBookGenre.AutoSize = true;
            this.lblDeleteBookGenre.Location = new System.Drawing.Point(6, 177);
            this.lblDeleteBookGenre.Name = "lblDeleteBookGenre";
            this.lblDeleteBookGenre.Size = new System.Drawing.Size(39, 13);
            this.lblDeleteBookGenre.TabIndex = 3;
            this.lblDeleteBookGenre.Text = "Genre:";
            // 
            // lblDeleteBookPublisher
            // 
            this.lblDeleteBookPublisher.AutoSize = true;
            this.lblDeleteBookPublisher.Location = new System.Drawing.Point(6, 214);
            this.lblDeleteBookPublisher.Name = "lblDeleteBookPublisher";
            this.lblDeleteBookPublisher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeleteBookPublisher.Size = new System.Drawing.Size(53, 13);
            this.lblDeleteBookPublisher.TabIndex = 4;
            this.lblDeleteBookPublisher.Text = "Publisher:";
            // 
            // lblDeleteBookPublication
            // 
            this.lblDeleteBookPublication.AutoSize = true;
            this.lblDeleteBookPublication.Location = new System.Drawing.Point(6, 251);
            this.lblDeleteBookPublication.Name = "lblDeleteBookPublication";
            this.lblDeleteBookPublication.Size = new System.Drawing.Size(88, 13);
            this.lblDeleteBookPublication.TabIndex = 5;
            this.lblDeleteBookPublication.Text = "Publication Date:";
            // 
            // lblDeleteBookStatus
            // 
            this.lblDeleteBookStatus.AutoSize = true;
            this.lblDeleteBookStatus.Location = new System.Drawing.Point(6, 290);
            this.lblDeleteBookStatus.Name = "lblDeleteBookStatus";
            this.lblDeleteBookStatus.Size = new System.Drawing.Size(40, 13);
            this.lblDeleteBookStatus.TabIndex = 6;
            this.lblDeleteBookStatus.Text = "Status:";
            // 
            // btnDeleteBookDelete
            // 
            this.btnDeleteBookDelete.Location = new System.Drawing.Point(9, 344);
            this.btnDeleteBookDelete.Name = "btnDeleteBookDelete";
            this.btnDeleteBookDelete.Size = new System.Drawing.Size(271, 34);
            this.btnDeleteBookDelete.TabIndex = 7;
            this.btnDeleteBookDelete.Text = "Delete Book";
            this.btnDeleteBookDelete.UseVisualStyleBackColor = true;
            this.btnDeleteBookDelete.Click += new System.EventHandler(this.btnDeleteBookDelete_Click);
            // 
            // txtDeleteBookTitle
            // 
            this.txtDeleteBookTitle.Location = new System.Drawing.Point(96, 30);
            this.txtDeleteBookTitle.Name = "txtDeleteBookTitle";
            this.txtDeleteBookTitle.ReadOnly = true;
            this.txtDeleteBookTitle.Size = new System.Drawing.Size(184, 20);
            this.txtDeleteBookTitle.TabIndex = 8;
            // 
            // txtDeleteBookAuthor
            // 
            this.txtDeleteBookAuthor.Location = new System.Drawing.Point(96, 68);
            this.txtDeleteBookAuthor.Name = "txtDeleteBookAuthor";
            this.txtDeleteBookAuthor.ReadOnly = true;
            this.txtDeleteBookAuthor.Size = new System.Drawing.Size(184, 20);
            this.txtDeleteBookAuthor.TabIndex = 9;
            // 
            // txtDeleteBookDescription
            // 
            this.txtDeleteBookDescription.Location = new System.Drawing.Point(96, 106);
            this.txtDeleteBookDescription.Multiline = true;
            this.txtDeleteBookDescription.Name = "txtDeleteBookDescription";
            this.txtDeleteBookDescription.ReadOnly = true;
            this.txtDeleteBookDescription.Size = new System.Drawing.Size(184, 50);
            this.txtDeleteBookDescription.TabIndex = 10;
            // 
            // txtDeleteBookGenre
            // 
            this.txtDeleteBookGenre.Location = new System.Drawing.Point(96, 174);
            this.txtDeleteBookGenre.Name = "txtDeleteBookGenre";
            this.txtDeleteBookGenre.ReadOnly = true;
            this.txtDeleteBookGenre.Size = new System.Drawing.Size(184, 20);
            this.txtDeleteBookGenre.TabIndex = 11;
            // 
            // txtDeleteBookPublisher
            // 
            this.txtDeleteBookPublisher.Location = new System.Drawing.Point(96, 211);
            this.txtDeleteBookPublisher.Name = "txtDeleteBookPublisher";
            this.txtDeleteBookPublisher.ReadOnly = true;
            this.txtDeleteBookPublisher.Size = new System.Drawing.Size(184, 20);
            this.txtDeleteBookPublisher.TabIndex = 12;
            // 
            // txtDeleteBookPublication
            // 
            this.txtDeleteBookPublication.Location = new System.Drawing.Point(96, 251);
            this.txtDeleteBookPublication.Name = "txtDeleteBookPublication";
            this.txtDeleteBookPublication.ReadOnly = true;
            this.txtDeleteBookPublication.Size = new System.Drawing.Size(184, 20);
            this.txtDeleteBookPublication.TabIndex = 13;
            // 
            // txtDeleteBookStatus
            // 
            this.txtDeleteBookStatus.Location = new System.Drawing.Point(96, 290);
            this.txtDeleteBookStatus.Name = "txtDeleteBookStatus";
            this.txtDeleteBookStatus.ReadOnly = true;
            this.txtDeleteBookStatus.Size = new System.Drawing.Size(184, 20);
            this.txtDeleteBookStatus.TabIndex = 14;
            // 
            // frmDeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 492);
            this.Controls.Add(this.grpDeleteBookDetails);
            this.Controls.Add(this.btnDeleteBookSearch);
            this.Controls.Add(this.txtDeleteBookISBN);
            this.Controls.Add(this.lblDeleteBookISBN);
            this.Controls.Add(this.mnuDeleteBook);
            this.MainMenuStrip = this.mnuDeleteBook;
            this.Name = "frmDeleteBook";
            this.Text = "Books - [Delete Book]";
            this.Load += new System.EventHandler(this.frmDeleteBook_Load);
            this.mnuDeleteBook.ResumeLayout(false);
            this.mnuDeleteBook.PerformLayout();
            this.grpDeleteBookDetails.ResumeLayout(false);
            this.grpDeleteBookDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuDeleteBook;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblDeleteBookISBN;
        private System.Windows.Forms.TextBox txtDeleteBookISBN;
        private System.Windows.Forms.Button btnDeleteBookSearch;
        private System.Windows.Forms.GroupBox grpDeleteBookDetails;
        private System.Windows.Forms.Label lblDeleteBookStatus;
        private System.Windows.Forms.Label lblDeleteBookPublication;
        private System.Windows.Forms.Label lblDeleteBookPublisher;
        private System.Windows.Forms.Label lblDeleteBookGenre;
        private System.Windows.Forms.Label lblDeleteBookDescription;
        private System.Windows.Forms.Label lblDeleteBookAuthor;
        private System.Windows.Forms.Label lblDeleteBookTitle;
        private System.Windows.Forms.Button btnDeleteBookDelete;
        private System.Windows.Forms.TextBox txtDeleteBookStatus;
        private System.Windows.Forms.TextBox txtDeleteBookPublication;
        private System.Windows.Forms.TextBox txtDeleteBookPublisher;
        private System.Windows.Forms.TextBox txtDeleteBookGenre;
        private System.Windows.Forms.TextBox txtDeleteBookDescription;
        private System.Windows.Forms.TextBox txtDeleteBookAuthor;
        private System.Windows.Forms.TextBox txtDeleteBookTitle;
    }
}