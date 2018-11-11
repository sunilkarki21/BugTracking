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
            lblLoggedInUser.Text = login.loggedIn;
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
 
    }
}
