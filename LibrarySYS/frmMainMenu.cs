using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LibrarySYS
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuAddBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddBook addBookForm = new frmAddBook(this);
            addBookForm.Show();
        }

        private void mnuDeleteBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeleteBook deleteBookForm = new frmDeleteBook(this);
            deleteBookForm.Show();
        }

        private void mnuUpdateBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateBook updateBookForm = new frmUpdateBook(this);
            updateBookForm.Show();
        }

        private void mnuViewBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewBook viewBookForm = new frmViewBook(this);
            viewBookForm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void mnuAddMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddMember addMemberForm = new frmAddMember(this);
            addMemberForm.Show();
        }

        private void mnuDeleteMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeleteMember deleteMemberForm = new frmDeleteMember(this);
            deleteMemberForm.Show();
        }

        private void mnuUpdateMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateMember updateMemberForm = new frmUpdateMember(this);
            updateMemberForm.Show();
        }

        private void mnuViewMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewMember viewMemberForm = new frmViewMember(this);
            viewMemberForm.Show();
        }

        private void mnuProcessLoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProcessLoan processLoanForm = new frmProcessLoan(this);
            processLoanForm.Show();
        }

        private void mnuProcessReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProcessReturn processReturnForm = new frmProcessReturn(this);
            processReturnForm.Show();
        }

        private void mnuProduceFineReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProduceYearlyFineReport produceYearlyFineReportForm = new frmProduceYearlyFineReport(this);
            produceYearlyFineReportForm.Show();
        }

        private void mnuProduceGenreReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProduceYearlyGenreReport produceYearlyGenreReportForm = new frmProduceYearlyGenreReport(this);
            produceYearlyGenreReportForm.Show();
        }
    }
}
