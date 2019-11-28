using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;

using System.IO;
using System.Drawing.Design;
using System.Drawing;//Dinh nghia cac  doi tuong ve co ban+ doi tuong graphic
using System.Drawing.Drawing2D;//Cung cap cac doi tuong ve vector 2 chieu
using System.Drawing.Imaging;//Thao tac vs hinh anh
using System.Drawing.Printing;//Thuc hien in, cac tac vu in an
using System.Drawing.Text;//Thuc hien ve voi Font


namespace TestRada1
{
    public partial class frm_rada : DevExpress.XtraEditors.XtraForm
    {
        public frm_rada( )
        {
            InitializeComponent( );
        }

        private void frm_map_Load(object sender, EventArgs e)
        {
            // Create a new chart.

             //Add a radar series to it.
            Series series1 = new Series("Series 1", ViewType.RadarPoint);

            // Populate the series with points.
            //series1.Points.Add(new SeriesPoint(0, 90));
            //series1.Points.Add(new SeriesPoint(90, 95));
            //series1.Points.Add(new SeriesPoint(180, 50));
            //series1.Points.Add(new SeriesPoint(270, 55));
            //series1.Points.Add(new SeriesPoint(0, 180));
            series1.Points.Add(new SeriesPoint(90, 185));
            series1.Points.Add(new SeriesPoint(180, 300));
            series1.Points.Add(new SeriesPoint(270, 275));

            // Add the series to the chart.
            RadarPointChart.Series.Add(series1);

            // Flip the diagram (if necessary).
            ((RadarDiagram) RadarPointChart.Diagram).StartAngleInDegrees = 180;
            ((RadarDiagram) RadarPointChart.Diagram).RotationDirection =
                RadarDiagramRotationDirection.Counterclockwise;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle( );
            chartTitle1.Text = "Radar Point Chart";
            RadarPointChart.Titles.Add(chartTitle1);
            RadarPointChart.Legend.Visible = true;

            // Add the chart to the form.
            RadarPointChart.Dock = DockStyle.Fill;
            this.Controls.Add(RadarPointChart);

            
            
        }

        private void chartControl1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = RadarPointChart.CreateGraphics( );
            //g.DrawLine(Pens.Red, 30, 30, 400, 400);// sử dụng drawLine để vẽ đường
        }

        private void RadarPointChart_CustomPaint(object sender, CustomPaintEventArgs e)
        {
            if ( RadarPointChart.Diagram is DevExpress.XtraCharts.XYDiagram )
            {
                DevExpress.XtraCharts.XYDiagram2D diagram2 = (DevExpress.XtraCharts.XYDiagram) RadarPointChart.Diagram;
                Point coords = diagram2.DiagramToPoint(0, 0).Point;

                Pen pen = new Pen(Color.Red, 2);

                e.Graphics.DrawRectangle(pen, coords.X, coords.Y, 10, 10);

            }   
        }

        private void RadarPointChart_CustomDrawSeries(object sender, CustomDrawSeriesEventArgs e)
        {
            // Add a radar series to it. 
            Series series1 = new Series("Series 2", ViewType.RadarLine);
            // Populate the series with points. 
            series1.Points.Add(new SeriesPoint(0, 300));
            series1.Points.Add(new SeriesPoint(300, 400));
            // Add the series to the chart. 
            RadarPointChart.Series.Add(series1);

           // RadarPointChart.Controls.Add();
        }


        
    }
}