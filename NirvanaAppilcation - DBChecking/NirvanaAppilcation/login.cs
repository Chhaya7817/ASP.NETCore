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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public SqlConnection conn=new SqlConnection(@"Data Source=CHHAYADEV\MSSQLSERVER19;Initial Catalog=Nirvana_Demo;Integrated Security=True");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = textUser.Text;
            password = textPass.Text;
            try
            {
                string query = "Select * from LoginData where username='" + username + "' and password='" + password + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable tempTable = new System.Data.DataTable();
                adapter.Fill(tempTable);
                if (tempTable.Rows.Count > 0)
                {
                   // Nirvana form = new Nirvana();
                   // form.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Details");
                    textUser.Clear();
                    textPass.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

    
    }
}
