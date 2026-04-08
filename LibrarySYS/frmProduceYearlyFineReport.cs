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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            crtProduceYearlyFineReportChart.Visible = false;
            Utility.StyleExitButton(mnuProduceYearlyFineReportExit);
        }

        private void cboProduceYearlyFineReportYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            crtProduceYearlyFineReportChart.Visible = false;
            crtProduceYearlyFineReportChart.Series.Clear();
            crtProduceYearlyFineReportChart.ChartAreas[0].AxisX.Interval = 1;
            crtProduceYearlyFineReportChart.ChartAreas[0].AxisX.Title = "Month";
            crtProduceYearlyFineReportChart.ChartAreas[0].AxisY.Title = "€";

            int selectedYear = Convert.ToInt32(cboProduceYearlyFineReportYear.SelectedItem);
            double[] monthlyFines = Fine.GetFinesByMonth(selectedYear);

            string[] monthsOfYear = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            crtProduceYearlyFineReportChart.Series.Add("Fines Collected");
            crtProduceYearlyFineReportChart.Series["Fines Collected"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            for (int i = 0; i < 12; i++)
            {
                crtProduceYearlyFineReportChart.Series["Fines Collected"].Points.AddXY(monthsOfYear[i], monthlyFines[i]);
            }

            crtProduceYearlyFineReportChart.Visible = true;
            crtProduceYearlyFineReportChart.Update();
        }
    }
}
