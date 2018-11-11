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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

     

        private void btn_help_ok_Click(object sender, EventArgs e)
        {
            string type = login.loggedIN_utype;
            if (type == "Admin")
            {
                admin_dashboard admin = new admin_dashboard();
                admin.Show();
                this.Hide();
            }
            else
            {
                Dashboard home = new Dashboard();
                home.Show();
                this.Close();
            }
        }
    }
}
