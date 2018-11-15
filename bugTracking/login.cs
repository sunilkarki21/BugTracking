using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace bugTracking
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        //initializing Static class to Send Value from this form to another form
        public static string loggedIn;
        public static string loggedIN_utype;

        //closing the program
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
            //login process
            private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;//username
            string pass = txtPassword.Text;//password
            //Decrypt Password Here
           // pass = EncryptDecrypt.Encrypt(pass);
            // string uType = this.cmbUsertype.GetItemText(this.cmbUsertype.SelectedItem);//gets item selected in usertype

            string uType = cmbUsertype.Text.Trim();

            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            
            MySqlDataAdapter sda = new MySqlDataAdapter("Select count(*) from registration where username='" + txtUser.Text+"'and password='"+txtPassword.Text+"' and usertype='"+ cmbUsertype .Text+ "'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);//it means the fill method retype the row from the datasource using sql query
             
            if (user == "" || pass == "" || uType == "" )
            {
            
                MessageBox.Show("U must Fill all the forms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            else
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    loggedIn = user;
                    loggedIN_utype = uType;
                    switch(uType)
                    {
                        case "Admin":
                        {
                                if (user == "admin")
                                {
                                    //Display Admin Dashboard
                                    this.Hide();
                                    loggedIN_utype = uType;
                                    admin_dashboard admin = new admin_dashboard();
                                    MessageBox.Show("Login succesful. Welcome back " + txtUser.Text + " !!");
                                    admin.Show();
                                }
                                else
                                {
                                     MessageBox.Show("Admin Login was failed. Please enter correct username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                                }

                                break;

                        }
                            //tester
                         case "User":
                        {
                                

                                //Display User Dashboard
                                this.Hide();
                                user.Dashboard umenu = new user.Dashboard();
                                MessageBox.Show("Login was succesful. Welcome back " + txtUser.Text + " !!");
                                umenu.Show();
                                break;

                            }
                            //programmer
                        case "Debugger":
                            {
                                //Display User Dashboard
                                this.Hide();
                                programmer.ProgrammerPanel umenu = new programmer.ProgrammerPanel();
                                MessageBox.Show("Login was succesful. Welcome back " + txtUser.Text + " !!");
                                umenu.Show();
                                break;
                            }

                    }
                   
                }
                else
                {
                    MessageBox.Show("incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            user.Register reg = new user.Register();
            reg.Show();
            this.Hide();

        }
    }
}
