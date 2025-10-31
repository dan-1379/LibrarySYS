namespace LibrarySYS
{
    partial class frmUpdateBook
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
            this.mnuUpdateBook = new System.Windows.Forms.MenuStrip();
            this.mnuUpdateBookExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUpdateBookISBN = new System.Windows.Forms.Label();
            this.txtUpdateBookISBN = new System.Windows.Forms.TextBox();
            this.btnUpdateBookSearch = new System.Windows.Forms.Button();
            this.grpUpdateBook = new System.Windows.Forms.GroupBox();
            this.txtUpdateBookPublisher = new System.Windows.Forms.TextBox();
            this.cboUpdateBookGenre = new System.Windows.Forms.ComboBox();
            this.txtUpdateBookDescription = new System.Windows.Forms.TextBox();
            this.txtUpdateBookAuthor = new System.Windows.Forms.TextBox();
            this.txtUpdateBookTitle = new System.Windows.Forms.TextBox();
            this.btnUpdateBookUpdate = new System.Windows.Forms.Button();
            this.lblUpdateBookPublication = new System.Windows.Forms.Label();
            this.lblUpdateBookPublisher = new System.Windows.Forms.Label();
            this.lblUpdateBookGenre = new System.Windows.Forms.Label();
            this.lblUpdateBookDescription = new System.Windows.Forms.Label();
            this.lblUpdateBookAuthor = new System.Windows.Forms.Label();
            this.lblUpdateBookTitle = new System.Windows.Forms.Label();
            this.dtpUpdateBookPublication = new System.Windows.Forms.DateTimePicker();
            this.mnuUpdateBook.SuspendLayout();
            this.grpUpdateBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateBook
            // 
            this.mnuUpdateBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateBookExit});
            this.mnuUpdateBook.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateBook.Name = "mnuUpdateBook";
            this.mnuUpdateBook.Size = new System.Drawing.Size(345, 24);
            this.mnuUpdateBook.TabIndex = 0;
            this.mnuUpdateBook.Text = "menuStrip1";
            // 
            // mnuUpdateBookExit
            // 
            this.mnuUpdateBookExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuUpdateBookExit.Name = "mnuUpdateBookExit";
            this.mnuUpdateBookExit.Size = new System.Drawing.Size(37, 20);
            this.mnuUpdateBookExit.Text = "Exit";
            this.mnuUpdateBookExit.Click += new System.EventHandler(this.mnuUpdateBookExit_Click);
            // 
            // lblUpdateBookISBN
            // 
            this.lblUpdateBookISBN.AutoSize = true;
            this.lblUpdateBookISBN.Location = new System.Drawing.Point(12, 32);
            this.lblUpdateBookISBN.Name = "lblUpdateBookISBN";
            this.lblUpdateBookISBN.Size = new System.Drawing.Size(63, 13);
            this.lblUpdateBookISBN.TabIndex = 1;
            this.lblUpdateBookISBN.Text = "Enter ISBN:";
            // 
            // txtUpdateBookISBN
            // 
            this.txtUpdateBookISBN.Location = new System.Drawing.Point(83, 28);
            this.txtUpdateBookISBN.Name = "txtUpdateBookISBN";
            this.txtUpdateBookISBN.Size = new System.Drawing.Size(131, 20);
            this.txtUpdateBookISBN.TabIndex = 2;
            // 
            // btnUpdateBookSearch
            // 
            this.btnUpdateBookSearch.Location = new System.Drawing.Point(233, 27);
            this.btnUpdateBookSearch.Name = "btnUpdateBookSearch";
            this.btnUpdateBookSearch.Size = new System.Drawing.Size(88, 20);
            this.btnUpdateBookSearch.TabIndex = 3;
            this.btnUpdateBookSearch.Text = "Search";
            this.btnUpdateBookSearch.UseVisualStyleBackColor = true;
            this.btnUpdateBookSearch.Click += new System.EventHandler(this.btnUpdateBookSearch_Click);
            // 
            // grpUpdateBook
            // 
            this.grpUpdateBook.Controls.Add(this.dtpUpdateBookPublication);
            this.grpUpdateBook.Controls.Add(this.txtUpdateBookPublisher);
            this.grpUpdateBook.Controls.Add(this.cboUpdateBookGenre);
            this.grpUpdateBook.Controls.Add(this.txtUpdateBookDescription);
            this.grpUpdateBook.Controls.Add(this.txtUpdateBookAuthor);
            this.grpUpdateBook.Controls.Add(this.txtUpdateBookTitle);
            this.grpUpdateBook.Controls.Add(this.btnUpdateBookUpdate);
            this.grpUpdateBook.Controls.Add(this.lblUpdateBookPublication);
            this.grpUpdateBook.Controls.Add(this.lblUpdateBookPublisher);
            this.grpUpdateBook.Controls.Add(this.lblUpdateBookGenre);
            this.grpUpdateBook.Controls.Add(this.lblUpdateBookDescription);
            this.grpUpdateBook.Controls.Add(this.lblUpdateBookAuthor);
            this.grpUpdateBook.Controls.Add(this.lblUpdateBookTitle);
            this.grpUpdateBook.Location = new System.Drawing.Point(15, 73);
            this.grpUpdateBook.Name = "grpUpdateBook";
            this.grpUpdateBook.Size = new System.Drawing.Size(306, 376);
            this.grpUpdateBook.TabIndex = 4;
            this.grpUpdateBook.TabStop = false;
            this.grpUpdateBook.Text = "Update Book";
            // 
            // txtUpdateBookPublisher
            // 
            this.txtUpdateBookPublisher.Location = new System.Drawing.Point(78, 232);
            this.txtUpdateBookPublisher.Name = "txtUpdateBookPublisher";
            this.txtUpdateBookPublisher.Size = new System.Drawing.Size(201, 20);
            this.txtUpdateBookPublisher.TabIndex = 11;
            // 
            // cboUpdateBookGenre
            // 
            this.cboUpdateBookGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateBookGenre.FormattingEnabled = true;
            this.cboUpdateBookGenre.Items.AddRange(new object[] {
            "Young Adult",
            "Fantasy",
            "Horror",
            "Mystery",
            "Thriller",
            "Romance",
            "Science Fiction",
            "Action",
            "Historical"});
            this.cboUpdateBookGenre.Location = new System.Drawing.Point(78, 195);
            this.cboUpdateBookGenre.Name = "cboUpdateBookGenre";
            this.cboUpdateBookGenre.Size = new System.Drawing.Size(201, 21);
            this.cboUpdateBookGenre.TabIndex = 10;
            // 
            // txtUpdateBookDescription
            // 
            this.txtUpdateBookDescription.Location = new System.Drawing.Point(78, 105);
            this.txtUpdateBookDescription.Multiline = true;
            this.txtUpdateBookDescription.Name = "txtUpdateBookDescription";
            this.txtUpdateBookDescription.Size = new System.Drawing.Size(201, 68);
            this.txtUpdateBookDescription.TabIndex = 9;
            // 
            // txtUpdateBookAuthor
            // 
            this.txtUpdateBookAuthor.Location = new System.Drawing.Point(78, 67);
            this.txtUpdateBookAuthor.Name = "txtUpdateBookAuthor";
            this.txtUpdateBookAuthor.Size = new System.Drawing.Size(201, 20);
            this.txtUpdateBookAuthor.TabIndex = 8;
            // 
            // txtUpdateBookTitle
            // 
            this.txtUpdateBookTitle.Location = new System.Drawing.Point(78, 34);
            this.txtUpdateBookTitle.Name = "txtUpdateBookTitle";
            this.txtUpdateBookTitle.Size = new System.Drawing.Size(201, 20);
            this.txtUpdateBookTitle.TabIndex = 7;
            // 
            // btnUpdateBookUpdate
            // 
            this.btnUpdateBookUpdate.Location = new System.Drawing.Point(10, 321);
            this.btnUpdateBookUpdate.Name = "btnUpdateBookUpdate";
            this.btnUpdateBookUpdate.Size = new System.Drawing.Size(269, 33);
            this.btnUpdateBookUpdate.TabIndex = 6;
            this.btnUpdateBookUpdate.Text = "Update Book";
            this.btnUpdateBookUpdate.UseVisualStyleBackColor = true;
            this.btnUpdateBookUpdate.Click += new System.EventHandler(this.btnUpdateBookUpdate_Click);
            // 
            // lblUpdateBookPublication
            // 
            this.lblUpdateBookPublication.AutoSize = true;
            this.lblUpdateBookPublication.Location = new System.Drawing.Point(10, 276);
            this.lblUpdateBookPublication.Name = "lblUpdateBookPublication";
            this.lblUpdateBookPublication.Size = new System.Drawing.Size(62, 13);
            this.lblUpdateBookPublication.TabIndex = 5;
            this.lblUpdateBookPublication.Text = "Publication:";
            // 
            // lblUpdateBookPublisher
            // 
            this.lblUpdateBookPublisher.AutoSize = true;
            this.lblUpdateBookPublisher.Location = new System.Drawing.Point(10, 235);
            this.lblUpdateBookPublisher.Name = "lblUpdateBookPublisher";
            this.lblUpdateBookPublisher.Size = new System.Drawing.Size(53, 13);
            this.lblUpdateBookPublisher.TabIndex = 4;
            this.lblUpdateBookPublisher.Text = "Publisher:";
            // 
            // lblUpdateBookGenre
            // 
            this.lblUpdateBookGenre.AutoSize = true;
            this.lblUpdateBookGenre.Location = new System.Drawing.Point(10, 198);
            this.lblUpdateBookGenre.Name = "lblUpdateBookGenre";
            this.lblUpdateBookGenre.Size = new System.Drawing.Size(39, 13);
            this.lblUpdateBookGenre.TabIndex = 3;
            this.lblUpdateBookGenre.Text = "Genre:";
            // 
            // lblUpdateBookDescription
            // 
            this.lblUpdateBookDescription.AutoSize = true;
            this.lblUpdateBookDescription.Location = new System.Drawing.Point(6, 108);
            this.lblUpdateBookDescription.Name = "lblUpdateBookDescription";
            this.lblUpdateBookDescription.Size = new System.Drawing.Size(63, 13);
            this.lblUpdateBookDescription.TabIndex = 2;
            this.lblUpdateBookDescription.Text = "Description:";
            // 
            // lblUpdateBookAuthor
            // 
            this.lblUpdateBookAuthor.AutoSize = true;
            this.lblUpdateBookAuthor.Location = new System.Drawing.Point(7, 70);
            this.lblUpdateBookAuthor.Name = "lblUpdateBookAuthor";
            this.lblUpdateBookAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblUpdateBookAuthor.TabIndex = 1;
            this.lblUpdateBookAuthor.Text = "Author:";
            // 
            // lblUpdateBookTitle
            // 
            this.lblUpdateBookTitle.AutoSize = true;
            this.lblUpdateBookTitle.Location = new System.Drawing.Point(7, 34);
            this.lblUpdateBookTitle.Name = "lblUpdateBookTitle";
            this.lblUpdateBookTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUpdateBookTitle.Size = new System.Drawing.Size(30, 13);
            this.lblUpdateBookTitle.TabIndex = 0;
            this.lblUpdateBookTitle.Text = "Title:";
            // 
            // dtpUpdateBookPublication
            // 
            this.dtpUpdateBookPublication.Location = new System.Drawing.Point(79, 270);
            this.dtpUpdateBookPublication.Name = "dtpUpdateBookPublication";
            this.dtpUpdateBookPublication.Size = new System.Drawing.Size(200, 20);
            this.dtpUpdateBookPublication.TabIndex = 12;
            // 
            // frmUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 468);
            this.Controls.Add(this.grpUpdateBook);
            this.Controls.Add(this.btnUpdateBookSearch);
            this.Controls.Add(this.txtUpdateBookISBN);
            this.Controls.Add(this.lblUpdateBookISBN);
            this.Controls.Add(this.mnuUpdateBook);
            this.MainMenuStrip = this.mnuUpdateBook;
            this.Name = "frmUpdateBook";
            this.Text = "Books - [Update Book]";
            this.Load += new System.EventHandler(this.frmUpdateBook_Load);
            this.mnuUpdateBook.ResumeLayout(false);
            this.mnuUpdateBook.PerformLayout();
            this.grpUpdateBook.ResumeLayout(false);
            this.grpUpdateBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateBookExit;
        private System.Windows.Forms.Label lblUpdateBookISBN;
        private System.Windows.Forms.TextBox txtUpdateBookISBN;
        private System.Windows.Forms.Button btnUpdateBookSearch;
        private System.Windows.Forms.GroupBox grpUpdateBook;
        private System.Windows.Forms.Label lblUpdateBookGenre;
        private System.Windows.Forms.Label lblUpdateBookDescription;
        private System.Windows.Forms.Label lblUpdateBookAuthor;
        private System.Windows.Forms.Label lblUpdateBookTitle;
        private System.Windows.Forms.Button btnUpdateBookUpdate;
        private System.Windows.Forms.Label lblUpdateBookPublication;
        private System.Windows.Forms.Label lblUpdateBookPublisher;
        private System.Windows.Forms.TextBox txtUpdateBookPublisher;
        private System.Windows.Forms.ComboBox cboUpdateBookGenre;
        private System.Windows.Forms.TextBox txtUpdateBookDescription;
        private System.Windows.Forms.TextBox txtUpdateBookAuthor;
        private System.Windows.Forms.TextBox txtUpdateBookTitle;
        private System.Windows.Forms.DateTimePicker dtpUpdateBookPublication;
    }
}