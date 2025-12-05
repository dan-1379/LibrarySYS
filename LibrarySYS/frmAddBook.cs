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
            string dateOnly;

            // Book_ID and Status variables created for testing purposes
            String bookID = "B001";
            char status = 'A';

            if (publicationDate == DateTime.Now)
            {
                dateOnly = "";
            } else
            {
                dateOnly = publicationDate.ToString("dd/MM/yyyy");
            }

            if (title == "")
            {
                MessageBox.Show("No data has been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddBookTitle.Focus();
                return;
            }

            if (title == "1")
            {
                MessageBox.Show("Invalid data entered:\nPlease enter a book title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddBookTitle.Focus();
                return;
            }

            MessageBox.Show("BOOK ADDED SUCCESSFULLY\n\n" +
                $"\nBook_ID: \n{bookID}" +
                $"\n\nTITLE: \n{title}" +
                $"\n\nAUTHOR: \n{author}" +
                $"\n\nDESCRIPTION: \n{description}" +
                $"\n\nISBN: \n{isbn}" +
                $"\n\nGENRE: \n{genre}" +
                $"\n\nPUBLISHER: \n{publisher}" +
                $"\n\nPUBLICATION DATE: \n{dateOnly}" +
                $"\n\nStatus: {status}", 
                "Success");

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
