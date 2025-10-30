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
            parent.Visible = true;
            this.Close();
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

            if (publicationDate == DateTime.Now)
            {
                dateOnly = "";
            } else
            {
                dateOnly = publicationDate.ToString("dd/MM/yyyy");
            }

            MessageBox.Show("BOOK ADDED SUCCESSFULLY\n\n" +
                $"\nTITLE: {title}\nAUTHOR: {author}\nDESCRIPTION: {description}\nISBN: {isbn}\nGENRE: {genre}" +
                $"\nPUBLISHER: {publisher}\nPUBLICATION DATE: {dateOnly}", 
                "Success");

            txtAddBookTitle.Clear();
            txtAddBookAuthor.Clear();
            txtAddBookDescription.Clear();
            txtAddBookISBN.Clear();
            cboAddBookGenre.SelectedIndex = -1;
            txtAddBookPublisher.Clear();
            dtpAddBookPublication.Value = DateTime.Now;
        }
    }
}
