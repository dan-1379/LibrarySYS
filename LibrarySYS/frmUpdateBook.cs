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

        String[] testData = {"The Hunger Games", "Suzanne Collins", "The Hunger Games book 1 written by Suzanne Collins",
                                "Science Fiction", "Scholastic Press", "14/09/2008"};
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
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                parent.Visible = true;
                this.Close();
            }
        }

        private void btnUpdateBookSearch_Click(object sender, EventArgs e)
        { 
            grpUpdateBook.Visible = true;

            txtUpdateBookTitle.Text = testData[0];
            txtUpdateBookAuthor.Text = testData[1];
            txtUpdateBookDescription.Text = testData[2];
            cboUpdateBookGenre.SelectedItem = testData[3];
            txtUpdateBookPublisher.Text = testData[4];
            dtpUpdateBookPublication.Value = DateTime.Parse(testData[5]);
        }

        private void btnUpdateBookUpdate_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show(
                $"Are you sure you want to update?\n\nUpdated Details:" +
                $"\n\n\tTitle: {txtUpdateBookTitle.Text}" +
                $"\n\tAuthor: {txtUpdateBookAuthor.Text}" +
                $"\n\tDescription: {txtUpdateBookDescription.Text}" +
                $"\n\tGenre: {cboUpdateBookGenre.Text}" +
                $"\n\tPublisher: {txtUpdateBookPublisher.Text}" +
                $"\n\tPublication: {dtpUpdateBookPublication.Text}", 
                "Confirm Update", MessageBoxButtons.YesNo
            );

            testData[0] = txtUpdateBookTitle.Text;
            testData[1] = txtUpdateBookAuthor.Text;
            testData[2] = txtUpdateBookDescription.Text;
            testData[3] = cboUpdateBookGenre.Text;
            testData[4] = txtUpdateBookPublisher.Text;
            testData[5] = dtpUpdateBookPublication.Text;

            if (confirmExit == DialogResult.Yes)
            {
                MessageBox.Show($"Book: {testData[0]} by {testData[1]} updated successfully.", "Update Successful");
                grpUpdateBook.Visible = false;
                txtUpdateBookISBN.Clear();
                txtUpdateBookISBN.Focus();
            }
        }
    }
}
