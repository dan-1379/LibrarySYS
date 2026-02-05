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
    public partial class frmUpdateBook : Form
    {
        frmMainMenu parent;
        private string selectedISBN;
        private int bookID;

        public frmUpdateBook()
        {
            InitializeComponent();
        }

        public frmUpdateBook(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void frmUpdateBook_Load(object sender, EventArgs e)
        {
            grpUpdateBook.Visible = false;
        }

        private void mnuUpdateBookExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmExit == DialogResult.Yes)
            {
                parent.Visible = true;
                this.Close();
            }
        }

        private void btnUpdateBookSearch_Click(object sender, EventArgs e)
        {
            selectedISBN = txtUpdateBookISBN.Text;
            string isValidISBN = BookValidator.IsValidISBN(selectedISBN);

            if (isValidISBN != "Valid ISBN")
            {
                MessageBox.Show(isValidISBN, "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet ds = Book.GetBook(selectedISBN);

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No book found with the provided ISBN.", "Book Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grpUpdateBook.Visible = false;
                return;
            }

            DataRow row = ds.Tables[0].Rows[0];

            grpUpdateBook.Visible = true;
            txtUpdateBookISBN.ReadOnly = true;

            bookID = Convert.ToInt32(row["Book_ID"].ToString());

            txtUpdateBookTitle.Text = row["Title"].ToString();
            txtUpdateBookAuthor.Text = row["Author"].ToString();
            txtUpdateBookDescription.Text = row["Description"].ToString();
            cboUpdateBookGenre.Text = row["Genre"].ToString();
            txtUpdateBookPublisher.Text = row["Publisher"].ToString();
            dtpUpdateBookPublication.Value = Convert.ToDateTime(row["Publication_Date"]);
            cboUpdateBookStatus.Text = row["Status"].ToString();

        }

        private void btnUpdateBookUpdate_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show(
                $"Are you sure you want to update?\n\nUpdated Details:" +
                $"\n\tTitle: {txtUpdateBookTitle.Text}" +
                $"\n\tAuthor: {txtUpdateBookAuthor.Text}" +
                $"\n\tDescription: {txtUpdateBookDescription.Text}" +
                $"\n\tGenre: {cboUpdateBookGenre.Text}" +
                $"\n\tPublisher: {txtUpdateBookPublisher.Text}" +
                $"\n\tPublication: {dtpUpdateBookPublication.Text}", 
                "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (confirmExit == DialogResult.Yes)
            {

                string title = txtUpdateBookTitle.Text.Trim();
                string author = txtUpdateBookAuthor.Text.Trim();
                string description = txtUpdateBookDescription.Text.Trim();
                string isbn = txtUpdateBookISBN.Text.Trim();
                string genre = cboUpdateBookGenre.SelectedItem?.ToString();
                string publisher = txtUpdateBookPublisher.Text.Trim();
                DateTime publicationDate = dtpUpdateBookPublication.Value;
                string dateOnly = publicationDate.ToString("yyyy-MM-dd");
                char status = cboUpdateBookStatus.SelectedItem.ToString()[0];

                if (!BookValidator.IsValidTitle(title))
                {
                    MessageBox.Show("Invalid Title. Please enter a valid title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!BookValidator.IsValidAuthor(author))
                {
                    MessageBox.Show("Invalid Author. Please enter a valid author.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!BookValidator.IsValidDescription(description))
                {
                    MessageBox.Show("Invalid Description. Please enter a valid description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!BookValidator.IsValidGenre(genre))
                {
                    MessageBox.Show("Invalid Genre. Please enter a valid genre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!BookValidator.IsValidPublisher(publisher))
                {
                    MessageBox.Show("Invalid Publisher. Please enter a valid publisher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!BookValidator.IsValidPublicationDate(publicationDate))
                {
                    MessageBox.Show("Invalid Publication Date. Please enter a valid publication date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!BookValidator.IsValidStatus(status))
                {
                    MessageBox.Show("Invalid Publication Date. Please enter a valid publication date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Book newBook = new Book(bookID, title, author, description, isbn, genre, publisher, publicationDate, status);
                newBook.UpdateBook(isbn);

                MessageBox.Show($"Book updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpUpdateBook.Visible = false;
                txtUpdateBookISBN.ReadOnly = false;

                txtUpdateBookISBN.Clear();
                txtUpdateBookISBN.Focus();

                selectedISBN = null;
            }
        }
    }
}
