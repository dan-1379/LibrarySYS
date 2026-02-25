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
            grdDeleteMember.DataSource = Member.getAllMembers().Tables[0];
            Utility.constructMemberDataGrid(grdDeleteMember);
            Utility.styleGrid(grdDeleteMember);
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
            }
        }

        private void grdDeleteMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpDeleteMember.Visible = true;
            txtDeleteMemberFName.Text = grdDeleteMember.CurrentRow.Cells[1].Value.ToString();
            txtDeleteMemberLName.Text = grdDeleteMember.CurrentRow.Cells[2].Value.ToString();

            DateTime dob = Convert.ToDateTime(grdDeleteMember.CurrentRow.Cells[3].Value);
            txtDeleteMemberDOB.Text = dob.ToString("dd/MM/yyyy");

            txtDeleteMemberPhone.Text = grdDeleteMember.CurrentRow.Cells[4].Value.ToString();
            txtDeleteMemberEmail.Text = grdDeleteMember.CurrentRow.Cells[5].Value.ToString();
            txtDeleteMemberAddress1.Text = grdDeleteMember.CurrentRow.Cells[6].Value.ToString();

            txtDeleteMemberAddress2.Text = grdDeleteMember.CurrentRow.Cells[7].Value.ToString();
            txtDeleteMemberCounty.Text = grdDeleteMember.CurrentRow.Cells[9].Value.ToString();
            txtDeleteMemberEircode.Text = grdDeleteMember.CurrentRow.Cells[10].Value.ToString();

            DateTime regDate = Convert.ToDateTime(grdDeleteMember.CurrentRow.Cells[11].Value);
            txtDeleteMemberRegDate.Text = regDate.ToString("dd/MM/yyyy");

            txtDeleteMemberFines.Text = "€0.00";
            txtDeleteMemberLoans.Text = "€0.00";
        }
    }
}
