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
    public partial class Allocation : Form
    {
        public Allocation()
        {
            InitializeComponent();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void ultraSplitter1_Click(object sender, EventArgs e)
        {

        }

        private void Allocation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'irvingInvestorsDataSet.T_Sub' table. You can move, or remove it, as needed.
            this.t_SubTableAdapter.Fill(this.irvingInvestorsDataSet.T_Sub);

        }
    }
}
