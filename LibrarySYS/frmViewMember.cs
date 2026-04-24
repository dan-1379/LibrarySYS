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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;


            LoadMembers();

            if (grdViewMember.DataSource == null)
            {
                this.Close();
                parent.Visible = true;
                return;
            }

            Utility.ConstructGrid(grdViewMember);
            Utility.StyleGrid(grdViewMember);
            Utility.ColourRowsByStatus(grdViewMember);
            Utility.StyleSearchButton(btnViewMembersSearch);
            Utility.StyleExitButton(mnuViewMemberExit);
        }

        private void LoadMembers()
        {
            try
            {
                grdViewMember.DataSource = Member.GetAllMembers().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewMemberSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuViewMemberExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.OK, MessageBoxIcon.Question);

            if (confirmExit == DialogResult.Yes)
            {
                parent.Visible = true;
                this.Close();
            }
        }

        private void lblViewMemberName_Click(object sender, EventArgs e)
        {

        }

        private void btnViewMembers_Click(object sender, EventArgs e)
        {
            grdViewMember.ClearSelection();
            grdViewMember.CurrentCell = null;

            string search = txtViewMemberPhone.Text.Trim();

            foreach (DataGridViewRow row in grdViewMember.Rows)
            {
                if (row.IsNewRow) continue;

                string phone = row.Cells["Phone"].Value?.ToString();

                if (string.IsNullOrEmpty(search))
                {
                    row.Visible = true;
                }
                else if (phone != null && phone.Contains(search))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void txtViewMemberName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
