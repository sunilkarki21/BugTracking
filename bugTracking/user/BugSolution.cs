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
    public partial class BugSolution : Form
    {
        public BugSolution()
        {
            InitializeComponent();
        }
      
        public DataTable Select_bug()
        {

            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            //getting data from database using dataadapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from bug where assignedto='" + login.loggedIn + "'", conn);
            //to hold data from database
            DataTable dt = new DataTable();
            sda.Fill(dt);//it means the fill in our database
            return dt;
        }
       
        private void BugSolution_Load(object sender, EventArgs e)
        {
            // Data Grid View
            BugSolution vu = new BugSolution();
            DataTable dt = vu.Select_bug();
            dgv1.DataSource = dt;
        }

        private void dgv1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtBox_bugID.Text = dgv1.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxProject.Text = dgv1.Rows[rowIndex].Cells[1].Value.ToString();
            txt_bugtitle.Text = dgv1.Rows[rowIndex].Cells[2].Value.ToString();
            txtdes.Text = dgv1.Rows[rowIndex].Cells[3].Value.ToString();
            reportDate.Text = dgv1.Rows[rowIndex].Cells[4].Value.ToString();
            cmbBox_status.Text = dgv1.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void btn_solution_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtracker");
            int BugID = 0;
            if (txtBox_bugID.Text.Trim() != "")
            {
                BugID = int.Parse(txtBox_bugID.Text.Trim());
            }
            string ProjectTitle = txtboxProject.Text.ToString();
            string BugTitle = txt_bugtitle.Text.Trim();
            string cls = txt_class.Text;
            string mthd = txt_method.Text;
            string line = txt_line.Text;
            string BugDescription = txtdes.Text.Trim();
            string bugsolved = txt_bugsol.Text;
            string ReportDate = reportDate.Text.Trim();
            string SolveDate = solvedate.Text.Trim();
             string status = cmbBox_status.Text.ToString();
            //getting loggedin user in added by field
            string loggedusr = login.loggedIn;

            string Fixedby = loggedusr;

            ReportDate = DateTime.Now.ToString("yyyy-MM-dd");
            SolveDate = DateTime.Now.ToString("yyyy-MM-dd");


            try
            {
                //connecting to the database

                MySqlCommand sda = new MySqlCommand("INSERT INTO bugsolve (bugid, project, bugtitle, class,method,line,error,solved,reportdate,solvedate,status,fixedby) " +
                    "VALUES ('" + this.txtBox_bugID.Text + "','" + this.txtboxProject.Text + "','" + this.txt_bugtitle.Text + "','" + this.txt_class.Text + "','" + this.txt_method.Text + "','" + this.txt_line.Text + "'" +
                    ",'" + this.txtdes.Text + "','"+this.txt_bugsol.Text+"','" + this.reportDate.Text + "','" + this.solvedate.Text + "','" + this.cmbBox_status.Text + "',@Fixedby)", conn);
                sda.Parameters.AddWithValue("@Fixedby", Fixedby);
                conn.Open();

                int rows = sda.ExecuteNonQuery();
                //if Inserted rows is greater is greater than 0
                //Else set isSuccess to false, Save Failed

                if (rows > 0)
                {
                    MessageBox.Show("bug fixed. click ok to continue");
                    //connecting to the database
                    MySqlConnection con= new MySqlConnection("server = localhost; user id = root; database = bugtracker");
                    //getting data from database using dataadapter 
                    MySqlDataAdapter adapter = new MySqlDataAdapter("update bug set status='" + this.cmbBox_status.Text + "' where id='"+this.txtBox_bugID.Text+"'", conn);
                    //to hold data from database
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);//it means the fill in our database
                    //Refresh Data Grid View

                    BugSolution bs = new BugSolution();
                     dt = bs.Select_bug();
                    dgv1.DataSource = dt;
                    //Clear all the Input fields
                    txtboxProject.Clear();
                    txt_bugtitle.Clear(); 
                     txt_class.Clear();
                     txt_method.Clear();
                     txt_line.Clear();
                     txtdes.Clear();
                    txt_bugsol.Clear();

                     
                }
                else
                {
                    MessageBox.Show("Bug failed to fixed. click ok to continue");

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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
