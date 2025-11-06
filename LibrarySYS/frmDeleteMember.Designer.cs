namespace LibrarySYS
{
    partial class frmDeleteMember
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
            this.mnuDeleteMember = new System.Windows.Forms.MenuStrip();
            this.mnuDeleteMemberExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDeleteMemberID = new System.Windows.Forms.Label();
            this.txtDeleteMemberID = new System.Windows.Forms.TextBox();
            this.btnDeleteMemberSearch = new System.Windows.Forms.Button();
            this.grpDeleteMember = new System.Windows.Forms.GroupBox();
            this.lblDeleteMemberFName = new System.Windows.Forms.Label();
            this.lblDeleteMemberLName = new System.Windows.Forms.Label();
            this.lblDeleteMemberDOB = new System.Windows.Forms.Label();
            this.lblDeleteMemberPhone = new System.Windows.Forms.Label();
            this.lblDeleteMemberEmail = new System.Windows.Forms.Label();
            this.lblDeleteMemberAddress1 = new System.Windows.Forms.Label();
            this.lblDeleteMemberAddress2 = new System.Windows.Forms.Label();
            this.lblDeleteMemberCounty = new System.Windows.Forms.Label();
            this.lblDeleteMemberEircode = new System.Windows.Forms.Label();
            this.lblDeleteMemberRegDate = new System.Windows.Forms.Label();
            this.btnDeleteMemberDelete = new System.Windows.Forms.Button();
            this.txtDeleteMemberFName = new System.Windows.Forms.TextBox();
            this.txtDeleteMemberLName = new System.Windows.Forms.TextBox();
            this.txtDeleteMemberDOB = new System.Windows.Forms.TextBox();
            this.txtDeleteMemberPhone = new System.Windows.Forms.TextBox();
            this.txtDeleteMemberEmail = new System.Windows.Forms.TextBox();
            this.txtDeleteMemberAddress1 = new System.Windows.Forms.TextBox();
            this.txtDeleteMemberAddress2 = new System.Windows.Forms.TextBox();
            this.txtDeleteMemberCounty = new System.Windows.Forms.TextBox();
            this.txtDeleteMemberEircode = new System.Windows.Forms.TextBox();
            this.txtDeleteMemberRegDate = new System.Windows.Forms.TextBox();
            this.lblDeleteMemberFines = new System.Windows.Forms.Label();
            this.txtDeleteMemberFines = new System.Windows.Forms.TextBox();
            this.lblDeleteMemberLoans = new System.Windows.Forms.Label();
            this.txtDeleteMemberLoans = new System.Windows.Forms.TextBox();
            this.mnuDeleteMember.SuspendLayout();
            this.grpDeleteMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuDeleteMember
            // 
            this.mnuDeleteMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeleteMemberExit});
            this.mnuDeleteMember.Location = new System.Drawing.Point(0, 0);
            this.mnuDeleteMember.Name = "mnuDeleteMember";
            this.mnuDeleteMember.Size = new System.Drawing.Size(406, 24);
            this.mnuDeleteMember.TabIndex = 0;
            this.mnuDeleteMember.Text = "menuStrip1";
            // 
            // mnuDeleteMemberExit
            // 
            this.mnuDeleteMemberExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuDeleteMemberExit.Name = "mnuDeleteMemberExit";
            this.mnuDeleteMemberExit.Size = new System.Drawing.Size(37, 20);
            this.mnuDeleteMemberExit.Text = "Exit";
            this.mnuDeleteMemberExit.Click += new System.EventHandler(this.mnuDeleteMemberExit_Click);
            // 
            // lblDeleteMemberID
            // 
            this.lblDeleteMemberID.AutoSize = true;
            this.lblDeleteMemberID.Location = new System.Drawing.Point(12, 36);
            this.lblDeleteMemberID.Name = "lblDeleteMemberID";
            this.lblDeleteMemberID.Size = new System.Drawing.Size(90, 13);
            this.lblDeleteMemberID.TabIndex = 1;
            this.lblDeleteMemberID.Text = "Enter Member ID:";
            // 
            // txtDeleteMemberID
            // 
            this.txtDeleteMemberID.Location = new System.Drawing.Point(108, 33);
            this.txtDeleteMemberID.Name = "txtDeleteMemberID";
            this.txtDeleteMemberID.Size = new System.Drawing.Size(148, 20);
            this.txtDeleteMemberID.TabIndex = 2;
            // 
            // btnDeleteMemberSearch
            // 
            this.btnDeleteMemberSearch.Location = new System.Drawing.Point(280, 31);
            this.btnDeleteMemberSearch.Name = "btnDeleteMemberSearch";
            this.btnDeleteMemberSearch.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteMemberSearch.TabIndex = 3;
            this.btnDeleteMemberSearch.Text = "Search";
            this.btnDeleteMemberSearch.UseVisualStyleBackColor = true;
            this.btnDeleteMemberSearch.Click += new System.EventHandler(this.btnDeleteMemberSearch_Click);
            // 
            // grpDeleteMember
            // 
            this.grpDeleteMember.Controls.Add(this.txtDeleteMemberLoans);
            this.grpDeleteMember.Controls.Add(this.lblDeleteMemberLoans);
            this.grpDeleteMember.Controls.Add(this.txtDeleteMemberFines);
            this.grpDeleteMember.Controls.Add(this.lblDeleteMemberFines);
            this.grpDeleteMember.Controls.Add(this.txtDeleteMemberRegDate);
            this.grpDeleteMember.Controls.Add(this.txtDeleteMemberEircode);
            this.grpDeleteMember.Controls.Add(this.txtDeleteMemberCounty);
            this.grpDeleteMember.Controls.Add(this.txtDeleteMemberAddress2);
            this.grpDeleteMember.Controls.Add(this.txtDeleteMemberAddress1);
            this.grpDeleteMember.Controls.Add(this.txtDeleteMemberEmail);
            this.grpDeleteMember.Controls.Add(this.txtDeleteMemberPhone);
            this.grpDeleteMember.Controls.Add(this.txtDeleteMemberDOB);
            this.grpDeleteMember.Controls.Add(this.txtDeleteMemberLName);
            this.grpDeleteMember.Controls.Add(this.txtDeleteMemberFName);
            this.grpDeleteMember.Controls.Add(this.btnDeleteMemberDelete);
            this.grpDeleteMember.Controls.Add(this.lblDeleteMemberRegDate);
            this.grpDeleteMember.Controls.Add(this.lblDeleteMemberEircode);
            this.grpDeleteMember.Controls.Add(this.lblDeleteMemberCounty);
            this.grpDeleteMember.Controls.Add(this.lblDeleteMemberAddress2);
            this.grpDeleteMember.Controls.Add(this.lblDeleteMemberAddress1);
            this.grpDeleteMember.Controls.Add(this.lblDeleteMemberEmail);
            this.grpDeleteMember.Controls.Add(this.lblDeleteMemberPhone);
            this.grpDeleteMember.Controls.Add(this.lblDeleteMemberDOB);
            this.grpDeleteMember.Controls.Add(this.lblDeleteMemberLName);
            this.grpDeleteMember.Controls.Add(this.lblDeleteMemberFName);
            this.grpDeleteMember.Location = new System.Drawing.Point(15, 72);
            this.grpDeleteMember.Name = "grpDeleteMember";
            this.grpDeleteMember.Size = new System.Drawing.Size(358, 585);
            this.grpDeleteMember.TabIndex = 4;
            this.grpDeleteMember.TabStop = false;
            this.grpDeleteMember.Text = "Member Details";
            // 
            // lblDeleteMemberFName
            // 
            this.lblDeleteMemberFName.AutoSize = true;
            this.lblDeleteMemberFName.Location = new System.Drawing.Point(13, 37);
            this.lblDeleteMemberFName.Name = "lblDeleteMemberFName";
            this.lblDeleteMemberFName.Size = new System.Drawing.Size(60, 13);
            this.lblDeleteMemberFName.TabIndex = 0;
            this.lblDeleteMemberFName.Text = "First Name:";
            // 
            // lblDeleteMemberLName
            // 
            this.lblDeleteMemberLName.AutoSize = true;
            this.lblDeleteMemberLName.Location = new System.Drawing.Point(13, 69);
            this.lblDeleteMemberLName.Name = "lblDeleteMemberLName";
            this.lblDeleteMemberLName.Size = new System.Drawing.Size(61, 13);
            this.lblDeleteMemberLName.TabIndex = 1;
            this.lblDeleteMemberLName.Text = "Last Name:";
            // 
            // lblDeleteMemberDOB
            // 
            this.lblDeleteMemberDOB.AutoSize = true;
            this.lblDeleteMemberDOB.Location = new System.Drawing.Point(13, 104);
            this.lblDeleteMemberDOB.Name = "lblDeleteMemberDOB";
            this.lblDeleteMemberDOB.Size = new System.Drawing.Size(39, 13);
            this.lblDeleteMemberDOB.TabIndex = 2;
            this.lblDeleteMemberDOB.Text = "D.O.B:";
            // 
            // lblDeleteMemberPhone
            // 
            this.lblDeleteMemberPhone.AutoSize = true;
            this.lblDeleteMemberPhone.Location = new System.Drawing.Point(13, 140);
            this.lblDeleteMemberPhone.Name = "lblDeleteMemberPhone";
            this.lblDeleteMemberPhone.Size = new System.Drawing.Size(41, 13);
            this.lblDeleteMemberPhone.TabIndex = 3;
            this.lblDeleteMemberPhone.Text = "Phone:";
            // 
            // lblDeleteMemberEmail
            // 
            this.lblDeleteMemberEmail.AutoSize = true;
            this.lblDeleteMemberEmail.Location = new System.Drawing.Point(13, 174);
            this.lblDeleteMemberEmail.Name = "lblDeleteMemberEmail";
            this.lblDeleteMemberEmail.Size = new System.Drawing.Size(35, 13);
            this.lblDeleteMemberEmail.TabIndex = 4;
            this.lblDeleteMemberEmail.Text = "Email:";
            // 
            // lblDeleteMemberAddress1
            // 
            this.lblDeleteMemberAddress1.AutoSize = true;
            this.lblDeleteMemberAddress1.Location = new System.Drawing.Point(13, 211);
            this.lblDeleteMemberAddress1.Name = "lblDeleteMemberAddress1";
            this.lblDeleteMemberAddress1.Size = new System.Drawing.Size(80, 13);
            this.lblDeleteMemberAddress1.TabIndex = 5;
            this.lblDeleteMemberAddress1.Text = "Address Line 1:";
            // 
            // lblDeleteMemberAddress2
            // 
            this.lblDeleteMemberAddress2.AutoSize = true;
            this.lblDeleteMemberAddress2.Location = new System.Drawing.Point(13, 254);
            this.lblDeleteMemberAddress2.Name = "lblDeleteMemberAddress2";
            this.lblDeleteMemberAddress2.Size = new System.Drawing.Size(80, 13);
            this.lblDeleteMemberAddress2.TabIndex = 6;
            this.lblDeleteMemberAddress2.Text = "Address Line 2:";
            // 
            // lblDeleteMemberCounty
            // 
            this.lblDeleteMemberCounty.AutoSize = true;
            this.lblDeleteMemberCounty.Location = new System.Drawing.Point(13, 292);
            this.lblDeleteMemberCounty.Name = "lblDeleteMemberCounty";
            this.lblDeleteMemberCounty.Size = new System.Drawing.Size(43, 13);
            this.lblDeleteMemberCounty.TabIndex = 7;
            this.lblDeleteMemberCounty.Text = "County:";
            // 
            // lblDeleteMemberEircode
            // 
            this.lblDeleteMemberEircode.AutoSize = true;
            this.lblDeleteMemberEircode.Location = new System.Drawing.Point(13, 336);
            this.lblDeleteMemberEircode.Name = "lblDeleteMemberEircode";
            this.lblDeleteMemberEircode.Size = new System.Drawing.Size(46, 13);
            this.lblDeleteMemberEircode.TabIndex = 8;
            this.lblDeleteMemberEircode.Text = "Eircode:";
            // 
            // lblDeleteMemberRegDate
            // 
            this.lblDeleteMemberRegDate.AutoSize = true;
            this.lblDeleteMemberRegDate.Location = new System.Drawing.Point(13, 382);
            this.lblDeleteMemberRegDate.Name = "lblDeleteMemberRegDate";
            this.lblDeleteMemberRegDate.Size = new System.Drawing.Size(92, 13);
            this.lblDeleteMemberRegDate.TabIndex = 9;
            this.lblDeleteMemberRegDate.Text = "Registration Date:";
            // 
            // btnDeleteMemberDelete
            // 
            this.btnDeleteMemberDelete.Location = new System.Drawing.Point(16, 521);
            this.btnDeleteMemberDelete.Name = "btnDeleteMemberDelete";
            this.btnDeleteMemberDelete.Size = new System.Drawing.Size(321, 39);
            this.btnDeleteMemberDelete.TabIndex = 10;
            this.btnDeleteMemberDelete.Text = "Delete Member";
            this.btnDeleteMemberDelete.UseVisualStyleBackColor = true;
            this.btnDeleteMemberDelete.Click += new System.EventHandler(this.btnDeleteMemberDelete_Click);
            // 
            // txtDeleteMemberFName
            // 
            this.txtDeleteMemberFName.Location = new System.Drawing.Point(115, 30);
            this.txtDeleteMemberFName.Name = "txtDeleteMemberFName";
            this.txtDeleteMemberFName.ReadOnly = true;
            this.txtDeleteMemberFName.Size = new System.Drawing.Size(222, 20);
            this.txtDeleteMemberFName.TabIndex = 11;
            // 
            // txtDeleteMemberLName
            // 
            this.txtDeleteMemberLName.Location = new System.Drawing.Point(115, 62);
            this.txtDeleteMemberLName.Name = "txtDeleteMemberLName";
            this.txtDeleteMemberLName.ReadOnly = true;
            this.txtDeleteMemberLName.Size = new System.Drawing.Size(222, 20);
            this.txtDeleteMemberLName.TabIndex = 12;
            // 
            // txtDeleteMemberDOB
            // 
            this.txtDeleteMemberDOB.Location = new System.Drawing.Point(115, 97);
            this.txtDeleteMemberDOB.Name = "txtDeleteMemberDOB";
            this.txtDeleteMemberDOB.ReadOnly = true;
            this.txtDeleteMemberDOB.Size = new System.Drawing.Size(222, 20);
            this.txtDeleteMemberDOB.TabIndex = 13;
            // 
            // txtDeleteMemberPhone
            // 
            this.txtDeleteMemberPhone.Location = new System.Drawing.Point(115, 133);
            this.txtDeleteMemberPhone.Name = "txtDeleteMemberPhone";
            this.txtDeleteMemberPhone.ReadOnly = true;
            this.txtDeleteMemberPhone.Size = new System.Drawing.Size(222, 20);
            this.txtDeleteMemberPhone.TabIndex = 14;
            // 
            // txtDeleteMemberEmail
            // 
            this.txtDeleteMemberEmail.Location = new System.Drawing.Point(115, 167);
            this.txtDeleteMemberEmail.Name = "txtDeleteMemberEmail";
            this.txtDeleteMemberEmail.ReadOnly = true;
            this.txtDeleteMemberEmail.Size = new System.Drawing.Size(222, 20);
            this.txtDeleteMemberEmail.TabIndex = 15;
            // 
            // txtDeleteMemberAddress1
            // 
            this.txtDeleteMemberAddress1.Location = new System.Drawing.Point(115, 204);
            this.txtDeleteMemberAddress1.Name = "txtDeleteMemberAddress1";
            this.txtDeleteMemberAddress1.ReadOnly = true;
            this.txtDeleteMemberAddress1.Size = new System.Drawing.Size(222, 20);
            this.txtDeleteMemberAddress1.TabIndex = 16;
            // 
            // txtDeleteMemberAddress2
            // 
            this.txtDeleteMemberAddress2.Location = new System.Drawing.Point(115, 247);
            this.txtDeleteMemberAddress2.Name = "txtDeleteMemberAddress2";
            this.txtDeleteMemberAddress2.ReadOnly = true;
            this.txtDeleteMemberAddress2.Size = new System.Drawing.Size(222, 20);
            this.txtDeleteMemberAddress2.TabIndex = 17;
            // 
            // txtDeleteMemberCounty
            // 
            this.txtDeleteMemberCounty.Location = new System.Drawing.Point(115, 289);
            this.txtDeleteMemberCounty.Name = "txtDeleteMemberCounty";
            this.txtDeleteMemberCounty.ReadOnly = true;
            this.txtDeleteMemberCounty.Size = new System.Drawing.Size(222, 20);
            this.txtDeleteMemberCounty.TabIndex = 18;
            // 
            // txtDeleteMemberEircode
            // 
            this.txtDeleteMemberEircode.Location = new System.Drawing.Point(115, 329);
            this.txtDeleteMemberEircode.Name = "txtDeleteMemberEircode";
            this.txtDeleteMemberEircode.ReadOnly = true;
            this.txtDeleteMemberEircode.Size = new System.Drawing.Size(222, 20);
            this.txtDeleteMemberEircode.TabIndex = 19;
            // 
            // txtDeleteMemberRegDate
            // 
            this.txtDeleteMemberRegDate.Location = new System.Drawing.Point(115, 375);
            this.txtDeleteMemberRegDate.Name = "txtDeleteMemberRegDate";
            this.txtDeleteMemberRegDate.ReadOnly = true;
            this.txtDeleteMemberRegDate.Size = new System.Drawing.Size(222, 20);
            this.txtDeleteMemberRegDate.TabIndex = 20;
            // 
            // lblDeleteMemberFines
            // 
            this.lblDeleteMemberFines.AutoSize = true;
            this.lblDeleteMemberFines.Location = new System.Drawing.Point(16, 427);
            this.lblDeleteMemberFines.Name = "lblDeleteMemberFines";
            this.lblDeleteMemberFines.Size = new System.Drawing.Size(62, 13);
            this.lblDeleteMemberFines.TabIndex = 21;
            this.lblDeleteMemberFines.Text = "Total Fines:";
            // 
            // txtDeleteMemberFines
            // 
            this.txtDeleteMemberFines.Location = new System.Drawing.Point(115, 419);
            this.txtDeleteMemberFines.Name = "txtDeleteMemberFines";
            this.txtDeleteMemberFines.ReadOnly = true;
            this.txtDeleteMemberFines.Size = new System.Drawing.Size(222, 20);
            this.txtDeleteMemberFines.TabIndex = 22;
            // 
            // lblDeleteMemberLoans
            // 
            this.lblDeleteMemberLoans.AutoSize = true;
            this.lblDeleteMemberLoans.Location = new System.Drawing.Point(16, 467);
            this.lblDeleteMemberLoans.Name = "lblDeleteMemberLoans";
            this.lblDeleteMemberLoans.Size = new System.Drawing.Size(78, 13);
            this.lblDeleteMemberLoans.TabIndex = 23;
            this.lblDeleteMemberLoans.Text = "Books on loan:";
            // 
            // txtDeleteMemberLoans
            // 
            this.txtDeleteMemberLoans.Location = new System.Drawing.Point(115, 464);
            this.txtDeleteMemberLoans.Name = "txtDeleteMemberLoans";
            this.txtDeleteMemberLoans.ReadOnly = true;
            this.txtDeleteMemberLoans.Size = new System.Drawing.Size(222, 20);
            this.txtDeleteMemberLoans.TabIndex = 24;
            // 
            // frmDeleteMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 676);
            this.Controls.Add(this.grpDeleteMember);
            this.Controls.Add(this.btnDeleteMemberSearch);
            this.Controls.Add(this.txtDeleteMemberID);
            this.Controls.Add(this.lblDeleteMemberID);
            this.Controls.Add(this.mnuDeleteMember);
            this.MainMenuStrip = this.mnuDeleteMember;
            this.Name = "frmDeleteMember";
            this.Text = "frmDeleteMember";
            this.Load += new System.EventHandler(this.frmDeleteMember_Load);
            this.mnuDeleteMember.ResumeLayout(false);
            this.mnuDeleteMember.PerformLayout();
            this.grpDeleteMember.ResumeLayout(false);
            this.grpDeleteMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuDeleteMember;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteMemberExit;
        private System.Windows.Forms.Label lblDeleteMemberID;
        private System.Windows.Forms.TextBox txtDeleteMemberID;
        private System.Windows.Forms.Button btnDeleteMemberSearch;
        private System.Windows.Forms.GroupBox grpDeleteMember;
        private System.Windows.Forms.Label lblDeleteMemberFName;
        private System.Windows.Forms.Label lblDeleteMemberRegDate;
        private System.Windows.Forms.Label lblDeleteMemberEircode;
        private System.Windows.Forms.Label lblDeleteMemberCounty;
        private System.Windows.Forms.Label lblDeleteMemberAddress2;
        private System.Windows.Forms.Label lblDeleteMemberAddress1;
        private System.Windows.Forms.Label lblDeleteMemberEmail;
        private System.Windows.Forms.Label lblDeleteMemberPhone;
        private System.Windows.Forms.Label lblDeleteMemberDOB;
        private System.Windows.Forms.Label lblDeleteMemberLName;
        private System.Windows.Forms.Button btnDeleteMemberDelete;
        private System.Windows.Forms.TextBox txtDeleteMemberRegDate;
        private System.Windows.Forms.TextBox txtDeleteMemberEircode;
        private System.Windows.Forms.TextBox txtDeleteMemberCounty;
        private System.Windows.Forms.TextBox txtDeleteMemberAddress2;
        private System.Windows.Forms.TextBox txtDeleteMemberAddress1;
        private System.Windows.Forms.TextBox txtDeleteMemberEmail;
        private System.Windows.Forms.TextBox txtDeleteMemberPhone;
        private System.Windows.Forms.TextBox txtDeleteMemberDOB;
        private System.Windows.Forms.TextBox txtDeleteMemberLName;
        private System.Windows.Forms.TextBox txtDeleteMemberFName;
        private System.Windows.Forms.TextBox txtDeleteMemberFines;
        private System.Windows.Forms.Label lblDeleteMemberFines;
        private System.Windows.Forms.TextBox txtDeleteMemberLoans;
        private System.Windows.Forms.Label lblDeleteMemberLoans;
    }
}