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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            //to hold data from database
            string uname = login.loggedIn;
            user_name.Text = uname;
             
            DataTable dt = new DataTable();
            MySqlCommand sda = new MySqlCommand("Select * from registration where username='" + this.user_name.Text + "'", conn);
            MySqlDataReader myreader;
            conn.Open();
            myreader = sda.ExecuteReader();
            while(myreader.Read())
            {
                string sid = myreader.GetInt32("id").ToString();
               // string sname = myreader.GetString("username");

                user_id.Text = sid;
                // user_name.Text = sname;
  
           }


        }

        private void btn_changeDetails_Click(object sender, EventArgs e)
        {
            string userpassword = txt_pwd.Text.ToString();
            string userconpwd = txt_cnfm.Text.Trim();
              

            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");

            try
            {

                if (userpassword == userconpwd)
                {
                    MySqlCommand sda = new MySqlCommand("update registration set password='" + this.txt_pwd.Text + "',confirm_Password='" + this.txt_cnfm.Text + "' where id='"+this.user_id.Text+"'", conn);
                    //Open Connection
                    conn.Open();
                    int rows = sda.ExecuteNonQuery();

                    //if Inserted rows is greater is greater than 0
                    //Else set isSuccess to false, Save Failed


                    if (rows > 0)
                    {
                        MessageBox.Show("Password changed. Please click ok to continue");
                        //going to dashboard page
                        Dashboard dash = new Dashboard();
                        dash.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password failed to changed. click ok to continue");

                    }
                  
                }
                else
                {
                    MessageBox.Show("Password didnot matched !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
              

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //CLose Connection
                conn.Close();
            }
        }
    }
}
