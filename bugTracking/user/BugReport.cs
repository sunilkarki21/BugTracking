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
    public partial class BugReport : Form
    {
 
        public BugReport()
        {
            InitializeComponent();
        }
    
         
        public DataTable Select_bug()
        {
            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            //to hold data from database
            DataTable dt = new DataTable();
            try { 
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

        private void BugReport_load(object sender, EventArgs e)
        {
            BugReport vb = new BugReport();
            DataTable dt = vb.Select_bug();
            dgv_bug.DataSource = dt;
        }
         
        public DataTable Search_bug(string keyword)
        {


            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            //getting data from database using dataadapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM bug WHERE ProjectTitle LIKE '%" + keyword + "%'", conn);
            //to hold data from database
            DataTable dt = new DataTable();
            sda.Fill(dt);//it means the fill in our database
            return dt;

        }
         
        //for searching 
        private void txt_searchbug_TextChanged(object sender, EventArgs e)
        {

            //get keyword from textbox 
            string keyword = txt_searchbug.Text;
            BugReport vb1 = new BugReport();
            //check if keywords have value or not
            if (keyword != null)
            {
                //show user based based on keywords

                DataTable dt = vb1.Search_bug(keyword);
                dgv_bug.DataSource = dt;

            }
            else
            {
                //show all user from database
                DataTable dt = vb1.Select_bug();
                dgv_bug.DataSource = dt;
            }
        }

        //getting image 
        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.Filter = "Images|*.png;*.jpg;*.jpeg;*.gif";
            if (browse.ShowDialog() == DialogResult.OK)
            {
                lbl_img_path.Text = browse.FileName;
                pictureBox_bugimg.Image = new Bitmap(browse.FileName);
            }
        }

        //button cancel 
        private void btn_cancel_Click(object sender, EventArgs e)
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
        //adding but to database
        private void btn_add_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            int BugID = 0;
            if (txtBox_bugID.Text.Trim() != "")
            {
                BugID = int.Parse(txtBox_bugID.Text.Trim());
            }
            string ProjectTitle = comboBoxProject.Text.ToString();
            string BugTitle = textBox_bugtitle.Text.Trim();
            string BugDescription = textBox_bugdescription.Text.Trim();
            string ReportDate = dateTimePicker_reportdate.Text.Trim();
            string ImagePath = lbl_img_path.Text.Trim();
            string status = cmbBox_status.Text.ToString();
            //getting loggedin user in added by field
            string loggeduser = login.loggedIn;
           string addedby = loggeduser;
          


            ReportDate = DateTime.Now.ToString("yyyy-MM-dd");


            try
            {
                //connecting to the database

                MySqlCommand sda = new MySqlCommand("INSERT INTO bug (ProjectTitle, BugTitle, BugDescription, ReportDate,image,status,addedby) VALUES ('" + this.comboBoxProject.Text + "','" + this.textBox_bugtitle.Text + "','" + this.textBox_bugdescription.Text + "','" + this.dateTimePicker_reportdate.Text + "','" + this.lbl_img_path.Text + "','" + this.cmbBox_status.Text + "',@addedby)", conn);
                sda.Parameters.AddWithValue("@addedby", addedby);
                conn.Open();

                int rows = sda.ExecuteNonQuery();
                //if Inserted rows is greater is greater than 0
                //Else set isSuccess to false, Save Failed

                if (rows > 0)
                {
                    MessageBox.Show("Bug added to database. click ok to continue");
                    //Refresh Data Grid View
                    BugReport vb = new BugReport();
                    DataTable dt = vb.Select_bug();
                    dgv_bug.DataSource = dt;
                    //Clear all the Input fields
                    txtBox_bugID.Clear();
                    comboBoxProject.Text = "";
                    textBox_bugtitle.Clear();
                    textBox_bugdescription.Clear();
                    dateTimePicker_reportdate.Text = "";
                    lbl_img_path.Text = "[image path]";
                    cmbBox_status.Text = "";


                }
                else
                {
                    MessageBox.Show("Bug failed to database. click ok to continue");

                }

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

        

        private void btn_delete_Click(object sender, EventArgs e)
        {
             
            //Checking if the user is admin or user or debugger
            string type = login.loggedIN_utype;
            if (type == "Admin")
            {
                //connecting to the database
                MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");

                MySqlDataAdapter sda = new MySqlDataAdapter("DELETE FROM Bug WHERE BugID='" + this.txtBox_bugID.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count>0)
                {
                    MessageBox.Show("Bug Deleted Successfully. Thank You.");
                  
                 }
                else
                {
                    //Delete Failed Message
                    MessageBox.Show("Failed to delte bug. Please Try Again.");
                }

            }
            else
            {
                MessageBox.Show("Sorry! You are not allowed to remove any data.");
            }
        }

        private void btn_updatebug_Click(object sender, EventArgs e)
        {
            int BugID = 0;
            if (txtBox_bugID.Text.Trim() != "")
            {
                BugID = int.Parse(txtBox_bugID.Text.Trim());
            }
            string ProjectTitle = comboBoxProject.Text.ToString();
            string BugTitle = textBox_bugtitle.Text.Trim();
            string BugDescription = textBox_bugdescription.Text.Trim();
            string ReportDate = dateTimePicker_reportdate.Text.Trim();
            string ImagePath = lbl_img_path.Text.Trim();
            string status = cmbBox_status.Text.ToString();

            // int addedby = ;

            ReportDate = DateTime.Now.ToString("yyyy-MM-dd");


            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            
            try
            {
                MySqlCommand sda = new MySqlCommand("update bug set ProjectTitle='" + this.comboBoxProject.Text + "',BugTitle='" + this.textBox_bugtitle.Text + "',BugDescription='" + this.textBox_bugdescription.Text + "',ReportDate='" + this.dateTimePicker_reportdate.Text + "',image='" + this.lbl_img_path.Text + "',status='" + this.cmbBox_status.Text + "' where bug.id='" + this.txtBox_bugID.Text + "'",conn);
                //Open Connection
                conn.Open();
                int rows = sda.ExecuteNonQuery();
                //if Inserted rows is greater is greater than 0
                //Else set isSuccess to false, Save Failed

                if (rows > 0)
                {
                    MessageBox.Show("Bug updated. click ok to continue");
                    //Refresh Data Grid View
                    BugReport vb = new BugReport();
                    DataTable dt = vb.Select_bug();
                    dgv_bug.DataSource = dt;
                    //Clear all the Input fields
                    txtBox_bugID.Clear();
                    comboBoxProject.Text = "";
                    textBox_bugtitle.Clear();
                    textBox_bugdescription.Clear();
                    dateTimePicker_reportdate.Text = "";
                    lbl_img_path.Text = "[image path]";

                }
                else
                {
                    MessageBox.Show("Bug failed to update. click ok to continue");

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

        private void dgv_bug_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get index from particular row
            int rowIndex = e.RowIndex;
            txtBox_bugID.Text=dgv_bug.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxProject.Text = dgv_bug.Rows[rowIndex].Cells[1].Value.ToString(); 
            textBox_bugtitle.Text= dgv_bug.Rows[rowIndex].Cells[2].Value.ToString();
            textBox_bugdescription.Text= dgv_bug.Rows[rowIndex].Cells[3].Value.ToString();
            dateTimePicker_reportdate.Text = dgv_bug.Rows[rowIndex].Cells[4].Value.ToString();
            lbl_img_path.Text = dgv_bug.Rows[rowIndex].Cells[5].Value.ToString();
            cmbBox_status.Text= dgv_bug.Rows[rowIndex].Cells[6].Value.ToString();

        }   

        private void homeMenu_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
        }
    }
}
