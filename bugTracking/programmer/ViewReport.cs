using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bugTracking.programmer
{
    public partial class ViewReport : Form
    {
        public ViewReport()
        {
            InitializeComponent();
        }

        public DataTable Select_bug()
        {

            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            //getting data from database using dataadapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from bug where assignedto='"+login.loggedIn+"'", conn);
            //to hold data from database
            DataTable dt = new DataTable();
            sda.Fill(dt);//it means the fill in our database
            return dt;
        }
        private void ViewReport_Load(object sender, EventArgs e)
        {
            // Data Grid View
            ViewReport vu = new ViewReport();
            DataTable dt = vu.Select_bug();
            dataGridView1.DataSource = dt;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
