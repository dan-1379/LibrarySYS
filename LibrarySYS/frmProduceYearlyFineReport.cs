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
    public partial class frmProduceYearlyFineReport : Form
    {
        frmMainMenu parent;
        public frmProduceYearlyFineReport()
        {
            InitializeComponent();
        }

        public frmProduceYearlyFineReport(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuProduceYearlyFineReportExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                parent.Visible = true;
                this.Close();
            }
        }

        private void frmProduceYearlyFineReport_Load(object sender, EventArgs e)
        {
            crtProduceYearlyFineReportChart.Visible = false;
        }

        private void cboProduceYearlyFineReportYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            crtProduceYearlyFineReportChart.Visible = true;

            crtProduceYearlyFineReportChart.Series.Clear();
            crtProduceYearlyFineReportChart.Series.Add("Fines Collected");

            crtProduceYearlyFineReportChart.Series["Fines Collected"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            crtProduceYearlyFineReportChart.Series["Fines Collected"].Points.AddXY("January", 10);
            crtProduceYearlyFineReportChart.Series["Fines Collected"].Points.AddXY("Febuary", 30);
            crtProduceYearlyFineReportChart.Series["Fines Collected"].Points.AddXY("March", 40);
            crtProduceYearlyFineReportChart.Series["Fines Collected"].Points.AddXY("April", 60);
            crtProduceYearlyFineReportChart.Series["Fines Collected"].Points.AddXY("May", 100);
            crtProduceYearlyFineReportChart.Series["Fines Collected"].Points.AddXY("June", 120);
            crtProduceYearlyFineReportChart.Series["Fines Collected"].Points.AddXY("July", 150);
            crtProduceYearlyFineReportChart.Series["Fines Collected"].Points.AddXY("August", 250);
            crtProduceYearlyFineReportChart.Series["Fines Collected"].Points.AddXY("September", 70);
            crtProduceYearlyFineReportChart.Series["Fines Collected"].Points.AddXY("October", 20);
            crtProduceYearlyFineReportChart.Series["Fines Collected"].Points.AddXY("November", 30);
            crtProduceYearlyFineReportChart.Series["Fines Collected"].Points.AddXY("December", 10);

            crtProduceYearlyFineReportChart.ChartAreas[0].AxisX.Interval = 1;
            crtProduceYearlyFineReportChart.ChartAreas[0].AxisX.Title = "Month";
            crtProduceYearlyFineReportChart.ChartAreas[0].AxisY.Title = "€";
        }
    }
}
