using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LibrarySYS
{
    public partial class frmProcessReturn : Form
    {
        Form parent;

        String[,] dummyBookDetails = {
            {"978-0-439-02352-8", "The Hunger Games", "Suzanne Collins", "Dystopian Novel", "Young Adult", "Scholastic Press", "14/09/2008", "A", "20/11/2025", "1.30"},
            {"978-0-385-73794-4", "The Maze Runner", "James Dashner", "Dystopian Novel", "Young Adult", "Delacorte Press", "06/10/2009", "A", "20/11/2025", "1.30"},
            {"978-0-7432-7356-5", "Angels & Demons", "Dan Brown", "Thriller", "Fiction", "Pocket Books", "01/05/2000", "A", "24/11/25", "0.00"},
            {"978-0-316-76948-0", "The Silent Patient", "Alex Michaelides", "Psychological Thriller", "Fiction", "Celadon Books", "05/02/2019", "A", "24/11/2025", "0.00"},
            {"978-1-250-03096-2", "Where the Crawdads Sing", "Delia Owens", "Mystery/Drama", "Fiction", "G.P. Putnam's Sons", "14/08/2018", "A",  "24/11/2025", "0.00"}
        };
        public frmProcessReturn()
        {
            InitializeComponent();
        }

        public frmProcessReturn(Form Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmProcessReturn_Load(object sender, EventArgs e)
        {
            grpProcessReturn.Visible = false;
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

        private void btnProcessReturnSearchID_Click(object sender, EventArgs e)
        {
            grpProcessReturn.Visible = true;
        }

        private void btnProcessLoanReturnISBN_Click(object sender, EventArgs e)
        {
            String ISBN = txtProcessReturnISBN.Text;

            for (int i = 0; i < dummyBookDetails.Length; i++)
            {
                if (ISBN == "")
                {
                    MessageBox.Show("Please enter an ISBN to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ;

                if (dummyBookDetails[i, 0] == ISBN)
                {
                    txtProcessReturnTitle.Text = dummyBookDetails[i, 1];
                    txtProcessReturnAuthor.Text = dummyBookDetails[i, 2];
                    txtProcessReturnDescription.Text = dummyBookDetails[i, 3];
                    cboProcessReturnGenre.Text = dummyBookDetails[i, 4];
                    txtProcessReturnPublisher.Text = dummyBookDetails[i, 5];
                    dtpProcessReturnPublication.Text = dummyBookDetails[i, 6];
                    cboProcessReturnStatus.Text = dummyBookDetails[i, 7];
                    dtpProcessReturnCheckout.Text = dummyBookDetails[i, 8];
                    return;
                }
            }
        }

        private void btnProcessReturnAdd_Click(object sender, EventArgs e)
        {
            clbProcessReturn.Items.Add(txtProcessReturnTitle.Text);

            txtProcessReturnISBN.Clear();
            txtProcessReturnTitle.Clear();
            txtProcessReturnAuthor.Clear();
            txtProcessReturnDescription.Clear();
            cboProcessReturnGenre.Text = "";
            txtProcessReturnPublisher.Clear();
            dtpProcessReturnPublication.Value = DateTime.Now;
            cboProcessReturnStatus.Text = "";
        }

        private void btnProcessReturnRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbProcessReturn.CheckedItems.Count; i++)
            {
                clbProcessReturn.Items.Remove(clbProcessReturn.CheckedItems[i]);
            }
        }

        private void grpProcessReturn_Enter(object sender, EventArgs e)
        {

        }

        private void btnProcessLoanReturnBooks_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("This member has €12.70 in active fines. Pay the fines?",
               "Active Fines", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                frmPayFines payFinesForm = new frmPayFines(this);
                payFinesForm.ShowDialog();
                this.Hide();
            } else
            {
                MessageBox.Show("Please pay outstanding fines before returning books.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grpProcessReturn.Visible = false;
                txtProcessReturnMemberID.Clear();
                return;
            }

            if (clbProcessReturn.Items.Count == 0)
            {
                MessageBox.Show("No books selected for loan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to return the selected books?", "Confirm Loan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Books returned successfully!", "Return Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clbProcessReturn.Items.Clear();
                    grpProcessReturn.Visible = false;
                } else
                {
                    MessageBox.Show("Books not returned!", "Return not Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtProcessReturnMemberID_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
