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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
           
            string Uname = textBox_user.Text.Trim();
            string Pwd = textBox_pwd.Text.Trim();
            string confirm_pwd = textBox_conPwd.Text.Trim();
            string UserType = comboBox_usertype.Text.Trim();
            
             
            if (Pwd == confirm_pwd)
            {
                //connecting to the database
                MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");

                MySqlCommand sda = new MySqlCommand("INSERT INTO registration (username, password, confirm_Password, userType) VALUES ('" + this.textBox_user.Text + "','" + this.textBox_pwd.Text + "','" + this.textBox_conPwd.Text + "','" + this.comboBox_usertype.Text + "')", conn);
                MySqlDataReader MyReader;
                conn.Open();
                MyReader = sda.ExecuteReader();
                MessageBox.Show("You are now registered. Please click ok");
                //going to login page
                login login = new login();
                login.Show();
                this.Hide();
               

            }
            else
            {
                MessageBox.Show( "Password didnot matched !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

         }
    }
}
