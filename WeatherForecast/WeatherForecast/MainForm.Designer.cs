namespace WeatherForecast
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 22D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, -3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 0D);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CityNum = new System.Windows.Forms.Label();
            this.NumimageList = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DetailText = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.minSize_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.search_txtbox = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CityNum
            // 
            this.CityNum.AutoSize = true;
            this.CityNum.Font = new System.Drawing.Font("微软雅黑", 30.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityNum.ForeColor = System.Drawing.Color.Red;
            this.CityNum.Location = new System.Drawing.Point(44, 70);
            this.CityNum.Name = "CityNum";
            this.CityNum.Size = new System.Drawing.Size(108, 56);
            this.CityNum.TabIndex = 0;
            this.CityNum.Text = "北京";
            // 
            // NumimageList
            // 
            this.NumimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("NumimageList.ImageStream")));
            this.NumimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.NumimageList.Images.SetKeyName(0, "Number_000.png");
            this.NumimageList.Images.SetKeyName(1, "Number_001.png");
            this.NumimageList.Images.SetKeyName(2, "Number_002.png");
            this.NumimageList.Images.SetKeyName(3, "Number_003.png");
            this.NumimageList.Images.SetKeyName(4, "Number_004.png");
            this.NumimageList.Images.SetKeyName(5, "Number_005.png");
            this.NumimageList.Images.SetKeyName(6, "Number_006.png");
            this.NumimageList.Images.SetKeyName(7, "Number_007.png");
            this.NumimageList.Images.SetKeyName(8, "Number_008.png");
            this.NumimageList.Images.SetKeyName(9, "Number_009.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(170, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(244, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // DetailText
            // 
            this.DetailText.BackColor = System.Drawing.Color.Turquoise;
            this.DetailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailText.ForeColor = System.Drawing.Color.Coral;
            this.DetailText.Location = new System.Drawing.Point(356, 70);
            this.DetailText.Multiline = true;
            this.DetailText.Name = "DetailText";
            this.DetailText.ReadOnly = true;
            this.DetailText.Size = new System.Drawing.Size(130, 66);
            this.DetailText.TabIndex = 3;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineWidth = 0;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Interval = 0D;
            chartArea1.AxisY.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 87.56219F;
            chartArea1.InnerPlotPosition.Width = 94.64894F;
            chartArea1.InnerPlotPosition.X = 1.67553F;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(1, 204);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.MarkerSize = 10;
            series1.Name = "High";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            series2.IsValueShownAsLabel = true;
            series2.MarkerSize = 10;
            series2.Name = "Low";
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(582, 237);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // minSize_btn
            // 
            this.minSize_btn.BackColor = System.Drawing.Color.Turquoise;
            this.minSize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minSize_btn.FlatAppearance.BorderSize = 0;
            this.minSize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minSize_btn.Font = new System.Drawing.Font("黑体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minSize_btn.ForeColor = System.Drawing.Color.Black;
            this.minSize_btn.Location = new System.Drawing.Point(521, 12);
            this.minSize_btn.Name = "minSize_btn";
            this.minSize_btn.Size = new System.Drawing.Size(28, 23);
            this.minSize_btn.TabIndex = 5;
            this.minSize_btn.Text = "-";
            this.minSize_btn.UseVisualStyleBackColor = false;
            this.minSize_btn.Click += new System.EventHandler(this.minSize_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Turquoise;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("黑体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close_btn.ForeColor = System.Drawing.Color.Black;
            this.close_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.close_btn.Location = new System.Drawing.Point(555, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(28, 23);
            this.close_btn.TabIndex = 6;
            this.close_btn.Text = "×";
            this.close_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // search_txtbox
            // 
            this.search_txtbox.Location = new System.Drawing.Point(42, 177);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.Size = new System.Drawing.Size(100, 21);
            this.search_txtbox.TabIndex = 7;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.DarkGray;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_btn.ForeColor = System.Drawing.Color.Black;
            this.search_btn.Location = new System.Drawing.Point(148, 175);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(55, 23);
            this.search_btn.TabIndex = 8;
            this.search_btn.Text = "查询";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(595, 453);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_txtbox);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.minSize_btn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.DetailText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CityNum);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "天气预报";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label CityNum;
        private System.Windows.Forms.ImageList NumimageList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox DetailText;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button minSize_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.TextBox search_txtbox;
        private System.Windows.Forms.Button search_btn;
    }
}

