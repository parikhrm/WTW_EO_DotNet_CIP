using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
using System.Text.RegularExpressions;

namespace CIP_Tool
{
    public partial class TrainingCalendar : Form
    {
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public TrainingCalendar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trainingprogram_list();
            empdetails_list();
            reset_overall();
            
        }

        public void reset_overall()
        {
            trainingid.Text = string.Empty;
            trainingid.Enabled = false;
            date.CustomFormat = " ";
            trainername.SelectedIndex = -1;
            trainingprogram.SelectedIndex = -1;
            trainingduration.Value = 0;
            seatsavailable.Value = 0;
            searchby_month.CustomFormat = " ";
            datagridview1_display();
            insert.Enabled = true;
            update.Enabled = false;
            trainingprogramcomments.Text = string.Empty;
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            date.CustomFormat = "dd-MMMM-yyyy";
        }

        private void date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                date.CustomFormat = " ";
            }
        }

        public void trainingprogram_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                Training_Programs obj_trainingprogram = new Training_Programs();
                DataTable dtaa = new DataTable();
                obj_trainingprogram.trainingprogram_list(dtaa);
                trainingprogram.DataSource = dtaa;
                trainingprogram.DisplayMember = "Program_Name";
                trainingprogram.ValueMember = "PR_Code";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        public void empdetails_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                Emp_Details obj_empdetails = new Emp_Details();
                DataTable dtaa = new DataTable();
                obj_empdetails.associate_training_list(dtaa);
                trainername.DataSource = dtaa;
                trainername.DisplayMember = "EmpName";
                conn.Close();
            }
            catch (Exception ab)
                {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        public void datagridview1_display()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();
                conn.ConnectionString = connectionstringtxt;
                cmd.Connection = conn;
                conn.Open();
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                if (searchby_month.Text.Trim() == string.Empty)
                {
                    cmd.CommandText = "select * from dbo.vw_Training_Calendar_CIP_dotnet order by Training_ID ";
                }
                else
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "select * from dbo.vw_Training_Calendar_CIP_dotnet where month = convert(date,dateadd(dd,1,eomonth(@monthparam,-1))) order by Training_ID ";
                    cmd.Parameters.AddWithValue("@monthparam", searchby_month.Value.Date);
                }
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        

        private void searchby_month_ValueChanged(object sender, EventArgs e)
        {
            searchby_month.CustomFormat = "MMMM-yyyy";
            datagridview1_display();
        }

        private void searchby_month_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                searchby_month.CustomFormat = " ";
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset_overall();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                cmd.Parameters.Clear();
                conn.ConnectionString = connectionstringtxt;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into dbo.tbl_Training_Calendar_CIP_dotnet(Date,Trainer_Name,PR_Code,Training_Duration,Seats_Available,IsDeleted,LastUpdatedBy,MachineName,LastUpdatedDateTime,TrainingProgramComments) values(@Dateparam,@Trainer_Nameparam,@PR_Codeparam,@Training_Durationparam,@Seats_Availableparam,@IsDeletedparam,@LastUpdatedByparam,@MachineNameparam,@LastUpdatedDateTimeparam,@TrainingProgramCommentsparam)";
                cmd.Parameters.AddWithValue("@Dateparam", date.Value.Date);
                cmd.Parameters.AddWithValue("@Trainer_Nameparam", trainername.Text);
                cmd.Parameters.AddWithValue("@PR_Codeparam", trainingprogram.SelectedValue);
                cmd.Parameters.AddWithValue("@Training_Durationparam", Convert.ToInt32(trainingduration.Value));
                cmd.Parameters.AddWithValue("@Seats_Availableparam", Convert.ToInt32(seatsavailable.Value));
                cmd.Parameters.AddWithValue("@IsDeletedparam", 0);
                cmd.Parameters.AddWithValue("@LastUpdatedByparam", Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@MachineNameparam", Environment.MachineName.ToString());
                cmd.Parameters.AddWithValue("@LastUpdatedDateTimeparam", DateTime.Now.ToLocalTime());
                if (string.IsNullOrEmpty(trainingprogramcomments.Text))
                {
                    cmd.Parameters.AddWithValue("@TrainingProgramCommentsparam", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TrainingProgramCommentsparam", trainingprogramcomments.Text);
                }

                //if conditions
                if (date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Date");
                }
                else if (string.IsNullOrEmpty(trainername.Text))
                {
                    MessageBox.Show("Please update Trainer Name");
                }
                else if (string.IsNullOrEmpty(trainingprogram.Text))
                {
                    MessageBox.Show("Please update Training Program");
                }
                else if (trainingduration.Value == 0)
                {
                    MessageBox.Show("Please update Training Duration");
                }
                else if (seatsavailable.Value == 0)
                {
                    MessageBox.Show("Please update Seats Avaiable");
                }
                else
                {

                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records Inserted Successfully");
                    cmd.Parameters.Clear();
                    reset_overall();
                    conn.Close();
                }
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details :" + ab.ToString());
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                cmd.Parameters.Clear();
                conn.ConnectionString = connectionstringtxt;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update dbo.tbl_Training_Calendar_CIP_dotnet set Date=@Dateparam,Trainer_Name=@Trainer_Nameparam,PR_Code=@PR_Codeparam,Training_Duration=@Training_Durationparam,Seats_Available=@Seats_Availableparam,LastUpdatedBy=@LastUpdatedByparam,MachineName=@MachineNameparam,LastUpdatedDateTime=@LastUpdatedDateTimeparam,TrainingProgramComments=@TrainingProgramCommentsparam where training_id=@Training_IDparam";
                cmd.Parameters.AddWithValue("@Training_IDparam", trainingid.Text);
                cmd.Parameters.AddWithValue("@Dateparam", date.Value.Date);
                cmd.Parameters.AddWithValue("@Trainer_Nameparam", trainername.Text);
                cmd.Parameters.AddWithValue("@PR_Codeparam", trainingprogram.SelectedValue);
                cmd.Parameters.AddWithValue("@Training_Durationparam", Convert.ToInt32(trainingduration.Value));
                cmd.Parameters.AddWithValue("@Seats_Availableparam", Convert.ToInt32(seatsavailable.Value));
                cmd.Parameters.AddWithValue("@LastUpdatedByparam", Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@MachineNameparam", Environment.MachineName.ToString());
                cmd.Parameters.AddWithValue("@LastUpdatedDateTimeparam", DateTime.Now.ToLocalTime());
                if (string.IsNullOrEmpty(trainingprogramcomments.Text))
                {
                    cmd.Parameters.AddWithValue("@TrainingProgramCommentsparam", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TrainingProgramCommentsparam", trainingprogramcomments.Text);
                }

                if (date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Date");
                }
                else if (string.IsNullOrEmpty(trainername.Text))
                {
                    MessageBox.Show("Please update Trainer Name");
                }
                else if (string.IsNullOrEmpty(trainingprogram.Text))
                {
                    MessageBox.Show("Please update Training Program");
                }
                else if (trainingduration.Value == 0)
                {
                    MessageBox.Show("Please update Training Duration");
                }
                else if (seatsavailable.Value == 0)
                {
                    MessageBox.Show("Please update Seats Avaiable");
                }
                else
                {

                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records Updated Successfully");
                    cmd.Parameters.Clear();
                    reset_overall();
                    conn.Close();
                }
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details :" + ab.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string messsage = "Do you want to update the record?";
            string title = "Message Box";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(messsage, title, buttons);
            if (result == DialogResult.Yes)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    trainingid.Text = row.Cells["txtTraining_Id"].Value.ToString();
                    date.Text = row.Cells["txtDate"].Value.ToString();
                    date.CustomFormat = "dd-MMMM-yyyy";
                    trainername.Text = row.Cells["txtTrainer_Name"].Value.ToString();
                    trainingprogram.Text = row.Cells["txtProgram_Name"].Value.ToString();
                    trainingduration.Value = Convert.ToInt32(row.Cells["txtTraining_Duration"].Value.ToString());
                    seatsavailable.Value = Convert.ToInt32(row.Cells["txtSeats_Available"].Value.ToString());
                    if (string.IsNullOrEmpty(row.Cells["txtTrainingProgramComments"].Value.ToString()))
                    {
                        trainingprogramcomments.Text = string.Empty;
                    }
                    else
                    {
                        trainingprogramcomments.Text = row.Cells["txtTrainingProgramComments"].Value.ToString();
                    }
                    insert.Enabled = false;
                    update.Enabled = true;
                }

            }
            else
            {
                trainingid.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainingDetails obj_form2 = new TrainingDetails();
            obj_form2.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://A20-CB-DBSE01P/Reports/report/DRD%20MI%20Mumbai/DRD%20Reports/rpt_SSRS_CIPTool_TrainingProgram_dotnet");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomePage obj_form3 = new HomePage();
            obj_form3.Show();
        }
    }
}
