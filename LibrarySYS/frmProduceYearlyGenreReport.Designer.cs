namespace LibrarySYS
{
    partial class frmProduceYearlyGenreReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.crtProduceYearlyGenreReportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblProduceYearlyGenreReportYear = new System.Windows.Forms.Label();
            this.cboProduceYearlyGenreReportYear = new System.Windows.Forms.ComboBox();
            this.mnuProduceYearlyGenreReport = new System.Windows.Forms.MenuStrip();
            this.mnuProduceYearlyGenreReportExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.crtProduceYearlyGenreReportChart)).BeginInit();
            this.mnuProduceYearlyGenreReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // crtProduceYearlyGenreReportChart
            // 
            chartArea1.Name = "ChartArea1";
            this.crtProduceYearlyGenreReportChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtProduceYearlyGenreReportChart.Legends.Add(legend1);
            this.crtProduceYearlyGenreReportChart.Location = new System.Drawing.Point(15, 111);
            this.crtProduceYearlyGenreReportChart.Name = "crtProduceYearlyGenreReportChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.crtProduceYearlyGenreReportChart.Series.Add(series1);
            this.crtProduceYearlyGenreReportChart.Size = new System.Drawing.Size(691, 313);
            this.crtProduceYearlyGenreReportChart.TabIndex = 8;
            this.crtProduceYearlyGenreReportChart.Text = "Fine Report";
            // 
            // lblProduceYearlyGenreReportYear
            // 
            this.lblProduceYearlyGenreReportYear.AutoSize = true;
            this.lblProduceYearlyGenreReportYear.Location = new System.Drawing.Point(12, 57);
            this.lblProduceYearlyGenreReportYear.Name = "lblProduceYearlyGenreReportYear";
            this.lblProduceYearlyGenreReportYear.Size = new System.Drawing.Size(65, 13);
            this.lblProduceYearlyGenreReportYear.TabIndex = 7;
            this.lblProduceYearlyGenreReportYear.Text = "Select Year:";
            // 
            // cboProduceYearlyGenreReportYear
            // 
            this.cboProduceYearlyGenreReportYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduceYearlyGenreReportYear.FormattingEnabled = true;
            this.cboProduceYearlyGenreReportYear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cboProduceYearlyGenreReportYear.Location = new System.Drawing.Point(83, 54);
            this.cboProduceYearlyGenreReportYear.Name = "cboProduceYearlyGenreReportYear";
            this.cboProduceYearlyGenreReportYear.Size = new System.Drawing.Size(121, 21);
            this.cboProduceYearlyGenreReportYear.TabIndex = 6;
            this.cboProduceYearlyGenreReportYear.SelectedIndexChanged += new System.EventHandler(this.cboProduceYearlyGenreReportYear_SelectedIndexChanged);
            // 
            // mnuProduceYearlyGenreReport
            // 
            this.mnuProduceYearlyGenreReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProduceYearlyGenreReportExit});
            this.mnuProduceYearlyGenreReport.Location = new System.Drawing.Point(0, 0);
            this.mnuProduceYearlyGenreReport.Name = "mnuProduceYearlyGenreReport";
            this.mnuProduceYearlyGenreReport.Size = new System.Drawing.Size(728, 24);
            this.mnuProduceYearlyGenreReport.TabIndex = 5;
            this.mnuProduceYearlyGenreReport.Text = "mnuProcessLoan";
            // 
            // mnuProduceYearlyGenreReportExit
            // 
            this.mnuProduceYearlyGenreReportExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuProduceYearlyGenreReportExit.Name = "mnuProduceYearlyGenreReportExit";
            this.mnuProduceYearlyGenreReportExit.Size = new System.Drawing.Size(37, 20);
            this.mnuProduceYearlyGenreReportExit.Text = "Exit";
            this.mnuProduceYearlyGenreReportExit.Click += new System.EventHandler(this.mnuProduceYearlyGenreReportExit_Click);
            // 
            // frmProduceYearlyGenreReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 444);
            this.Controls.Add(this.crtProduceYearlyGenreReportChart);
            this.Controls.Add(this.lblProduceYearlyGenreReportYear);
            this.Controls.Add(this.cboProduceYearlyGenreReportYear);
            this.Controls.Add(this.mnuProduceYearlyGenreReport);
            this.Name = "frmProduceYearlyGenreReport";
            this.Text = "Admin - [Produce Yearly Genre Report]";
            this.Load += new System.EventHandler(this.frmProduceYearlyGenreReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crtProduceYearlyGenreReportChart)).EndInit();
            this.mnuProduceYearlyGenreReport.ResumeLayout(false);
            this.mnuProduceYearlyGenreReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crtProduceYearlyGenreReportChart;
        private System.Windows.Forms.Label lblProduceYearlyGenreReportYear;
        private System.Windows.Forms.ComboBox cboProduceYearlyGenreReportYear;
        private System.Windows.Forms.MenuStrip mnuProduceYearlyGenreReport;
        private System.Windows.Forms.ToolStripMenuItem mnuProduceYearlyGenreReportExit;
    }
}