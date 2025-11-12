namespace LibrarySYS
{
    partial class frmUpdateMember
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
            this.mnuUpdateMember = new System.Windows.Forms.MenuStrip();
            this.mnuUpdateMemberExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUpdateMemberID = new System.Windows.Forms.Label();
            this.txtUpdateMemberID = new System.Windows.Forms.TextBox();
            this.btnUpdateMemberSearch = new System.Windows.Forms.Button();
            this.grpUpdateMember = new System.Windows.Forms.GroupBox();
            this.lblUpdateMemberFName = new System.Windows.Forms.Label();
            this.lblUpdateMemberLName = new System.Windows.Forms.Label();
            this.lblUpdateMemberDOB = new System.Windows.Forms.Label();
            this.lblUpdateMemberPhone = new System.Windows.Forms.Label();
            this.lblUpdateMemberEmail = new System.Windows.Forms.Label();
            this.lblUpdateMemberAddress1 = new System.Windows.Forms.Label();
            this.lblUpdateMemberAddress2 = new System.Windows.Forms.Label();
            this.lblUpdateMemberTown = new System.Windows.Forms.Label();
            this.lblUpdateMemberCounty = new System.Windows.Forms.Label();
            this.lblUpdateMemberEircode = new System.Windows.Forms.Label();
            this.btnUpdateMemberUpdate = new System.Windows.Forms.Button();
            this.txtUpdateMemberFName = new System.Windows.Forms.TextBox();
            this.txtUpdateMemberLName = new System.Windows.Forms.TextBox();
            this.txtUpdateMemberPhone = new System.Windows.Forms.TextBox();
            this.txtUpdateMemberEmail = new System.Windows.Forms.TextBox();
            this.txtUpdateMemberAddress1 = new System.Windows.Forms.TextBox();
            this.txtUpdateMemberAddress2 = new System.Windows.Forms.TextBox();
            this.txtUpdateMemberTown = new System.Windows.Forms.TextBox();
            this.txtUpdateMemberCounty = new System.Windows.Forms.TextBox();
            this.txtUpdateMemberEircode = new System.Windows.Forms.TextBox();
            this.dtpUpdateMemberDOB = new System.Windows.Forms.DateTimePicker();
            this.mnuUpdateMember.SuspendLayout();
            this.grpUpdateMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateMember
            // 
            this.mnuUpdateMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateMemberExit});
            this.mnuUpdateMember.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateMember.Name = "mnuUpdateMember";
            this.mnuUpdateMember.Size = new System.Drawing.Size(375, 24);
            this.mnuUpdateMember.TabIndex = 0;
            this.mnuUpdateMember.Text = "menuStrip1";
            // 
            // mnuUpdateMemberExit
            // 
            this.mnuUpdateMemberExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuUpdateMemberExit.Name = "mnuUpdateMemberExit";
            this.mnuUpdateMemberExit.Size = new System.Drawing.Size(37, 20);
            this.mnuUpdateMemberExit.Text = "Exit";
            this.mnuUpdateMemberExit.Click += new System.EventHandler(this.mnuUpdateMemberExit_Click);
            // 
            // lblUpdateMemberID
            // 
            this.lblUpdateMemberID.AutoSize = true;
            this.lblUpdateMemberID.Location = new System.Drawing.Point(13, 28);
            this.lblUpdateMemberID.Name = "lblUpdateMemberID";
            this.lblUpdateMemberID.Size = new System.Drawing.Size(90, 13);
            this.lblUpdateMemberID.TabIndex = 1;
            this.lblUpdateMemberID.Text = "Enter Member ID:";
            // 
            // txtUpdateMemberID
            // 
            this.txtUpdateMemberID.Location = new System.Drawing.Point(123, 25);
            this.txtUpdateMemberID.Name = "txtUpdateMemberID";
            this.txtUpdateMemberID.Size = new System.Drawing.Size(124, 20);
            this.txtUpdateMemberID.TabIndex = 2;
            // 
            // btnUpdateMemberSearch
            // 
            this.btnUpdateMemberSearch.Location = new System.Drawing.Point(270, 23);
            this.btnUpdateMemberSearch.Name = "btnUpdateMemberSearch";
            this.btnUpdateMemberSearch.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMemberSearch.TabIndex = 3;
            this.btnUpdateMemberSearch.Text = "Search";
            this.btnUpdateMemberSearch.UseVisualStyleBackColor = true;
            this.btnUpdateMemberSearch.Click += new System.EventHandler(this.btnUpdateMemberSearch_Click);
            // 
            // grpUpdateMember
            // 
            this.grpUpdateMember.Controls.Add(this.dtpUpdateMemberDOB);
            this.grpUpdateMember.Controls.Add(this.txtUpdateMemberEircode);
            this.grpUpdateMember.Controls.Add(this.txtUpdateMemberCounty);
            this.grpUpdateMember.Controls.Add(this.txtUpdateMemberTown);
            this.grpUpdateMember.Controls.Add(this.txtUpdateMemberAddress2);
            this.grpUpdateMember.Controls.Add(this.txtUpdateMemberAddress1);
            this.grpUpdateMember.Controls.Add(this.txtUpdateMemberEmail);
            this.grpUpdateMember.Controls.Add(this.txtUpdateMemberPhone);
            this.grpUpdateMember.Controls.Add(this.txtUpdateMemberLName);
            this.grpUpdateMember.Controls.Add(this.txtUpdateMemberFName);
            this.grpUpdateMember.Controls.Add(this.btnUpdateMemberUpdate);
            this.grpUpdateMember.Controls.Add(this.lblUpdateMemberEircode);
            this.grpUpdateMember.Controls.Add(this.lblUpdateMemberCounty);
            this.grpUpdateMember.Controls.Add(this.lblUpdateMemberTown);
            this.grpUpdateMember.Controls.Add(this.lblUpdateMemberAddress2);
            this.grpUpdateMember.Controls.Add(this.lblUpdateMemberAddress1);
            this.grpUpdateMember.Controls.Add(this.lblUpdateMemberEmail);
            this.grpUpdateMember.Controls.Add(this.lblUpdateMemberPhone);
            this.grpUpdateMember.Controls.Add(this.lblUpdateMemberDOB);
            this.grpUpdateMember.Controls.Add(this.lblUpdateMemberLName);
            this.grpUpdateMember.Controls.Add(this.lblUpdateMemberFName);
            this.grpUpdateMember.Location = new System.Drawing.Point(16, 68);
            this.grpUpdateMember.Name = "grpUpdateMember";
            this.grpUpdateMember.Size = new System.Drawing.Size(329, 441);
            this.grpUpdateMember.TabIndex = 4;
            this.grpUpdateMember.TabStop = false;
            this.grpUpdateMember.Text = "Update Member";
            // 
            // lblUpdateMemberFName
            // 
            this.lblUpdateMemberFName.AutoSize = true;
            this.lblUpdateMemberFName.Location = new System.Drawing.Point(13, 30);
            this.lblUpdateMemberFName.Name = "lblUpdateMemberFName";
            this.lblUpdateMemberFName.Size = new System.Drawing.Size(60, 13);
            this.lblUpdateMemberFName.TabIndex = 0;
            this.lblUpdateMemberFName.Text = "First Name:";
            // 
            // lblUpdateMemberLName
            // 
            this.lblUpdateMemberLName.AutoSize = true;
            this.lblUpdateMemberLName.Location = new System.Drawing.Point(13, 63);
            this.lblUpdateMemberLName.Name = "lblUpdateMemberLName";
            this.lblUpdateMemberLName.Size = new System.Drawing.Size(61, 13);
            this.lblUpdateMemberLName.TabIndex = 1;
            this.lblUpdateMemberLName.Text = "Last Name:";
            // 
            // lblUpdateMemberDOB
            // 
            this.lblUpdateMemberDOB.AutoSize = true;
            this.lblUpdateMemberDOB.Location = new System.Drawing.Point(13, 94);
            this.lblUpdateMemberDOB.Name = "lblUpdateMemberDOB";
            this.lblUpdateMemberDOB.Size = new System.Drawing.Size(39, 13);
            this.lblUpdateMemberDOB.TabIndex = 2;
            this.lblUpdateMemberDOB.Text = "D.O.B:";
            // 
            // lblUpdateMemberPhone
            // 
            this.lblUpdateMemberPhone.AutoSize = true;
            this.lblUpdateMemberPhone.Location = new System.Drawing.Point(13, 126);
            this.lblUpdateMemberPhone.Name = "lblUpdateMemberPhone";
            this.lblUpdateMemberPhone.Size = new System.Drawing.Size(41, 13);
            this.lblUpdateMemberPhone.TabIndex = 3;
            this.lblUpdateMemberPhone.Text = "Phone:";
            // 
            // lblUpdateMemberEmail
            // 
            this.lblUpdateMemberEmail.AutoSize = true;
            this.lblUpdateMemberEmail.Location = new System.Drawing.Point(13, 159);
            this.lblUpdateMemberEmail.Name = "lblUpdateMemberEmail";
            this.lblUpdateMemberEmail.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateMemberEmail.TabIndex = 4;
            this.lblUpdateMemberEmail.Text = "Email:";
            // 
            // lblUpdateMemberAddress1
            // 
            this.lblUpdateMemberAddress1.AutoSize = true;
            this.lblUpdateMemberAddress1.Location = new System.Drawing.Point(13, 194);
            this.lblUpdateMemberAddress1.Name = "lblUpdateMemberAddress1";
            this.lblUpdateMemberAddress1.Size = new System.Drawing.Size(80, 13);
            this.lblUpdateMemberAddress1.TabIndex = 5;
            this.lblUpdateMemberAddress1.Text = "Address Line 1:";
            // 
            // lblUpdateMemberAddress2
            // 
            this.lblUpdateMemberAddress2.AutoSize = true;
            this.lblUpdateMemberAddress2.Location = new System.Drawing.Point(13, 232);
            this.lblUpdateMemberAddress2.Name = "lblUpdateMemberAddress2";
            this.lblUpdateMemberAddress2.Size = new System.Drawing.Size(80, 13);
            this.lblUpdateMemberAddress2.TabIndex = 6;
            this.lblUpdateMemberAddress2.Text = "Address Line 2:";
            // 
            // lblUpdateMemberTown
            // 
            this.lblUpdateMemberTown.AutoSize = true;
            this.lblUpdateMemberTown.Location = new System.Drawing.Point(13, 266);
            this.lblUpdateMemberTown.Name = "lblUpdateMemberTown";
            this.lblUpdateMemberTown.Size = new System.Drawing.Size(65, 13);
            this.lblUpdateMemberTown.TabIndex = 7;
            this.lblUpdateMemberTown.Text = "Town / City:";
            // 
            // lblUpdateMemberCounty
            // 
            this.lblUpdateMemberCounty.AutoSize = true;
            this.lblUpdateMemberCounty.Location = new System.Drawing.Point(13, 302);
            this.lblUpdateMemberCounty.Name = "lblUpdateMemberCounty";
            this.lblUpdateMemberCounty.Size = new System.Drawing.Size(43, 13);
            this.lblUpdateMemberCounty.TabIndex = 8;
            this.lblUpdateMemberCounty.Text = "County:";
            // 
            // lblUpdateMemberEircode
            // 
            this.lblUpdateMemberEircode.AutoSize = true;
            this.lblUpdateMemberEircode.Location = new System.Drawing.Point(13, 339);
            this.lblUpdateMemberEircode.Name = "lblUpdateMemberEircode";
            this.lblUpdateMemberEircode.Size = new System.Drawing.Size(49, 13);
            this.lblUpdateMemberEircode.TabIndex = 9;
            this.lblUpdateMemberEircode.Text = "Eircode: ";
            // 
            // btnUpdateMemberUpdate
            // 
            this.btnUpdateMemberUpdate.Location = new System.Drawing.Point(16, 392);
            this.btnUpdateMemberUpdate.Name = "btnUpdateMemberUpdate";
            this.btnUpdateMemberUpdate.Size = new System.Drawing.Size(298, 31);
            this.btnUpdateMemberUpdate.TabIndex = 10;
            this.btnUpdateMemberUpdate.Text = "Update Member";
            this.btnUpdateMemberUpdate.UseVisualStyleBackColor = true;
            this.btnUpdateMemberUpdate.Click += new System.EventHandler(this.btnUpdateMemberUpdate_Click);
            // 
            // txtUpdateMemberFName
            // 
            this.txtUpdateMemberFName.Location = new System.Drawing.Point(122, 27);
            this.txtUpdateMemberFName.Name = "txtUpdateMemberFName";
            this.txtUpdateMemberFName.Size = new System.Drawing.Size(192, 20);
            this.txtUpdateMemberFName.TabIndex = 11;
            // 
            // txtUpdateMemberLName
            // 
            this.txtUpdateMemberLName.Location = new System.Drawing.Point(122, 60);
            this.txtUpdateMemberLName.Name = "txtUpdateMemberLName";
            this.txtUpdateMemberLName.Size = new System.Drawing.Size(192, 20);
            this.txtUpdateMemberLName.TabIndex = 12;
            // 
            // txtUpdateMemberPhone
            // 
            this.txtUpdateMemberPhone.Location = new System.Drawing.Point(122, 123);
            this.txtUpdateMemberPhone.Name = "txtUpdateMemberPhone";
            this.txtUpdateMemberPhone.Size = new System.Drawing.Size(192, 20);
            this.txtUpdateMemberPhone.TabIndex = 14;
            // 
            // txtUpdateMemberEmail
            // 
            this.txtUpdateMemberEmail.Location = new System.Drawing.Point(122, 156);
            this.txtUpdateMemberEmail.Name = "txtUpdateMemberEmail";
            this.txtUpdateMemberEmail.Size = new System.Drawing.Size(192, 20);
            this.txtUpdateMemberEmail.TabIndex = 15;
            // 
            // txtUpdateMemberAddress1
            // 
            this.txtUpdateMemberAddress1.Location = new System.Drawing.Point(122, 191);
            this.txtUpdateMemberAddress1.Name = "txtUpdateMemberAddress1";
            this.txtUpdateMemberAddress1.Size = new System.Drawing.Size(192, 20);
            this.txtUpdateMemberAddress1.TabIndex = 16;
            // 
            // txtUpdateMemberAddress2
            // 
            this.txtUpdateMemberAddress2.Location = new System.Drawing.Point(122, 229);
            this.txtUpdateMemberAddress2.Name = "txtUpdateMemberAddress2";
            this.txtUpdateMemberAddress2.Size = new System.Drawing.Size(192, 20);
            this.txtUpdateMemberAddress2.TabIndex = 17;
            // 
            // txtUpdateMemberTown
            // 
            this.txtUpdateMemberTown.Location = new System.Drawing.Point(122, 263);
            this.txtUpdateMemberTown.Name = "txtUpdateMemberTown";
            this.txtUpdateMemberTown.Size = new System.Drawing.Size(192, 20);
            this.txtUpdateMemberTown.TabIndex = 18;
            // 
            // txtUpdateMemberCounty
            // 
            this.txtUpdateMemberCounty.Location = new System.Drawing.Point(122, 299);
            this.txtUpdateMemberCounty.Name = "txtUpdateMemberCounty";
            this.txtUpdateMemberCounty.Size = new System.Drawing.Size(192, 20);
            this.txtUpdateMemberCounty.TabIndex = 19;
            // 
            // txtUpdateMemberEircode
            // 
            this.txtUpdateMemberEircode.Location = new System.Drawing.Point(122, 336);
            this.txtUpdateMemberEircode.Name = "txtUpdateMemberEircode";
            this.txtUpdateMemberEircode.Size = new System.Drawing.Size(192, 20);
            this.txtUpdateMemberEircode.TabIndex = 20;
            // 
            // dtpUpdateMemberDOB
            // 
            this.dtpUpdateMemberDOB.Location = new System.Drawing.Point(122, 94);
            this.dtpUpdateMemberDOB.Name = "dtpUpdateMemberDOB";
            this.dtpUpdateMemberDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpUpdateMemberDOB.TabIndex = 21;
            this.dtpUpdateMemberDOB.Value = new System.DateTime(2025, 11, 12, 0, 0, 0, 0);
            // 
            // frmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 524);
            this.Controls.Add(this.grpUpdateMember);
            this.Controls.Add(this.btnUpdateMemberSearch);
            this.Controls.Add(this.txtUpdateMemberID);
            this.Controls.Add(this.lblUpdateMemberID);
            this.Controls.Add(this.mnuUpdateMember);
            this.MainMenuStrip = this.mnuUpdateMember;
            this.Name = "frmUpdateMember";
            this.Text = "Members - [Update Member]";
            this.Load += new System.EventHandler(this.frmUpdateMember_Load);
            this.mnuUpdateMember.ResumeLayout(false);
            this.mnuUpdateMember.PerformLayout();
            this.grpUpdateMember.ResumeLayout(false);
            this.grpUpdateMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateMember;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMemberExit;
        private System.Windows.Forms.Label lblUpdateMemberID;
        private System.Windows.Forms.TextBox txtUpdateMemberID;
        private System.Windows.Forms.Button btnUpdateMemberSearch;
        private System.Windows.Forms.GroupBox grpUpdateMember;
        private System.Windows.Forms.Label lblUpdateMemberPhone;
        private System.Windows.Forms.Label lblUpdateMemberDOB;
        private System.Windows.Forms.Label lblUpdateMemberLName;
        private System.Windows.Forms.Label lblUpdateMemberFName;
        private System.Windows.Forms.Label lblUpdateMemberEircode;
        private System.Windows.Forms.Label lblUpdateMemberCounty;
        private System.Windows.Forms.Label lblUpdateMemberTown;
        private System.Windows.Forms.Label lblUpdateMemberAddress2;
        private System.Windows.Forms.Label lblUpdateMemberAddress1;
        private System.Windows.Forms.Label lblUpdateMemberEmail;
        private System.Windows.Forms.Button btnUpdateMemberUpdate;
        private System.Windows.Forms.TextBox txtUpdateMemberFName;
        private System.Windows.Forms.TextBox txtUpdateMemberEircode;
        private System.Windows.Forms.TextBox txtUpdateMemberCounty;
        private System.Windows.Forms.TextBox txtUpdateMemberTown;
        private System.Windows.Forms.TextBox txtUpdateMemberAddress2;
        private System.Windows.Forms.TextBox txtUpdateMemberAddress1;
        private System.Windows.Forms.TextBox txtUpdateMemberEmail;
        private System.Windows.Forms.TextBox txtUpdateMemberPhone;
        private System.Windows.Forms.TextBox txtUpdateMemberLName;
        private System.Windows.Forms.DateTimePicker dtpUpdateMemberDOB;
    }
}