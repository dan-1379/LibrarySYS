using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarySYS
{
    public partial class frmAddMember : Form
    {
        frmMainMenu parent;

        public frmAddMember()
        {
            InitializeComponent();
        }

        public frmAddMember(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmAddMember_Load(object sender, EventArgs e)
        {
          
        }

        private void mnuAddMemberExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                parent.Visible = true;
                this.Close();
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            string memberID = "M001";
            string firstName = txtAddMemberFName.Text.Trim();
            string lastName = txtAddMemberLName.Text.Trim();
            string dob = txtAddMemberDOB.Text.Trim();
            string phone = txtAddMemberPhone.Text.Trim();
            string email = txtAddMemberEmail.Text.Trim();
            string address1 = txtAddMemberAddress1.Text.Trim();
            string address2 = txtAddMemberAddress2.Text.Trim();
            string town = txtAddMemberTown.Text.Trim();
            string county = txtAddMemberCounty.Text.Trim();
            string eircode = txtAddMemberEircode.Text.Trim();
            string registrationDate = DateTime.Now.ToString("dd/MM/yyyy");

            MessageBox.Show("MEMBER ADDED SUCCESSFULLY\n\n" +
                $"\nMember ID: \n{memberID}" +
                $"\n\nFirst Name: \n{firstName}" +
                $"\n\nLast Name: \n{lastName}" +
                $"\n\nD.O.B: \n{dob}" +
                $"\n\nPhone: \n{phone}" +
                $"\n\nEmail: \n{email}" +
                $"\n\nAddress Line 1: \n{address1}" +
                $"\n\nAddress Line 2: \n{address2}" +
                $"\n\nTown: \n{town}" +
                $"\n\nCounty: \n{county}" +
                $"\n\nEircode: \n{eircode}" +
                $"\n\nRegistration Date: \n{registrationDate}",
                "Success");

            txtAddMemberFName.Clear();
            txtAddMemberLName.Clear();
            txtAddMemberDOB.Clear();
            txtAddMemberPhone.Clear();
            txtAddMemberEmail.Clear();
            txtAddMemberAddress1.Clear();
            txtAddMemberAddress2.Clear();
            txtAddMemberTown.Clear();
            txtAddMemberCounty.Clear();
            txtAddMemberEircode.Clear();
            txtAddMemberFName.Focus();
        }

        private void frmAddMember_Shown(object sender, EventArgs e)
        {
            txtAddMemberFName.Focus();
        }
    }
}
