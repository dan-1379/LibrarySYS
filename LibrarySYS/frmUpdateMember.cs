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
        bool memberSelected = false;

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

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            grdUpdateMember.DataSource = Member.getAllMembers().Tables[0];

            Utility.constructGrid(grdUpdateMember);
            Utility.styleGrid(grdUpdateMember);
            Utility.ColourRowsByStatus(grdUpdateMember);
            Utility.StyleInputBoxesActive(grpUpdateMember);
            Utility.StyleButton(btnUpdateMemberUpdate);

            foreach (Control control in grpUpdateMember.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).ReadOnly = true;
                }
                else if (control is DateTimePicker || control is ComboBox)
                {
                    control.Enabled = false;
                }
            }
        }

        private void btnUpdateMemberUpdate_Click(object sender, EventArgs e)
        {
            if (!memberSelected)
            {
                MessageBox.Show("Please select a member to update", "Select member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = txtUpdateMemberFName.Text;

            if (name == null || name == "")
            {
                MessageBox.Show("Please select a member to update", "Select Member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmDelete = MessageBox.Show(
                $"Are you sure you wish to update member:\n{txtUpdateMemberFName.Text} {txtUpdateMemberLName.Text}",
                "Confirm Deletion", MessageBoxButtons.YesNo
            );

            if (confirmDelete != DialogResult.Yes)
            {
                return;
            }

            if (txtUpdateMemberFines.Text != "€0.00")
            {
                MessageBox.Show("Cannot delete member with outstanding fines.", "Deletion Error");
                return;
            }

            int selectedMemberID = Convert.ToInt32(grdUpdateMember.CurrentRow.Cells[0].Value);
            string firstName = txtUpdateMemberFName.Text;
            string lastName = txtUpdateMemberLName.Text;
            DateTime dob = dtpUpdateMemberDOB.Value;

            string phone = txtUpdateMemberPhone.Text;
            string email = txtUpdateMemberEmail.Text;

            string addressLine1 = txtUpdateMemberAddress1.Text;
            string addressLine2 = txtUpdateMemberAddress2.Text;
            string town = txtUpdateMemberTown.Text;
            string county = txtUpdateMemberCounty.Text;
            string eircode = txtUpdateMemberEircode.Text;
            char status = cboUpdateMemberStatus.Text[0];

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

            if (!MemberValidator.IsValidAddressLine1(addressLine1))
            {
                MessageBox.Show("Please enter a valid line 1 address", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!MemberValidator.IsValidAddressLine2(addressLine2))
            {
                MessageBox.Show("Please enter a valid line 2 address", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!MemberValidator.IsValidCity(town))
            {
                MessageBox.Show("Please enter a valid city", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            Member updatedMember = new Member(selectedMemberID, firstName, lastName, Convert.ToDateTime(dob), phone, email, addressLine1, addressLine2, town, county, eircode, status);
            updatedMember.UpdateMemberDetails(selectedMemberID.ToString());


            MessageBox.Show("Member updated successfully.", "Deletion Successful");
            grdUpdateMember.DataSource = Member.getAllMembers().Tables[0];
            Utility.ColourRowsByStatus(grdUpdateMember);

            foreach (Control control in grpUpdateMember.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                    ((TextBox)control).ReadOnly = true;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                    control.Enabled = false;
                }
                else if (control is ComboBox)
                {
                    control.Enabled = false;
                }
            }
        }

        private void grdUpdateMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            memberSelected = true;

            foreach (Control control in grpUpdateMember.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).ReadOnly = false;
                }
                else if (control is DateTimePicker || control is ComboBox)
                {
                    control.Enabled = true;
                }
            }

            txtUpdateMemberFName.Text = grdUpdateMember.CurrentRow.Cells[1].Value.ToString();
            txtUpdateMemberLName.Text = grdUpdateMember.CurrentRow.Cells[2].Value.ToString();

            DateTime dob = Convert.ToDateTime(grdUpdateMember.CurrentRow.Cells[3].Value);
            dtpUpdateMemberDOB.Text = dob.ToString("dd/MM/yyyy");

            txtUpdateMemberPhone.Text = grdUpdateMember.CurrentRow.Cells[4].Value.ToString();
            txtUpdateMemberEmail.Text = grdUpdateMember.CurrentRow.Cells[5].Value.ToString();

            txtUpdateMemberAddress1.Text = grdUpdateMember.CurrentRow.Cells[6].Value.ToString();
            txtUpdateMemberAddress2.Text = grdUpdateMember.CurrentRow.Cells[7].Value.ToString();
            txtUpdateMemberTown.Text = grdUpdateMember.CurrentRow.Cells[8].Value.ToString();

            txtUpdateMemberCounty.Text = grdUpdateMember.CurrentRow.Cells[9].Value.ToString();
            txtUpdateMemberEircode.Text = grdUpdateMember.CurrentRow.Cells[10].Value.ToString();
            cboUpdateMemberStatus.Text = grdUpdateMember.CurrentRow.Cells[12].Value.ToString();

            txtUpdateMemberFines.Text = Fine.GetOutstandingFines(Convert.ToInt32(grdUpdateMember.CurrentRow.Cells[0].Value)).ToString("C");
        }
    }
}
