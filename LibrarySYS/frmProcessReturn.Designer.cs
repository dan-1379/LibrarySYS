namespace LibrarySYS
{
    partial class frmProcessReturn
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
            this.mnuProcessReturn = new System.Windows.Forms.MenuStrip();
            this.mnuProcessLoanExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpProcessReturn = new System.Windows.Forms.GroupBox();
            this.btnProcessLoanReturnBooks = new System.Windows.Forms.Button();
            this.btnProcessReturnRemove = new System.Windows.Forms.Button();
            this.btnProcessLoanReturnISBN = new System.Windows.Forms.Button();
            this.txtProcessReturnISBN = new System.Windows.Forms.TextBox();
            this.lblProcessReturnISBN = new System.Windows.Forms.Label();
            this.lblProcessReturnCart = new System.Windows.Forms.Label();
            this.clbProcessReturn = new System.Windows.Forms.CheckedListBox();
            this.btnProcessReturnAdd = new System.Windows.Forms.Button();
            this.dtpProcessReturnPublication = new System.Windows.Forms.DateTimePicker();
            this.cboProcessReturnStatus = new System.Windows.Forms.ComboBox();
            this.cboProcessReturnGenre = new System.Windows.Forms.ComboBox();
            this.txtProcessReturnPublisher = new System.Windows.Forms.TextBox();
            this.txtProcessReturnDescription = new System.Windows.Forms.TextBox();
            this.txtProcessReturnAuthor = new System.Windows.Forms.TextBox();
            this.txtProcessReturnTitle = new System.Windows.Forms.TextBox();
            this.lblProcessReturnStatus = new System.Windows.Forms.Label();
            this.lblProcessReturnPublication = new System.Windows.Forms.Label();
            this.lblProcessReturnPublisher = new System.Windows.Forms.Label();
            this.lblProcessReturnGenre = new System.Windows.Forms.Label();
            this.lblProcessReturnDescription = new System.Windows.Forms.Label();
            this.lblProcessReturnAuthor = new System.Windows.Forms.Label();
            this.lblProcessReturnTitle = new System.Windows.Forms.Label();
            this.btnProcessReturnSearchID = new System.Windows.Forms.Button();
            this.txtProcessReturnMemberID = new System.Windows.Forms.TextBox();
            this.lblProcessReturnMemberID = new System.Windows.Forms.Label();
            this.lblProcessReturnCheckout = new System.Windows.Forms.Label();
            this.dtpProcessReturnCheckout = new System.Windows.Forms.DateTimePicker();
            this.mnuProcessReturn.SuspendLayout();
            this.grpProcessReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuProcessReturn
            // 
            this.mnuProcessReturn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProcessLoanExit});
            this.mnuProcessReturn.Location = new System.Drawing.Point(0, 0);
            this.mnuProcessReturn.Name = "mnuProcessReturn";
            this.mnuProcessReturn.Size = new System.Drawing.Size(800, 24);
            this.mnuProcessReturn.TabIndex = 1;
            this.mnuProcessReturn.Text = "mnuProcessLoan";
            // 
            // mnuProcessLoanExit
            // 
            this.mnuProcessLoanExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuProcessLoanExit.Name = "mnuProcessLoanExit";
            this.mnuProcessLoanExit.Size = new System.Drawing.Size(37, 20);
            this.mnuProcessLoanExit.Text = "Exit";
            this.mnuProcessLoanExit.Click += new System.EventHandler(this.mnuProcessLoanExit_Click);
            // 
            // grpProcessReturn
            // 
            this.grpProcessReturn.Controls.Add(this.dtpProcessReturnCheckout);
            this.grpProcessReturn.Controls.Add(this.lblProcessReturnCheckout);
            this.grpProcessReturn.Controls.Add(this.btnProcessLoanReturnBooks);
            this.grpProcessReturn.Controls.Add(this.btnProcessReturnRemove);
            this.grpProcessReturn.Controls.Add(this.btnProcessLoanReturnISBN);
            this.grpProcessReturn.Controls.Add(this.txtProcessReturnISBN);
            this.grpProcessReturn.Controls.Add(this.lblProcessReturnISBN);
            this.grpProcessReturn.Controls.Add(this.lblProcessReturnCart);
            this.grpProcessReturn.Controls.Add(this.clbProcessReturn);
            this.grpProcessReturn.Controls.Add(this.btnProcessReturnAdd);
            this.grpProcessReturn.Controls.Add(this.dtpProcessReturnPublication);
            this.grpProcessReturn.Controls.Add(this.cboProcessReturnStatus);
            this.grpProcessReturn.Controls.Add(this.cboProcessReturnGenre);
            this.grpProcessReturn.Controls.Add(this.txtProcessReturnPublisher);
            this.grpProcessReturn.Controls.Add(this.txtProcessReturnDescription);
            this.grpProcessReturn.Controls.Add(this.txtProcessReturnAuthor);
            this.grpProcessReturn.Controls.Add(this.txtProcessReturnTitle);
            this.grpProcessReturn.Controls.Add(this.lblProcessReturnStatus);
            this.grpProcessReturn.Controls.Add(this.lblProcessReturnPublication);
            this.grpProcessReturn.Controls.Add(this.lblProcessReturnPublisher);
            this.grpProcessReturn.Controls.Add(this.lblProcessReturnGenre);
            this.grpProcessReturn.Controls.Add(this.lblProcessReturnDescription);
            this.grpProcessReturn.Controls.Add(this.lblProcessReturnAuthor);
            this.grpProcessReturn.Controls.Add(this.lblProcessReturnTitle);
            this.grpProcessReturn.Location = new System.Drawing.Point(14, 50);
            this.grpProcessReturn.Name = "grpProcessReturn";
            this.grpProcessReturn.Size = new System.Drawing.Size(773, 460);
            this.grpProcessReturn.TabIndex = 5;
            this.grpProcessReturn.TabStop = false;
            this.grpProcessReturn.Text = "Process Loan";
            this.grpProcessReturn.Enter += new System.EventHandler(this.grpProcessReturn_Enter);
            // 
            // btnProcessLoanReturnBooks
            // 
            this.btnProcessLoanReturnBooks.Location = new System.Drawing.Point(574, 362);
            this.btnProcessLoanReturnBooks.Name = "btnProcessLoanReturnBooks";
            this.btnProcessLoanReturnBooks.Size = new System.Drawing.Size(181, 37);
            this.btnProcessLoanReturnBooks.TabIndex = 21;
            this.btnProcessLoanReturnBooks.Text = "Return Books";
            this.btnProcessLoanReturnBooks.UseVisualStyleBackColor = true;
            this.btnProcessLoanReturnBooks.Click += new System.EventHandler(this.btnProcessLoanReturnBooks_Click);
            // 
            // btnProcessReturnRemove
            // 
            this.btnProcessReturnRemove.Location = new System.Drawing.Point(495, 362);
            this.btnProcessReturnRemove.Name = "btnProcessReturnRemove";
            this.btnProcessReturnRemove.Size = new System.Drawing.Size(73, 37);
            this.btnProcessReturnRemove.TabIndex = 20;
            this.btnProcessReturnRemove.Text = "Remove";
            this.btnProcessReturnRemove.UseVisualStyleBackColor = true;
            this.btnProcessReturnRemove.Click += new System.EventHandler(this.btnProcessReturnRemove_Click);
            // 
            // btnProcessLoanReturnISBN
            // 
            this.btnProcessLoanReturnISBN.Location = new System.Drawing.Point(210, 31);
            this.btnProcessLoanReturnISBN.Name = "btnProcessLoanReturnISBN";
            this.btnProcessLoanReturnISBN.Size = new System.Drawing.Size(75, 23);
            this.btnProcessLoanReturnISBN.TabIndex = 19;
            this.btnProcessLoanReturnISBN.Text = "Search";
            this.btnProcessLoanReturnISBN.UseVisualStyleBackColor = true;
            this.btnProcessLoanReturnISBN.Click += new System.EventHandler(this.btnProcessLoanReturnISBN_Click);
            // 
            // txtProcessReturnISBN
            // 
            this.txtProcessReturnISBN.Location = new System.Drawing.Point(65, 34);
            this.txtProcessReturnISBN.Name = "txtProcessReturnISBN";
            this.txtProcessReturnISBN.Size = new System.Drawing.Size(129, 20);
            this.txtProcessReturnISBN.TabIndex = 18;
            // 
            // lblProcessReturnISBN
            // 
            this.lblProcessReturnISBN.AutoSize = true;
            this.lblProcessReturnISBN.Location = new System.Drawing.Point(14, 35);
            this.lblProcessReturnISBN.Name = "lblProcessReturnISBN";
            this.lblProcessReturnISBN.Size = new System.Drawing.Size(35, 13);
            this.lblProcessReturnISBN.TabIndex = 17;
            this.lblProcessReturnISBN.Text = "ISBN:";
            // 
            // lblProcessReturnCart
            // 
            this.lblProcessReturnCart.AutoSize = true;
            this.lblProcessReturnCart.Location = new System.Drawing.Point(492, 31);
            this.lblProcessReturnCart.Name = "lblProcessReturnCart";
            this.lblProcessReturnCart.Size = new System.Drawing.Size(63, 13);
            this.lblProcessReturnCart.TabIndex = 16;
            this.lblProcessReturnCart.Text = "Current Cart";
            // 
            // clbProcessReturn
            // 
            this.clbProcessReturn.FormattingEnabled = true;
            this.clbProcessReturn.Location = new System.Drawing.Point(495, 51);
            this.clbProcessReturn.Name = "clbProcessReturn";
            this.clbProcessReturn.Size = new System.Drawing.Size(260, 289);
            this.clbProcessReturn.TabIndex = 15;
            // 
            // btnProcessReturnAdd
            // 
            this.btnProcessReturnAdd.Location = new System.Drawing.Point(96, 409);
            this.btnProcessReturnAdd.Name = "btnProcessReturnAdd";
            this.btnProcessReturnAdd.Size = new System.Drawing.Size(200, 37);
            this.btnProcessReturnAdd.TabIndex = 14;
            this.btnProcessReturnAdd.Text = "Add to Return";
            this.btnProcessReturnAdd.UseVisualStyleBackColor = true;
            this.btnProcessReturnAdd.Click += new System.EventHandler(this.btnProcessReturnAdd_Click);
            // 
            // dtpProcessReturnPublication
            // 
            this.dtpProcessReturnPublication.Enabled = false;
            this.dtpProcessReturnPublication.Location = new System.Drawing.Point(96, 287);
            this.dtpProcessReturnPublication.Name = "dtpProcessReturnPublication";
            this.dtpProcessReturnPublication.Size = new System.Drawing.Size(200, 20);
            this.dtpProcessReturnPublication.TabIndex = 13;
            // 
            // cboProcessReturnStatus
            // 
            this.cboProcessReturnStatus.Enabled = false;
            this.cboProcessReturnStatus.FormattingEnabled = true;
            this.cboProcessReturnStatus.Location = new System.Drawing.Point(96, 317);
            this.cboProcessReturnStatus.Name = "cboProcessReturnStatus";
            this.cboProcessReturnStatus.Size = new System.Drawing.Size(200, 21);
            this.cboProcessReturnStatus.TabIndex = 12;
            // 
            // cboProcessReturnGenre
            // 
            this.cboProcessReturnGenre.Enabled = false;
            this.cboProcessReturnGenre.FormattingEnabled = true;
            this.cboProcessReturnGenre.Location = new System.Drawing.Point(96, 210);
            this.cboProcessReturnGenre.Name = "cboProcessReturnGenre";
            this.cboProcessReturnGenre.Size = new System.Drawing.Size(200, 21);
            this.cboProcessReturnGenre.TabIndex = 11;
            // 
            // txtProcessReturnPublisher
            // 
            this.txtProcessReturnPublisher.Enabled = false;
            this.txtProcessReturnPublisher.Location = new System.Drawing.Point(96, 248);
            this.txtProcessReturnPublisher.Name = "txtProcessReturnPublisher";
            this.txtProcessReturnPublisher.Size = new System.Drawing.Size(200, 20);
            this.txtProcessReturnPublisher.TabIndex = 10;
            // 
            // txtProcessReturnDescription
            // 
            this.txtProcessReturnDescription.Enabled = false;
            this.txtProcessReturnDescription.Location = new System.Drawing.Point(96, 176);
            this.txtProcessReturnDescription.Name = "txtProcessReturnDescription";
            this.txtProcessReturnDescription.Size = new System.Drawing.Size(200, 20);
            this.txtProcessReturnDescription.TabIndex = 9;
            // 
            // txtProcessReturnAuthor
            // 
            this.txtProcessReturnAuthor.Enabled = false;
            this.txtProcessReturnAuthor.Location = new System.Drawing.Point(96, 136);
            this.txtProcessReturnAuthor.Name = "txtProcessReturnAuthor";
            this.txtProcessReturnAuthor.Size = new System.Drawing.Size(200, 20);
            this.txtProcessReturnAuthor.TabIndex = 8;
            // 
            // txtProcessReturnTitle
            // 
            this.txtProcessReturnTitle.Enabled = false;
            this.txtProcessReturnTitle.Location = new System.Drawing.Point(96, 100);
            this.txtProcessReturnTitle.Name = "txtProcessReturnTitle";
            this.txtProcessReturnTitle.Size = new System.Drawing.Size(200, 20);
            this.txtProcessReturnTitle.TabIndex = 7;
            // 
            // lblProcessReturnStatus
            // 
            this.lblProcessReturnStatus.AutoSize = true;
            this.lblProcessReturnStatus.Location = new System.Drawing.Point(11, 325);
            this.lblProcessReturnStatus.Name = "lblProcessReturnStatus";
            this.lblProcessReturnStatus.Size = new System.Drawing.Size(40, 13);
            this.lblProcessReturnStatus.TabIndex = 6;
            this.lblProcessReturnStatus.Text = "Status:";
            // 
            // lblProcessReturnPublication
            // 
            this.lblProcessReturnPublication.AutoSize = true;
            this.lblProcessReturnPublication.Location = new System.Drawing.Point(11, 287);
            this.lblProcessReturnPublication.Name = "lblProcessReturnPublication";
            this.lblProcessReturnPublication.Size = new System.Drawing.Size(62, 13);
            this.lblProcessReturnPublication.TabIndex = 5;
            this.lblProcessReturnPublication.Text = "Publication:";
            // 
            // lblProcessReturnPublisher
            // 
            this.lblProcessReturnPublisher.AutoSize = true;
            this.lblProcessReturnPublisher.Location = new System.Drawing.Point(11, 248);
            this.lblProcessReturnPublisher.Name = "lblProcessReturnPublisher";
            this.lblProcessReturnPublisher.Size = new System.Drawing.Size(53, 13);
            this.lblProcessReturnPublisher.TabIndex = 4;
            this.lblProcessReturnPublisher.Text = "Publisher:";
            // 
            // lblProcessReturnGenre
            // 
            this.lblProcessReturnGenre.AutoSize = true;
            this.lblProcessReturnGenre.Location = new System.Drawing.Point(11, 213);
            this.lblProcessReturnGenre.Name = "lblProcessReturnGenre";
            this.lblProcessReturnGenre.Size = new System.Drawing.Size(39, 13);
            this.lblProcessReturnGenre.TabIndex = 3;
            this.lblProcessReturnGenre.Text = "Genre:";
            // 
            // lblProcessReturnDescription
            // 
            this.lblProcessReturnDescription.AutoSize = true;
            this.lblProcessReturnDescription.Location = new System.Drawing.Point(11, 176);
            this.lblProcessReturnDescription.Name = "lblProcessReturnDescription";
            this.lblProcessReturnDescription.Size = new System.Drawing.Size(63, 13);
            this.lblProcessReturnDescription.TabIndex = 2;
            this.lblProcessReturnDescription.Text = "Description:";
            // 
            // lblProcessReturnAuthor
            // 
            this.lblProcessReturnAuthor.AutoSize = true;
            this.lblProcessReturnAuthor.Location = new System.Drawing.Point(11, 136);
            this.lblProcessReturnAuthor.Name = "lblProcessReturnAuthor";
            this.lblProcessReturnAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblProcessReturnAuthor.TabIndex = 1;
            this.lblProcessReturnAuthor.Text = "Author:";
            // 
            // lblProcessReturnTitle
            // 
            this.lblProcessReturnTitle.AutoSize = true;
            this.lblProcessReturnTitle.Location = new System.Drawing.Point(11, 100);
            this.lblProcessReturnTitle.Name = "lblProcessReturnTitle";
            this.lblProcessReturnTitle.Size = new System.Drawing.Size(30, 13);
            this.lblProcessReturnTitle.TabIndex = 0;
            this.lblProcessReturnTitle.Text = "Title:";
            // 
            // btnProcessReturnSearchID
            // 
            this.btnProcessReturnSearchID.Location = new System.Drawing.Point(229, 19);
            this.btnProcessReturnSearchID.Name = "btnProcessReturnSearchID";
            this.btnProcessReturnSearchID.Size = new System.Drawing.Size(75, 23);
            this.btnProcessReturnSearchID.TabIndex = 24;
            this.btnProcessReturnSearchID.Text = "Search";
            this.btnProcessReturnSearchID.UseVisualStyleBackColor = true;
            this.btnProcessReturnSearchID.Click += new System.EventHandler(this.btnProcessReturnSearchID_Click);
            // 
            // txtProcessReturnMemberID
            // 
            this.txtProcessReturnMemberID.Location = new System.Drawing.Point(84, 21);
            this.txtProcessReturnMemberID.Name = "txtProcessReturnMemberID";
            this.txtProcessReturnMemberID.Size = new System.Drawing.Size(129, 20);
            this.txtProcessReturnMemberID.TabIndex = 23;
            this.txtProcessReturnMemberID.TextChanged += new System.EventHandler(this.txtProcessReturnMemberID_TextChanged);
            // 
            // lblProcessReturnMemberID
            // 
            this.lblProcessReturnMemberID.AutoSize = true;
            this.lblProcessReturnMemberID.Location = new System.Drawing.Point(16, 24);
            this.lblProcessReturnMemberID.Name = "lblProcessReturnMemberID";
            this.lblProcessReturnMemberID.Size = new System.Drawing.Size(62, 13);
            this.lblProcessReturnMemberID.TabIndex = 22;
            this.lblProcessReturnMemberID.Text = "Member ID:";
            // 
            // lblProcessReturnCheckout
            // 
            this.lblProcessReturnCheckout.AutoSize = true;
            this.lblProcessReturnCheckout.Location = new System.Drawing.Point(11, 362);
            this.lblProcessReturnCheckout.Name = "lblProcessReturnCheckout";
            this.lblProcessReturnCheckout.Size = new System.Drawing.Size(82, 13);
            this.lblProcessReturnCheckout.TabIndex = 22;
            this.lblProcessReturnCheckout.Text = "Checkout Date:";
            // 
            // dtpProcessReturnCheckout
            // 
            this.dtpProcessReturnCheckout.Enabled = false;
            this.dtpProcessReturnCheckout.Location = new System.Drawing.Point(96, 356);
            this.dtpProcessReturnCheckout.Name = "dtpProcessReturnCheckout";
            this.dtpProcessReturnCheckout.Size = new System.Drawing.Size(200, 20);
            this.dtpProcessReturnCheckout.TabIndex = 23;
            // 
            // frmProcessReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.btnProcessReturnSearchID);
            this.Controls.Add(this.grpProcessReturn);
            this.Controls.Add(this.txtProcessReturnMemberID);
            this.Controls.Add(this.mnuProcessReturn);
            this.Controls.Add(this.lblProcessReturnMemberID);
            this.Name = "frmProcessReturn";
            this.Text = "Loans - [Process Return]";
            this.Load += new System.EventHandler(this.frmProcessReturn_Load);
            this.mnuProcessReturn.ResumeLayout(false);
            this.mnuProcessReturn.PerformLayout();
            this.grpProcessReturn.ResumeLayout(false);
            this.grpProcessReturn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuProcessReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuProcessLoanExit;
        private System.Windows.Forms.GroupBox grpProcessReturn;
        private System.Windows.Forms.Button btnProcessLoanReturnBooks;
        private System.Windows.Forms.Button btnProcessReturnRemove;
        private System.Windows.Forms.Button btnProcessLoanReturnISBN;
        private System.Windows.Forms.TextBox txtProcessReturnISBN;
        private System.Windows.Forms.Label lblProcessReturnISBN;
        private System.Windows.Forms.Label lblProcessReturnCart;
        private System.Windows.Forms.CheckedListBox clbProcessReturn;
        private System.Windows.Forms.Button btnProcessReturnAdd;
        private System.Windows.Forms.DateTimePicker dtpProcessReturnPublication;
        private System.Windows.Forms.ComboBox cboProcessReturnStatus;
        private System.Windows.Forms.ComboBox cboProcessReturnGenre;
        private System.Windows.Forms.TextBox txtProcessReturnPublisher;
        private System.Windows.Forms.TextBox txtProcessReturnDescription;
        private System.Windows.Forms.TextBox txtProcessReturnAuthor;
        private System.Windows.Forms.TextBox txtProcessReturnTitle;
        private System.Windows.Forms.Label lblProcessReturnStatus;
        private System.Windows.Forms.Label lblProcessReturnPublication;
        private System.Windows.Forms.Label lblProcessReturnPublisher;
        private System.Windows.Forms.Label lblProcessReturnGenre;
        private System.Windows.Forms.Label lblProcessReturnDescription;
        private System.Windows.Forms.Label lblProcessReturnAuthor;
        private System.Windows.Forms.Label lblProcessReturnTitle;
        private System.Windows.Forms.Button btnProcessReturnSearchID;
        private System.Windows.Forms.TextBox txtProcessReturnMemberID;
        private System.Windows.Forms.Label lblProcessReturnMemberID;
        private System.Windows.Forms.DateTimePicker dtpProcessReturnCheckout;
        private System.Windows.Forms.Label lblProcessReturnCheckout;
    }
}