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
            this.mnuProduceYearlyGenreReport = new System.Windows.Forms.MenuStrip();
            this.mnuProduceYearlyGenreReportExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Book Genre Breakdown";
            // 
            // frmProduceYearlyGenreReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crtProduceYearlyGenreReportChart);
            this.Controls.Add(this.mnuProduceYearlyGenreReport);
            this.Name = "frmProduceYearlyGenreReport";
            this.ShowIcon = false;
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
        private System.Windows.Forms.MenuStrip mnuProduceYearlyGenreReport;
        private System.Windows.Forms.ToolStripMenuItem mnuProduceYearlyGenreReportExit;
        private System.Windows.Forms.Label label1;
    }
}