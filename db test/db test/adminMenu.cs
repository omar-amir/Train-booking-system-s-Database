using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_test
{
    public partial class adminMenu : Form
    {
        public adminMenu()
        {
            InitializeComponent();
        }

        private void adminMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_project_database_sqlDataSet.TRIP' table. You can move, or remove it, as needed.
            this.tRIPTableAdapter.Fill(this.db_project_database_sqlDataSet.TRIP);
            // TODO: This line of code loads data into the 'db_project_database_sqlDataSet.TRAIN' table. You can move, or remove it, as needed.
            //this.tRAINTableAdapter.Fill(this.db_project_database_sqlDataSet.TRAIN);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tRAINTableAdapter.Fill(this.db_project_database_sqlDataSet.TRAIN);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertMenu menu = new insertMenu();
            menu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateMenu2 menu = new updateMenu2();
            menu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deleteMenu menu = new deleteMenu();
            menu.Show();
            this.Hide();
        }
    }
}
