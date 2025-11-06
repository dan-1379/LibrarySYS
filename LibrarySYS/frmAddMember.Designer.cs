namespace LibrarySYS
{
    partial class frmAddMember
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
            this.mnuAddMember = new System.Windows.Forms.MenuStrip();
            this.mnuAddMemberExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAddMember = new System.Windows.Forms.GroupBox();
            this.lblAddMemberFName = new System.Windows.Forms.Label();
            this.lblAddMemberLName = new System.Windows.Forms.Label();
            this.lblAddMemberDOB = new System.Windows.Forms.Label();
            this.lblAddMemberPhone = new System.Windows.Forms.Label();
            this.lblAddMemberEmail = new System.Windows.Forms.Label();
            this.lblAddMemberAddress1 = new System.Windows.Forms.Label();
            this.lblAddMemberAddress2 = new System.Windows.Forms.Label();
            this.lblAddMemberTown = new System.Windows.Forms.Label();
            this.lblAddMemberCounty = new System.Windows.Forms.Label();
            this.lblAddMemberEircode = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.txtAddMemberFName = new System.Windows.Forms.TextBox();
            this.txtAddMemberLName = new System.Windows.Forms.TextBox();
            this.txtAddMemberDOB = new System.Windows.Forms.TextBox();
            this.txtAddMemberPhone = new System.Windows.Forms.TextBox();
            this.txtAddMemberEmail = new System.Windows.Forms.TextBox();
            this.txtAddMemberAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddMemberAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddMemberTown = new System.Windows.Forms.TextBox();
            this.txtAddMemberCounty = new System.Windows.Forms.TextBox();
            this.txtAddMemberEircode = new System.Windows.Forms.TextBox();
            this.mnuAddMember.SuspendLayout();
            this.grpAddMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAddMember
            // 
            this.mnuAddMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMemberExit});
            this.mnuAddMember.Location = new System.Drawing.Point(0, 0);
            this.mnuAddMember.Name = "mnuAddMember";
            this.mnuAddMember.Size = new System.Drawing.Size(360, 24);
            this.mnuAddMember.TabIndex = 0;
            this.mnuAddMember.Text = "menuStrip1";
            // 
            // mnuAddMemberExit
            // 
            this.mnuAddMemberExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuAddMemberExit.Name = "mnuAddMemberExit";
            this.mnuAddMemberExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuAddMemberExit.Size = new System.Drawing.Size(37, 20);
            this.mnuAddMemberExit.Text = "Exit";
            this.mnuAddMemberExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuAddMemberExit.Click += new System.EventHandler(this.mnuAddMemberExit_Click);
            // 
            // grpAddMember
            // 
            this.grpAddMember.Controls.Add(this.txtAddMemberEircode);
            this.grpAddMember.Controls.Add(this.txtAddMemberCounty);
            this.grpAddMember.Controls.Add(this.txtAddMemberTown);
            this.grpAddMember.Controls.Add(this.txtAddMemberAddress2);
            this.grpAddMember.Controls.Add(this.txtAddMemberAddress1);
            this.grpAddMember.Controls.Add(this.txtAddMemberEmail);
            this.grpAddMember.Controls.Add(this.txtAddMemberPhone);
            this.grpAddMember.Controls.Add(this.txtAddMemberDOB);
            this.grpAddMember.Controls.Add(this.txtAddMemberLName);
            this.grpAddMember.Controls.Add(this.txtAddMemberFName);
            this.grpAddMember.Controls.Add(this.btnAddMember);
            this.grpAddMember.Controls.Add(this.lblAddMemberEircode);
            this.grpAddMember.Controls.Add(this.lblAddMemberCounty);
            this.grpAddMember.Controls.Add(this.lblAddMemberTown);
            this.grpAddMember.Controls.Add(this.lblAddMemberAddress2);
            this.grpAddMember.Controls.Add(this.lblAddMemberAddress1);
            this.grpAddMember.Controls.Add(this.lblAddMemberEmail);
            this.grpAddMember.Controls.Add(this.lblAddMemberPhone);
            this.grpAddMember.Controls.Add(this.lblAddMemberDOB);
            this.grpAddMember.Controls.Add(this.lblAddMemberLName);
            this.grpAddMember.Controls.Add(this.lblAddMemberFName);
            this.grpAddMember.Location = new System.Drawing.Point(13, 28);
            this.grpAddMember.Name = "grpAddMember";
            this.grpAddMember.Size = new System.Drawing.Size(318, 467);
            this.grpAddMember.TabIndex = 1;
            this.grpAddMember.TabStop = false;
            this.grpAddMember.Text = "Add Member";
            // 
            // lblAddMemberFName
            // 
            this.lblAddMemberFName.AutoSize = true;
            this.lblAddMemberFName.Location = new System.Drawing.Point(7, 33);
            this.lblAddMemberFName.Name = "lblAddMemberFName";
            this.lblAddMemberFName.Size = new System.Drawing.Size(60, 13);
            this.lblAddMemberFName.TabIndex = 0;
            this.lblAddMemberFName.Text = "First Name:";
            // 
            // lblAddMemberLName
            // 
            this.lblAddMemberLName.AutoSize = true;
            this.lblAddMemberLName.Location = new System.Drawing.Point(6, 71);
            this.lblAddMemberLName.Name = "lblAddMemberLName";
            this.lblAddMemberLName.Size = new System.Drawing.Size(61, 13);
            this.lblAddMemberLName.TabIndex = 1;
            this.lblAddMemberLName.Text = "Last Name:";
            // 
            // lblAddMemberDOB
            // 
            this.lblAddMemberDOB.AutoSize = true;
            this.lblAddMemberDOB.Location = new System.Drawing.Point(4, 102);
            this.lblAddMemberDOB.Name = "lblAddMemberDOB";
            this.lblAddMemberDOB.Size = new System.Drawing.Size(39, 13);
            this.lblAddMemberDOB.TabIndex = 2;
            this.lblAddMemberDOB.Text = "D.O.B:";
            // 
            // lblAddMemberPhone
            // 
            this.lblAddMemberPhone.AutoSize = true;
            this.lblAddMemberPhone.Location = new System.Drawing.Point(6, 134);
            this.lblAddMemberPhone.Name = "lblAddMemberPhone";
            this.lblAddMemberPhone.Size = new System.Drawing.Size(41, 13);
            this.lblAddMemberPhone.TabIndex = 3;
            this.lblAddMemberPhone.Text = "Phone:";
            // 
            // lblAddMemberEmail
            // 
            this.lblAddMemberEmail.AutoSize = true;
            this.lblAddMemberEmail.Location = new System.Drawing.Point(6, 174);
            this.lblAddMemberEmail.Name = "lblAddMemberEmail";
            this.lblAddMemberEmail.Size = new System.Drawing.Size(35, 13);
            this.lblAddMemberEmail.TabIndex = 4;
            this.lblAddMemberEmail.Text = "Email:";
            // 
            // lblAddMemberAddress1
            // 
            this.lblAddMemberAddress1.AutoSize = true;
            this.lblAddMemberAddress1.Location = new System.Drawing.Point(6, 209);
            this.lblAddMemberAddress1.Name = "lblAddMemberAddress1";
            this.lblAddMemberAddress1.Size = new System.Drawing.Size(80, 13);
            this.lblAddMemberAddress1.TabIndex = 5;
            this.lblAddMemberAddress1.Text = "Address Line 1:";
            // 
            // lblAddMemberAddress2
            // 
            this.lblAddMemberAddress2.AutoSize = true;
            this.lblAddMemberAddress2.Location = new System.Drawing.Point(6, 246);
            this.lblAddMemberAddress2.Name = "lblAddMemberAddress2";
            this.lblAddMemberAddress2.Size = new System.Drawing.Size(80, 13);
            this.lblAddMemberAddress2.TabIndex = 6;
            this.lblAddMemberAddress2.Text = "Address Line 2:";
            // 
            // lblAddMemberTown
            // 
            this.lblAddMemberTown.AutoSize = true;
            this.lblAddMemberTown.Location = new System.Drawing.Point(6, 283);
            this.lblAddMemberTown.Name = "lblAddMemberTown";
            this.lblAddMemberTown.Size = new System.Drawing.Size(65, 13);
            this.lblAddMemberTown.TabIndex = 7;
            this.lblAddMemberTown.Text = "Town / City:";
            // 
            // lblAddMemberCounty
            // 
            this.lblAddMemberCounty.AutoSize = true;
            this.lblAddMemberCounty.Location = new System.Drawing.Point(4, 327);
            this.lblAddMemberCounty.Name = "lblAddMemberCounty";
            this.lblAddMemberCounty.Size = new System.Drawing.Size(43, 13);
            this.lblAddMemberCounty.TabIndex = 8;
            this.lblAddMemberCounty.Text = "County:";
            // 
            // lblAddMemberEircode
            // 
            this.lblAddMemberEircode.AutoSize = true;
            this.lblAddMemberEircode.Location = new System.Drawing.Point(6, 367);
            this.lblAddMemberEircode.Name = "lblAddMemberEircode";
            this.lblAddMemberEircode.Size = new System.Drawing.Size(46, 13);
            this.lblAddMemberEircode.TabIndex = 9;
            this.lblAddMemberEircode.Text = "Eircode:";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(9, 414);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(288, 38);
            this.btnAddMember.TabIndex = 10;
            this.btnAddMember.Text = "Save Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // txtAddMemberFName
            // 
            this.txtAddMemberFName.Location = new System.Drawing.Point(107, 30);
            this.txtAddMemberFName.Name = "txtAddMemberFName";
            this.txtAddMemberFName.Size = new System.Drawing.Size(190, 20);
            this.txtAddMemberFName.TabIndex = 11;
            // 
            // txtAddMemberLName
            // 
            this.txtAddMemberLName.Location = new System.Drawing.Point(107, 68);
            this.txtAddMemberLName.Name = "txtAddMemberLName";
            this.txtAddMemberLName.Size = new System.Drawing.Size(190, 20);
            this.txtAddMemberLName.TabIndex = 12;
            // 
            // txtAddMemberDOB
            // 
            this.txtAddMemberDOB.Location = new System.Drawing.Point(107, 99);
            this.txtAddMemberDOB.Name = "txtAddMemberDOB";
            this.txtAddMemberDOB.Size = new System.Drawing.Size(190, 20);
            this.txtAddMemberDOB.TabIndex = 13;
            // 
            // txtAddMemberPhone
            // 
            this.txtAddMemberPhone.Location = new System.Drawing.Point(107, 131);
            this.txtAddMemberPhone.Name = "txtAddMemberPhone";
            this.txtAddMemberPhone.Size = new System.Drawing.Size(190, 20);
            this.txtAddMemberPhone.TabIndex = 14;
            // 
            // txtAddMemberEmail
            // 
            this.txtAddMemberEmail.Location = new System.Drawing.Point(107, 171);
            this.txtAddMemberEmail.Name = "txtAddMemberEmail";
            this.txtAddMemberEmail.Size = new System.Drawing.Size(190, 20);
            this.txtAddMemberEmail.TabIndex = 15;
            // 
            // txtAddMemberAddress1
            // 
            this.txtAddMemberAddress1.Location = new System.Drawing.Point(107, 206);
            this.txtAddMemberAddress1.Name = "txtAddMemberAddress1";
            this.txtAddMemberAddress1.Size = new System.Drawing.Size(190, 20);
            this.txtAddMemberAddress1.TabIndex = 16;
            // 
            // txtAddMemberAddress2
            // 
            this.txtAddMemberAddress2.Location = new System.Drawing.Point(107, 243);
            this.txtAddMemberAddress2.Name = "txtAddMemberAddress2";
            this.txtAddMemberAddress2.Size = new System.Drawing.Size(190, 20);
            this.txtAddMemberAddress2.TabIndex = 17;
            // 
            // txtAddMemberTown
            // 
            this.txtAddMemberTown.Location = new System.Drawing.Point(107, 280);
            this.txtAddMemberTown.Name = "txtAddMemberTown";
            this.txtAddMemberTown.Size = new System.Drawing.Size(190, 20);
            this.txtAddMemberTown.TabIndex = 18;
            // 
            // txtAddMemberCounty
            // 
            this.txtAddMemberCounty.Location = new System.Drawing.Point(107, 324);
            this.txtAddMemberCounty.Name = "txtAddMemberCounty";
            this.txtAddMemberCounty.Size = new System.Drawing.Size(190, 20);
            this.txtAddMemberCounty.TabIndex = 19;
            // 
            // txtAddMemberEircode
            // 
            this.txtAddMemberEircode.Location = new System.Drawing.Point(107, 364);
            this.txtAddMemberEircode.Name = "txtAddMemberEircode";
            this.txtAddMemberEircode.Size = new System.Drawing.Size(190, 20);
            this.txtAddMemberEircode.TabIndex = 20;
            // 
            // frmAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 507);
            this.Controls.Add(this.grpAddMember);
            this.Controls.Add(this.mnuAddMember);
            this.MainMenuStrip = this.mnuAddMember;
            this.Name = "frmAddMember";
            this.Text = "frmAddMember";
            this.Load += new System.EventHandler(this.frmAddMember_Load);
            this.Shown += new System.EventHandler(this.frmAddMember_Shown);
            this.mnuAddMember.ResumeLayout(false);
            this.mnuAddMember.PerformLayout();
            this.grpAddMember.ResumeLayout(false);
            this.grpAddMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAddMember;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMemberExit;
        private System.Windows.Forms.GroupBox grpAddMember;
        private System.Windows.Forms.Label lblAddMemberPhone;
        private System.Windows.Forms.Label lblAddMemberDOB;
        private System.Windows.Forms.Label lblAddMemberLName;
        private System.Windows.Forms.Label lblAddMemberFName;
        private System.Windows.Forms.Label lblAddMemberEircode;
        private System.Windows.Forms.Label lblAddMemberCounty;
        private System.Windows.Forms.Label lblAddMemberTown;
        private System.Windows.Forms.Label lblAddMemberAddress2;
        private System.Windows.Forms.Label lblAddMemberAddress1;
        private System.Windows.Forms.Label lblAddMemberEmail;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.TextBox txtAddMemberEircode;
        private System.Windows.Forms.TextBox txtAddMemberCounty;
        private System.Windows.Forms.TextBox txtAddMemberTown;
        private System.Windows.Forms.TextBox txtAddMemberAddress2;
        private System.Windows.Forms.TextBox txtAddMemberAddress1;
        private System.Windows.Forms.TextBox txtAddMemberEmail;
        private System.Windows.Forms.TextBox txtAddMemberPhone;
        private System.Windows.Forms.TextBox txtAddMemberDOB;
        private System.Windows.Forms.TextBox txtAddMemberLName;
        private System.Windows.Forms.TextBox txtAddMemberFName;
    }
}