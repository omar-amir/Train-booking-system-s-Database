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
    public partial class insertMenu : Form
    {
        public insertMenu()
        {
            InitializeComponent();
        }

        private void trainInsert_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=OMAR-AMIR-PC;Initial Catalog=db project database sql;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string query = "INSERT INTO [TRAIN] VALUES (@Value1, @Value2, @Value3, @Value4, @value5)";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Value1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Value2", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Value3", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Value4", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Value5", textBox2.Text);
                    MessageBox.Show("Train added!");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void insertMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_project_database_sqlDataSet.TRIP' table. You can move, or remove it, as needed.
            //this.tRIPTableAdapter.Fill(this.db_project_database_sqlDataSet.TRIP);
            // TODO: This line of code loads data into the 'db_project_database_sqlDataSet.TRAIN' table. You can move, or remove it, as needed.
            //this.tRAINTableAdapter.Fill(this.db_project_database_sqlDataSet.TRAIN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tRAINTableAdapter.Fill(this.db_project_database_sqlDataSet.TRAIN);
        }

        private void tripInsert_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=OMAR-AMIR-PC;Initial Catalog=db project database sql;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                //string query = "INSERT INTO [TRIP] VALUES (@Value1, @Value2, @Value3)";
                string query = "insert into trip (TRIP_ID,AVAILABLE_SEATS) values (@Value1,@Value3);";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Value1", textBox8.Text);
                    cmd.Parameters.AddWithValue("@Value3", textBox6.Text);
                    MessageBox.Show("Trip added!");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tRIPTableAdapter.Fill(this.db_project_database_sqlDataSet.TRIP);
        }
    }
}
