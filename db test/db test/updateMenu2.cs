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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace db_test
{
    public partial class updateMenu2 : Form
    {
        public updateMenu2()
        {
            InitializeComponent();
        }

        private void updateMenu2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_project_database_sqlDataSet.TRAIN' table. You can move, or remove it, as needed.
            //this.tRAINTableAdapter.Fill(this.db_project_database_sqlDataSet.TRAIN);
            // TODO: This line of code loads data into the 'db_project_database_sqlDataSet.TRIP' table. You can move, or remove it, as needed.
            // this.tRIPTableAdapter.Fill(this.db_project_database_sqlDataSet.TRIP);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tRIPTableAdapter.Fill(this.db_project_database_sqlDataSet.TRIP);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=OMAR-AMIR-PC;Initial Catalog=db project database sql;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string query = "UPDATE [trip] SET AVAILABLE_SEATS = @Value1 WHERE TRIP_ID = @Value2";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Value1", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Value2", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update completed!");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=OMAR-AMIR-PC;Initial Catalog=db project database sql;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string query = "UPDATE [train] SET TRAINNUMBER=@Value1, NAME=@Value2, DEPARTURE_TIME=@Value3, ARRIVAL_TIME=@Value4 WHERE TRAIN_ID = @Value5";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Value1", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Value2", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Value3", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Value4", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Value5", textBox7.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update completed!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tRAINTableAdapter.Fill(this.db_project_database_sqlDataSet.TRAIN);
        }
    }
}
