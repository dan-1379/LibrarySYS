namespace LibrarySYS
{
    partial class frmProduceYearlyFineReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mnuProduceYearlyFineReport = new System.Windows.Forms.MenuStrip();
            this.mnuProduceYearlyFineReportExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cboProduceYearlyFineReportYear = new System.Windows.Forms.ComboBox();
            this.lblProduceYearlyFineReportYear = new System.Windows.Forms.Label();
            this.crtProduceYearlyFineReportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mnuProduceYearlyFineReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtProduceYearlyFineReportChart)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuProduceYearlyFineReport
            // 
            this.mnuProduceYearlyFineReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProduceYearlyFineReportExit});
            this.mnuProduceYearlyFineReport.Location = new System.Drawing.Point(0, 0);
            this.mnuProduceYearlyFineReport.Name = "mnuProduceYearlyFineReport";
            this.mnuProduceYearlyFineReport.Size = new System.Drawing.Size(728, 24);
            this.mnuProduceYearlyFineReport.TabIndex = 1;
            this.mnuProduceYearlyFineReport.Text = "mnuProcessLoan";
            // 
            // mnuProduceYearlyFineReportExit
            // 
            this.mnuProduceYearlyFineReportExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuProduceYearlyFineReportExit.Name = "mnuProduceYearlyFineReportExit";
            this.mnuProduceYearlyFineReportExit.Size = new System.Drawing.Size(37, 20);
            this.mnuProduceYearlyFineReportExit.Text = "Exit";
            this.mnuProduceYearlyFineReportExit.Click += new System.EventHandler(this.mnuProduceYearlyFineReportExit_Click);
            // 
            // cboProduceYearlyFineReportYear
            // 
            this.cboProduceYearlyFineReportYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduceYearlyFineReportYear.FormattingEnabled = true;
            this.cboProduceYearlyFineReportYear.Items.AddRange(new object[] {
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
            this.cboProduceYearlyFineReportYear.Location = new System.Drawing.Point(83, 33);
            this.cboProduceYearlyFineReportYear.Name = "cboProduceYearlyFineReportYear";
            this.cboProduceYearlyFineReportYear.Size = new System.Drawing.Size(121, 21);
            this.cboProduceYearlyFineReportYear.TabIndex = 2;
            this.cboProduceYearlyFineReportYear.SelectedIndexChanged += new System.EventHandler(this.cboProduceYearlyFineReportYear_SelectedIndexChanged);
            // 
            // lblProduceYearlyFineReportYear
            // 
            this.lblProduceYearlyFineReportYear.AutoSize = true;
            this.lblProduceYearlyFineReportYear.Location = new System.Drawing.Point(12, 36);
            this.lblProduceYearlyFineReportYear.Name = "lblProduceYearlyFineReportYear";
            this.lblProduceYearlyFineReportYear.Size = new System.Drawing.Size(65, 13);
            this.lblProduceYearlyFineReportYear.TabIndex = 3;
            this.lblProduceYearlyFineReportYear.Text = "Select Year:";
            // 
            // crtProduceYearlyFineReportChart
            // 
            chartArea2.Name = "ChartArea1";
            this.crtProduceYearlyFineReportChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.crtProduceYearlyFineReportChart.Legends.Add(legend2);
            this.crtProduceYearlyFineReportChart.Location = new System.Drawing.Point(15, 90);
            this.crtProduceYearlyFineReportChart.Name = "crtProduceYearlyFineReportChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.crtProduceYearlyFineReportChart.Series.Add(series2);
            this.crtProduceYearlyFineReportChart.Size = new System.Drawing.Size(691, 313);
            this.crtProduceYearlyFineReportChart.TabIndex = 4;
            this.crtProduceYearlyFineReportChart.Text = "Fine Report";
            // 
            // frmProduceYearlyFineReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 444);
            this.Controls.Add(this.crtProduceYearlyFineReportChart);
            this.Controls.Add(this.lblProduceYearlyFineReportYear);
            this.Controls.Add(this.cboProduceYearlyFineReportYear);
            this.Controls.Add(this.mnuProduceYearlyFineReport);
            this.Name = "frmProduceYearlyFineReport";
            this.Text = "Admin - [Produce Yearly Fine Report]";
            this.Load += new System.EventHandler(this.frmProduceYearlyFineReport_Load);
            this.mnuProduceYearlyFineReport.ResumeLayout(false);
            this.mnuProduceYearlyFineReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtProduceYearlyFineReportChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuProduceYearlyFineReport;
        private System.Windows.Forms.ToolStripMenuItem mnuProduceYearlyFineReportExit;
        private System.Windows.Forms.ComboBox cboProduceYearlyFineReportYear;
        private System.Windows.Forms.Label lblProduceYearlyFineReportYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtProduceYearlyFineReportChart;
    }
}