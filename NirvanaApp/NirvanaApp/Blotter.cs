using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NirvanaApp
{
    public partial class Blotter : Form
    {
        public Blotter()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //vertical line
            //Pen pen = new Pen(Color.Black,1);
            //PointF pt1=new PointF(3F,15F);
            //PointF pt2 = new PointF(3F, 250F);
            //e.Graphics.DrawLine(pen, pt1, pt2);


            ////Horizontal line
            //PointF pt3 = new PointF(60F, 15F);
            //PointF pt4 = new PointF(597F, 15F);
            //e.Graphics.DrawLine(pen, pt3, pt4);

            /////////
            //PointF pt5 = new PointF(3F, 250F);
            //PointF pt6 = new PointF(597F, 250F);
            //e.Graphics.DrawLine(pen, pt5, pt6);
            ///////////
            //PointF pt7 = new PointF(597F, 15F);
            //PointF pt8 = new PointF(597F, 250F);
            //e.Graphics.DrawLine(pen, pt7, pt8);


         
        }

        private void Blotter_Load(object sender, EventArgs e)
        {

        }
    }
}
