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
            crtProduceYearlyGenreReportChart.Visible = false;
        }

        private void cboProduceYearlyGenreReportYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            crtProduceYearlyGenreReportChart.Visible = true;

            crtProduceYearlyGenreReportChart.Series.Clear();
            crtProduceYearlyGenreReportChart.Series.Add("Genre Popularity");

            crtProduceYearlyGenreReportChart.Series["Genre Popularity"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            crtProduceYearlyGenreReportChart.Series["Genre Popularity"].Points.AddXY("January", 250);
            crtProduceYearlyGenreReportChart.Series["Genre Popularity"].Points.AddXY("Febuary", 350);
            crtProduceYearlyGenreReportChart.Series["Genre Popularity"].Points.AddXY("March", 160);
            crtProduceYearlyGenreReportChart.Series["Genre Popularity"].Points.AddXY("April", 180);
            crtProduceYearlyGenreReportChart.Series["Genre Popularity"].Points.AddXY("May", 450);
            crtProduceYearlyGenreReportChart.Series["Genre Popularity"].Points.AddXY("June", 500);
            crtProduceYearlyGenreReportChart.Series["Genre Popularity"].Points.AddXY("July", 700);
            crtProduceYearlyGenreReportChart.Series["Genre Popularity"].Points.AddXY("August", 900);
            crtProduceYearlyGenreReportChart.Series["Genre Popularity"].Points.AddXY("September", 1250);
            crtProduceYearlyGenreReportChart.Series["Genre Popularity"].Points.AddXY("October", 400);
            crtProduceYearlyGenreReportChart.Series["Genre Popularity"].Points.AddXY("November", 300);
            crtProduceYearlyGenreReportChart.Series["Genre Popularity"].Points.AddXY("December", 100);

            crtProduceYearlyGenreReportChart.ChartAreas[0].AxisX.Interval = 1;
            crtProduceYearlyGenreReportChart.ChartAreas[0].AxisX.Title = "Month";
            crtProduceYearlyGenreReportChart.ChartAreas[0].AxisY.Title = "Number of books";
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
