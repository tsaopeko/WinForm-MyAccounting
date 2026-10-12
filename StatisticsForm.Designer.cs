namespace MyAccounting
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlBarChartCard = new System.Windows.Forms.Panel();
            this.chartMonthly = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbBarChartTitle = new System.Windows.Forms.Label();
            this.pnlPieChartCard = new System.Windows.Forms.Panel();
            this.chartCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBarChartCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthly)).BeginInit();
            this.pnlPieChartCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.lbTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnRefresh.Location = new System.Drawing.Point(909, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 50);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "重新整理";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseEnter += new System.EventHandler(this.btnRefresh_MouseEnter);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.btnRefresh_MouseLeave);
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lbTitle.Size = new System.Drawing.Size(159, 50);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "統計分析";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBarChartCard
            // 
            this.pnlBarChartCard.BackColor = System.Drawing.Color.White;
            this.pnlBarChartCard.Controls.Add(this.chartMonthly);
            this.pnlBarChartCard.Controls.Add(this.lbBarChartTitle);
            this.pnlBarChartCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBarChartCard.Location = new System.Drawing.Point(0, 50);
            this.pnlBarChartCard.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.pnlBarChartCard.Name = "pnlBarChartCard";
            this.pnlBarChartCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlBarChartCard.Size = new System.Drawing.Size(482, 561);
            this.pnlBarChartCard.TabIndex = 1;
            // 
            // chartMonthly
            // 
            this.chartMonthly.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "MainArea";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chartMonthly.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            legend1.IsTextAutoFit = false;
            legend1.Name = "MainLegend";
            this.chartMonthly.Legends.Add(legend1);
            this.chartMonthly.Location = new System.Drawing.Point(23, 57);
            this.chartMonthly.Margin = new System.Windows.Forms.Padding(0);
            this.chartMonthly.Name = "chartMonthly";
            this.chartMonthly.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "MainArea";
            series1.Legend = "MainLegend";
            series1.LegendText = "收入";
            series1.Name = "IncomeSeries";
            series2.ChartArea = "MainArea";
            series2.Legend = "MainLegend";
            series2.LegendText = "支出";
            series2.Name = "ExpenseSeries";
            this.chartMonthly.Series.Add(series1);
            this.chartMonthly.Series.Add(series2);
            this.chartMonthly.Size = new System.Drawing.Size(439, 481);
            this.chartMonthly.TabIndex = 1;
            this.chartMonthly.Text = "chart1";
            // 
            // lbBarChartTitle
            // 
            this.lbBarChartTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.lbBarChartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBarChartTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbBarChartTitle.ForeColor = System.Drawing.Color.White;
            this.lbBarChartTitle.Location = new System.Drawing.Point(20, 20);
            this.lbBarChartTitle.Name = "lbBarChartTitle";
            this.lbBarChartTitle.Size = new System.Drawing.Size(442, 23);
            this.lbBarChartTitle.TabIndex = 0;
            this.lbBarChartTitle.Text = "每月收支統計";
            this.lbBarChartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPieChartCard
            // 
            this.pnlPieChartCard.BackColor = System.Drawing.Color.White;
            this.pnlPieChartCard.Controls.Add(this.chartCategory);
            this.pnlPieChartCard.Controls.Add(this.label1);
            this.pnlPieChartCard.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPieChartCard.Location = new System.Drawing.Point(492, 50);
            this.pnlPieChartCard.Name = "pnlPieChartCard";
            this.pnlPieChartCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlPieChartCard.Size = new System.Drawing.Size(492, 561);
            this.pnlPieChartCard.TabIndex = 2;
            // 
            // chartCategory
            // 
            this.chartCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "PieArea";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.chartCategory.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BorderColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            legend2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            legend2.IsTextAutoFit = false;
            legend2.Name = "CategoryLegend";
            this.chartCategory.Legends.Add(legend2);
            this.chartCategory.Location = new System.Drawing.Point(23, 57);
            this.chartCategory.Margin = new System.Windows.Forms.Padding(0);
            this.chartCategory.Name = "chartCategory";
            this.chartCategory.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.BorderColor = System.Drawing.Color.Transparent;
            series3.ChartArea = "PieArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Color = System.Drawing.Color.White;
            series3.CustomProperties = "PieLabelStyle=Outside";
            series3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            series3.IsValueShownAsLabel = true;
            series3.Label = "#VALX\\n#PERCENT";
            series3.Legend = "CategoryLegend";
            series3.LegendText = "#VALX";
            series3.Name = "CategorySeries";
            series3.ShadowColor = System.Drawing.Color.Transparent;
            this.chartCategory.Series.Add(series3);
            this.chartCategory.Size = new System.Drawing.Size(449, 481);
            this.chartCategory.TabIndex = 1;
            this.chartCategory.Text = "chart1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "支出分類";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.pnlPieChartCard);
            this.Controls.Add(this.pnlBarChartCard);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlBarChartCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthly)).EndInit();
            this.pnlPieChartCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlBarChartCard;
        private System.Windows.Forms.Panel pnlPieChartCard;
        private System.Windows.Forms.Label lbBarChartTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthly;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategory;
        private System.Windows.Forms.Button btnRefresh;
    }
}