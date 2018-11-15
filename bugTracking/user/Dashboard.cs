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
    public partial class Dashboard : Form
    {
 
        public Dashboard()
        {
            InitializeComponent();
        }
        //logged in user name
        private void dashboard_Load(object sender, EventArgs e)
        {
            //
            lblLoggedInUser.Text = login.loggedIn;


            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            try
            {
                //  MySqlDataAdapter sda = new MySqlDataAdapter("Select count(*) from registration", conn);
                MySqlCommand numOfBugs = new MySqlCommand("Select count(id) from bug", conn);
                MySqlCommand numOfBugsSolved = new MySqlCommand("Select count(id) from bug where status = 'Solved'", conn);
                MySqlCommand numOfBugsUnsolved = new MySqlCommand("Select count(id) from bug where status = 'Unsolved'", conn);

                conn.Open();
                //count no of user in database
                Int32 rows_numOfBugs = Convert.ToInt32(numOfBugs.ExecuteScalar());
                Int32 rows_numOfBugsSolved = Convert.ToInt32(numOfBugsSolved.ExecuteScalar());
                Int32 rows_numOfBugsUnsolved = Convert.ToInt32(numOfBugsUnsolved.ExecuteScalar());
                 
                numOfBugs.Dispose();
                numOfBugsSolved.Dispose();
                numOfBugsUnsolved.Dispose();

                lbl_countbugreport.Text = rows_numOfBugs.ToString();
                label_bugsolved.Text = rows_numOfBugsSolved.ToString();
                label_bugactive.Text = rows_numOfBugsUnsolved.ToString();



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

        }

        //help button click
        private void btn_help_Click(object sender, EventArgs e)
        {
           Help help = new Help();
           help.Show();
           this.Hide();

        }
        //logout buttons
        private void btn_logout_Click(object sender, EventArgs e)
        {
            login logout = new login();
            logout.Show();
            this.Hide();

        }

        private void btn_add_bug_Click(object sender, EventArgs e)
        {
            BugReport bugreport = new BugReport();
            bugreport.Show();
            this.Hide();

        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Show();
        }

        private void btn__bug_report_Click(object sender, EventArgs e)
        {

        }
 
    }
}
