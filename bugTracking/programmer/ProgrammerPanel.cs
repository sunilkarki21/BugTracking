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
    }
}
