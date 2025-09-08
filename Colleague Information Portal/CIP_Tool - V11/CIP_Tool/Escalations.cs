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
    public partial class Escalations : Form
    {
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public Escalations()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            empdetails_list();
            inboxtype_list();
            reset_overall();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomePage obj_form3 = new HomePage();
            obj_form3.Show();
        }

        public void reset_overall()
        {
            id.Text = string.Empty;
            id.Enabled = false;
            requestoremailaddress.Text = string.Empty;
            escalateddate.CustomFormat = " ";
            associatename.SelectedIndex = -1;
            mailboxtype.SelectedIndex = -1;
            subjectline.Text = string.Empty;
            rdccomments.Text = string.Empty;
            insert.Enabled = true;
            update.Enabled = false;
            datagridview_main_display();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset_overall();
        }

       

        private void escalateddate_ValueChanged(object sender, EventArgs e)
        {
            escalateddate.CustomFormat = "dd-MMMM-yyyy";
        }

        private void escalateddate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                escalateddate.CustomFormat = " ";
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
                obj_empdetails.associate_list_overall(dtaa);
                associatename.DataSource = dtaa;
                associatename.DisplayMember = "EmpName";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        public void inboxtype_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                //InboxType obj_inboxtype = new InboxType();
                //DataTable dtaa = new DataTable();
                //obj_inboxtype.inboxtype_list (dtaa);
                Emp_Details obj_empdetails = new Emp_Details();
                DataTable dtaa = new DataTable();
                obj_empdetails.process_list(dtaa);
                mailboxtype.DataSource = dtaa;
                mailboxtype.DisplayMember = "Process";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        public void datagridview_main_display()
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
                if (string.IsNullOrEmpty(searchby_associatename.Text) && string.IsNullOrEmpty(searchby_reportingmanager.Text))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select ID,EscalatedDate,AssociateName,ReportingManager,MailBoxType,SubjectLine,RequestorEmailAddress,RequestorBusinessUnit,RDCComments from dbo.tbl_escalations_cip_dotnet with(nolock) where isdeleted = 0 order by ID ";
                }
                else if (!string.IsNullOrEmpty(searchby_associatename.Text) && string.IsNullOrEmpty(searchby_reportingmanager.Text))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select ID,EscalatedDate,AssociateName,ReportingManager,MailBoxType,SubjectLine,RequestorEmailAddress,RequestorBusinessUnit,RDCComments from dbo.tbl_escalations_cip_dotnet with(nolock) where isdeleted = 0 and associatename like @associatename order by ID ";
                    cmd.Parameters.AddWithValue("@associatename", "%" + searchby_associatename.Text + "%");
                }
                else if (string.IsNullOrEmpty(searchby_associatename.Text) && !string.IsNullOrEmpty(searchby_reportingmanager.Text))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select ID,EscalatedDate,AssociateName,ReportingManager,MailBoxType,SubjectLine,RequestorEmailAddress,RequestorBusinessUnit,RDCComments from dbo.tbl_escalations_cip_dotnet with(nolock) where isdeleted = 0 and ReportingManager like @reportingmanager order by ID ";
                    cmd.Parameters.AddWithValue("@reportingmanager", "%" + searchby_reportingmanager.Text + "%");
                }
                else if (!string.IsNullOrEmpty(searchby_associatename.Text) && !string.IsNullOrEmpty(searchby_reportingmanager.Text))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select ID,EscalatedDate,AssociateName,ReportingManager,MailBoxType,SubjectLine,RequestorEmailAddress,RequestorBusinessUnit,RDCComments from dbo.tbl_escalations_cip_dotnet with(nolock) where isdeleted = 0 and ReportingManager like @reportingmanager and associatename like @associatename order by ID ";
                    cmd.Parameters.AddWithValue("@reportingmanager", "%" + searchby_reportingmanager.Text + "%");
                    cmd.Parameters.AddWithValue("@associatename", "%" + searchby_associatename.Text + "%");
                }
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                datagridview_main.DataSource = dt;
                conn.Close();
            }
                
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        
        private void insert_Click(object sender, EventArgs e)
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
                    //cmd.CommandText = "insert into tbl_approvals_daily_dotnet(processtype,drdprocess,approvalteam,receiveddate,receivedtime,completiondate,completiontime,noofemails,associatename,requestorbusinessunit,partyname,principalname,category,noofrecords,qualityparameters,TypeofBreaches,FeedbackGiven,TypeofError,NoofCriticalErrors,NoofMinorErrors,Comments,CorrectiveActionTaken,CorrectiveActionDate,CorrectiveActionTime,CorrectiveActionComments,ReasonsforDisagreement,lastupdatedatetime,isdeleted,machinename,principletype,riskid,BatchID,PartyLocation,RiskCategory,EventCodes) values (@processtypeparam,@drdprocessparam,@approvalteamnameparam,@receiveddateparam,@receivedtimeparam,@completiondateparam,@completiontimeparam,@noofemailsparam,@associatenameparam,@requestorbusinessunitparam,@partynameparam,@principalnameparam,@categorynameparam,@noofrecordsparam,@qualityparametersparam,@typeofbreachesparam,@feedbackgivenparam,@typeoferrorparam,@noofcriticalerrorsparam,@noofminorerrorsparam,@commentsparam,@correctiveactiontakenparam,@correctiveactiondateparam,@correctiveactiontimeparam,@correctiveactioncommentsparam,@reasonsfordisagreementparam,@lastupdatedatetimeparam,@isdeletedparam,@machinenameparam,@principletypeparam,@riskidparam,@BatchIDparam,@PartyLocationparam,@RiskCategory,@EventCodes)";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "usp_escalations_cip_insert_dotnet";
                    cmd.Parameters.AddWithValue("@EscalatedDate",escalateddate.Value.Date);
                    cmd.Parameters.AddWithValue("@AssociateName",associatename.Text);
                    cmd.Parameters.AddWithValue("@MailboxType", mailboxtype.Text);
                    cmd.Parameters.AddWithValue("@SubjectLine",subjectline.Text);
                    cmd.Parameters.AddWithValue("@RequestorEmailAddress",requestoremailaddress.Text);
                    if (string.IsNullOrEmpty(rdccomments.Text))
                    {
                        cmd.Parameters.AddWithValue("@RDCComments", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@RDCComments", rdccomments.Text);
                    }
                    cmd.Parameters.AddWithValue("@LastUpdatedBy",Environment.UserName.ToString());
                    cmd.Parameters.AddWithValue("@LastUpdatedDateTime",DateTime.Now.ToLocalTime());
                    cmd.Parameters.AddWithValue("@MachineName",Environment.MachineName.ToString());
                    cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 500);
                    cmd.Parameters["@Message"].Direction = ParameterDirection.Output;

                    
                    if (escalateddate.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please update Escalated Date");
                    }
                    else if (string.IsNullOrEmpty(associatename.Text))
                    {
                        MessageBox.Show("Please update Associate Name");
                    }
                    else if (string.IsNullOrEmpty(mailboxtype.Text))
                    {
                        MessageBox.Show("Please update Mailbox Type");
                    }
                    else if (string.IsNullOrEmpty(subjectline.Text))
                    {
                        MessageBox.Show("Please update Subject Line");
                    }
                    else if (string.IsNullOrEmpty(requestoremailaddress.Text))
                    {
                        MessageBox.Show("Please update Escalated By");
                    }

                    else
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        string message = cmd.Parameters["@Message"].Value.ToString();
                        if (!string.IsNullOrEmpty(message))
                        {
                            MessageBox.Show("" + message.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Record Inserted Successfully");
                            cmd.Parameters.Clear();
                            reset_overall();
                            conn.Close();
                        }
                    }
                }
                catch (Exception ab)
                {
                    MessageBox.Show("Error Generated Details" + ab.ToString());
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            string messsage = "Do you want to update this record?";
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
                    //cmd.CommandText = "insert into tbl_approvals_daily_dotnet(processtype,drdprocess,approvalteam,receiveddate,receivedtime,completiondate,completiontime,noofemails,associatename,requestorbusinessunit,partyname,principalname,category,noofrecords,qualityparameters,TypeofBreaches,FeedbackGiven,TypeofError,NoofCriticalErrors,NoofMinorErrors,Comments,CorrectiveActionTaken,CorrectiveActionDate,CorrectiveActionTime,CorrectiveActionComments,ReasonsforDisagreement,lastupdatedatetime,isdeleted,machinename,principletype,riskid,BatchID,PartyLocation,RiskCategory,EventCodes) values (@processtypeparam,@drdprocessparam,@approvalteamnameparam,@receiveddateparam,@receivedtimeparam,@completiondateparam,@completiontimeparam,@noofemailsparam,@associatenameparam,@requestorbusinessunitparam,@partynameparam,@principalnameparam,@categorynameparam,@noofrecordsparam,@qualityparametersparam,@typeofbreachesparam,@feedbackgivenparam,@typeoferrorparam,@noofcriticalerrorsparam,@noofminorerrorsparam,@commentsparam,@correctiveactiontakenparam,@correctiveactiondateparam,@correctiveactiontimeparam,@correctiveactioncommentsparam,@reasonsfordisagreementparam,@lastupdatedatetimeparam,@isdeletedparam,@machinenameparam,@principletypeparam,@riskidparam,@BatchIDparam,@PartyLocationparam,@RiskCategory,@EventCodes)";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "usp_escalations_cip_update_dotnet";
                    cmd.Parameters.AddWithValue("@ID",id.Text);
                    cmd.Parameters.AddWithValue("@EscalatedDate", escalateddate.Value.Date);
                    cmd.Parameters.AddWithValue("@AssociateName", associatename.Text);
                    cmd.Parameters.AddWithValue("@MailboxType", mailboxtype.Text);
                    cmd.Parameters.AddWithValue("@SubjectLine", subjectline.Text);
                    if (string.IsNullOrEmpty(rdccomments.Text))
                    {
                        cmd.Parameters.AddWithValue("@RDCComments", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@RDCComments", rdccomments.Text);
                    }
                    cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());
                    cmd.Parameters.AddWithValue("@LastUpdatedDateTime", DateTime.Now.ToLocalTime());
                    cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName.ToString());
                    cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 500);
                    cmd.Parameters["@Message"].Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@RequestorEmailAddress",requestoremailaddress.Text);
                    
                    if (escalateddate.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please update Escalated Date");
                    }
                    else if (string.IsNullOrEmpty(associatename.Text))
                    {
                        MessageBox.Show("Please update Associate Name");
                    }
                    else if (string.IsNullOrEmpty(mailboxtype.Text))
                    {
                        MessageBox.Show("Please update Mailbox Type");
                    }
                    else if (string.IsNullOrEmpty(subjectline.Text))
                    {
                        MessageBox.Show("Please update Subject Line");
                    }
                    else if (string.IsNullOrEmpty(requestoremailaddress.Text))
                    {
                        MessageBox.Show("Please update Escalated By");
                    }
                    else
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        string message = cmd.Parameters["@Message"].Value.ToString();
                        if (!string.IsNullOrEmpty(message))
                        {
                            MessageBox.Show("" + message.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Record Updated Successfully");
                            cmd.Parameters.Clear();
                            reset_overall();
                            conn.Close();
                        }
                    }
                }
                catch (Exception ab)
                {
                    MessageBox.Show("Error Generated Details" + ab.ToString());
                }
            }
        }

        private void datagridview_main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string messsage = "Do you want to update the record?";
            string title = "Message Box";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(messsage, title, buttons);
            if (result == DialogResult.Yes)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.datagridview_main.Rows[e.RowIndex];
                    id.Text = row.Cells["txtID"].Value.ToString();
                    escalateddate.Text = row.Cells["txtEscalatedDate"].Value.ToString();
                    escalateddate.CustomFormat = "dd-MMMM-yyyy";
                    associatename.Text = row.Cells["txtAssociateName"].Value.ToString();
                    mailboxtype.Text = row.Cells["txtMailBoxType"].Value.ToString();
                    subjectline.Text = row.Cells["txtSubjectLine"].Value.ToString();
                    requestoremailaddress.Text = row.Cells["txtRequestorEmailAddress"].Value.ToString();
                    if (string.IsNullOrEmpty(row.Cells["txtRequestorEmailAddress"].Value.ToString()))
                    {
                        rdccomments.Text = string.Empty;
                    }
                    else
                    {
                        rdccomments.Text = row.Cells["txtRDCComments"].Value.ToString();
                    }

                    insert.Enabled = false;
                    update.Enabled = true;
                }
                
            }
            else
            {
                id.Focus();
            }
        }

        
        private void escalateddate_MouseHover(object sender, EventArgs e)
        {
            escalateddate.CustomFormat = "dd-MMMM-yyyy";
        }

        private void searchby_subjectline_TextChanged(object sender, EventArgs e)
        {
            datagridview_main_display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://A20-CB-DBSE01P/Reports/report/DRD%20MI%20Mumbai/DRD%20Reports/rpt_SSRS_Escalations_CIP_DotNet");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }

        private void searchby_reportingmanager_TextChanged(object sender, EventArgs e)
        {
            datagridview_main_display();
        }

        private void summaryreport_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://app.powerbi.com/groups/81c3ab7d-0a2a-46f2-b54f-38eb239011a1/reports/800bcb68-3e7c-4858-8273-c805d1974670/ReportSection31a41de679b2bcefa277?experience=power-bi");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }
    }
}
