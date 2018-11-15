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

namespace bugTracking
{
    public partial class FixedBug : Form
    {
        public FixedBug()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FixedBug_Load(object sender, EventArgs e)
        {
            // Data Grid View
            FixedBug vu = new FixedBug();
            DataTable dt = vu.Select_fixed();
            dgv_fixed.DataSource = dt;
        }

        public DataTable Select_fixed()
        {

            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            //getting data from database using dataadapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from bugsolve ", conn);
            //to hold data from database
            DataTable dt = new DataTable();
            sda.Fill(dt);//it means the fill in our database
            return dt;
        } 
    }
}
