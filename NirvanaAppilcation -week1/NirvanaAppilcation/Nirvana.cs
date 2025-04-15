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
        public Nirvana()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Blotter blotter = new Blotter();    
            blotter.Show();
        }
    }
}
