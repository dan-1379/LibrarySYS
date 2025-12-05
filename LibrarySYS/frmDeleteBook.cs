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
            String[] testData = {"The Hunger Games", "Suzanne Collins", "The Hunger Games book 1 written by Suzanne Collins", 
                                "Science Fiction", "Scholastic Press", "14/09/2008", "A", "978-0-439-02352-8"};

            String ISBN = txtDeleteBookISBN.Text;
            if (ISBN == "")
            {
                MessageBox.Show("Invalid ISBN entered. Please try again.", "Invalid Input");
                return;
            }

            if (ISBN == "1")
            {
                MessageBox.Show("ISBN " + ISBN + " not located. Please try again.", "Book Not Found");
                return;
            }
            
            grpDeleteBookDetails.Visible = true;

            txtDeleteBookTitle.Text = testData[0];
            txtDeleteBookAuthor.Text = testData[1];
            txtDeleteBookDescription.Text = testData[2];
            txtDeleteBookGenre.Text = testData[3];
            txtDeleteBookPublisher.Text = testData[4];
            txtDeleteBookPublication.Text = testData[5];
            txtDeleteBookStatus.Text = testData[6];
        }

        private void btnDeleteBookDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show(
                $"Are you sure you wish to delete: {txtDeleteBookTitle.Text} by {txtDeleteBookAuthor.Text}?", 
                "Confirm Deletion", MessageBoxButtons.YesNo
            );

            if (confirmDelete == DialogResult.Yes)
            {
                MessageBox.Show("Book deleted successfully.", "Deletion Successful");
                grpDeleteBookDetails.Visible = false;
                txtDeleteBookISBN.Clear();
                txtDeleteBookISBN.Focus();
            }
        }
    }
}
