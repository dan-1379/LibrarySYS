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
    public partial class frmViewMember : Form
    {
        frmMainMenu parent;

        String[] testData = {"M001","Dan", "Courtney", "12/02/2004", "0874651234", "dcourtney@gmail.com",
                            "12 Downing Street", "Rockfeller",  "Tralee", "Kerry", "V94 X2H6"};

        public frmViewMember()
        {
            InitializeComponent();
        }

        public frmViewMember(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmViewMember_Load(object sender, EventArgs e)
        {
            grpViewMember.Visible = false;
        }

        private void btnViewMemberSearch_Click(object sender, EventArgs e)
        {
            grpViewMember.Visible = true;

            txtViewMemberidentifier.Text = testData[0];
            txtViewMemberFName.Text = testData[1];
            txtViewMemberLName.Text = testData[2];
            dtpViewMemberDOB.Text = testData[3];
            txtViewMemberPhone.Text = testData[4];
            txtViewMemberEmail.Text = testData[5];
            txtViewMemberAddress1.Text = testData[6];
            txtViewMemberAddress2.Text = testData[7];
            txtViewMemberTown.Text = testData[8];
            txtViewMemberCounty.Text = testData[9];
            txtViewMemberEircode.Text = testData[10];
        }

        private void mnuViewMemberExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                parent.Visible = true;
                this.Close();
            }
        }

        private void lblViewMemberID_Click(object sender, EventArgs e)
        {

        }
    }
}
