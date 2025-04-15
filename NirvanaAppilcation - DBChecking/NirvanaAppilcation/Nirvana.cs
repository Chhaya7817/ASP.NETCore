using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NirvanaAppilcation
{
    public partial class Nirvana : Form
    {
        private Blotter blotterTool;
        private TT TTtool;
        private Allocation allocationTool;
        private PM PMtool;
        private Closing closingTool;
        public Nirvana()
        {
            int num=(int) new login().ShowDialog();
            this.InitializeComponent();

        }

        private void toolStripTT_Click(object sender, EventArgs e)
        {
            if (this.TTtool == null || this.TTtool.IsDisposed)
            {
                this.TTtool = new TT();
                TTtool.Show();
                TTtool.BringToFront();

            }
            else
            {
                TTtool.BringToFront();
            }

        }

        private void toolStripBlotter_Click(object sender, EventArgs e)
        {
            if (this.blotterTool == null || this.blotterTool.IsDisposed)
            {
                this.blotterTool = new Blotter();
                blotterTool.Show();
                blotterTool.BringToFront();

            }
            else
            {
                blotterTool.BringToFront();
            }
        }

        private void toolStripAllocation_Click(object sender, EventArgs e)
        {
            if (this.allocationTool == null || this.allocationTool.IsDisposed)
            {
                this.allocationTool = new Allocation();
                allocationTool.Show();
                allocationTool.BringToFront();

            }
            else
            {
                allocationTool.BringToFront();
            }
        }

        private void toolStripClosing_Click(object sender, EventArgs e)
        {
            if (this.closingTool == null || this.closingTool.IsDisposed)
            {
                this.closingTool = new Closing();
                closingTool.Show();
                closingTool.BringToFront();

            }
            else
            {
                closingTool.BringToFront();
            }
        }

        private void toolStripPM_Click(object sender, EventArgs e)
        {
            if (this.PMtool == null || this.PMtool.IsDisposed)
            {
                this.PMtool = new PM();
                PMtool.Show();
                PMtool.BringToFront();

            }
            else
            {
                PMtool.BringToFront();
            }
        }

        private void Nirvana_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.TTtool!=null) this.TTtool.Close();
            if(this.blotterTool!=null) this.blotterTool.Close();
            if(this.allocationTool!=null) this.allocationTool.Close();  
            if(this.closingTool!=null) this.closingTool.Close();
            if(this.PMtool!=null) this.PMtool.Close();
        }
    }
}
