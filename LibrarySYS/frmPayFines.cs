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

        public frmPayFines(Form Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmPayFines_Load(object sender, EventArgs e)
        {

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
            MessageBox.Show("Fines Paid Successfully!", "Payment Confirmation");
            this.Close();
            parent.Visible = true;
        }
    }
}
