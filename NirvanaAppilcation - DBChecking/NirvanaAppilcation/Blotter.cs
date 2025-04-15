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
    public partial class Blotter : Form
    {
        public Blotter()
        {
            InitializeComponent();
        }

        private void Blotter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDataSet.T_TradedOrders' table. You can move, or remove it, as needed.
            this.t_TradedOrdersTableAdapter.Fill(this.trainingDataSet.T_TradedOrders);
            // TODO: This line of code loads data into the 'trainingDataSet.T_OrderAndSub' table. You can move, or remove it, as needed.
            this.t_OrderAndSubTableAdapter.Fill(this.trainingDataSet.T_OrderAndSub);

        }
    }
}
