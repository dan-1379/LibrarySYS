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
using Oracle.ManagedDataAccess.Client;

namespace LibrarySYS
{
    public partial class frmProcessLoan : Form
    {
        frmMainMenu parent;
        private List<Book> bookItems = new List<Book>();
        private Member extracted;

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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            grpProcessLoan.Visible = false;
            grpProcessLoanMemberDetails.Visible = false;
            bookItems.Clear();

            Utility.StyleButton(btnProcessLoanAdd);
            Utility.StyleButton(btnProcessLoanLoanBooks);
            Utility.StyleSearchButton(btnProcessLoanSearchID);
            Utility.StyleSearchButton(btnProcessLoanSearchISBN);
            Utility.StyleDeleteButton(btnProcessLoanRemove);
            Utility.StyleDeleteButton(btnProcessLoanCancel);

            Utility.StyleInputBoxesActive(grpProcessLoan);
            Utility.StyleInputBoxes(grpProcessLoanMemberDetails);

            Utility.StyleCheckedListBox(clbProcessLoan);
            Utility.StyleExitButton(mnuProcessLoanExit);
        }

        private void btnProcessLoanSearchID_Click(object sender, EventArgs e)
        {
            string ID = txtProcessLoanMemberID.Text;

            if (!MemberValidator.IsValidID(ID)) { 
                MessageBox.Show("Invalid ID. Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                extracted = Member.GetMemberRecord(ID);
            } catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching member details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            if (LoanItem.FetchOverdueBooksCount(extracted.ID) > 0)
            {
                MessageBox.Show("Member has overdue books and cannot loan more until they are returned.", "Overdue Books", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProcessLoanMemberID.Clear();
                return;
            }

            double fetchFine = Fine.GetOutstandingFines(Convert.ToInt32(ID));

            if (fetchFine > 0)
            {
                DialogResult dr = MessageBox.Show("Member currently has: €" + fetchFine + " in unpaid fines. Does the member wish to pay the fine?",
                                "Outstanding Fines", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    frmPayFines payFineForm = new frmPayFines(ID, this);
                    payFineForm.ShowDialog();

                    if (Fine.GetOutstandingFines(Convert.ToInt32(ID)) > 0)
                    {
                        MessageBox.Show("Member has outstanding fines and cannot loan books until they are paid.", "Outstanding Fines", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtProcessLoanMemberID.Clear();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Member must pay outstanding fines before loaning books.", "Outstanding Fines", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProcessLoanMemberID.Clear();
                    return;
                }
            }

            txtProcessLoanName.Text = extracted.FirstName + " " + extracted.LastName;
            txtProcessLoanAddress.Text = extracted.AddressLine1 + ", " + extracted.AddressLine2 + ", " + extracted.City;
            txtProcessLoanBooksLoaned.Text = LoanItem.FetchUnreturnedBooks(extracted.ID).ToString();

            grpProcessLoan.Visible = true;
            grpProcessLoanMemberDetails.Visible = true;
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

            Book book;

            try
            {
                book = Book.GetBook(ISBN);
            } catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching book details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (book == null)
            {
                MessageBox.Show("No book found with the provided ISBN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (book.Status == 'U')
            {
                MessageBox.Show("Book is currently unavailable for loan.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bookItems.Any(b => b.ISBN == ISBN))
            {
                MessageBox.Show("Book already in loan", "Book in loan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtProcessLoanTitle.Text = book.Title;
            txtProcessLoanAuthor.Text = book.Author;
            txtProcessLoanDescription.Text = book.Description;
            cboProcessLoanGenre.Text = book.Genre;
            txtProcessLoanPublisher.Text = book.Publisher;
            dtpProcessLoanPublication.Value = Convert.ToDateTime(book.Publication);
            cboProcessLoanStatus.Text = Convert.ToString(book.Status);
        }

        private void btnProcessLoanAdd_Click(object sender, EventArgs e)
        {
            string bookTitle = txtProcessLoanTitle.Text;
            string bookISBN = txtProcessLoanISBN.Text;

            if (string.IsNullOrEmpty(bookISBN))
            {
                MessageBox.Show("Please search for a book before adding it to the loan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char status = cboProcessLoanStatus.Text[0];

            if (status == 'U')
            {
                MessageBox.Show("Book is currently unavailable for loan.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bookItems.Any(b => b.ISBN == bookISBN))
            {
                MessageBox.Show("Book already in loan", "Book in loan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bookItems.Count >= 5)
            {
                MessageBox.Show("Cannot add more than 5 books to a single loan.", "Loan Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Book book;

            try
            {
                book = Book.GetBook(bookISBN);
            } catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching book details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (book == null)
            {
                MessageBox.Show("No book found with the provided ISBN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clbProcessLoan.Items.Add(book.Title);
            bookItems.Add(book);

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
            if (clbProcessLoan.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one book to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = clbProcessLoan.CheckedItems.Count - 1; i >= 0; i--)
            {
                string titleToRemove = clbProcessLoan.CheckedItems[i].ToString();
                bookItems.RemoveAll(b => b.Title == titleToRemove);

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
                    int currentLoanedAmount = LoanItem.FetchUnreturnedBooks(memberID);

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

                    OracleConnection con = Database.OpenConnection();
                    OracleTransaction transaction = null;

                    try
                    {
                        transaction = con.BeginTransaction();

                        LoanTransaction newLoan = new LoanTransaction(1, Convert.ToInt32(txtProcessLoanMemberID.Text));
                        newLoan.ProcessTransaction();

                        foreach (Book book in bookItems)
                        {
                            LoanItem newItem = new LoanItem(book.ID, newLoan.LoanID);
                            newItem.AddLoanItem();
                            Book.UpdateBookStatus(book.ID, 'U');
                        }

                        transaction.Commit();

                        DialogResult confirm = MessageBox.Show("Books loaned successfully! Does the user want to print a receipt?", "Loan Processed", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (confirm == DialogResult.Yes)
                        {
                            LoanReceipt.GenerateReceipt(newLoan.LoanID, extracted, bookItems);
                        }

                        clbProcessLoan.Items.Clear();
                        bookItems.Clear();
                        extracted = null;
                        grpProcessLoan.Visible = false;
                        txtProcessLoanMemberID.ReadOnly = false;
                        txtProcessLoanMemberID.Clear();
                        txtProcessLoanMemberID.Focus();
                        txtProcessLoanName.Clear();
                        txtProcessLoanAddress.Clear();
                        grpProcessLoanMemberDetails.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null)
                        {
                            transaction.Rollback();
                        }

                        MessageBox.Show("An error occurred while processing the loan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void mnuProcessLoanExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmExit == DialogResult.Yes)
            {
                parent.Visible = true;
                this.Close();
            }
        }

        private void txtProcessLoanMemberID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnProcessLoanCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loan process cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clbProcessLoan.Items.Clear();
            bookItems.Clear();
            grpProcessLoan.Visible = false;
            txtProcessLoanMemberID.ReadOnly = false;
            txtProcessLoanMemberID.Clear();
            txtProcessLoanMemberID.Focus();
            txtProcessLoanName.Clear();
            txtProcessLoanAddress.Clear();
            grpProcessLoanMemberDetails.Visible = false;
        }
    }
}
