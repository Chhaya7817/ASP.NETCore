using System.Data;
using System.Data.SqlClient;
namespace NirvanaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection conn = new SqlConnection(@"Data Source=CHHAYADEV\MSSQLSERVER19;Initial Catalog=Nirvana_Demo;Integrated Security=True");
        private void btnSubmit_Click(object sender, EventArgs e)
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
                    Nirvana form = new Nirvana();
                    form.Show();
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

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}