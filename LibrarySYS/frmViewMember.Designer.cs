namespace LibrarySYS
{
    partial class frmViewMember
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
            this.mnuViewMember = new System.Windows.Forms.MenuStrip();
            this.mnuViewMemberExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblViewMemberID = new System.Windows.Forms.Label();
            this.txtViewMemberID = new System.Windows.Forms.TextBox();
            this.btnViewMemberSearch = new System.Windows.Forms.Button();
            this.grpViewMember = new System.Windows.Forms.GroupBox();
            this.lblViewMemberidentifier = new System.Windows.Forms.Label();
            this.lblViewMemberFName = new System.Windows.Forms.Label();
            this.lblViewMemberLName = new System.Windows.Forms.Label();
            this.lblViewMemberDOB = new System.Windows.Forms.Label();
            this.lblViewMemberPhone = new System.Windows.Forms.Label();
            this.lblViewMemberEmail = new System.Windows.Forms.Label();
            this.lblViewMemberAddress1 = new System.Windows.Forms.Label();
            this.lblViewMemberAddress2 = new System.Windows.Forms.Label();
            this.lblViewMemberTown = new System.Windows.Forms.Label();
            this.lblViewMemberCounty = new System.Windows.Forms.Label();
            this.lblUpdateMemberEircode = new System.Windows.Forms.Label();
            this.txtViewMemberidentifier = new System.Windows.Forms.TextBox();
            this.txtViewMemberFName = new System.Windows.Forms.TextBox();
            this.txtViewMemberLName = new System.Windows.Forms.TextBox();
            this.dtpViewMemberDOB = new System.Windows.Forms.DateTimePicker();
            this.txtViewMemberPhone = new System.Windows.Forms.TextBox();
            this.txtViewMemberEmail = new System.Windows.Forms.TextBox();
            this.txtViewMemberAddress1 = new System.Windows.Forms.TextBox();
            this.txtViewMemberAddress2 = new System.Windows.Forms.TextBox();
            this.txtViewMemberTown = new System.Windows.Forms.TextBox();
            this.txtViewMemberCounty = new System.Windows.Forms.TextBox();
            this.txtViewMemberEircode = new System.Windows.Forms.TextBox();
            this.mnuViewMember.SuspendLayout();
            this.grpViewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuViewMember
            // 
            this.mnuViewMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewMemberExit});
            this.mnuViewMember.Location = new System.Drawing.Point(0, 0);
            this.mnuViewMember.Name = "mnuViewMember";
            this.mnuViewMember.Size = new System.Drawing.Size(365, 24);
            this.mnuViewMember.TabIndex = 0;
            this.mnuViewMember.Text = "menuStrip1";
            // 
            // mnuViewMemberExit
            // 
            this.mnuViewMemberExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuViewMemberExit.Name = "mnuViewMemberExit";
            this.mnuViewMemberExit.Size = new System.Drawing.Size(37, 20);
            this.mnuViewMemberExit.Text = "Exit";
            this.mnuViewMemberExit.Click += new System.EventHandler(this.mnuViewMemberExit_Click);
            // 
            // lblViewMemberID
            // 
            this.lblViewMemberID.AutoSize = true;
            this.lblViewMemberID.Location = new System.Drawing.Point(12, 35);
            this.lblViewMemberID.Name = "lblViewMemberID";
            this.lblViewMemberID.Size = new System.Drawing.Size(90, 13);
            this.lblViewMemberID.TabIndex = 1;
            this.lblViewMemberID.Text = "Enter Member ID:";
            this.lblViewMemberID.Click += new System.EventHandler(this.lblViewMemberID_Click);
            // 
            // txtViewMemberID
            // 
            this.txtViewMemberID.Location = new System.Drawing.Point(108, 32);
            this.txtViewMemberID.Name = "txtViewMemberID";
            this.txtViewMemberID.Size = new System.Drawing.Size(140, 20);
            this.txtViewMemberID.TabIndex = 2;
            // 
            // btnViewMemberSearch
            // 
            this.btnViewMemberSearch.Location = new System.Drawing.Point(263, 30);
            this.btnViewMemberSearch.Name = "btnViewMemberSearch";
            this.btnViewMemberSearch.Size = new System.Drawing.Size(90, 23);
            this.btnViewMemberSearch.TabIndex = 3;
            this.btnViewMemberSearch.Text = "Search";
            this.btnViewMemberSearch.UseVisualStyleBackColor = true;
            this.btnViewMemberSearch.Click += new System.EventHandler(this.btnViewMemberSearch_Click);
            // 
            // grpViewMember
            // 
            this.grpViewMember.Controls.Add(this.txtViewMemberEircode);
            this.grpViewMember.Controls.Add(this.txtViewMemberCounty);
            this.grpViewMember.Controls.Add(this.txtViewMemberTown);
            this.grpViewMember.Controls.Add(this.txtViewMemberAddress2);
            this.grpViewMember.Controls.Add(this.txtViewMemberAddress1);
            this.grpViewMember.Controls.Add(this.txtViewMemberEmail);
            this.grpViewMember.Controls.Add(this.txtViewMemberPhone);
            this.grpViewMember.Controls.Add(this.dtpViewMemberDOB);
            this.grpViewMember.Controls.Add(this.txtViewMemberLName);
            this.grpViewMember.Controls.Add(this.txtViewMemberFName);
            this.grpViewMember.Controls.Add(this.txtViewMemberidentifier);
            this.grpViewMember.Controls.Add(this.lblUpdateMemberEircode);
            this.grpViewMember.Controls.Add(this.lblViewMemberCounty);
            this.grpViewMember.Controls.Add(this.lblViewMemberTown);
            this.grpViewMember.Controls.Add(this.lblViewMemberAddress2);
            this.grpViewMember.Controls.Add(this.lblViewMemberAddress1);
            this.grpViewMember.Controls.Add(this.lblViewMemberEmail);
            this.grpViewMember.Controls.Add(this.lblViewMemberPhone);
            this.grpViewMember.Controls.Add(this.lblViewMemberDOB);
            this.grpViewMember.Controls.Add(this.lblViewMemberLName);
            this.grpViewMember.Controls.Add(this.lblViewMemberFName);
            this.grpViewMember.Controls.Add(this.lblViewMemberidentifier);
            this.grpViewMember.Location = new System.Drawing.Point(16, 75);
            this.grpViewMember.Name = "grpViewMember";
            this.grpViewMember.Size = new System.Drawing.Size(337, 405);
            this.grpViewMember.TabIndex = 4;
            this.grpViewMember.TabStop = false;
            this.grpViewMember.Text = "View Member";
            // 
            // lblViewMemberidentifier
            // 
            this.lblViewMemberidentifier.AutoSize = true;
            this.lblViewMemberidentifier.Location = new System.Drawing.Point(10, 28);
            this.lblViewMemberidentifier.Name = "lblViewMemberidentifier";
            this.lblViewMemberidentifier.Size = new System.Drawing.Size(62, 13);
            this.lblViewMemberidentifier.TabIndex = 0;
            this.lblViewMemberidentifier.Text = "Member ID:";
            // 
            // lblViewMemberFName
            // 
            this.lblViewMemberFName.AutoSize = true;
            this.lblViewMemberFName.Location = new System.Drawing.Point(10, 64);
            this.lblViewMemberFName.Name = "lblViewMemberFName";
            this.lblViewMemberFName.Size = new System.Drawing.Size(60, 13);
            this.lblViewMemberFName.TabIndex = 1;
            this.lblViewMemberFName.Text = "First Name:";
            // 
            // lblViewMemberLName
            // 
            this.lblViewMemberLName.AutoSize = true;
            this.lblViewMemberLName.Location = new System.Drawing.Point(10, 97);
            this.lblViewMemberLName.Name = "lblViewMemberLName";
            this.lblViewMemberLName.Size = new System.Drawing.Size(61, 13);
            this.lblViewMemberLName.TabIndex = 2;
            this.lblViewMemberLName.Text = "Last Name:";
            // 
            // lblViewMemberDOB
            // 
            this.lblViewMemberDOB.AutoSize = true;
            this.lblViewMemberDOB.Location = new System.Drawing.Point(10, 135);
            this.lblViewMemberDOB.Name = "lblViewMemberDOB";
            this.lblViewMemberDOB.Size = new System.Drawing.Size(39, 13);
            this.lblViewMemberDOB.TabIndex = 3;
            this.lblViewMemberDOB.Text = "D.O.B:";
            // 
            // lblViewMemberPhone
            // 
            this.lblViewMemberPhone.AutoSize = true;
            this.lblViewMemberPhone.Location = new System.Drawing.Point(10, 164);
            this.lblViewMemberPhone.Name = "lblViewMemberPhone";
            this.lblViewMemberPhone.Size = new System.Drawing.Size(41, 13);
            this.lblViewMemberPhone.TabIndex = 4;
            this.lblViewMemberPhone.Text = "Phone:";
            // 
            // lblViewMemberEmail
            // 
            this.lblViewMemberEmail.AutoSize = true;
            this.lblViewMemberEmail.Location = new System.Drawing.Point(10, 196);
            this.lblViewMemberEmail.Name = "lblViewMemberEmail";
            this.lblViewMemberEmail.Size = new System.Drawing.Size(35, 13);
            this.lblViewMemberEmail.TabIndex = 5;
            this.lblViewMemberEmail.Text = "Email:";
            // 
            // lblViewMemberAddress1
            // 
            this.lblViewMemberAddress1.AutoSize = true;
            this.lblViewMemberAddress1.Location = new System.Drawing.Point(10, 227);
            this.lblViewMemberAddress1.Name = "lblViewMemberAddress1";
            this.lblViewMemberAddress1.Size = new System.Drawing.Size(80, 13);
            this.lblViewMemberAddress1.TabIndex = 6;
            this.lblViewMemberAddress1.Text = "Address Line 1:";
            // 
            // lblViewMemberAddress2
            // 
            this.lblViewMemberAddress2.AutoSize = true;
            this.lblViewMemberAddress2.Location = new System.Drawing.Point(10, 260);
            this.lblViewMemberAddress2.Name = "lblViewMemberAddress2";
            this.lblViewMemberAddress2.Size = new System.Drawing.Size(80, 13);
            this.lblViewMemberAddress2.TabIndex = 7;
            this.lblViewMemberAddress2.Text = "Address Line 2:";
            // 
            // lblViewMemberTown
            // 
            this.lblViewMemberTown.AutoSize = true;
            this.lblViewMemberTown.Location = new System.Drawing.Point(10, 296);
            this.lblViewMemberTown.Name = "lblViewMemberTown";
            this.lblViewMemberTown.Size = new System.Drawing.Size(65, 13);
            this.lblViewMemberTown.TabIndex = 8;
            this.lblViewMemberTown.Text = "Town / City:";
            // 
            // lblViewMemberCounty
            // 
            this.lblViewMemberCounty.AutoSize = true;
            this.lblViewMemberCounty.Location = new System.Drawing.Point(10, 329);
            this.lblViewMemberCounty.Name = "lblViewMemberCounty";
            this.lblViewMemberCounty.Size = new System.Drawing.Size(43, 13);
            this.lblViewMemberCounty.TabIndex = 9;
            this.lblViewMemberCounty.Text = "County:";
            // 
            // lblUpdateMemberEircode
            // 
            this.lblUpdateMemberEircode.AutoSize = true;
            this.lblUpdateMemberEircode.Location = new System.Drawing.Point(10, 362);
            this.lblUpdateMemberEircode.Name = "lblUpdateMemberEircode";
            this.lblUpdateMemberEircode.Size = new System.Drawing.Size(46, 13);
            this.lblUpdateMemberEircode.TabIndex = 10;
            this.lblUpdateMemberEircode.Text = "Eircode:";
            // 
            // txtViewMemberidentifier
            // 
            this.txtViewMemberidentifier.Location = new System.Drawing.Point(120, 25);
            this.txtViewMemberidentifier.Name = "txtViewMemberidentifier";
            this.txtViewMemberidentifier.ReadOnly = true;
            this.txtViewMemberidentifier.Size = new System.Drawing.Size(200, 20);
            this.txtViewMemberidentifier.TabIndex = 11;
            // 
            // txtViewMemberFName
            // 
            this.txtViewMemberFName.Location = new System.Drawing.Point(120, 61);
            this.txtViewMemberFName.Name = "txtViewMemberFName";
            this.txtViewMemberFName.ReadOnly = true;
            this.txtViewMemberFName.Size = new System.Drawing.Size(200, 20);
            this.txtViewMemberFName.TabIndex = 12;
            // 
            // txtViewMemberLName
            // 
            this.txtViewMemberLName.Location = new System.Drawing.Point(120, 94);
            this.txtViewMemberLName.Name = "txtViewMemberLName";
            this.txtViewMemberLName.ReadOnly = true;
            this.txtViewMemberLName.Size = new System.Drawing.Size(200, 20);
            this.txtViewMemberLName.TabIndex = 13;
            // 
            // dtpViewMemberDOB
            // 
            this.dtpViewMemberDOB.Enabled = false;
            this.dtpViewMemberDOB.Location = new System.Drawing.Point(120, 129);
            this.dtpViewMemberDOB.Name = "dtpViewMemberDOB";
            this.dtpViewMemberDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpViewMemberDOB.TabIndex = 14;
            // 
            // txtViewMemberPhone
            // 
            this.txtViewMemberPhone.Location = new System.Drawing.Point(120, 161);
            this.txtViewMemberPhone.Name = "txtViewMemberPhone";
            this.txtViewMemberPhone.ReadOnly = true;
            this.txtViewMemberPhone.Size = new System.Drawing.Size(200, 20);
            this.txtViewMemberPhone.TabIndex = 15;
            // 
            // txtViewMemberEmail
            // 
            this.txtViewMemberEmail.Location = new System.Drawing.Point(120, 193);
            this.txtViewMemberEmail.Name = "txtViewMemberEmail";
            this.txtViewMemberEmail.ReadOnly = true;
            this.txtViewMemberEmail.Size = new System.Drawing.Size(200, 20);
            this.txtViewMemberEmail.TabIndex = 16;
            // 
            // txtViewMemberAddress1
            // 
            this.txtViewMemberAddress1.Location = new System.Drawing.Point(120, 224);
            this.txtViewMemberAddress1.Name = "txtViewMemberAddress1";
            this.txtViewMemberAddress1.ReadOnly = true;
            this.txtViewMemberAddress1.Size = new System.Drawing.Size(200, 20);
            this.txtViewMemberAddress1.TabIndex = 17;
            // 
            // txtViewMemberAddress2
            // 
            this.txtViewMemberAddress2.Location = new System.Drawing.Point(120, 257);
            this.txtViewMemberAddress2.Name = "txtViewMemberAddress2";
            this.txtViewMemberAddress2.ReadOnly = true;
            this.txtViewMemberAddress2.Size = new System.Drawing.Size(200, 20);
            this.txtViewMemberAddress2.TabIndex = 18;
            // 
            // txtViewMemberTown
            // 
            this.txtViewMemberTown.Location = new System.Drawing.Point(120, 293);
            this.txtViewMemberTown.Name = "txtViewMemberTown";
            this.txtViewMemberTown.ReadOnly = true;
            this.txtViewMemberTown.Size = new System.Drawing.Size(200, 20);
            this.txtViewMemberTown.TabIndex = 19;
            // 
            // txtViewMemberCounty
            // 
            this.txtViewMemberCounty.Location = new System.Drawing.Point(120, 326);
            this.txtViewMemberCounty.Name = "txtViewMemberCounty";
            this.txtViewMemberCounty.ReadOnly = true;
            this.txtViewMemberCounty.Size = new System.Drawing.Size(200, 20);
            this.txtViewMemberCounty.TabIndex = 20;
            // 
            // txtViewMemberEircode
            // 
            this.txtViewMemberEircode.Location = new System.Drawing.Point(120, 359);
            this.txtViewMemberEircode.Name = "txtViewMemberEircode";
            this.txtViewMemberEircode.ReadOnly = true;
            this.txtViewMemberEircode.Size = new System.Drawing.Size(200, 20);
            this.txtViewMemberEircode.TabIndex = 21;
            // 
            // frmViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 493);
            this.Controls.Add(this.grpViewMember);
            this.Controls.Add(this.btnViewMemberSearch);
            this.Controls.Add(this.txtViewMemberID);
            this.Controls.Add(this.lblViewMemberID);
            this.Controls.Add(this.mnuViewMember);
            this.MainMenuStrip = this.mnuViewMember;
            this.Name = "frmViewMember";
            this.Text = "Members - [View Member]";
            this.Load += new System.EventHandler(this.frmViewMember_Load);
            this.mnuViewMember.ResumeLayout(false);
            this.mnuViewMember.PerformLayout();
            this.grpViewMember.ResumeLayout(false);
            this.grpViewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuViewMember;
        private System.Windows.Forms.ToolStripMenuItem mnuViewMemberExit;
        private System.Windows.Forms.Label lblViewMemberID;
        private System.Windows.Forms.TextBox txtViewMemberID;
        private System.Windows.Forms.Button btnViewMemberSearch;
        private System.Windows.Forms.GroupBox grpViewMember;
        private System.Windows.Forms.Label lblViewMemberidentifier;
        private System.Windows.Forms.Label lblUpdateMemberEircode;
        private System.Windows.Forms.Label lblViewMemberCounty;
        private System.Windows.Forms.Label lblViewMemberTown;
        private System.Windows.Forms.Label lblViewMemberAddress2;
        private System.Windows.Forms.Label lblViewMemberAddress1;
        private System.Windows.Forms.Label lblViewMemberEmail;
        private System.Windows.Forms.Label lblViewMemberPhone;
        private System.Windows.Forms.Label lblViewMemberDOB;
        private System.Windows.Forms.Label lblViewMemberLName;
        private System.Windows.Forms.Label lblViewMemberFName;
        private System.Windows.Forms.TextBox txtViewMemberLName;
        private System.Windows.Forms.TextBox txtViewMemberFName;
        private System.Windows.Forms.TextBox txtViewMemberidentifier;
        private System.Windows.Forms.TextBox txtViewMemberEircode;
        private System.Windows.Forms.TextBox txtViewMemberCounty;
        private System.Windows.Forms.TextBox txtViewMemberTown;
        private System.Windows.Forms.TextBox txtViewMemberAddress2;
        private System.Windows.Forms.TextBox txtViewMemberAddress1;
        private System.Windows.Forms.TextBox txtViewMemberEmail;
        private System.Windows.Forms.TextBox txtViewMemberPhone;
        private System.Windows.Forms.DateTimePicker dtpViewMemberDOB;
    }
}