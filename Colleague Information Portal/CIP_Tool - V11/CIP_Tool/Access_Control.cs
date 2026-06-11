using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIP_Tool
{
    public partial class Access_Control : Form
    {
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();
        public Access_Control()
        {
            InitializeComponent();
        }

        private void Access_Control_Load(object sender, EventArgs e)
        {
            empname_list();
            reset_overall();
        }

        public void reset_overall()
        {
            empname.SelectedIndex = -1;
            workpulse_admin_access.Checked = false;
            pkt_tool_admin_access.Checked = false;
            ot_tool_admin_access.Checked = false;
            termination_tool_admin_access.Checked = false;
            maxsight_upload_tool_admin_access.Checked = false;
            batchworkflow_L2_form_access.Checked = false;
            batchworkflow_admin_access.Checked = false;
            cip_tool_admin_access.Checked = false;
            batch_oms_bulkupload_admin_access.Checked = false;
            workpulse_powerbi_admin_access.Checked = false;
            admin_access.Checked = false;
            synthetic_tracker_access.Checked = false;
            dispute_tracker_access.Checked = false;
            error_tracker_access.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomePage obj_form3 = new HomePage();
            obj_form3.Show();
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
                System.Data.DataTable dtaa = new System.Data.DataTable();
                DataSet ds = new DataSet();
                obj_empdetails.associate_training_list(dtaa);
                empname.DataSource = dtaa;
                empname.DisplayMember = "EmpName";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        private void add_admin_Click(object sender, EventArgs e)
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
                cmd.CommandText = "dbo.usp_access_control_add_as_admin_ciptool_dotnet";
                cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 1000);
                cmd.Parameters["@Message"].Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@EmpName",empname.Text);
                if (workpulse_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@WorkPulse_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@WorkPulse_Admin_Access", 1);
                }

                if (pkt_tool_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@PKT_Tool_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PKT_Tool_Admin_Access", 1);
                }
                if (ot_tool_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@OT_Tool_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OT_Tool_Admin_Access", 1);
                }
                if (termination_tool_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@Termination_Tool_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Termination_Tool_Admin_Access", 1);
                }
                if (maxsight_upload_tool_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@Maxsight_Upload_Tool_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Maxsight_Upload_Tool_Admin_Access", 1);
                }
                if (batchworkflow_L2_form_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@BatchWorkflow_L2_Form_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@BatchWorkflow_L2_Form_Access", 1);
                }
                if (batchworkflow_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@BatchWorkflow_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@BatchWorkflow_Admin_Access", 1);
                }
                if (cip_tool_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@CIP_Tool_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CIP_Tool_Admin_Access", 1);
                }
                if (batch_oms_bulkupload_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@Batch_OMS_BulkUpload_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Batch_OMS_BulkUpload_Admin_Access", 1);
                }
                if (workpulse_powerbi_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@WorkPulse_PowerBI_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@WorkPulse_PowerBI_Admin_Access", 1);
                }
                if (admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Admin_Access", 1);
                }
                if (synthetic_tracker_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@Synthetic_Tracker_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Synthetic_Tracker_Access", 1);
                }
                if (dispute_tracker_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@Dispute_Tracker_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Dispute_Tracker_Access", 1);
                }
                if (error_tracker_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@Error_Tracker_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Error_Tracker_Access", 1);
                }


                //if conditions
                if (string.IsNullOrEmpty(empname.Text))
                {
                    MessageBox.Show("Please update EmpName");
                }
                
                else
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    string uploadmessage = cmd.Parameters["@Message"].Value.ToString();
                    MessageBox.Show("" + uploadmessage.ToString());
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

        private void remove_admin_Click(object sender, EventArgs e)
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
                cmd.CommandText = "dbo.usp_access_control_remove_as_admin_ciptool_dotnet";
                cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 1000);
                cmd.Parameters["@Message"].Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@EmpName", empname.Text);
                if (workpulse_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@WorkPulse_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@WorkPulse_Admin_Access", 1);
                }

                if (pkt_tool_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@PKT_Tool_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PKT_Tool_Admin_Access", 1);
                }
                if (ot_tool_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@OT_Tool_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OT_Tool_Admin_Access", 1);
                }
                if (termination_tool_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@Termination_Tool_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Termination_Tool_Admin_Access", 1);
                }
                if (maxsight_upload_tool_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@Maxsight_Upload_Tool_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Maxsight_Upload_Tool_Admin_Access", 1);
                }
                if (batchworkflow_L2_form_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@BatchWorkflow_L2_Form_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@BatchWorkflow_L2_Form_Access", 1);
                }
                if (batchworkflow_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@BatchWorkflow_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@BatchWorkflow_Admin_Access", 1);
                }
                if (cip_tool_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@CIP_Tool_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CIP_Tool_Admin_Access", 1);
                }
                if (batch_oms_bulkupload_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@Batch_OMS_BulkUpload_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Batch_OMS_BulkUpload_Admin_Access", 1);
                }
                if (workpulse_powerbi_admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@WorkPulse_PowerBI_Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@WorkPulse_PowerBI_Admin_Access", 1);
                }
                if (admin_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@Admin_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Admin_Access", 1);
                }
                if (synthetic_tracker_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@Synthetic_Tracker_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Synthetic_Tracker_Access", 1);
                }
                if (dispute_tracker_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@Dispute_Tracker_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Dispute_Tracker_Access", 1);
                }
                if (error_tracker_access.Checked == false)
                {
                    cmd.Parameters.AddWithValue("@Error_Tracker_Access", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Error_Tracker_Access", 1);
                }


                //if conditions
                if (string.IsNullOrEmpty(empname.Text))
                {
                    MessageBox.Show("Please update EmpName");
                }

                else
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    string uploadmessage = cmd.Parameters["@Message"].Value.ToString();
                    MessageBox.Show("" + uploadmessage.ToString());
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
    }
}
