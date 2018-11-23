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
        public DataTable Select_bugtitle()
        {
            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            DataTable dt = new DataTable();

            try
            {

                //getting data from database using dataadapter 
                MySqlDataAdapter sda = new MySqlDataAdapter("Select bugtitle from bugsolve", conn);

                //Create a Datatable to hold the records from database
                //Step 5:Open Connection
                conn.Open();

                //Step 6: Use Adapter to Fill dt
                sda.Fill(dt);
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
            return dt;
        }
        public DataTable Select_debugtitle()
        {
            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            DataTable dt = new DataTable();

            try
            {

                //getting data from database using dataadapter 
                MySqlDataAdapter sda = new MySqlDataAdapter("Select bugtitle from bugsolve where fixedby='" + login.loggedIn + "'", conn);

                //Create a Datatable to hold the records from database
                //Step 5:Open Connection
                conn.Open();

                //Step 6: Use Adapter to Fill dt
                sda.Fill(dt);
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
            return dt;
        }
        private void FixedBug_Load(object sender, EventArgs e)
        {

            string type = login.loggedIN_utype;
            if (type == "Admin")
            {
                

                //creating datatable to hold the categories from database
                FixedBug a = new FixedBug();
                DataTable dtassign = a.Select_bugtitle();
                //specify datasource for assigned box
                comboBox1.DataSource = dtassign;
                //specify display member and valuemenber for combobox
                comboBox1.DisplayMember = "bugtitle";
                comboBox1.ValueMember = "bugtitle";

             }
            else
            {
                
                //creating datatable to hold the categories from database
                FixedBug a = new FixedBug();
                DataTable dtassign = a.Select_debugtitle();
                //specify datasource for assigned box
                comboBox1.DataSource = dtassign;
                //specify display member and valuemenber for combobox
                comboBox1.DisplayMember = "bugtitle";
                comboBox1.ValueMember = "bugtitle";
            }


        }
        public DataTable Sort_bugtitle(string title)
        {
            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            //getting data from database using dataadapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from bugsolve where bugtitle='" + title + "' ", conn);
            //to hold data from database
            DataTable dt = new DataTable();
            sda.Fill(dt);//it means the fill in our database
            return dt;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string title = comboBox1.Text;
            FixedBug vu = new FixedBug();
            DataTable dt = vu.Sort_bugtitle(title);
            dgv_fixed.DataSource = dt;
        }

        private void button_showall_Click(object sender, EventArgs e)
        {
            string type = login.loggedIN_utype;
            if (type == "Admin")
            {
                // Data Grid View
                //connecting to the database
                MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
                //getting data from database using dataadapter
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM bugsolve", conn);

                //to hold data from database
                DataTable dt = new DataTable();
                sda.Fill(dt);//it means the fill in our database

                dgv_fixed.DataSource = dt;
 
                conn.Close();
            }
            else
            {
                // Data Grid View
                //connecting to the database
                MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
                //getting data from database using dataadapter 
                MySqlDataAdapter adap = new MySqlDataAdapter("Select * from bugsolve where fixedby='" + login.loggedIn + "'", con);
                //to hold data from database
                DataTable d = new DataTable();
                adap.Fill(d);//it means the fill in our database
                dgv_fixed.DataSource = d;
 
            }

        }
    }
}

