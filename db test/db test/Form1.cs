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

namespace db_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_project_database_sqlDataSet.USER' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.db_project_database_sqlDataSet.USER);

        }
        SqlConnection conn = new SqlConnection(@"Data Source=OMAR-AMIR-PC;Initial Catalog=""db project database sql"";Integrated Security=True");
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=OMAR-AMIR-PC;Initial Catalog=db project database sql;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string query = "INSERT INTO [USER] VALUES (@Value1, @Value2, @Value3, @Value4)";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Value1", usernametextBox.Text);
                    cmd.Parameters.AddWithValue("@Value2", passwordtextBox.Text);
                    cmd.Parameters.AddWithValue("@Value3", mailtextbox.Text);
                    cmd.Parameters.AddWithValue("@Value4", roletextbox.Text);
                    MessageBox.Show("Registration completed!");
                    cmd.ExecuteNonQuery();
                    login user = new login();
                    user.Show();
                    this.Hide();
                }
            }
        }

        private void alreadyloginbutton_Click(object sender, EventArgs e)
        {
            login user = new login();
            user.Show();
            this.Hide();
        }
    }
}
