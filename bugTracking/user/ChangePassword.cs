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

        public DataTable Select_userdetail()
        {
            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            //to hold data from database
            DataTable dt = new DataTable();
            try
            {
                //getting data from database using dataadapter 
                MySqlDataAdapter sda = new MySqlDataAdapter("Select * from bug", conn);


                sda.Fill(dt);//it means the fill in our database

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step :CLose Connection
                conn.Close();
            }
            return dt;

        }
 
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword();
            DataTable dt = change.Select_userdetail();
            user_id.Text=data


        }
    }
}
