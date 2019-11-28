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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataTable table;
        private void Form2_Load(object sender, EventArgs e)
        {
            repositoryItem.NullText = "Chọn";
            phuongTien.ColumnEdit = repositoryItem;
            table = new DataTable();
            table.Columns.Add("phuongTien", typeof(string));
            table.Columns.Add("xStart", typeof(string));
            table.Columns.Add("yStart", typeof(string));
            table.Columns.Add("xEnd", typeof(string));
            table.Columns.Add("yEnd", typeof(string));
            table.Columns.Add("buocNhay", typeof(string));
            table.Columns.Add("time", typeof(string));
            
          
            gridControl1.DataSource =  table;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Columns.Add("phuongTien", typeof(string));
            data.Columns.Add("xStart", typeof(string));
            data.Columns.Add("yStart", typeof(string));
            data.Columns.Add("xEnd", typeof(string));
            data.Columns.Add("yEnd", typeof(string));
            data.Columns.Add("buocNhay", typeof(string));
            data.Columns.Add("time", typeof(string));
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DateTime now = DateTime.Now;
                string time = gridView1.GetRowCellValue(i, "time").ToString();
                DateTime now2 = now.AddSeconds(Convert.ToInt32(time));


                

                data.Rows.Add(
                    gridView1.GetRowCellValue(i, "phuongTien"),
                   gridView1.GetRowCellValue(i, "xStart"),
                   gridView1.GetRowCellValue(i, "yStart"),
                   gridView1.GetRowCellValue(i, "xEnd"),
                   gridView1.GetRowCellValue(i, "yEnd"),
                   gridView1.GetRowCellValue(i, "buocNhay"),
                  now2
                   );
            }
            frm_rada5 frm = new frm_rada5( );
            frm.dt = data;
            frm.cl_mayBay = (Color)cl_mayBay.EditValue;
            frm.cl_thuyen = (Color)cl_Thuyen.EditValue;
            frm.cl_xe = (Color)cl_xe.EditValue;
            frm.ShowDialog();
           
        }
        int x2;
        int y2;
        public void tayBac()
        {
            
            x2 = rd.Next(0, 75);       
            y2 = rd.Next(0, 76 - x2);
                     
        }
        public void tayNam()
        {
            
            x2 = rd.Next(0, 100);
            y2 = rd.Next(x2+299, 400);

        }
        Random rd = new Random();
        public void dongBac()
        {
           
            x2 = rd.Next(300, 400);
            y2 = rd.Next(0,x2-299);
        }
        public void dongNam()
        {
          
            x2 = rd.Next(275, 400);
            y2 = rd.Next(650-x2, 400);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtRandom.Text);

           
            for (int i = 0; i < number; i++)
            {
                
               
                string time = rd.Next(2,3).ToString();
                int numberPhuongTien = rd.Next(1, 4);
                string phuongTien = "";
                if (numberPhuongTien == 1)
                {
                     phuongTien = "Thuyền";
                }
                else if (numberPhuongTien == 2)
                {
                     phuongTien = "Xe";
                }
                else
                {
                     phuongTien = "Máy Bay";
                }


                int xStart;
                int yStart;
                int xEnd;
                int yEnd;
                
                xStart = rd.Next(0, 1200);
                yStart = rd.Next(0, 800);
                xEnd = rd.Next(0, 1200);
                yEnd = rd.Next(0, 800);

                string BuocNhay = rd.Next(50, 100).ToString();
                table.Rows.Add(
                   phuongTien,
                   xStart.ToString(),
                   yStart.ToString(),
                   xEnd.ToString(),
                   yEnd.ToString(),
                  BuocNhay,
                  time
                   );
            }

            gridControl1.DataSource = table;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            table.Clear();
            gridControl1.DataSource = table;
        }
    }
}
