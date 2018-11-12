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

namespace bugTracking.user
{
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();
        }
     
        public DataTable Select_user()
        {
            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            //getting data from database using dataadapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from registration", conn);
            //to hold data from database
            DataTable dt = new DataTable();
            sda.Fill(dt);//it means the fill in our database
            return dt;
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            // Data Grid View
            ViewUsers vu = new ViewUsers();
            DataTable dt = vu.Select_user();
            dataGridView1.DataSource = dt;
        }
        public DataTable Search(string keyword)
        {
            

            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
                //getting data from database using dataadapter 
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM registration WHERE username LIKE '%" + keyword + "%'", conn);
                //to hold data from database
                DataTable dt = new DataTable();
                sda.Fill(dt);//it means the fill in our database
                return dt;
           
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            //get keyword from textbox 
            string keyword = text_search.Text;
            ViewUsers vu1 = new ViewUsers();
            //check if keywords have value or not
            if (keyword != null)
            {
                //show user based based on keywords

                DataTable dt = vu1.Search(keyword);
                dataGridView1.DataSource = dt;

            }
            else
            {
                //show all user from database
                DataTable dt = vu1.Select_user();
                dataGridView1.DataSource = dt;
            }
        }

        private void btn_userdelete_Click(object sender, EventArgs e)
        {
            string selected_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            //getting data from database using dataadapter 
            MySqlCommand sda = new MySqlCommand("delete from registration where id='" + selected_id + "'", conn);
          
            MySqlDataReader MyReader2;
            conn.Open();
            MyReader2 = sda.ExecuteReader();
            
            MessageBox.Show("Data Deleted... click Refresh ");
   
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ViewUsers vu = new ViewUsers();
            DataTable dt = vu.Select_user();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
