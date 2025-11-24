namespace LibrarySYS
{
    partial class frmPayFines
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
            this.mnuPayFines = new System.Windows.Forms.MenuStrip();
            this.mnuPayFinesExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPayFinesMemberID = new System.Windows.Forms.Label();
            this.txtPayFinesMemberID = new System.Windows.Forms.TextBox();
            this.lblPayFinesTotalAmount = new System.Windows.Forms.Label();
            this.txtPayFinesTotalAmount = new System.Windows.Forms.TextBox();
            this.lblPayFinesCardNumber = new System.Windows.Forms.Label();
            this.txtPayFinesCardNumber = new System.Windows.Forms.TextBox();
            this.lblPayFinesExpiryDate = new System.Windows.Forms.Label();
            this.lblPayFinesCVV = new System.Windows.Forms.Label();
            this.lblPayFinesCardName = new System.Windows.Forms.Label();
            this.txtPayFinesExpiryDate = new System.Windows.Forms.TextBox();
            this.txtPayFinesCVV = new System.Windows.Forms.TextBox();
            this.txtPayFinesCardName = new System.Windows.Forms.TextBox();
            this.btnPayFinesPay = new System.Windows.Forms.Button();
            this.mnuPayFines.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPayFines
            // 
            this.mnuPayFines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPayFinesExit});
            this.mnuPayFines.Location = new System.Drawing.Point(0, 0);
            this.mnuPayFines.Name = "mnuPayFines";
            this.mnuPayFines.Size = new System.Drawing.Size(550, 24);
            this.mnuPayFines.TabIndex = 0;
            this.mnuPayFines.Text = "menuStrip1";
            // 
            // mnuPayFinesExit
            // 
            this.mnuPayFinesExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuPayFinesExit.Name = "mnuPayFinesExit";
            this.mnuPayFinesExit.Size = new System.Drawing.Size(37, 20);
            this.mnuPayFinesExit.Text = "Exit";
            this.mnuPayFinesExit.Click += new System.EventHandler(this.mnuPayFinesExit_Click);
            // 
            // lblPayFinesMemberID
            // 
            this.lblPayFinesMemberID.AutoSize = true;
            this.lblPayFinesMemberID.Location = new System.Drawing.Point(12, 39);
            this.lblPayFinesMemberID.Name = "lblPayFinesMemberID";
            this.lblPayFinesMemberID.Size = new System.Drawing.Size(62, 13);
            this.lblPayFinesMemberID.TabIndex = 1;
            this.lblPayFinesMemberID.Text = "Member ID:";
            // 
            // txtPayFinesMemberID
            // 
            this.txtPayFinesMemberID.Location = new System.Drawing.Point(94, 36);
            this.txtPayFinesMemberID.Name = "txtPayFinesMemberID";
            this.txtPayFinesMemberID.Size = new System.Drawing.Size(140, 20);
            this.txtPayFinesMemberID.TabIndex = 2;
            // 
            // lblPayFinesTotalAmount
            // 
            this.lblPayFinesTotalAmount.AutoSize = true;
            this.lblPayFinesTotalAmount.Location = new System.Drawing.Point(263, 39);
            this.lblPayFinesTotalAmount.Name = "lblPayFinesTotalAmount";
            this.lblPayFinesTotalAmount.Size = new System.Drawing.Size(96, 13);
            this.lblPayFinesTotalAmount.TabIndex = 3;
            this.lblPayFinesTotalAmount.Text = "Total Fine Amount:";
            // 
            // txtPayFinesTotalAmount
            // 
            this.txtPayFinesTotalAmount.Location = new System.Drawing.Point(365, 36);
            this.txtPayFinesTotalAmount.Name = "txtPayFinesTotalAmount";
            this.txtPayFinesTotalAmount.Size = new System.Drawing.Size(134, 20);
            this.txtPayFinesTotalAmount.TabIndex = 4;
            // 
            // lblPayFinesCardNumber
            // 
            this.lblPayFinesCardNumber.AutoSize = true;
            this.lblPayFinesCardNumber.Location = new System.Drawing.Point(15, 89);
            this.lblPayFinesCardNumber.Name = "lblPayFinesCardNumber";
            this.lblPayFinesCardNumber.Size = new System.Drawing.Size(72, 13);
            this.lblPayFinesCardNumber.TabIndex = 5;
            this.lblPayFinesCardNumber.Text = "Card Number:";
            // 
            // txtPayFinesCardNumber
            // 
            this.txtPayFinesCardNumber.Location = new System.Drawing.Point(94, 89);
            this.txtPayFinesCardNumber.Name = "txtPayFinesCardNumber";
            this.txtPayFinesCardNumber.Size = new System.Drawing.Size(140, 20);
            this.txtPayFinesCardNumber.TabIndex = 6;
            // 
            // lblPayFinesExpiryDate
            // 
            this.lblPayFinesExpiryDate.AutoSize = true;
            this.lblPayFinesExpiryDate.Location = new System.Drawing.Point(263, 92);
            this.lblPayFinesExpiryDate.Name = "lblPayFinesExpiryDate";
            this.lblPayFinesExpiryDate.Size = new System.Drawing.Size(64, 13);
            this.lblPayFinesExpiryDate.TabIndex = 7;
            this.lblPayFinesExpiryDate.Text = "Expiry Date:";
            // 
            // lblPayFinesCVV
            // 
            this.lblPayFinesCVV.AutoSize = true;
            this.lblPayFinesCVV.Location = new System.Drawing.Point(263, 144);
            this.lblPayFinesCVV.Name = "lblPayFinesCVV";
            this.lblPayFinesCVV.Size = new System.Drawing.Size(31, 13);
            this.lblPayFinesCVV.TabIndex = 8;
            this.lblPayFinesCVV.Text = "CVV:";
            // 
            // lblPayFinesCardName
            // 
            this.lblPayFinesCardName.AutoSize = true;
            this.lblPayFinesCardName.Location = new System.Drawing.Point(15, 144);
            this.lblPayFinesCardName.Name = "lblPayFinesCardName";
            this.lblPayFinesCardName.Size = new System.Drawing.Size(78, 13);
            this.lblPayFinesCardName.TabIndex = 9;
            this.lblPayFinesCardName.Text = "Name on Card:";
            // 
            // txtPayFinesExpiryDate
            // 
            this.txtPayFinesExpiryDate.Location = new System.Drawing.Point(365, 86);
            this.txtPayFinesExpiryDate.Name = "txtPayFinesExpiryDate";
            this.txtPayFinesExpiryDate.Size = new System.Drawing.Size(134, 20);
            this.txtPayFinesExpiryDate.TabIndex = 10;
            // 
            // txtPayFinesCVV
            // 
            this.txtPayFinesCVV.Location = new System.Drawing.Point(365, 141);
            this.txtPayFinesCVV.Name = "txtPayFinesCVV";
            this.txtPayFinesCVV.Size = new System.Drawing.Size(134, 20);
            this.txtPayFinesCVV.TabIndex = 11;
            this.txtPayFinesCVV.TextChanged += new System.EventHandler(this.txtPayFinesCVV_TextChanged);
            // 
            // txtPayFinesCardName
            // 
            this.txtPayFinesCardName.Location = new System.Drawing.Point(99, 141);
            this.txtPayFinesCardName.Name = "txtPayFinesCardName";
            this.txtPayFinesCardName.Size = new System.Drawing.Size(135, 20);
            this.txtPayFinesCardName.TabIndex = 12;
            // 
            // btnPayFinesPay
            // 
            this.btnPayFinesPay.Location = new System.Drawing.Point(183, 188);
            this.btnPayFinesPay.Name = "btnPayFinesPay";
            this.btnPayFinesPay.Size = new System.Drawing.Size(207, 37);
            this.btnPayFinesPay.TabIndex = 13;
            this.btnPayFinesPay.Text = "Pay Fine";
            this.btnPayFinesPay.UseVisualStyleBackColor = true;
            this.btnPayFinesPay.Click += new System.EventHandler(this.btnPayFinesPay_Click);
            // 
            // frmPayFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 244);
            this.Controls.Add(this.btnPayFinesPay);
            this.Controls.Add(this.txtPayFinesCardName);
            this.Controls.Add(this.txtPayFinesCVV);
            this.Controls.Add(this.txtPayFinesExpiryDate);
            this.Controls.Add(this.lblPayFinesCardName);
            this.Controls.Add(this.lblPayFinesCVV);
            this.Controls.Add(this.lblPayFinesExpiryDate);
            this.Controls.Add(this.txtPayFinesCardNumber);
            this.Controls.Add(this.lblPayFinesCardNumber);
            this.Controls.Add(this.txtPayFinesTotalAmount);
            this.Controls.Add(this.lblPayFinesTotalAmount);
            this.Controls.Add(this.txtPayFinesMemberID);
            this.Controls.Add(this.lblPayFinesMemberID);
            this.Controls.Add(this.mnuPayFines);
            this.MainMenuStrip = this.mnuPayFines;
            this.Name = "frmPayFines";
            this.Text = "Loans - [Pay Fine]";
            this.Load += new System.EventHandler(this.frmPayFines_Load);
            this.mnuPayFines.ResumeLayout(false);
            this.mnuPayFines.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPayFines;
        private System.Windows.Forms.ToolStripMenuItem mnuPayFinesExit;
        private System.Windows.Forms.Label lblPayFinesMemberID;
        private System.Windows.Forms.TextBox txtPayFinesMemberID;
        private System.Windows.Forms.Label lblPayFinesTotalAmount;
        private System.Windows.Forms.TextBox txtPayFinesTotalAmount;
        private System.Windows.Forms.Label lblPayFinesCardNumber;
        private System.Windows.Forms.TextBox txtPayFinesCardNumber;
        private System.Windows.Forms.Label lblPayFinesExpiryDate;
        private System.Windows.Forms.Label lblPayFinesCVV;
        private System.Windows.Forms.Label lblPayFinesCardName;
        private System.Windows.Forms.TextBox txtPayFinesExpiryDate;
        private System.Windows.Forms.TextBox txtPayFinesCVV;
        private System.Windows.Forms.TextBox txtPayFinesCardName;
        private System.Windows.Forms.Button btnPayFinesPay;
    }
}