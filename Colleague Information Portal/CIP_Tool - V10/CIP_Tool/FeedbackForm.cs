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
    public partial class FeedbackForm : Form
    {
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            empname_list();
            typeoffeedback_list();
            reset_overall();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomePage obj_form3 = new HomePage();
            obj_form3.Show();
        }

        public void reset_overall()
        {
            requestid.Enabled = false;
            requestid.Text = string.Empty;
            employeename.SelectedIndex = -1;
            feedbackdate.CustomFormat = " ";
            typeoffeedback.SelectedIndex = -1;
            subjectline.Text = string.Empty;
            mailbody.Text = string.Empty;
            insert.Enabled = true;
            update.Enabled = false;
            datagridview_display();
        }

        private void feedbackdate_ValueChanged(object sender, EventArgs e)
        {
            feedbackdate.CustomFormat = "dd-MMMM-yyyy";
        }

        private void feedbackdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                feedbackdate.CustomFormat = " ";
            }
        }

        public void empname_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                Emp_Details obj_empdetails = new Emp_Details();
                DataTable dtaa = new DataTable();
                obj_empdetails.associate_list(dtaa);
                employeename.DataSource = dtaa;
                employeename.DisplayMember = "EmpName";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        public void typeoffeedback_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                TypeOfFeedback obj_typeoffeedback = new TypeOfFeedback();
                DataTable dtaa = new DataTable();
                obj_typeoffeedback.typeoffeedback_list(dtaa);
                typeoffeedback.DataSource = dtaa;
                typeoffeedback.DisplayMember = "TypeOfFeedback";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
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
                cmd.CommandText = "insert into dbo.tbl_FeedbackForm_CIP_dotnet(EmpName,TypeOfError,MailSubject,MailBody,IsDeleted,Lastudpatedby,LastUPdatedDateTime,MachineName,Date) values(@EmpNameparam,@TypeOfErrorparam,@MailSubjectparam,@MailBodyparam,@IsDeletedparam,@LastUpdatedByparam,@LastUpdatedDateTimeparam,@MachineNameparam,@Dateparam)";
                //@EmpNameparam,@TypeOfErrorparam,@MailSubjectparam,@MailBodyparam,@IsDeletedparam,@LastUpdatedByparam,@LastUpdatedDateTimeparam,@MachineNameparam,@Dateparam
                cmd.Parameters.AddWithValue("@EmpNameparam",employeename.Text);
                cmd.Parameters.AddWithValue("@TypeOfErrorparam",typeoffeedback.Text);
                if (string.IsNullOrEmpty(subjectline.Text))
                {
                    cmd.Parameters.AddWithValue("@MailSubjectparam", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MailSubjectparam", subjectline.Text);
                }
                if (string.IsNullOrEmpty(mailbody.Text))
                {
                    cmd.Parameters.AddWithValue("@MailBodyparam", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MailBodyparam", mailbody.Text);
                }
                cmd.Parameters.AddWithValue("@IsDeletedparam",0);
                cmd.Parameters.AddWithValue("@LastUpdatedByparam",Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@LastUpdatedDateTimeparam",DateTime.Now.ToLocalTime());
                cmd.Parameters.AddWithValue("@MachineNameparam", Environment.MachineName.ToString());
                cmd.Parameters.AddWithValue("@Dateparam",feedbackdate.Value.Date);

                //if conditions
                if (string.IsNullOrEmpty(employeename.Text))
                {
                    MessageBox.Show("Please update Employee Name");
                }
                else if (string.IsNullOrEmpty(typeoffeedback.Text))
                {
                    MessageBox.Show("Please update Type Of Feedback");
                }
                else if (feedbackdate.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Feedback date");
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
                cmd.CommandText = "update dbo.tbl_FeedbackForm_CIP_dotnet set EmpName=@EmpNameparam,TypeOfError=@TypeOfErrorparam,MailSubject=@MailSubjectparam,MailBody=@MailBodyparam,Lastudpatedby=@LastUpdatedByparam,LastUPdatedDateTime=@LastUpdatedDateTimeparam,MachineName=@MachineNameparam,Date=@Dateparam where RequestID=@RequestIDparam";
                //@EmpNameparam,@TypeOfErrorparam,@MailSubjectparam,@MailBodyparam,@IsDeletedparam,@LastUpdatedByparam,@LastUpdatedDateTimeparam,@MachineNameparam,@Dateparam
                cmd.Parameters.AddWithValue("@RequestIDparam",requestid.Text);
                cmd.Parameters.AddWithValue("@EmpNameparam", employeename.Text);
                cmd.Parameters.AddWithValue("@TypeOfErrorparam", typeoffeedback.Text);
                if (string.IsNullOrEmpty(subjectline.Text))
                {
                    cmd.Parameters.AddWithValue("@MailSubjectparam", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MailSubjectparam", subjectline.Text);
                }
                if (string.IsNullOrEmpty(mailbody.Text))
                {
                    cmd.Parameters.AddWithValue("@MailBodyparam", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MailBodyparam", mailbody.Text);
                }
                cmd.Parameters.AddWithValue("@LastUpdatedByparam", Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@LastUpdatedDateTimeparam", DateTime.Now.ToLocalTime());
                cmd.Parameters.AddWithValue("@MachineNameparam", Environment.MachineName.ToString());
                cmd.Parameters.AddWithValue("@Dateparam", feedbackdate.Value.Date);

                //if conditions
                if (string.IsNullOrEmpty(employeename.Text))
                {
                    MessageBox.Show("Please update Employee Name");
                }
                else if (string.IsNullOrEmpty(typeoffeedback.Text))
                {
                    MessageBox.Show("Please update Type Of Feedback");
                }
                else if (feedbackdate.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Feedback date");
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

        public void datagridview_display()
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
                cmd.CommandText = "select * from dbo.vw_FeedbackForm_CIP_dotnet order by RequestID asc ";
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

        private void reset_Click(object sender, EventArgs e)
        {
            reset_overall();
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
                    requestid.Text = row.Cells["txtrequestid"].Value.ToString();
                    employeename.Text = row.Cells["txtEmpname"].Value.ToString();
                    feedbackdate.Text = row.Cells["txtDate"].Value.ToString();
                    feedbackdate.CustomFormat = "dd-MMMM-yyyy";
                    typeoffeedback.Text = row.Cells["txtTypeofError"].Value.ToString();
                    if (string.IsNullOrEmpty(row.Cells["txtMailSubject"].Value.ToString()))
                    {
                        subjectline.Text = string.Empty;
                    }
                    else
                    {
                        subjectline.Text = row.Cells["txtMailSubject"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtMailBody"].Value.ToString()))
                    {
                        mailbody.Text = string.Empty;
                    }
                    else
                    {
                        mailbody.Text = row.Cells["txtMailBody"].Value.ToString();
                    }
                    insert.Enabled = false;
                    update.Enabled = true;
                }

            }
            else
            {
                requestid.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://A20-CB-DBSE01P/Reports/report/DRD%20MI%20Mumbai/DRD%20Reports/rpt_SSRS_CIPTool_FeedackForm_dotnet");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }
    }
}
