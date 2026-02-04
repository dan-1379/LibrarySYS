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
            grpViewBook.Visible = false;
            dtpViewBookPublication.Enabled = false;
            cboViewBookStatus.Enabled = false;
            cboViewBookGenre.Enabled = false;
        }

        private void mnuViewBookExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

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
                MessageBox.Show(isValidISBN, "Invalid ISBN");
                return;
            }

            DataSet ds = Book.GetBook(txtViewBookISBN.Text);

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Book not found.", "Error");
                grpViewBook.Visible = false;
                return;
            }

            DataRow row = ds.Tables[0].Rows[0];
            grpViewBook.Visible = true;

            txtViewBookTitle.Text = row["Title"].ToString();
            txtViewBookAuthor.Text = row["Author"].ToString();
            txtViewBookDescription.Text = row["Description"].ToString();
            cboViewBookGenre.Text = row["Genre"].ToString();
            txtViewBookPublisher.Text = row["Publisher"].ToString();
            dtpViewBookPublication.Text = row["Publication_Date"].ToString();
            cboViewBookStatus.Text = row["Status"].ToString();
        }
    }
}
