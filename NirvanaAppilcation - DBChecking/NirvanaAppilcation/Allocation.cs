using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NirvanaAppilcation
{
    public partial class Allocation : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=CHHAYADEV\MSSQLSERVER19;Initial Catalog=Training;Integrated Security=True");
        SqlCommand cmd;
        public Allocation()
        {
            InitializeComponent();
        }


        private void Allocation_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string queryUnall = "select * from T_Group where Account='Unallocated'";
                cmd = new SqlCommand(queryUnall, conn);
                var reader = cmd.ExecuteReader();
                DataTable unallo = new DataTable();
                unallo.Load(reader);
                unallocatedGrid.DataSource = unallo;

                string queryAllo = "select * from T_Group where Account!='Unallocated'";
                cmd = new SqlCommand(queryAllo, conn);
                reader = cmd.ExecuteReader();
                DataTable allo = new DataTable();
                allo.Load(reader);
                allocatedGrid.DataSource = allo;

                BindCompanyFunds();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }
        }

        public void BindCompanyFunds()
        {
            cmd = new SqlCommand("select Account from T_CompanyFunds", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (unallocatedGrid.Rows.Count == 0)
            {
                MessageBox.Show("All orders are already allocated.", "Invalid Allocation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string acc_change = comboBox1.SelectedItem as string;
            int idx = unallocatedGrid.ActiveRow.VisibleIndex;
            string symbl = unallocatedGrid.Rows[idx].Cells[0].Value.ToString();
            string side = unallocatedGrid.Rows[idx].Cells[1].Value.ToString();
            string acc = acc_change;
        

            SqlCommand cmd = new SqlCommand("accChange", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Symbol", SqlDbType.NVarChar).Value = symbl;
            cmd.Parameters.Add("@Side", SqlDbType.NVarChar).Value = side;
            cmd.Parameters.Add("@Account", SqlDbType.NVarChar).Value = acc;

            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
            allocatedGrid.DataBind();
            allocatedGrid.Refresh();
            allocatedGrid.DataBind();
            allocatedGrid.Refresh();
            this.Close();
            Allocation all = new Allocation();
            all.Show();
            all.Focus();
        }
    }
}
