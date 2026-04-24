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
    public partial class frmViewBook : Form
    {
        frmMainMenu parent;

        public frmViewBook()
        {
            InitializeComponent();
        }
        public frmViewBook(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void frmViewBook_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            grpViewBook.Visible = false;
            dtpViewBookPublication.Enabled = false;
            cboViewBookStatus.Enabled = false;
            cboViewBookGenre.Enabled = false;

            Utility.StyleInputBoxes(grpViewBook);
            Utility.StyleSearchButton(btnViewBookSearch);
            Utility.StyleLabel(grpViewBook);
            Utility.StyleExitButton(mnuViewBookExit);
        }

        private void mnuViewBookExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmExit == DialogResult.Yes)
            {
                parent.Visible = true;
                this.Close();
            }
        }

        private void btnViewBookSearch_Click(object sender, EventArgs e)
        {
            string isbn = txtViewBookISBN.Text;
            string isValidISBN = BookValidator.IsValidISBN(isbn);

            if (isValidISBN != "Valid ISBN")
            {
                MessageBox.Show(isValidISBN, "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Book book = Book.GetBook(isbn);

                if (book == null)
                {
                    MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    grpViewBook.Visible = false;
                    return;
                }

                grpViewBook.Visible = true;

                txtViewBookTitle.Text = book.Title;
                txtViewBookAuthor.Text = book.Author;
                txtViewBookDescription.Text = book.Description;
                cboViewBookGenre.Text = book.Genre;
                txtViewBookPublisher.Text = book.Publisher;
                dtpViewBookPublication.Value = Convert.ToDateTime(book.Publication);
                cboViewBookStatus.Text = Convert.ToString(book.Status);
            } catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
