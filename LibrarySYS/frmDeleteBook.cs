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
    public partial class frmDeleteBook : Form
    {
        frmMainMenu parent;
        private string selectedISBN;
        private int selectedBookID;
        public frmDeleteBook()
        {
            InitializeComponent();
        }

        public frmDeleteBook(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmDeleteBook_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            grpDeleteBookDetails.Visible = false;
            Utility.StyleInputBoxes(grpDeleteBookDetails);
            Utility.StyleButton(btnDeleteBookDelete);
            Utility.StyleSearchButton(btnDeleteBookSearch);
            Utility.StyleLabel(grpDeleteBookDetails);
            Utility.StyleExitButton(mnuExit);
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

        private void btnDeleteBookSearch_Click(object sender, EventArgs e)
        {

            selectedISBN = txtDeleteBookISBN.Text;
            string isValidISBN = BookValidator.IsValidISBN(selectedISBN);

            if (isValidISBN != "Valid ISBN")
            {
                MessageBox.Show(isValidISBN, "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Book book = Book.GetBook(selectedISBN);

            if (book == null)
            {
                MessageBox.Show("No book found with the provided ISBN.", "Book Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grpDeleteBookDetails.Visible = false;
                return;
            }

            grpDeleteBookDetails.Visible = true;
            txtDeleteBookISBN.ReadOnly = true;
            selectedBookID = book.BookID;

            txtDeleteBookTitle.Text = book.Title;
            txtDeleteBookAuthor.Text = book.Author;
            txtDeleteBookDescription.Text = book.Description;
            txtDeleteBookGenre.Text = book.Genre;
            txtDeleteBookPublisher.Text = book.Publisher;
            txtDeleteBookPublication.Text = Convert.ToDateTime(book.Publication).ToString("dd-MM-yyyy");
            txtDeleteBookStatus.Text = book.Status.ToString();
        }

        private void btnDeleteBookDelete_Click(object sender, EventArgs e)
        {
            if (txtDeleteBookStatus.Text != "A")
            {
                MessageBox.Show("This book is currently on loan and must be returned to delete.", "Deletion Error" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmDelete = MessageBox.Show(
                $"Are you sure you wish to delete: {txtDeleteBookTitle.Text} by {txtDeleteBookAuthor.Text}?", 
                "Confirm Deletion", MessageBoxButtons.YesNo
            );

            if (confirmDelete == DialogResult.Yes)
            {
                Book.UpdateBookStatus(selectedBookID, 'U');

                MessageBox.Show("Book deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                grpDeleteBookDetails.Visible = false;
                txtDeleteBookISBN.ReadOnly = false;
            
                txtDeleteBookISBN.Clear();
                txtDeleteBookISBN.Focus();

                selectedISBN = null;
                selectedBookID = 0;
            }
        }
    }
}
