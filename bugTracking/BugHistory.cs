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

namespace bugTracking
{
    public partial class BugHistory : Form
    {
        public BugHistory()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DataTable SelectBug()
        {
            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            DataTable dt = new DataTable();

            try
            {

                //getting data from database using dataadapter 
                MySqlDataAdapter sda = new MySqlDataAdapter("Select * from bug", conn);

                //Create a Datatable to hold the records from database
                //Step 5:Open Connection
                conn.Open();

                //Step 6: Use Adapter to Fill dt
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step 8: Close Connection
                conn.Close();
            }
            return dt;
        }

        private void BugHistory_Load(object sender, EventArgs e)
        {
            //creating datatable to hold the categories from database
            AssignBug a = new AssignBug();
            DataTable dtassign = a.SelectUSer();
            //specify datasource for assigned box
            cmb_bugname.DataSource = dtassign;
            //specify display member and valuemenber for combobox
            cmb_bugname.DisplayMember = "BugTitle";
            cmb_bugname.ValueMember = "BugTitle";


           
        }
    }
}
