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
            this.grdViewMember = new System.Windows.Forms.DataGridView();
            this.mnuViewMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewMember)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuViewMember
            // 
            this.mnuViewMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewMemberExit});
            this.mnuViewMember.Location = new System.Drawing.Point(0, 0);
            this.mnuViewMember.Name = "mnuViewMember";
            this.mnuViewMember.Size = new System.Drawing.Size(1497, 24);
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
            // grdViewMember
            // 
            this.grdViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewMember.Location = new System.Drawing.Point(12, 50);
            this.grdViewMember.Name = "grdViewMember";
            this.grdViewMember.Size = new System.Drawing.Size(1448, 256);
            this.grdViewMember.TabIndex = 1;
            // 
            // frmViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 343);
            this.Controls.Add(this.grdViewMember);
            this.Controls.Add(this.mnuViewMember);
            this.MainMenuStrip = this.mnuViewMember;
            this.Name = "frmViewMember";
            this.Text = "Members - [View Member]";
            this.Load += new System.EventHandler(this.frmViewMember_Load);
            this.mnuViewMember.ResumeLayout(false);
            this.mnuViewMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuViewMember;
        private System.Windows.Forms.ToolStripMenuItem mnuViewMemberExit;
        private System.Windows.Forms.DataGridView grdViewMember;
    }
}