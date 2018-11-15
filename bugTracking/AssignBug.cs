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
    public partial class AssignBug : Form
    {
        public AssignBug()
        {
            InitializeComponent();
        }
         
        private void btn_appoint_Click(object sender, EventArgs e)
        {
            int BugID = 0;
            if (textBox_bugID.Text.Trim() != "")
            {
                BugID = int.Parse(textBox_bugID.Text.Trim());
            }
            string BugTitle = textBox_BugTitle.Text.Trim();

             
            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            try
            {
                MySqlCommand sda = new MySqlCommand("update bug set assignedto='"+ this.comboBox_assign.Text + "' WHERE bug.id= '" + this.textBox_bugID.Text+"'", conn);
                 //Open Connection
                conn.Open();
                int rows = sda.ExecuteNonQuery();
                //if Inserted rows is greater is greater than 0
                //Else set isSuccess to false, Save Failed

                if (rows > 0)
                {
                    MessageBox.Show("Bug Assigned. click ok to continue");
                    //Refresh Data Grid View
                    AssignBug vb = new AssignBug();
                    DataTable dt = vb.SelectBug();
                    dataGridView1.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("Bug failed to Assigned. click ok to continue");

                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //CLose Connection
                conn.Close();
            }



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
        public DataTable SelectUSer()
        {
            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            DataTable dt = new DataTable();

            try
            {

                //getting data from database using dataadapter 
                MySqlDataAdapter sda = new MySqlDataAdapter("Select username from registration where usertype='Debugger'", conn);

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
        private void AssignBug_Load(object sender, EventArgs e)
        {
            //creating datatable to hold the categories from database
            AssignBug a = new AssignBug();
            DataTable dtassign = a.SelectUSer();
            //specify datasource for assigned box
            comboBox_assign.DataSource = dtassign;
            //specify display member and valuemenber for combobox
            comboBox_assign.DisplayMember = "username";
            comboBox_assign.ValueMember = "username";

             
            //datagird view 
            AssignBug vu = new AssignBug();
            DataTable dt = vu.SelectBug();
            dataGridView1.DataSource = dt;

          
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Step 0: Find the index of the row clicked
            int index = e.RowIndex;

            //Step 1: Get Values from Row Clicked
            string BugID = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string BugTitle = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string ProjectTitle = dataGridView1.Rows[index].Cells[1].Value.ToString();

            //Step2: Write Values to the textbox to assign user
            textBox_bugID.Text = BugID;
            textBox_BugTitle.Text = BugTitle;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
