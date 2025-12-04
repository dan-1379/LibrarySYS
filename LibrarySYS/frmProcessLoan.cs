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
    public partial class frmProcessLoan : Form
    {
        frmMainMenu parent;

        /*
            ISBN
            Title
            Author
            Description
            Genre
            Publisher
            Publication
            Status
         */
        String[,] dummyBookDetails = {
            {"1", "The Hunger Games", "Suzanne Collins", "Dystopian Novel", "Young Adult", "Scholastic Press", "14/09/2008", "A" },
            {"2", "The Maze Runner", "James Dashner", "Dystopian Novel", "Young Adult", "Delacorte Press", "06/10/2009", "A"},
            {"3", "Angels & Demons", "Dan Brown", "Thriller", "Fiction", "Pocket Books", "01/05/2000", "A"},
            {"4", "The Silent Patient", "Alex Michaelides", "Psychological Thriller", "Fiction", "Celadon Books", "05/02/2019", "A"},
            {"5", "Where the Crawdads Sing", "Delia Owens", "Mystery/Drama", "Fiction", "G.P. Putnam's Sons", "14/08/2018", "A"  }
        };
        public frmProcessLoan()
        {
            InitializeComponent();
        }

        public frmProcessLoan(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmProcessLoan_Load(object sender, EventArgs e)
        {
            grpProcessLoan.Visible = false;
        }

        private void btnProcessLoanSearchID_Click(object sender, EventArgs e)
        {
            grpProcessLoan.Visible = true;
        }

        private void btnProcessLoanSearchISBN_Click(object sender, EventArgs e)
        {
            String ISBN = txtProcessLoanISBN.Text;

            for (int i = 0; i < dummyBookDetails.Length; i++)
            {
                if (ISBN == "")
                {
                    MessageBox.Show("Please enter an ISBN to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                };

                if (dummyBookDetails[i, 0] == ISBN)
                {
                    txtProcessLoanTitle.Text = dummyBookDetails[i, 1];
                    txtProcessLoanAuthor.Text = dummyBookDetails[i, 2];
                    txtProcessLoanDescription.Text = dummyBookDetails[i, 3];
                    cboProcessLoanGenre.Text = dummyBookDetails[i, 4];
                    txtProcessLoanPublisher.Text = dummyBookDetails[i, 5];
                    dtpProcessLoanPublication.Text = dummyBookDetails[i, 6];
                    cboProcessLoanStatus.Text = dummyBookDetails[i, 7];
                    return;
                }
            }
        }

        private void btnProcessLoanAdd_Click(object sender, EventArgs e)
        {
            clbProcessLoan.Items.Add(txtProcessLoanTitle.Text);

            txtProcessLoanISBN.Clear();
            txtProcessLoanTitle.Clear();
            txtProcessLoanAuthor.Clear();
            txtProcessLoanDescription.Clear();
            cboProcessLoanGenre.Text = "";
            txtProcessLoanPublisher.Clear();
            dtpProcessLoanPublication.Value = DateTime.Now;
            cboProcessLoanStatus.Text = "";
        }

        private void btnProcessLoanRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbProcessLoan.CheckedItems.Count; i++)
            {
                clbProcessLoan.Items.Remove(clbProcessLoan.CheckedItems[i]);
            }
        }

        private void btnProcessLoanLoanBooks_Click(object sender, EventArgs e)
        {
            if (clbProcessLoan.Items.Count == 0)
            {
                MessageBox.Show("No books selected for loan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to loan the selected books?", "Confirm Loan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Books loaned successfully!", "Loan Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clbProcessLoan.Items.Clear();
                    grpProcessLoan.Visible = false;
                }
            }
        }

        private void mnuProcessLoanExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                parent.Visible = true;
                this.Close();
            }
        }

        private void txtProcessLoanMemberID_TextChanged(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("This member has €12.70 in active fines. Pay the fines?", 
                "Active Fines", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                frmPayFines payFinesForm = new frmPayFines(this);
                payFinesForm.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Cannot process loan with active fines.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
