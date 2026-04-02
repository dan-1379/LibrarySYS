using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmPayFines : Form
    {
        Form parent;

        public frmPayFines()
        {
            InitializeComponent();
        }

        public frmPayFines(string memberID, Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            txtPayFinesMemberID.Text = memberID;
        }

        private void frmPayFines_Load(object sender, EventArgs e)
        {
            txtPayFinesTotalAmount.Text = Fine.GetOutstandingFines(Convert.ToInt32(txtPayFinesMemberID.Text)).ToString();
        }

        private void txtPayFinesCVV_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuPayFinesExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                parent.Visible = true;
                this.Close();
            }
        }

        private void btnPayFinesPay_Click(object sender, EventArgs e)
        {
            string cardNumber = txtPayFinesCardNumber.Text;
            string expiryDate = txtPayFinesExpiryDate.Text;
            string cardholderName = txtPayFinesCardName.Text;
            string cvv = txtPayFinesCVV.Text;

            string checkCardNumber = CardValidator.IsValidCardNumber(cardNumber);

            if (checkCardNumber != "valid")
            {
                MessageBox.Show(checkCardNumber, "Invalid Card Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkExpiryDate = CardValidator.IsValidExpiryDate(expiryDate);

            if (checkExpiryDate != "valid")
            {
                MessageBox.Show(checkExpiryDate, "Invalid Expiry Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkCardholderName = CardValidator.IsValidCardholderName(cardholderName);

            if (checkCardholderName != "valid")
            {
                MessageBox.Show(checkCardholderName, "Invalid Cardholder Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkCVV = CardValidator.IsValidCVV(cvv);

            if (checkCVV != "valid")
            {
                MessageBox.Show(checkCVV, "Invalid CVV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fine.alterFineStatus(Convert.ToInt32(txtPayFinesMemberID.Text), 'P');
            MessageBox.Show("Fines Paid Successfully!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
