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
            this.mnuViewMember.SuspendLayout();
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
            // 
            // lblViewMemberID
            // 
            this.lblViewMemberID.AutoSize = true;
            this.lblViewMemberID.Location = new System.Drawing.Point(13, 28);
            this.lblViewMemberID.Name = "lblViewMemberID";
            this.lblViewMemberID.Size = new System.Drawing.Size(90, 13);
            this.lblViewMemberID.TabIndex = 1;
            this.lblViewMemberID.Text = "Enter Member ID:";
            // 
            // txtViewMemberID
            // 
            this.txtViewMemberID.Location = new System.Drawing.Point(110, 28);
            this.txtViewMemberID.Name = "txtViewMemberID";
            this.txtViewMemberID.Size = new System.Drawing.Size(140, 20);
            this.txtViewMemberID.TabIndex = 2;
            // 
            // btnViewMemberSearch
            // 
            this.btnViewMemberSearch.Location = new System.Drawing.Point(278, 26);
            this.btnViewMemberSearch.Name = "btnViewMemberSearch";
            this.btnViewMemberSearch.Size = new System.Drawing.Size(75, 23);
            this.btnViewMemberSearch.TabIndex = 3;
            this.btnViewMemberSearch.Text = "Search";
            this.btnViewMemberSearch.UseVisualStyleBackColor = true;
            // 
            // grpViewMember
            // 
            this.grpViewMember.Location = new System.Drawing.Point(16, 75);
            this.grpViewMember.Name = "grpViewMember";
            this.grpViewMember.Size = new System.Drawing.Size(337, 347);
            this.grpViewMember.TabIndex = 4;
            this.grpViewMember.TabStop = false;
            this.grpViewMember.Text = "View Member";
            // 
            // frmViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.grpViewMember);
            this.Controls.Add(this.btnViewMemberSearch);
            this.Controls.Add(this.txtViewMemberID);
            this.Controls.Add(this.lblViewMemberID);
            this.Controls.Add(this.mnuViewMember);
            this.MainMenuStrip = this.mnuViewMember;
            this.Name = "frmViewMember";
            this.Text = "Members - [View Member]";
            this.mnuViewMember.ResumeLayout(false);
            this.mnuViewMember.PerformLayout();
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
    }
}