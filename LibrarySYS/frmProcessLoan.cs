using System;
using System.Collections.Generic;
using System.Collections;
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
        ArrayList bookItems = new ArrayList();

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
            bookItems.Clear();
        }

        private void btnProcessLoanSearchID_Click(object sender, EventArgs e)
        {
            string ID = txtProcessLoanMemberID.Text;

            if (!MemberValidator.IsValidID(ID)) { 
                MessageBox.Show("Invalid ID. Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // CODE SHOULD BE WRITTEN HERE TO MAKE SURE THAT THE MEMBER HAS NO ACTIVE LOANS OR FINES BEFORE PROCEEDING TO THE LOAN PROCESSING
            Member extracted = Member.GetMemberRecord(ID);

            if (extracted == null) { 
                MessageBox.Show("No member found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            txtProcessLoanName.Text = extracted.FirstName + " " + extracted.LastName;
            txtProcessLoanAddress.Text = extracted.AddressLine1 + ", " + extracted.AddressLine2 + ", " + extracted.City;
            grpProcessLoan.Visible = true;
            txtProcessLoanMemberID.ReadOnly = true;
        }

        private void btnProcessLoanSearchISBN_Click(object sender, EventArgs e)
        {
            string ISBN = txtProcessLoanISBN.Text;
            String validation = BookValidator.IsValidISBN(ISBN);

            if (validation != "Valid ISBN")
            {
                MessageBox.Show(validation, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet dr = Book.GetBook(ISBN);

            if (dr.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No book found with the provided ISBN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bookItems.Add(dr.Tables[0].Rows[0]);

            txtProcessLoanTitle.Text = dr.Tables[0].Rows[0]["Title"].ToString();
            txtProcessLoanAuthor.Text = dr.Tables[0].Rows[0]["Author"].ToString();
            txtProcessLoanDescription.Text = dr.Tables[0].Rows[0]["Description"].ToString();
            cboProcessLoanGenre.Text = dr.Tables[0].Rows[0]["Genre"].ToString();
            txtProcessLoanPublisher.Text = dr.Tables[0].Rows[0]["Publisher"].ToString();
            dtpProcessLoanPublication.Value = Convert.ToDateTime(dr.Tables[0].Rows[0]["Publication_Date"]);
            cboProcessLoanStatus.Text = dr.Tables[0].Rows[0]["Status"].ToString();
        }

        private void btnProcessLoanAdd_Click(object sender, EventArgs e)
        {
            string bookTitle = txtProcessLoanTitle.Text;

            for (int i = 0; i < clbProcessLoan.Items.Count; i++)
            {
                if (clbProcessLoan.Items[i].ToString() == bookTitle)
                {
                    MessageBox.Show("Book already in loan", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            clbProcessLoan.Items.Add(bookTitle);

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
                    // CHECK TO MAKE SURE THAT THE MEMBER HAS NO ACTIVE LOANS OR FINES BEFORE PROCEEDING TO THE LOAN PROCESSING
                    LoanTransaction newLoan = new LoanTransaction(1, Convert.ToInt32(txtProcessLoanMemberID.Text));
                    newLoan.processTransaction();

                    foreach (DataRow book in bookItems)
                    {
                        LoanItem newItem = new LoanItem(Convert.ToInt32(book["Book_ID"]));
                        newItem.AddLoanItem();
                        Book.UpdateBookStatus(book["Book_ID"].ToString());
                    }

                    MessageBox.Show("Books loaned successfully!", "Loan Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clbProcessLoan.Items.Clear();
                    grpProcessLoan.Visible = false;
                    txtProcessLoanMemberID.ReadOnly = false;
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
           
        }
    }
}
