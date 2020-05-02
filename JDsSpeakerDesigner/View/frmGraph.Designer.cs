namespace View
{
    partial class frmGraph
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chtSPL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtSPL)).BeginInit();
            this.SuspendLayout();
            // 
            // chtSPL
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.CursorX.Interval = 10D;
            chartArea1.CursorY.Interval = 10D;
            chartArea1.Name = "chrtSPL";
            this.chtSPL.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtSPL.Legends.Add(legend1);
            this.chtSPL.Location = new System.Drawing.Point(13, 14);
            this.chtSPL.Name = "chtSPL";
            series1.ChartArea = "chrtSPL";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Plot";
            this.chtSPL.Series.Add(series1);
            this.chtSPL.Size = new System.Drawing.Size(747, 602);
            this.chtSPL.TabIndex = 0;
            this.chtSPL.Text = "MainChart";
            title1.Name = "tltSPL";
            title1.Text = "SPL";
            this.chtSPL.Titles.Add(title1);
            this.chtSPL.Click += new System.EventHandler(this.chtSPL_Click);
            // 
            // frmGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 627);
            this.Controls.Add(this.chtSPL);
            this.Name = "frmGraph";
            this.Text = "Graph";
            ((System.ComponentModel.ISupportInitialize)(this.chtSPL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtSPL;

    }
}