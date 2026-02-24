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

            if (!MemberValidator.IsValidFirstName(firstName))
            {
                MessageBox.Show("Please enter a valid first name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!MemberValidator.IsValidLastName(lastName))
            {
                MessageBox.Show("Please enter a valid last name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!MemberValidator.IsValidDOB(dob))
            {
                MessageBox.Show("Please enter a valid date of birth that is not a future date and is does not exeed 120 years .", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkPhoneNumber = MemberValidator.IsValidPhone(phone);

            if (checkPhoneNumber != "valid")
            {
                MessageBox.Show(checkPhoneNumber, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkEmail = MemberValidator.IsValidEmail(email);

            if (checkEmail != "valid")
            {
                MessageBox.Show(checkEmail, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!MemberValidator.IsValidCounty(county))
            {
                MessageBox.Show("Please enter a valid county.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkEircode = MemberValidator.IsValidEircode(eircode);

            if (checkEircode != "valid")
            {
                MessageBox.Show(checkEircode, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MemberValidator.IsExistingMember(firstName, lastName, phone))
            {
                MessageBox.Show("A member with the same first name, last name, and phone number already exists.", "Duplicate Member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
