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
    public partial class updateMenu : Form
    {
        public updateMenu()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tripInsert_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=OMAR-AMIR-PC;Initial Catalog=db project database sql;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string query = "UPDATE [trip] SET AVAILABLE_SEATS = @Value1 WHERE TRIP_ID = @Value2";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Value1", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Value2", textBox8.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update completed!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tRIPTableAdapter.Fill(this.db_project_database_sqlDataSet.TRIP);
        }
    }
}
