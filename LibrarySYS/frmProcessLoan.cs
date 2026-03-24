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
        private ArrayList bookItems = new ArrayList();

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

            double fetchFine = Fines.GetOutstandingFines(Convert.ToInt32(ID));

            if (fetchFine > 0)
            {
                DialogResult dr =  MessageBox.Show("Member currently has: €" + fetchFine + " in unpaid fines. Does the member wish to pay the fine?", 
                                "Outstanding Fines", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if (dr == DialogResult.Yes)
                {
                    frmPayFines payFineForm = new frmPayFines(ID, this);
                    payFineForm.ShowDialog();

                    if (Fines.GetOutstandingFines(Convert.ToInt32(ID)) > 0)
                    {
                        MessageBox.Show("Member has outstanding fines and cannot loan books until they are paid.", "Outstanding Fines", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtProcessLoanMemberID.Clear();
                        return;
                    }
                } else
                {
                    MessageBox.Show("Member must pay outstanding fines before loaning books.", "Outstanding Fines", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProcessLoanMemberID.Clear();
                    return;
                }
            }


            Member extracted = Member.GetMemberRecord(ID);

            if (extracted == null) { 
                MessageBox.Show("No member found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (extracted.Status == 'I')
            {
                MessageBox.Show("Member is currently inactive and cannot loan books.", "Inactive Member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProcessLoanMemberID.Clear();
                return;
            }

            if (LoanItem.fetchOverdueBooksCount(extracted.MemberID) > 0)
            {
                MessageBox.Show("Member has overdue books and cannot loan more until they are returned.", "Overdue Books", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProcessLoanMemberID.Clear();
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
            char status = cboProcessLoanStatus.Text[0];

            if (status == 'U')
            {
                MessageBox.Show("Book is currently unavailable for loan.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < clbProcessLoan.Items.Count; i++)
            {
                if (clbProcessLoan.Items[i].ToString() == bookTitle)
                {
                    MessageBox.Show("Book already in loan", "Book in loan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    int memberID = Convert.ToInt32(txtProcessLoanMemberID.Text);
                    int currentLoanedAmount = LoanItem.fetchUnreturnedBooks(memberID);

                    if (currentLoanedAmount >= 5)
                    {
                        MessageBox.Show("Member has already loaned the maximum amount of books (5).", "Loan Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (clbProcessLoan.Items.Count + currentLoanedAmount > 5)
                    {
                        MessageBox.Show("Member can only loan " + (5 - currentLoanedAmount) + " more book(s).", "Loan Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    LoanTransaction newLoan = new LoanTransaction(1, Convert.ToInt32(txtProcessLoanMemberID.Text));
                    newLoan.processTransaction();

                    foreach (DataRow book in bookItems)
                    {
                        LoanItem newItem = new LoanItem(Convert.ToInt32(book["Book_ID"]), newLoan.LoanId);
                        newItem.AddLoanItem();
                        Book.UpdateBookStatus(book["ISBN"].ToString());
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
