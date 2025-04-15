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
    public partial class TT : Form
    {
        public TT()
        {
            InitializeComponent();
        }

        private void TT_Load(object sender, EventArgs e)
        {
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g=this.panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 3);
            PointF pt1 = new PointF(0.0F, 0.0F);
            PointF pt2 = new PointF(0.0F, 100.0F);
            g.DrawLine(pen, pt1,pt2);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
