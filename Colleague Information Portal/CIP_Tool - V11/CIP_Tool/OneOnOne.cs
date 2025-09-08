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
    public partial class OneOnOne : Form
    {
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public OneOnOne()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            discussionwith_load();
            empdetails_list();
            reset_overall();
        }

        public void reset_overall()
        {
            requestid.Enabled = false;
            requestid.Text = string.Empty;
            employeename.SelectedIndex = -1;
            oneononedate.CustomFormat = " ";
            for (int i = 0; i < discussionwith.Items.Count; i++)
            {
                discussionwith.SetItemChecked(i, false);
            }
            summary.Text = string.Empty;
            insert.Enabled = true;
            update.Enabled = false;
            datagridview_display();
        }

        private void oneononedate_ValueChanged(object sender, EventArgs e)
        {
            oneononedate.CustomFormat = "dd-MMMM-yyyy";
        }

        private void oneononedate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                oneononedate.CustomFormat = " ";
            }
        }

        public void discussionwith_load()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                for (int i = 0; i < discussionwith.Items.Count; i++)
                {
                    discussionwith.SetItemChecked(i, false);
                }
                discussionwith.Items.Clear();
                Emp_Details obj_empname = new Emp_Details();
                DataTable dtaa = new DataTable();
                DataSet ds = new DataSet();
                obj_empname.reportingmanager_list(dtaa);
                foreach (DataRow datarow in dtaa.Rows)
                {
                    discussionwith.Items.Add(datarow["Reporting Manager"]);
                }

            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
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
                if (searchby_employeename.Text.Trim() == string.Empty)
                {
                    cmd.CommandText = "select * from dbo.vw_oneonone_cip_dotnet order by RequestID ";
                }
                else
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "select * from dbo.vw_oneonone_cip_dotnet where empname like @empnameparam order by RequestID ";
                    cmd.Parameters.AddWithValue("@empnameparam","%"+ searchby_employeename.Text +"%");
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
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_oneonone_insert_cip_dotnet";
                cmd.Parameters.AddWithValue("@EmployeeName",employeename.Text);
                cmd.Parameters.AddWithValue("@OneOnOneDate",oneononedate.Value.Date);
                if (discussionwith.CheckedItems.Count != 0)
                {
                    string qualityitems2 = string.Empty;
                    foreach (var checkeditem in this.discussionwith.CheckedItems)
                    {
                        qualityitems2 += "," + checkeditem.ToString();
                    }
                    qualityitems2 = qualityitems2.Substring(1);
                    cmd.Parameters.AddWithValue("@DiscussionWith", qualityitems2);
                }
                if (string.IsNullOrEmpty(summary.Text))
                {
                    cmd.Parameters.AddWithValue("@Summary", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Summary", summary.Text);
                }
                cmd.Parameters.AddWithValue("@LastUpdatedBy",Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@LastUpdatedDateTime",DateTime.Now.ToLocalTime());
                cmd.Parameters.AddWithValue("@MachineName",Environment.MachineName.ToString());

                //if conditions
                if (string.IsNullOrEmpty(employeename.Text))
                {
                    MessageBox.Show("Please update Employee Name");
                }
                else if (oneononedate.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update OneOnOne Date");
                }
                else if (discussionwith.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select items from Discussion With");
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
                    insert.Enabled = false;
                    update.Enabled = true;
                    requestid.Text = row.Cells["txtRequestID"].Value.ToString();
                    employeename.Text = row.Cells["txtEmpName"].Value.ToString();
                    oneononedate.Text = row.Cells["txtOneOnOneDate"].Value.ToString();
                    oneononedate.CustomFormat = "dd-MMMM-yyyy";
                    if (string.IsNullOrEmpty(row.Cells["txtSummary"].Value.ToString()))
                    {
                        summary.Text = string.Empty;
                    }
                    else
                    {
                        summary.Text = row.Cells["txtSummary"].Value.ToString();
                    }
                    if (!string.IsNullOrEmpty(row.Cells["txtDiscussionWith"].Value.ToString()))
                    {
                        for (int i = 0; i < discussionwith.Items.Count; i++)
                        {
                            discussionwith.SetItemChecked(i, false);
                        }
                        foreach (string value in row.Cells["txtDiscussionWith"].Value.ToString().Split(','))
                        {
                            discussionwith.SetItemChecked(discussionwith.Items.IndexOf(value), true);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < discussionwith.Items.Count; i++)
                        {
                            discussionwith.SetItemChecked(i, false);
                        }
                    }
                }
            }
            else
            {
                requestid.Focus();
            }
        }

        private void searchby_employeename_TextChanged(object sender, EventArgs e)
        {
            datagridview_display();
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
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_oneonone_update_cip_dotnet";
                cmd.Parameters.AddWithValue("@RequestID", requestid.Text);
                cmd.Parameters.AddWithValue("@EmployeeName", employeename.Text);
                cmd.Parameters.AddWithValue("@OneOnOneDate", oneononedate.Value.Date);
                if (discussionwith.CheckedItems.Count != 0)
                {
                    string qualityitems2 = string.Empty;
                    foreach (var checkeditem in this.discussionwith.CheckedItems)
                    {
                        qualityitems2 += "," + checkeditem.ToString();
                    }
                    qualityitems2 = qualityitems2.Substring(1);
                    cmd.Parameters.AddWithValue("@DiscussionWith", qualityitems2);
                }
                if (string.IsNullOrEmpty(summary.Text))
                {
                    cmd.Parameters.AddWithValue("@Summary", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Summary", summary.Text);
                }
                cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@LastUpdatedDateTime", DateTime.Now.ToLocalTime());
                cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName.ToString());

                //if conditions
                if (string.IsNullOrEmpty(employeename.Text))
                {
                    MessageBox.Show("Please update Employee Name");
                }
                else if (oneononedate.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update OneOnOne Date");
                }
                else if (discussionwith.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select items from Discussion With");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomePage obj_form3 = new HomePage();
            obj_form3.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://A20-CB-DBSE01P/Reports/report/DRD%20MI%20Mumbai/DRD%20Reports/rpt_SSRS_CIPTool_OneOnOne_dotnet");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }
    }
}
