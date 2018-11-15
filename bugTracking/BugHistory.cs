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
    public partial class BugHistory : Form
    {
        public BugHistory()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataTable Select_bugs()
        {
            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            //getting data from database using dataadapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from bug", conn);
            //to hold data from database
            DataTable dt = new DataTable();
            sda.Fill(dt);//it means the fill in our database
            return dt;
        }

        private void BugHistory_Load(object sender, EventArgs e)
        {
            //creating datatable to hold the categories from database
            //to get project titile  from database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            MySqlDataReader myreader;
            try
            {

                //getting data from database using dataadapter 
                MySqlCommand sda = new MySqlCommand("Select BugTitle from bug", conn);
                //Create a Datatable to hold the records from database
                //Step 5:Open Connection
                conn.Open();
                myreader = sda.ExecuteReader();
                while (myreader.Read())
                {
                    cmb_bugname.Items.Add(myreader.GetValue(0).ToString());

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step 8: Close Connection
                conn.Close();
            }

            // Data Grid View
            BugHistory vu = new BugHistory();
            DataTable dt = vu.Select_bugs();
            dgv_history.DataSource = dt;


        }
        public DataTable Sort_usertype(string type)
        {
            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            //getting data from database using dataadapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from bug where BugTitle='" + type + "' ", conn);
            //to hold data from database
            DataTable dt = new DataTable();
            sda.Fill(dt);//it means the fill in our database
            return dt;
        }


        private void cmb_bugname_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmb_bugname.Text;
            BugHistory vu = new BugHistory();
            DataTable dt = vu.Sort_usertype(type);
            dgv_history.DataSource = dt;
        }

        //show all button click
        private void button1_Click(object sender, EventArgs e)
        {
            BugHistory vu = new BugHistory();
                DataTable dt = vu.Select_bugs();
            dgv_history.DataSource = dt;
         

        }
    }
}
