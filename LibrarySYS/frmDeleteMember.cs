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
    public partial class frmDeleteMember : Form
    {
        frmMainMenu parent;
        public frmDeleteMember()
        {
            InitializeComponent();
        }

        public frmDeleteMember(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmDeleteMember_Load(object sender, EventArgs e)
        {
            grpDeleteMember.Visible = false;
        }

        private void mnuDeleteMemberExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                parent.Visible = true;
                this.Close();
            }
        }

        private void btnDeleteMemberSearch_Click(object sender, EventArgs e)
        {
            String[] testData = {"M001", "Suzanne",
                "Collins", "06/11/1983", "0123456789", "scollins123@gmail.com", "12 Upper Bridge Street",
                "Killorglin", "Kerry", "V93 XY65", "01/01/2025", "0", "0"};

            grpDeleteMember.Visible = true;


            txtDeleteMemberFName.Text = testData[1];
            txtDeleteMemberLName.Text = testData[2];
            txtDeleteMemberDOB.Text = testData[3];
            txtDeleteMemberPhone.Text = testData[4];
            txtDeleteMemberEmail.Text = testData[5];
            txtDeleteMemberAddress1.Text = testData[6];
            txtDeleteMemberAddress2.Text = testData[7];
            txtDeleteMemberCounty.Text = testData[8];
            txtDeleteMemberEircode.Text = testData[9];
            txtDeleteMemberRegDate.Text = testData[10];
            txtDeleteMemberFines.Text = testData[11];
            txtDeleteMemberLoans.Text = testData[12];
        }

        private void btnDeleteMemberDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show(
                $"Are you sure you wish to delete member:\n{txtDeleteMemberFName.Text} {txtDeleteMemberLName.Text}\n" +
                $"{txtDeleteMemberAddress1.Text}\n{txtDeleteMemberAddress2.Text}",
                "Confirm Deletion", MessageBoxButtons.YesNo
            );


            if (confirmDelete == DialogResult.Yes)
            {

                if (txtDeleteMemberFines.Text != "0")
                {
                    MessageBox.Show("Cannot delete member with outstanding fines.", "Deletion Error");
                    return;
                }

                if (txtDeleteMemberLoans.Text != "0")
                {
                    MessageBox.Show("Cannot delete member with outstanding loans.", "Deletion Error");
                    return;
                }

                MessageBox.Show("Member deleted successfully.", "Deletion Successful");
                grpDeleteMember.Visible = false;
                txtDeleteMemberID.Clear();
                txtDeleteMemberID.Focus();
            }
        }
    }
}
