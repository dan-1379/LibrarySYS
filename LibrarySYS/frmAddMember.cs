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
using System.Windows.Forms.DataVisualization.Charting;
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
            string firstName = txtAddMemberFName.Text.Trim();
            string lastName = txtAddMemberLName.Text.Trim();
            DateTime dob = dtpAddMemberDOB.Value;
            string phone = txtAddMemberPhone.Text.Trim();
            string email = txtAddMemberEmail.Text.Trim();
            string address1 = txtAddMemberAddress1.Text.Trim();
            string address2 = txtAddMemberAddress2.Text.Trim();
            string city = txtAddMemberTown.Text.Trim();
            string county = txtAddMemberCounty.Text.Trim();
            string eircode = txtAddMemberEircode.Text.Trim();

            int memberID = Member.GetNextMemberID();
            
            Member newMember = new Member(memberID, firstName, lastName, dob, phone, email, address1, address2, city, county, eircode);
            newMember.AddMember();

            MessageBox.Show("Member added successfully!\n" +
                $"{firstName}{lastName} is now a registered member", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtAddMemberFName.Clear();
            txtAddMemberLName.Clear();
            dtpAddMemberDOB.Value = DateTime.Now;
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
