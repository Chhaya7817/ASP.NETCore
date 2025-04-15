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
    public partial class Nirvana : Form
    {
        public Nirvana()
        {
            InitializeComponent();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            TT tt=new TT();
            tt.Show();
            //this.Hide();
        }

        private void btnBlotter_Click(object sender, EventArgs e)
        {
            Blotter blotter=new Blotter();
            blotter.Show();
        }

        private void btnAllocation_Click(object sender, EventArgs e)
        {
            Allocation allocation=new Allocation();
            allocation.Show();
        }
    }
}
