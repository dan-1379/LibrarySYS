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
            grpDeleteBookDetails.Visible = false;
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
                MessageBox.Show(isValidISBN, "Invalid ISBN");
                return;
            }

            DataSet ds = Book.GetBook(txtDeleteBookISBN.Text);

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No book found with the provided ISBN.", "Book Not Found");
                grpDeleteBookDetails.Visible = false;
                return;
            }

            DataRow row = ds.Tables[0].Rows[0];

            grpDeleteBookDetails.Visible = true;
            txtDeleteBookISBN.ReadOnly = true;

            string status = row["Status"].ToString();
            MessageBox.Show("Book Status: " + status);

            txtDeleteBookTitle.Text = row["Title"].ToString();
            txtDeleteBookAuthor.Text = row["Author"].ToString();
            txtDeleteBookDescription.Text = row["Description"].ToString();
            txtDeleteBookGenre.Text = row["Genre"].ToString();
            txtDeleteBookPublisher.Text = row["Publisher"].ToString();
            txtDeleteBookPublication.Text = row["Publication_Date"].ToString();
            txtDeleteBookStatus.Text = row["Status"].ToString();
        }

        private void btnDeleteBookDelete_Click(object sender, EventArgs e)
        {
            if (txtDeleteBookStatus.Text != "A")
            {
                MessageBox.Show("This book is currently on loan and must be returned to delete.", "Deletion Error");
                return;
            }

            DialogResult confirmDelete = MessageBox.Show(
                $"Are you sure you wish to delete: {txtDeleteBookTitle.Text} by {txtDeleteBookAuthor.Text}?", 
                "Confirm Deletion", MessageBoxButtons.YesNo
            );

            if (confirmDelete == DialogResult.Yes)
            {
                Book.DeleteBook(selectedISBN);

                MessageBox.Show("Book deleted successfully.", "Deletion Successful");
                grpDeleteBookDetails.Visible = false;
                txtDeleteBookISBN.ReadOnly = false;
            
                txtDeleteBookISBN.Clear();
                txtDeleteBookISBN.Focus();

                selectedISBN = null;
            }
        }
    }
}
