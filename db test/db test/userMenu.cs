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
    public partial class userMenu : Form
    {
        public userMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldusername = oldusernamebutton.Text;
            string oldpassword = oldpasswordbutton.Text;
            string connectionString = "Data Source=OMAR-AMIR-PC;Initial Catalog=db project database sql;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string query = "UPDATE [user] SET username = @Value1, password = @Value2, mail = @Value3 WHERE username = @Username and password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Value1", newusernamebutton.Text);
                    cmd.Parameters.AddWithValue("@Value2", newpasswordbutton.Text);
                    cmd.Parameters.AddWithValue("@Value3", newmailbutton.Text);
                    cmd.Parameters.AddWithValue("@Username", oldusername);
                    cmd.Parameters.AddWithValue("@Password", oldpassword);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update completed!");
                }
            }
        }
    }
}
