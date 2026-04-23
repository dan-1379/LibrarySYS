using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LibrarySYS
{
    public partial class frmProduceYearlyGenreReport : Form
    {
        frmMainMenu parent;
        public frmProduceYearlyGenreReport()
        {
            InitializeComponent();
        }

        public frmProduceYearlyGenreReport(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmProduceYearlyGenreReport_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            crtProduceYearlyGenreReportChart.Visible = false;

            crtProduceYearlyGenreReportChart.Series.Clear();
            crtProduceYearlyGenreReportChart.Series.Add("Genre Popularity");

            crtProduceYearlyGenreReportChart.Series["Genre Popularity"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            crtProduceYearlyGenreReportChart.Series["Genre Popularity"].Label = "#VALX (#VAL)";

            try
            {
                Dictionary<string, int> genreCounts = Book.GetBooksByGenre();

                foreach (KeyValuePair<string, int> value in genreCounts)
                {
                    crtProduceYearlyGenreReportChart.Series["Genre Popularity"].Points.AddXY(value.Key, value.Value);
                }

                crtProduceYearlyGenreReportChart.Visible = true;
            } catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                parent.Visible = true;
            }

            Utility.StyleExitButton(mnuProduceYearlyGenreReportExit);
        }

        private void cboProduceYearlyGenreReportYear_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void mnuProduceYearlyGenreReportExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                parent.Visible = true;
                this.Close();
            }
        }
    }
}
