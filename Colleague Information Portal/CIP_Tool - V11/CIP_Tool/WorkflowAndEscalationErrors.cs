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

namespace CIP_Tool
{
    public partial class WorkflowAndEscalationErrors : Form
    {
        string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public WorkflowAndEscalationErrors()
        {
            InitializeComponent();
        }

        private void WorkflowAndEscalationErrors_Load(object sender, EventArgs e)
        {
            reset_overall();
            workflowerrors_list();
            consequencemanagement_list();
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

        public void workflowerrors_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                WorkflowErrors obj_workflowerrors = new WorkflowErrors();
                DataTable dtaa = new DataTable();
                obj_workflowerrors.workflowerrors_list(dtaa);
                workflowerrors.DataSource = dtaa;
                workflowerrors.DisplayMember = "WorkflowErrors";
                conn.Close();
                workflowerrors.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void consequencemanagement_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                ConsequenceManagement obj_cm = new ConsequenceManagement();
                DataTable dtaa = new DataTable();
                obj_cm.consequencemanagement_list(dtaa);
                consequencemanagement.DataSource = dtaa;
                consequencemanagement.DisplayMember = "ConsequenceManagement";
                conn.Close();
                consequencemanagement.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void reset_overall()
        {
            hrcloudid.Text = string.Empty;
            date.CustomFormat = " ";
            workflowerrors.SelectedIndex = -1;
            escalationmails.Value = 0;
            requestid.Enabled = false;
            requestid.Text = string.Empty;
            datagridview_display_overall();
            insert.Enabled = true;
            update.Enabled = false;
            workflowerrors.SelectedIndex = -1;
            consequencemanagement.SelectedIndex = -1;
            followupemails.Value = 0;
            queryandsmso.Value = 0;
        }

        public void datagridview_display_overall()
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
                cmd.CommandText = "select RequestID,HRCloudID,EmpName,ReportingManager,Date,WorkflowErrors,EscalationMails,Followup_Emails_Pending,ConsequenceManagement,QueryandSMSO_ChaserProcessNotFollowed from vw_monthlykpiscorecard_errorsandattachments_dotnet  order by RequestID";
                cmd.ExecuteNonQuery();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();

            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomePage obj_homepage = new HomePage();
            obj_homepage.Show();
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
                //byte[] filebyte = File.ReadAllBytes(file.Text);
                cmd.CommandText = "insert into dbo.tbl_monthlykpiscorecard_errorsandattachments_dotnet(HRCloudID,Date,WorkflowErrors,EscalationMails,IsDeleted,LastUpdatedDateTime,LastUpdatedBy,MachineName,Followup_Emails_Pending,ConsequenceManagement,QueryandSMSO_ChaserProcessNotFollowed) values(@HRCloudID,@Date,@WorkflowErrors,@EscalationMails,@IsDeleted,@LastUpdatedDateTime,@LastUpdatedBy,@MachineName,@Followup_Emails_Pending,@ConsequenceManagement,@QueryandSMSO_ChaserProcessNotFollowed)";
                cmd.Parameters.AddWithValue("@HRCloudID", hrcloudid.Text);
                cmd.Parameters.AddWithValue("@Date", date.Value.Date);
                if (string.IsNullOrEmpty(workflowerrors.Text))
                {
                    cmd.Parameters.AddWithValue("@WorkflowErrors", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@WorkflowErrors", workflowerrors.Text);
                }
                cmd.Parameters.AddWithValue("@EscalationMails", escalationmails.Value);
                //SqlParameter parameterfile = cmd.Parameters.AddWithValue("@Attachments", filebyte);
                //parameterfile.DbType = DbType.Binary;
                cmd.Parameters.AddWithValue("@IsDeleted", 0);
                cmd.Parameters.AddWithValue("@LastUpdatedDateTime", DateTime.Now.ToLocalTime());
                cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName.ToString());
                cmd.Parameters.AddWithValue("@Followup_Emails_Pending", followupemails.Value);
                if (string.IsNullOrEmpty(consequencemanagement.Text))
                {
                    cmd.Parameters.AddWithValue("@ConsequenceManagement", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ConsequenceManagement", consequencemanagement.Text);
                }
                cmd.Parameters.AddWithValue("@QueryandSMSO_ChaserProcessNotFollowed", queryandsmso.Value);

                if (string.IsNullOrEmpty(hrcloudid.Text))
                {
                    MessageBox.Show("Please update HR Cloud ID");
                }
                else if (date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Date");
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

        private void reset_Click(object sender, EventArgs e)
        {
            reset_overall();
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
                //byte[] filebyte = File.ReadAllBytes(file.Text);
                cmd.CommandText = "update dbo.tbl_monthlykpiscorecard_errorsandattachments_dotnet set HRCloudID=@HRCloudID,Date=@Date,WorkflowErrors=@WorkflowErrors,EscalationMails=@EscalationMails,LastUpdatedDateTime=@LastUpdatedDateTime,LastUpdatedBy=@LastUpdatedBy,MachineName=@MachineName,Followup_Emails_Pending=@Followup_Emails_Pending,ConsequenceManagement=@ConsequenceManagement,QueryandSMSO_ChaserProcessNotFollowed=@QueryandSMSO_ChaserProcessNotFollowed where RequestID=@RequestID ";
                cmd.Parameters.AddWithValue("@RequestID", requestid.Text);
                cmd.Parameters.AddWithValue("@HRCloudID", hrcloudid.Text);
                cmd.Parameters.AddWithValue("@Date", date.Value.Date);
                if (string.IsNullOrEmpty(workflowerrors.Text))
                {
                    cmd.Parameters.AddWithValue("@WorkflowErrors", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@WorkflowErrors", workflowerrors.Text);
                }
                cmd.Parameters.AddWithValue("@EscalationMails", escalationmails.Value);
                //SqlParameter parameterfile = cmd.Parameters.AddWithValue("@Attachments", filebyte);
                //parameterfile.DbType = DbType.Binary;
                cmd.Parameters.AddWithValue("@LastUpdatedDateTime", DateTime.Now.ToLocalTime());
                cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName.ToString());
                cmd.Parameters.AddWithValue("@Followup_Emails_Pending", followupemails.Value);
                if (string.IsNullOrEmpty(consequencemanagement.Text))
                {
                    cmd.Parameters.AddWithValue("@ConsequenceManagement", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ConsequenceManagement", consequencemanagement.Text);
                }
                cmd.Parameters.AddWithValue("@QueryandSMSO_ChaserProcessNotFollowed", queryandsmso.Value);

                if (string.IsNullOrEmpty(hrcloudid.Text))
                {
                    MessageBox.Show("Please update HR Cloud ID");
                }
                else if (date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Date");
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

        private void searchbyassociatename_TextChanged(object sender, EventArgs e)
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
                cmd.CommandText = "select RequestID,HRCloudID,EmpName,ReportingManager,Date,WorkflowErrors,EscalationMails,Followup_Emails_Pending,ConsequenceManagement,QueryandSMSO_ChaserProcessNotFollowed from vw_monthlykpiscorecard_errorsandattachments_dotnet where EmpName like @EmpName order by RequestID";
                cmd.Parameters.AddWithValue("@EmpName", "%" + searchbyassociatename.Text + "%");
                cmd.ExecuteNonQuery();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();

            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
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
                    requestid.Text = row.Cells["txtRequestID"].Value.ToString();
                    hrcloudid.Text = row.Cells["txtHRCloudID"].Value.ToString();
                    date.Text = row.Cells["txtDate"].Value.ToString();
                    date.CustomFormat = "dd-MMMM-yyyy";
                    if (string.IsNullOrEmpty(row.Cells["txtWorkflowErrors"].Value.ToString()))
                    {
                        workflowerrors.SelectedIndex = -1;
                    }
                    else
                    {
                        workflowerrors.Text = row.Cells["txtWorkflowErrors"].Value.ToString();
                    }
                    escalationmails.Value = Convert.ToInt32(row.Cells["txtEscalationMails"].Value.ToString());
                    followupemails.Value = Convert.ToInt32(row.Cells["txtFollowup_Emails_Pending"].Value.ToString());
                    if (string.IsNullOrEmpty(row.Cells["txtConsequenceManagement"].Value.ToString()))
                    {
                        consequencemanagement.SelectedIndex = -1;
                    }
                    else
                    {
                        consequencemanagement.Text = row.Cells["txtConsequenceManagement"].Value.ToString();
                    }
                    queryandsmso.Value = Convert.ToInt32(row.Cells["txtQueryandSMSO_ChaserProcessNotFollowed"].Value.ToString());
                }
                insert.Enabled = false;
                update.Enabled = true;
            }
            else
            {
                requestid.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://A20-CB-DBSE01P/Reports/report/DRD%20MI%20Mumbai/DRD%20Reports/rpt_SSRS_KPIScoreCard_ErrorsandEscalation_RawData_DotNet");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }




    }
}
