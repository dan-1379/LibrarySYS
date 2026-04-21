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
            this.btnProcessReturnSearchID = new System.Windows.Forms.Button();
            this.txtProcessReturnMemberID = new System.Windows.Forms.TextBox();
            this.lblProcessReturnMemberID = new System.Windows.Forms.Label();
            this.grpProcessReturn = new System.Windows.Forms.GroupBox();
            this.btnProcessReturnCancel = new System.Windows.Forms.Button();
            this.btnProcessReturnReturn = new System.Windows.Forms.Button();
            this.clbProcessReturn = new System.Windows.Forms.CheckedListBox();
            this.txtProcessReturnMemberName = new System.Windows.Forms.TextBox();
            this.txtProcessReturnMemberAddress = new System.Windows.Forms.TextBox();
            this.lblProcessReturnMemberName = new System.Windows.Forms.Label();
            this.lblProcessReturnMemberAddress = new System.Windows.Forms.Label();
            this.grpProcessReturnMemberDetails = new System.Windows.Forms.GroupBox();
            this.mnuProcessReturn.SuspendLayout();
            this.grpProcessReturn.SuspendLayout();
            this.grpProcessReturnMemberDetails.SuspendLayout();
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
            // btnProcessReturnSearchID
            // 
            this.btnProcessReturnSearchID.Location = new System.Drawing.Point(252, 19);
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
            // grpProcessReturn
            // 
            this.grpProcessReturn.Controls.Add(this.btnProcessReturnCancel);
            this.grpProcessReturn.Controls.Add(this.btnProcessReturnReturn);
            this.grpProcessReturn.Controls.Add(this.clbProcessReturn);
            this.grpProcessReturn.Location = new System.Drawing.Point(19, 237);
            this.grpProcessReturn.Name = "grpProcessReturn";
            this.grpProcessReturn.Size = new System.Drawing.Size(746, 314);
            this.grpProcessReturn.TabIndex = 25;
            this.grpProcessReturn.TabStop = false;
            this.grpProcessReturn.Text = "Member Loans";
            // 
            // btnProcessReturnCancel
            // 
            this.btnProcessReturnCancel.Location = new System.Drawing.Point(177, 247);
            this.btnProcessReturnCancel.Name = "btnProcessReturnCancel";
            this.btnProcessReturnCancel.Size = new System.Drawing.Size(94, 40);
            this.btnProcessReturnCancel.TabIndex = 2;
            this.btnProcessReturnCancel.Text = "Cancel Return";
            this.btnProcessReturnCancel.UseVisualStyleBackColor = true;
            this.btnProcessReturnCancel.Click += new System.EventHandler(this.btnProcessReturnCancel_Click);
            // 
            // btnProcessReturnReturn
            // 
            this.btnProcessReturnReturn.Location = new System.Drawing.Point(277, 247);
            this.btnProcessReturnReturn.Name = "btnProcessReturnReturn";
            this.btnProcessReturnReturn.Size = new System.Drawing.Size(247, 40);
            this.btnProcessReturnReturn.TabIndex = 1;
            this.btnProcessReturnReturn.Text = "Return Books";
            this.btnProcessReturnReturn.UseVisualStyleBackColor = true;
            this.btnProcessReturnReturn.Click += new System.EventHandler(this.btnProcessReturnReturn_Click);
            // 
            // clbProcessReturn
            // 
            this.clbProcessReturn.FormattingEnabled = true;
            this.clbProcessReturn.Location = new System.Drawing.Point(7, 34);
            this.clbProcessReturn.Name = "clbProcessReturn";
            this.clbProcessReturn.Size = new System.Drawing.Size(715, 184);
            this.clbProcessReturn.TabIndex = 0;
            // 
            // txtProcessReturnMemberName
            // 
            this.txtProcessReturnMemberName.Location = new System.Drawing.Point(71, 28);
            this.txtProcessReturnMemberName.Name = "txtProcessReturnMemberName";
            this.txtProcessReturnMemberName.Size = new System.Drawing.Size(243, 20);
            this.txtProcessReturnMemberName.TabIndex = 26;
            // 
            // txtProcessReturnMemberAddress
            // 
            this.txtProcessReturnMemberAddress.Location = new System.Drawing.Point(71, 75);
            this.txtProcessReturnMemberAddress.Name = "txtProcessReturnMemberAddress";
            this.txtProcessReturnMemberAddress.Size = new System.Drawing.Size(243, 20);
            this.txtProcessReturnMemberAddress.TabIndex = 27;
            // 
            // lblProcessReturnMemberName
            // 
            this.lblProcessReturnMemberName.AutoSize = true;
            this.lblProcessReturnMemberName.Location = new System.Drawing.Point(6, 31);
            this.lblProcessReturnMemberName.Name = "lblProcessReturnMemberName";
            this.lblProcessReturnMemberName.Size = new System.Drawing.Size(38, 13);
            this.lblProcessReturnMemberName.TabIndex = 28;
            this.lblProcessReturnMemberName.Text = "Name:";
            // 
            // lblProcessReturnMemberAddress
            // 
            this.lblProcessReturnMemberAddress.AutoSize = true;
            this.lblProcessReturnMemberAddress.Location = new System.Drawing.Point(6, 75);
            this.lblProcessReturnMemberAddress.Name = "lblProcessReturnMemberAddress";
            this.lblProcessReturnMemberAddress.Size = new System.Drawing.Size(48, 13);
            this.lblProcessReturnMemberAddress.TabIndex = 29;
            this.lblProcessReturnMemberAddress.Text = "Address:";
            // 
            // grpProcessReturnMemberDetails
            // 
            this.grpProcessReturnMemberDetails.Controls.Add(this.lblProcessReturnMemberName);
            this.grpProcessReturnMemberDetails.Controls.Add(this.lblProcessReturnMemberAddress);
            this.grpProcessReturnMemberDetails.Controls.Add(this.txtProcessReturnMemberName);
            this.grpProcessReturnMemberDetails.Controls.Add(this.txtProcessReturnMemberAddress);
            this.grpProcessReturnMemberDetails.Location = new System.Drawing.Point(19, 76);
            this.grpProcessReturnMemberDetails.Name = "grpProcessReturnMemberDetails";
            this.grpProcessReturnMemberDetails.Size = new System.Drawing.Size(342, 114);
            this.grpProcessReturnMemberDetails.TabIndex = 30;
            this.grpProcessReturnMemberDetails.TabStop = false;
            this.grpProcessReturnMemberDetails.Text = "Member Details";
            // 
            // frmProcessReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.grpProcessReturnMemberDetails);
            this.Controls.Add(this.grpProcessReturn);
            this.Controls.Add(this.btnProcessReturnSearchID);
            this.Controls.Add(this.txtProcessReturnMemberID);
            this.Controls.Add(this.mnuProcessReturn);
            this.Controls.Add(this.lblProcessReturnMemberID);
            this.Name = "frmProcessReturn";
            this.ShowIcon = false;
            this.Text = "Loans - [Process Return]";
            this.Load += new System.EventHandler(this.frmProcessReturn_Load);
            this.mnuProcessReturn.ResumeLayout(false);
            this.mnuProcessReturn.PerformLayout();
            this.grpProcessReturn.ResumeLayout(false);
            this.grpProcessReturnMemberDetails.ResumeLayout(false);
            this.grpProcessReturnMemberDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuProcessReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuProcessLoanExit;
        private System.Windows.Forms.Button btnProcessReturnSearchID;
        private System.Windows.Forms.TextBox txtProcessReturnMemberID;
        private System.Windows.Forms.Label lblProcessReturnMemberID;
        private System.Windows.Forms.GroupBox grpProcessReturn;
        private System.Windows.Forms.CheckedListBox clbProcessReturn;
        private System.Windows.Forms.TextBox txtProcessReturnMemberName;
        private System.Windows.Forms.TextBox txtProcessReturnMemberAddress;
        private System.Windows.Forms.Label lblProcessReturnMemberName;
        private System.Windows.Forms.Label lblProcessReturnMemberAddress;
        private System.Windows.Forms.Button btnProcessReturnReturn;
        private System.Windows.Forms.GroupBox grpProcessReturnMemberDetails;
        private System.Windows.Forms.Button btnProcessReturnCancel;
    }
}