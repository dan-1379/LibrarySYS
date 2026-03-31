using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LibrarySYS
{
    public partial class frmProcessReturn : Form
    {
        Form parent;
        private List<Book> bookItems = new List<Book>();

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
            txtProcessReturnMemberID.Focus();

            lblProcessReturnMemberName.Visible = false;
            lblProcessReturnMemberAddress.Visible = false;

            txtProcessReturnMemberAddress.Visible = false;
            txtProcessReturnMemberAddress.ReadOnly = true;

            txtProcessReturnMemberName.Visible = false;
            txtProcessReturnMemberName.ReadOnly = true;

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
            string ID = txtProcessReturnMemberID.Text;

            if (!MemberValidator.IsValidID(ID))
            {
                MessageBox.Show("Invalid ID. Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Member extracted = Member.GetMemberRecord(ID);

            if (extracted == null)
            {
                MessageBox.Show("No member found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (extracted.Status == 'I')
            {
                MessageBox.Show("Member is currently inactive and cannot loan books.", "Inactive Member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProcessReturnMemberID.Clear();
                return;
            }

            if (LoanItem.fetchOverdueBooksCount(extracted.MemberID) > 0)
            {
                MessageBox.Show("Member has overdue books and cannot loan more until they are returned.", "Overdue Books", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProcessReturnMemberID.Clear();
                return;
            }

            double fetchFine = Fines.GetOutstandingFines(Convert.ToInt32(ID));

            if (fetchFine > 0)
            {
                DialogResult dr = MessageBox.Show("Member currently has: €" + fetchFine + " in unpaid fines. Does the member wish to pay the fine?",
                                "Outstanding Fines", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    frmPayFines payFineForm = new frmPayFines(ID, this);
                    payFineForm.ShowDialog();

                    if (Fines.GetOutstandingFines(Convert.ToInt32(ID)) > 0)
                    {
                        MessageBox.Show("Member has outstanding fines and cannot loan books until they are paid.", "Outstanding Fines", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtProcessReturnMemberID.Clear();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Member must pay outstanding fines before loaning books.", "Outstanding Fines", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProcessReturnMemberID.Clear();
                    return;
                }
            }

            txtProcessReturnMemberName.Text = extracted.FirstName + " " + extracted.LastName;
            txtProcessReturnMemberAddress.Text = extracted.AddressLine1 + ", " + extracted.AddressLine2 + ", " + extracted.City;
            grpProcessReturn.Visible = true;
            txtProcessReturnMemberID.ReadOnly = true;


            lblProcessReturnMemberName.Visible = true;
            lblProcessReturnMemberAddress.Visible = true;

            txtProcessReturnMemberAddress.Visible = true;
            txtProcessReturnMemberName.Visible = true;

            bookItems.Clear();
            clbProcessReturn.Items.Clear();
            List<Book> unreturnedBooks = LoanItem.GetUnreturnedBooks(extracted.MemberID);
            
            foreach (Book book in unreturnedBooks)
            {
                clbProcessReturn.Items.Add(book.Title);
                bookItems.Add(book);
            }
        }

        private void txtProcessReturnMemberID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnProcessReturnReturn_Click(object sender, EventArgs e)
        {
            if (clbProcessReturn.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one book to return.", "No Books Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmReturn = MessageBox.Show("Are you sure you want to return the selected book(s)?", "Confirm Return", MessageBoxButtons.YesNo);

            if (confirmReturn == DialogResult.Yes)
            {
                OracleConnection con = Database.OpenConnection();
                OracleTransaction transaction = null;

                try
                {
                    transaction = con.BeginTransaction();

                    foreach (Book book in bookItems)
                    {
                        ReturnTransaction returnTransaction = new ReturnTransaction(book.BookID, Convert.ToInt32(txtProcessReturnMemberID.Text));
                        ReturnTransaction.processTransaction(book.BookID);
                        Book.UpdateBookStatus(book.ISBN, 'A');
                    }

                    transaction.Commit();

                    MessageBox.Show("Books loaned successfully!", "Loan Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
