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
    public partial class TrainingDetails : Form
    {
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public TrainingDetails()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            associate_list();
            trainingid_list();
            //trainingprogram_list();
            trainingdates_list();
            reset_overall();
        }

        public void reset_overall()
        {
            for (int i = 0; i < associatelist.Items.Count; i++)
            {
                associatelist.SetItemChecked(i, false);
            }
            //trainingid.Enabled = false;
            trainingid.Value = 0;
            datagridview1_display();
        }

        public void trainingid_list()
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
                cmd.CommandText = "select distinct Training_Id from dbo.vw_Training_Calendar_CIP_dotnet order by Training_Id";
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                searchby_trainingid.DataSource = dt;
                searchby_trainingid.DisplayMember = "Training_ID";
                conn.Close();
                searchby_trainingid.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
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
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();
                conn.ConnectionString = connectionstringtxt;
                cmd.Connection = conn;
                conn.Open();
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select distinct Program_Name from dbo.vw_Training_Calendar_CIP_dotnet where convert(nvarchar(100),training_id) = @training_id order by Program_Name";
                cmd.Parameters.AddWithValue("@training_id",searchby_trainingid.Text);
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                searchby_programname.DataSource = dt;
                searchby_programname.DisplayMember = "Program_Name";
                conn.Close();
                searchby_programname.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        public void trainingdates_list()
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
                cmd.CommandText = "select distinct Date from dbo.vw_Training_Calendar_CIP_dotnet order by Date";
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                //searchby_date.DataSource = dt;
                //searchby_date.DisplayMember = "Date";
                conn.Close();
                //searchby_date.SelectedIndex = -1;
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

                if (string.IsNullOrEmpty(searchby_trainingid.Text) && string.IsNullOrEmpty(searchby_programname.Text) && searchby_date.Text.Trim() == string.Empty)
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select Training_ID,Attendees,Attendance_Status,Trainer_Name,Program_Name,TrainingProgramComments,Date,RequestId from dbo.vw_Training_Records_CIP_dotnet order by Date ";
                }
                else
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.usp_training_records_datagridview_search_dotnet";
                    if (string.IsNullOrEmpty(searchby_trainingid.Text))
                    {
                        cmd.Parameters.AddWithValue("@training_id", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@training_id", searchby_trainingid.Text);
                    }
                    if (string.IsNullOrEmpty(searchby_programname.Text))
                    {
                        cmd.Parameters.AddWithValue("@program_name", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@program_name", searchby_programname.Text);
                    }
                    if (searchby_date.Text.Trim() == string.Empty)
                    {
                        cmd.Parameters.AddWithValue("@date", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@date", searchby_date.Value.Date);
                    }


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

        /*
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
                    //if (!string.IsNullOrEmpty(searchby_trainingid.Text))
                    //{
                    //    cmd.CommandText = "select * from dbo.vw_Training_Records_CIP_dotnet where training_id = @training_idparam order by Training_ID, Attendees";
                    //    cmd.Parameters.AddWithValue("@training_idparam", searchby_trainingid.Text);
                    //}
                    //else
                    //{
                    //    cmd.CommandText = "select * from vw_Training_Records_CIP_dotnet order by Training_ID, Attendees";
                    //}
                    if (searchby_date.Text.Trim() == string.Empty && string.IsNullOrEmpty(searchby_programname.Text))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from dbo.vw_Training_Records_CIP_dotnet order by Training_ID, Attendees";
                    }
                    else if (searchby_date.Text.Trim() == string.Empty && !string.IsNullOrEmpty(searchby_programname.Text))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from dbo.vw_Training_Records_CIP_dotnet where Program_Name = @program_name order by Training_ID, Attendees";
                        cmd.Parameters.AddWithValue("@program_name",searchby_programname.Text);
                    }
                    else if ((searchby_date.Text.Trim() != string.Empty && string.IsNullOrEmpty(searchby_programname.Text)))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from dbo.vw_Training_Records_CIP_dotnet where date = @date order by Training_ID, Attendees";
                        cmd.Parameters.AddWithValue("@date", searchby_date.Value.Date);
                    }
                    else
                    {
                        //cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.CommandText = "dbo.usp_trainingdetails_datagridview_search_cip_dotnet";
                        //cmd.Parameters.AddWithValue("@Program_Name", searchby_programname.Text);
                        //cmd.Parameters.AddWithValue("@Date", searchby_date.Value.Date);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from dbo.vw_Training_Records_CIP_dotnet where date = @date and program_name = @program_name order by Training_ID, Attendees";
                        cmd.Parameters.AddWithValue("@date", searchby_date.Value.Date);
                        cmd.Parameters.AddWithValue("@program_name", searchby_programname.Text);

                    }
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                    dataGridView1.ClearSelection();
                }
                catch (Exception ab)
                {
                    MessageBox.Show("Error Generated Details : " + ab.ToString());
                }
            
            
        }
         */

        public void associate_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                for (int i = 0; i < associatelist.Items.Count; i++)
                {
                    associatelist.SetItemChecked(i, false);
                }
                associatelist.Items.Clear();
                Emp_Details obj_empdetails = new Emp_Details();
                DataTable dtaa = new DataTable();
                DataSet ds = new DataSet();
                obj_empdetails.associate_list(dtaa);
                foreach (DataRow datarow in dtaa.Rows)
                {
                    associatelist.Items.Add(datarow["EmpName"]);
                }
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        

        private void nominate_Click(object sender, System.EventArgs e)
        {
            if (trainingid.Value <= 0)
            {
                MessageBox.Show("Please select correct TrainingID");
            }
            else if (associatelist.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select associate name from the list");
            }
            else
            {
                string messsage = "Do you want to insert this record?";
                string title = "Message Box";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(messsage, title, buttons);
                if (result == DialogResult.Yes)
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
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "usp_insert_Training_Records_CIP_dotnet";
                        cmd.Parameters.AddWithValue("@Training_ID",Convert.ToInt32(trainingid.Value));
                        if (associatelist.CheckedItems.Count != 0)
                        {
                            string associatenames = string.Empty;
                            foreach (var checkeditem in this.associatelist.CheckedItems)
                            {
                                associatenames += "," + checkeditem.ToString();
                            }
                            associatenames = associatenames.ToString();
                            cmd.Parameters.AddWithValue("@Attendees", associatenames);
                        }
                        cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName.ToString());
                        cmd.Parameters.AddWithValue("@LastUpdatedby", Environment.UserName.ToString());
                        cmd.Parameters.Add("@Message",SqlDbType.NVarChar,2000);
                        cmd.Parameters["@Message"].Direction = ParameterDirection.Output;

                        
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        string message = cmd.Parameters["@Message"].Value.ToString();
                        if (!string.IsNullOrEmpty(message))
                        {
                             MessageBox.Show("" + message.ToString());

                        }
                        else
                        {
                             MessageBox.Show("Records Inserted Successfully");
                             reset_overall();
                             conn.Close();
                        }
                    }
                    catch (Exception ab)
                    {
                        MessageBox.Show("Error Generated Details :" + ab.ToString());
                    }
                }
            }
        }

        private void attended_Click(object sender, System.EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    bool isselected = Convert.ToBoolean(item.Cells["txtSelect"].Value);
                    if (isselected)
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }

                        cmd.Parameters.Clear();
                        conn.ConnectionString = connectionstringtxt;
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update dbo.tbl_Training_Records_CIP_dotnet set Attendance_Status = 'Attended', lastupdatedby = @lastupdatedbyparam, lastupdateddatetime = @lastupdateddatetiemparam where requestid = @requestidparam";
                        cmd.Parameters.AddWithValue("@lastupdatedbyparam",Environment.UserName.ToString());
                        cmd.Parameters.AddWithValue("@lastupdateddatetiemparam",DateTime.Now.ToLocalTime());
                        cmd.Parameters.AddWithValue("@requestidparam", Convert.ToInt32(item.Cells["txtRequestID"].Value));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        conn.Close();
                    }
                }
                MessageBox.Show("Records Updated Successfully");
                datagridview1_display();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        private void notattended_Click(object sender, System.EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    bool isselected = Convert.ToBoolean(item.Cells["txtSelect"].Value);
                    if (isselected)
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }

                        cmd.Parameters.Clear();
                        conn.ConnectionString = connectionstringtxt;
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update dbo.tbl_Training_Records_CIP_dotnet set Attendance_Status = 'NotAttended', lastupdatedby = @lastupdatedbyparam, lastupdateddatetime = @lastupdateddatetiemparam where requestid = @requestidparam";
                        cmd.Parameters.AddWithValue("@lastupdatedbyparam", Environment.UserName.ToString());
                        cmd.Parameters.AddWithValue("@lastupdateddatetiemparam", DateTime.Now.ToLocalTime());
                        cmd.Parameters.AddWithValue("@requestidparam", Convert.ToInt32(item.Cells["txtRequestID"].Value));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        conn.Close();
                    }
                }
                MessageBox.Show("Records Updated Successfully");
                datagridview1_display();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        private void deleteattendee_Click(object sender, System.EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    bool isselected = Convert.ToBoolean(item.Cells["txtSelect"].Value);
                    if (isselected)
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }

                        cmd.Parameters.Clear();
                        conn.ConnectionString = connectionstringtxt;
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update dbo.tbl_Training_Records_CIP_dotnet set isdeleted = 1, lastupdatedby = @lastupdatedbyparam, lastupdateddatetime = @lastupdateddatetiemparam where requestid = @requestidparam";
                        cmd.Parameters.AddWithValue("@lastupdatedbyparam", Environment.UserName.ToString());
                        cmd.Parameters.AddWithValue("@lastupdateddatetiemparam", DateTime.Now.ToLocalTime());
                        cmd.Parameters.AddWithValue("@requestidparam", Convert.ToInt32(item.Cells["txtRequestID"].Value));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        conn.Close();
                    }
                }
                MessageBox.Show("Records Updated Successfully");
                datagridview1_display();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        private void reset_Click(object sender, System.EventArgs e)
        {
            reset_overall();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://A20-CB-DBSE01P/Reports/report/DRD%20MI%20Mumbai/DRD%20Reports/rpt_SSRS_CIPTool_TrainingDetails_dotnet");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            TrainingCalendar obj_form1 = new TrainingCalendar();
            obj_form1.Show();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow myrow in dataGridView1.Rows)
            {
                if (myrow.Cells["txtAttendance_Status"].Value.ToString() == "Attended")
                {
                    myrow.DefaultCellStyle.BackColor = Color.Green;
                    myrow.DefaultCellStyle.ForeColor = Color.White;
                }
                if (myrow.Cells["txtAttendance_Status"].Value.ToString() == "NotAttended")
                {
                    myrow.DefaultCellStyle.BackColor = Color.Orange;
                }
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://A20-CB-DBSE01P/Reports/report/DRD%20MI%20Mumbai/DRD%20Reports/rpt_SSRS_CIPTool_TrainingRecordDetails_dotnet");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }

        private void searchby_programname_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridview1_display();
        }

        

        private void searchby_date_BindingContextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchby_date_ValueChanged(object sender, EventArgs e)
        {
            searchby_date.CustomFormat = "dd-MMMM-yyyy";
            datagridview1_display();
        }

        private void searchby_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                searchby_date.CustomFormat = " ";
            }
        }

        private void searchby_trainingid_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridview1_display();
            trainingprogram_list();
        }

        private void searchby_trainingid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                searchby_trainingid.SelectedIndex = -1;
            }
        }

        private void searchby_programname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                searchby_programname.SelectedIndex = -1;
            }
        }
    }
}
