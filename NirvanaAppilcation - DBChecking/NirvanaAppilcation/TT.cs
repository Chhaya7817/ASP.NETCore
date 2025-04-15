using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NirvanaAppilcation
{
    public partial class TT : Form
    {
        public TT()
        {
            InitializeComponent();
        }

        public SqlConnection conn = new SqlConnection(@"Data Source=CHHAYADEV\MSSQLSERVER19;Initial Catalog=Training;Integrated Security=True");

        public int id=-1;

        private int currId()
        {
            string query=$"Select count(*) from T_TradedOrders";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                int rowCount = (int)command.ExecuteScalar();
                return rowCount;
            }
        }
        private Boolean isDataValid()
        {
            return inputSym.Text!="Enter Symbol" && inputSide.Text!="Select Side" &&
                inputAcc.Text!="Select Account" && inputPrice.Text!="0.0" && inputQty.Text!="0";
        }

        private void inputSym_Click(object sender, EventArgs e)
        {
            if (inputSym.Text == "Enter Symbol")
            {
                inputSym.Text = "";
            }
        }

        private void inputSym_Leave(object sender, EventArgs e)
        {
            if (inputSym.Text == "")
            {
                inputSym.Text = "Enter Symbol";
            }
        }

        private void inputSide_Click(object sender, EventArgs e)
        {
            if (inputSide.Text == "Select Side")
            {
                inputSide.Text = "";
            }
        }

        private void inputSide_Leave(object sender, EventArgs e)
        {
            if (inputSide.Text == "")
            {
                inputSide.Text = "Select Side";
            }
        }

        private void inputAcc_Click(object sender, EventArgs e)
        {
            if (inputAcc.Text == "Select Account")
            {
                inputAcc.Text = "";
            }
        }

        private void inputAcc_Leave(object sender, EventArgs e)
        {
            if (inputAcc.Text == "")
            {
                inputAcc.Text = "Select Account";
            }
        }

        private void inputQty_Leave(object sender, EventArgs e)
        {
            if (inputQty.Text == "")
            {
                inputQty.Text = "0.0";
            }
        }

        private void inputQty_Click(object sender, EventArgs e)
        {
            if (inputQty.Text == "0.0")
            {
                inputQty.Text = "";
            }
        }

        private void inputPrice_Leave(object sender, EventArgs e)
        {
            if (inputPrice.Text == "")
            {
                inputPrice.Text = "0.0";
            }
        }

        private void inputPrice_Click(object sender, EventArgs e)
        {
            if (inputPrice.Text == "0.0")
            {
                inputPrice.Text = "";
            }
        }

        

        private void inputQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar <48 || e.KeyChar >57) && e.KeyChar!=8)
            {
                e.Handled = true;
                return;
            }
            if(e.KeyChar ==46)
            {
                if((sender as TextBox).Text.IndexOf(e.KeyChar)!=-1)
                {
                    e.Handled=true;
                    return;
                }
            }
        }

        private void inputPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                    return;
                }
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
           
            if(isDataValid())
            {
                //  MessageBox.Show("Good To GGo");
                conn.Open();
                if(id==-1)
                {
                    id = currId()*2 +1;
                }
                else
                {
                    id += 2;
                }
                SqlCommand cmd = new SqlCommand("InsertOrder", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Symbol", SqlDbType.NVarChar).Value = inputSym.Text;
                cmd.Parameters.Add("@Side", SqlDbType.NVarChar).Value = inputSide.Text;
                cmd.Parameters.Add("@Account", SqlDbType.NVarChar).Value = inputAcc.Text;
                cmd.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = inputQty.Text;
                cmd.Parameters.Add("@AvgPrice", SqlDbType.NVarChar).Value = inputPrice.Text;
                cmd.Parameters.Add("@RemainingQuantity", SqlDbType.NVarChar).Value = inputQty.Text;
                cmd.Parameters.Add("@OrderStatus", SqlDbType.NVarChar).Value = "new";
                cmd.Parameters.Add("@CLOrderId", SqlDbType.NVarChar).Value = "Order"+id;
                cmd.Parameters.Add("@ParentCLOrderId", SqlDbType.NVarChar).Value = "Order" + id;
                
                cmd.Parameters.Add("@StagedOrderId", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@OriginalCLOrderId", SqlDbType.NVarChar).Value = "";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Order Placed Successfully!!!");

            }
            else
            {
                MessageBox.Show("Invalid Trdae");
            }


        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                //  MessageBox.Show("Good To GGo");
                conn.Open();
                if (id == -1)
                {
                    id = currId() * 2 + 1;
                }
                else
                {
                    id += 2;
                }
                SqlCommand cmd = new SqlCommand("InsertOrder1", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Symbol", SqlDbType.NVarChar).Value = inputSym.Text;
                cmd.Parameters.Add("@Side", SqlDbType.NVarChar).Value = inputSide.Text;
                cmd.Parameters.Add("@Account", SqlDbType.NVarChar).Value = inputAcc.Text;
                cmd.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = inputQty.Text;
                cmd.Parameters.Add("@AvgPrice", SqlDbType.NVarChar).Value = inputPrice.Text;
                cmd.Parameters.Add("@RemainingQuantity", SqlDbType.NVarChar).Value = inputQty.Text;
                cmd.Parameters.Add("@OrderStatus", SqlDbType.NVarChar).Value = "new";
                cmd.Parameters.Add("@CLOrderId", SqlDbType.NVarChar).Value = "Order" + id;
                cmd.Parameters.Add("@ParentCLOrderId", SqlDbType.NVarChar).Value = "Order" + id;

                cmd.Parameters.Add("@StagedOrderId", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@OriginalCLOrderId", SqlDbType.NVarChar).Value = "";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Order Placed Successfully!!!");

            }

            else
            {
                MessageBox.Show("Invalid Trdae");
            }
}
    }
}
