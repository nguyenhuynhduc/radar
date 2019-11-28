namespace TestRada1
{
    partial class frm_rada5
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
            this.components = new System.ComponentModel.Container();
            this.RadarLineChart = new DevExpress.XtraCharts.ChartControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.RadarLineChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // RadarLineChart
            // 
            this.RadarLineChart.AppearanceNameSerializable = "Dark Flat";
            this.RadarLineChart.AutoLayout = false;
            this.RadarLineChart.BackColor = System.Drawing.Color.Transparent;
            this.RadarLineChart.BackImage.Stretch = true;
            this.RadarLineChart.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.RadarLineChart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.RadarLineChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadarLineChart.IndicatorsPaletteName = "Yellow Orange";
            this.RadarLineChart.Legend.Name = "Default Legend";
            this.RadarLineChart.Location = new System.Drawing.Point(0, 0);
            this.RadarLineChart.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.RadarLineChart.LookAndFeel.UseDefaultLookAndFeel = false;
            this.RadarLineChart.Name = "RadarLineChart";
            this.RadarLineChart.PaletteBaseColorNumber = 3;
            this.RadarLineChart.PaletteName = "Concourse";
            this.RadarLineChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.RadarLineChart.Size = new System.Drawing.Size(600, 600);
            this.RadarLineChart.TabIndex = 0;
            this.RadarLineChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RadarLineChart_MouseClick);
            this.RadarLineChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RadarLineChart_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(1, 678);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(277, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // frm_rada5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.RadarLineChart);
            this.Name = "frm_rada5";
            this.Text = "frm_rada5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_rada5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RadarLineChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl RadarLineChart;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}