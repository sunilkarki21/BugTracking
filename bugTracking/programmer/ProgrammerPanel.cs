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
    public partial class ProgrammerPanel : Form
    {
        public ProgrammerPanel()
        {
            InitializeComponent();
        }

        private void button_solution_Click(object sender, EventArgs e)
        {
            user.BugSolution bs = new user.BugSolution();
            bs.Show();

        }

        private void ProgrammerPanel_Load(object sender, EventArgs e)
        {
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

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void btn_viewreport_Click(object sender, EventArgs e)
        {
            ViewReport br = new ViewReport();
            br.Show();
        }

        private void button_bughis_Click(object sender, EventArgs e)
        {
            FixedBug fix = new FixedBug();
            fix.Show();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            user.ChangePassword up = new user.ChangePassword();
            up.Show();
            this.Close();
        }

        private void btn_versioncontrol_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/sunilkarki21/BugTracking");

        }
    }
}
