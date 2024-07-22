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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void userloginbutton_Click(object sender, EventArgs e)
        {
            string id = enterusernamelogintextBox1.Text;
            string name = enterpasswordlogintextbox.Text;

            string query = "SELECT * FROM [user] WHERE username = @Username AND password = @Password and role='user'";

            using (SqlConnection connection = new SqlConnection("Data Source=OMAR-AMIR-PC;Initial Catalog=db project database sql;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", enterusernamelogintextBox1.Text);
                    command.Parameters.AddWithValue("@Password", enterpasswordlogintextbox.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        id = enterusernamelogintextBox1.Text;
                        name = enterpasswordlogintextbox.Text;
                        MessageBox.Show("Login is completed!");
                        userMenu admin = new userMenu();
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        enterusernamelogintextBox1.Clear();
                        enterpasswordlogintextbox.Clear();
                        enterusernamelogintextBox1.Focus();
                    }
                }
            }
        }

        private void adminloginbutton_Click(object sender, EventArgs e)
        {
            string id = enterusernamelogintextBox1.Text;
            string name = enterpasswordlogintextbox.Text;

            string query = "SELECT * FROM [user] WHERE username = @Username AND password = @Password and role='admin'";

            using (SqlConnection connection = new SqlConnection("Data Source=OMAR-AMIR-PC;Initial Catalog=db project database sql;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", enterusernamelogintextBox1.Text);
                    command.Parameters.AddWithValue("@Password", enterpasswordlogintextbox.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        id = enterusernamelogintextBox1.Text;
                        name = enterpasswordlogintextbox.Text;
                        MessageBox.Show("Login is completed!");
                        adminMenu admin = new adminMenu();
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        enterusernamelogintextBox1.Clear();
                        enterpasswordlogintextbox.Clear();
                        enterusernamelogintextBox1.Focus();
                    }
                }
            }
        }
    }
}
