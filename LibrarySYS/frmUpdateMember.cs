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
    public partial class frmUpdateMember : Form
    {
        frmMainMenu parent;

        String[] testData = {"Dan", "Courtney", "12/02/2004", "0874651234", "dcourtney@gmail.com",
                            "12 Downing Street", "Rockfeller",  "Tralee", "Kerry", "V94 X2H6"};

        public frmUpdateMember()
        {
            InitializeComponent();
        }

        public frmUpdateMember(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void mnuUpdateMemberExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                parent.Visible = true;
                this.Close();
            }
        }

        private void btnUpdateMemberSearch_Click(object sender, EventArgs e)
        {
            grpUpdateMember.Visible = true;

            txtUpdateMemberFName.Text = testData[0];
            txtUpdateMemberLName.Text = testData[1];
            dtpUpdateMemberDOB.Value = DateTime.Parse(testData[2]);
            txtUpdateMemberPhone.Text = testData[3];
            txtUpdateMemberEmail.Text = testData[4];
            txtUpdateMemberAddress1.Text = testData[5];
            txtUpdateMemberAddress2.Text = testData[6];
            txtUpdateMemberTown.Text = testData[7];
            txtUpdateMemberCounty.Text = testData[8];
            txtUpdateMemberEircode.Text = testData[9];
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            grpUpdateMember.Visible = false;
        }

        private void btnUpdateMemberUpdate_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show(
                $"Are you sure you want to update?\n\nUpdated Details:" +
                $"\nFirst Name: " + txtUpdateMemberFName.Text +
                $"\nLast Name: " + txtUpdateMemberLName.Text +
                $"\nDate Of Birth: " + dtpUpdateMemberDOB.Value +
                $"\nPhone: " + txtUpdateMemberPhone.Text +
                $"\nEmail: " + txtUpdateMemberEmail.Text +
                $"\nAddress Line 1: " + txtUpdateMemberAddress1.Text +
                $"\nAddress Line 2: " + txtUpdateMemberAddress2.Text +
                $"\nTown / City: " + txtUpdateMemberTown.Text +
                $"\nCounty: " + txtUpdateMemberCounty.Text +
                $"\nEircode: " + txtUpdateMemberEircode.Text,
                "Confirm Update", MessageBoxButtons.YesNo
            );

            testData[0] = txtUpdateMemberFName.Text;
            testData[1] = txtUpdateMemberLName.Text;
            testData[2] = dtpUpdateMemberDOB.Text;
            testData[3] = txtUpdateMemberPhone.Text;
            testData[4] = txtUpdateMemberEmail.Text;
            testData[5] = txtUpdateMemberAddress1.Text;
            testData[6] = txtUpdateMemberAddress2.Text;
            testData[7] = txtUpdateMemberTown.Text;
            testData[8] = txtUpdateMemberCounty.Text;
            testData[9] = txtUpdateMemberEircode.Text;

            if (confirmExit == DialogResult.Yes)
            {
                MessageBox.Show($"Member: {testData[0]} {testData[1]} updated successfully.", "Update Successful");
                grpUpdateMember.Visible = false;
                txtUpdateMemberID.Clear();
                txtUpdateMemberID.Focus();
            }
        }
    }
}
