﻿using MySql.Data.MySqlClient;
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
    public partial class admin_dashboard : Form
    {
        public admin_dashboard()
        {
            InitializeComponent();
        }
        

        private void btn_viewuser_Click(object sender, EventArgs e)
        {
            user.ViewUsers vUser = new user.ViewUsers();
            vUser.Show();
        }

        private void admin_dashboard_Load(object sender, EventArgs e)
        {
             //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            try
            {
                //  MySqlDataAdapter sda = new MySqlDataAdapter("Select count(*) from registration", conn);
                MySqlCommand cmdcount = new MySqlCommand("Select count(id) from registration", conn);
                conn.Open();
                //count no of user in database
                Int32 rows_count = Convert.ToInt32(cmdcount.ExecuteScalar());
                 cmdcount.Dispose();
                 lbl_countuser.Text = rows_count.ToString();

            }catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step :CLose Connection
                conn.Close();
            }


        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            login logout = new login();
            logout.Show();
            this.Hide();
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            user.Help help = new user.Help();
            help.Show();
            this.Hide();
        }

        private void btn_viewbug_Click(object sender, EventArgs e)
        {
            user.BugReport bug = new user.BugReport();
            bug.Show();
            this.Hide();
        }

        private void btn_assign_Click(object sender, EventArgs e)
        {
            AssignBug ab = new AssignBug();
            ab.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FixedBug fb =new FixedBug();
            fb.Show();

        }

        private void button_history_Click(object sender, EventArgs e)
        {
            BugHistory bh = new BugHistory();
            bh.Show();
        }

        private void btn_versioncontrol_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/sunilkarki21/BugTracking");
        }
    }
}
