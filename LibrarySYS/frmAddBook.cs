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
    public partial class frmAddBook : Form
    {
        frmMainMenu parent;
        public frmAddBook()
        {
            InitializeComponent();
        }

        public frmAddBook(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                parent.Visible = true;
                this.Close();
            }
        }

        private void frmAddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent != null)
                parent.Visible = true;
        }

        private void cboAddBookGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddBookSave_Click(object sender, EventArgs e)
        {
            string title = txtAddBookTitle.Text.Trim();
            string author = txtAddBookAuthor.Text.Trim();
            string description = txtAddBookDescription.Text.Trim();
            string isbn = txtAddBookISBN.Text.Trim();
            string genre = cboAddBookGenre.SelectedItem?.ToString();
            string publisher = txtAddBookPublisher.Text.Trim();
            DateTime publicationDate = dtpAddBookPublication.Value;
            string dateOnly = publicationDate.ToString("yyyy-MM-dd");

            if (!BookValidator.IsValidTitle(title))
            {
                MessageBox.Show("Invalid Title. Please enter a valid title.", "Error");
                return;
            }

            if (!BookValidator.IsValidAuthor(author))
            {
                MessageBox.Show("Invalid Author. Please enter a valid author.", "Error");
                return;
            }

            if (!BookValidator.IsValidDescription(description))
            {
                MessageBox.Show("Invalid Description. Please enter a valid description.", "Error");
                return;
            }

            if (!BookValidator.IsValidISBN(isbn))
            {
                MessageBox.Show("Invalid ISBN. Please enter a valid ISBN.", "Error");
                return;
            }

            if (!BookValidator.IsValidGenre(genre))
            {
                MessageBox.Show("Invalid Genre. Please enter a valid genre.", "Error");
                return;
            }

            if (!BookValidator.IsValidPublisher(publisher))
            {
                MessageBox.Show("Invalid Publisher. Please enter a valid publisher.", "Error");
                return;
            }

            if (!BookValidator.IsValidPublicationDate(publicationDate))
            {
                MessageBox.Show("Invalid Publication Date. Please enter a valid publication date.", "Error");
                return;
            }

            int bookID = Book.GetNextBookID();
            char status = 'A';

            Book newBook = new Book(bookID, title, author, description, isbn, genre, publisher, publicationDate, status);
            newBook.AddBook();


            //MessageBox.Show("BOOK ADDED SUCCESSFULLY\n\n" +
            //    $"\nBook_ID: \n{bookID}" +
            //    $"\n\nTITLE: \n{title}" +
            //    $"\n\nAUTHOR: \n{author}" +
            //    $"\n\nDESCRIPTION: \n{description}" +
            //    $"\n\nISBN: \n{isbn}" +
            //    $"\n\nGENRE: \n{genre}" +
            //    $"\n\nPUBLISHER: \n{publisher}" +
            //    $"\n\nPUBLICATION DATE: \n{dateOnly}" +
            //    $"\n\nStatus: {status}", 
            //    "Success");

            MessageBox.Show("Book added successfully!\n" +
                $"{title} written by {author}", "Success");

            txtAddBookTitle.Clear();
            txtAddBookAuthor.Clear();
            txtAddBookDescription.Clear();
            txtAddBookISBN.Clear();
            cboAddBookGenre.SelectedIndex = -1;
            txtAddBookPublisher.Clear();
            dtpAddBookPublication.Value = DateTime.Now;
            txtAddBookTitle.Focus();
        }

        private void frmAddBook_Shown(object sender, EventArgs e)
        {
            txtAddBookTitle.Focus();
        }
    }
}
