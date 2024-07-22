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
    public partial class deleteMenu : Form
    {
        public deleteMenu()
        {
            InitializeComponent();
        }

        private void deleteMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_project_database_sqlDataSet.TRIP' table. You can move, or remove it, as needed.
            //this.tRIPTableAdapter.Fill(this.db_project_database_sqlDataSet.TRIP);
            // TODO: This line of code loads data into the 'db_project_database_sqlDataSet.TRAIN' table. You can move, or remove it, as needed.
           // this.tRAINTableAdapter.Fill(this.db_project_database_sqlDataSet.TRAIN);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tRIPTableAdapter.Fill(this.db_project_database_sqlDataSet.TRIP);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=OMAR-AMIR-PC;Initial Catalog=db project database sql;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string query = "delete from [trip] where TRIP_ID = @Value1";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Value1", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("deletion completed!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tRAINTableAdapter.Fill(this.db_project_database_sqlDataSet.TRAIN);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=OMAR-AMIR-PC;Initial Catalog=db project database sql;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string query = "delete from [train] where TRAIN_ID = @Value1";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Value1", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("deletion completed!");
                }
            }
        }
    }
}
