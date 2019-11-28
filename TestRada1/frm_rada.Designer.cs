namespace TestRada1
{
    partial class frm_rada
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
            if ( disposing && (components != null) )
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.bingMapDataProvider2 = new DevExpress.XtraMap.BingMapDataProvider();
            this.miniMapImageTilesLayer1 = new DevExpress.XtraMap.MiniMapImageTilesLayer();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.miniMapVectorItemsLayer1 = new DevExpress.XtraMap.MiniMapVectorItemsLayer();
            this.RadarPointChart = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.RadarPointChart)).BeginInit();
            this.SuspendLayout();
            this.bingMapDataProvider2.BingKey = "YOUR BING MAPS KEY";
            // 
            // RadarPointChart
            // 
            this.RadarPointChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadarPointChart.Legend.Name = "Default Legend";
            this.RadarPointChart.Location = new System.Drawing.Point(0, 0);
            this.RadarPointChart.Name = "RadarPointChart";
            this.RadarPointChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.RadarPointChart.Size = new System.Drawing.Size(1136, 616);
            this.RadarPointChart.TabIndex = 0;
            this.RadarPointChart.CustomDrawSeries += new DevExpress.XtraCharts.CustomDrawSeriesEventHandler(this.RadarPointChart_CustomDrawSeries);
            this.RadarPointChart.CustomPaint += new DevExpress.XtraCharts.CustomPaintEventHandler(this.RadarPointChart_CustomPaint);
            this.RadarPointChart.Paint += new System.Windows.Forms.PaintEventHandler(this.chartControl1_Paint);
            // 
            // frm_rada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 616);
            this.Controls.Add(this.RadarPointChart);
            this.Name = "frm_rada";
            this.Text = "frm_map";
            this.Load += new System.EventHandler(this.frm_map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RadarPointChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider2;
        private DevExpress.XtraMap.MiniMapImageTilesLayer miniMapImageTilesLayer1;
        private DevExpress.XtraMap.MapItemStorage mapItemStorage1;
        private DevExpress.XtraMap.MiniMapVectorItemsLayer miniMapVectorItemsLayer1;
        private DevExpress.XtraCharts.ChartControl RadarPointChart;

    }
}