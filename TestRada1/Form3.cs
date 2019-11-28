using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TestRada1
{
    public partial class Form3 : Form
    {
        public Form3( )
        {
            InitializeComponent( );
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // pen, brush, Font, Image



            g.DrawEllipse(Pens.Red, 0, 0, 400, 400);

            Point p1 = new Point( )
            {
                X = 200,
                Y = 200
            };
            Point p2 = new Point( )
            {
                X = 200,
                Y = 400
            };

            g.DrawLine(Pens.Black, p1, p2);
        }

       

    }


    
}
