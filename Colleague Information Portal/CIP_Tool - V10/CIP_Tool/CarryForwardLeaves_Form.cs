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
using System.Configuration;
using System.IO;

namespace CIP_Tool
{
    public partial class CarryForwardLeaves_Form : Form
    {
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public CarryForwardLeaves_Form()
        {
            InitializeComponent();
        }

        private void CarryForwardLeaves_Load(object sender, EventArgs e)
        {
            
            reportingmanager_load();
            empname_load();
            adminlevel_check();
            //year_load();
            reset_overall();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Roster obj_roster = new Roster();
            obj_roster.Show();
        }

        public void reset_overall()
        {
            //requestid.Text = string.Empty;
            empname_insert.SelectedIndex = -1;
            //year.Text = string.Empty;
            carryforwardleaves_insert.Value = 0;
            //empname_load();
            carryforwardleaves_insert.Minimum = 0;
            //requestid.Enabled = false;
            year.Maximum = 2100;
            year.Minimum = 2020;
            year.Value = 2020;
            insert.Enabled = true;
            //datagridview2_display_overall();
            datagridview_display_overall();
            year.Visible = true;
            //reportingmanager_load();
            for (int i = 0; i < empname_insert.Items.Count; i++)
            {
                empname_insert.SetItemChecked(i, false);
            }
            empname_insert.Items.Clear();
            //requestid.Enabled = false;
            
 
        }

        public void empname_load()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                for (int i = 0; i < empname_insert.Items.Count; i++)
                {
                    empname_insert.SetItemChecked(i, false);
                }
                empname_insert.Items.Clear();
                Emp_Details obj_empname = new Emp_Details();
                DataTable dtaa = new DataTable();
                DataTable dtaa1 = new DataTable();
                DataSet ds = new DataSet();
                //obj_empname.empname_list_basedon_reportingmanager(dtaa, reportingmanager.Text);
                obj_empname.empname_list_basedon_reportingmanager_insert(dtaa, reportingmanager_insert.Text);
                obj_empname.associate_list_carryforward(dtaa1);
                if (reportingmanager_insert.Text != string.Empty)
                {
                    foreach (DataRow datarow in dtaa.Rows)
                    {
                        empname_insert.Items.Add(datarow["Empname"]);
                    }
                }
                obj_empname.associate_list(dtaa);
                txtEmpName.DataSource = dtaa1;
                txtEmpName.DisplayMember = "EmpName";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

     

        public void adminlevel_check()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                adminlevel.SelectedIndex = -1;
                Emp_Details obj_empnames = new Emp_Details();
                DataTable dtaa = new DataTable();
                obj_empnames.check_accesslevel (dtaa);
                adminlevel.DataSource = dtaa;
                adminlevel.DisplayMember = "Admin Level";
                conn.Close();
                adminlevel.Visible = false;
                if (adminlevel.Text == "Admin")
                {
                    insert.Enabled = true;
                    dataGridView2.Enabled = true;
                    dataGridView2.AllowUserToDeleteRows = true;
                    dataGridView2.ReadOnly = false;
                }
                else
                {
                    insert.Enabled = false;
                    dataGridView2.AllowUserToDeleteRows = false;
                    dataGridView2.ReadOnly = true;
                }
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void reportingmanager_load()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                Emp_Details obj_reportingmanager = new Emp_Details();
                DataTable dtaa = new DataTable();
                obj_reportingmanager.reportingmanager_list(dtaa);
                reportingmanager_insert.DataSource = dtaa;
                reportingmanager_insert.DisplayMember = "Reporting Manager";
                searchby_reportingmanager.DataSource = dtaa;
                searchby_reportingmanager.DisplayMember = "Reporting Manager";
                conn.Close();
                reportingmanager_insert.SelectedIndex = -1;
                searchby_reportingmanager.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        //public void year_load()
        //{
        //    if (conn.State == ConnectionState.Open)
        //    {
        //        conn.Close();
        //    }
        //    try
        //    {
        //        DateRoster obj_dateroster = new DateRoster();
        //        DataTable dtaa = new DataTable();
        //        obj_dateroster.year_list(dtaa);
        //        searchby_year.DataSource = dtaa;
        //        searchby_year.DisplayMember = "Year";
        //        conn.Close();
        //        searchby_year.SelectedIndex = -1;
        //    }
        //    catch (Exception ab)
        //    {
        //        MessageBox.Show("Error Generated Details: " + ab.ToString());
        //    }
        //}

        //public void validate_associatename()
        //{

        //    if (!string.IsNullOrEmpty(empname_insert.Text) && string.IsNullOrEmpty(requestid.Text))
        //    {

        //        //dataGridView1.Visible = false;
        //        //year.Visible = true;
        //        if (conn.State == ConnectionState.Open)
        //        {
        //            conn.Close();
        //        }
        //        SqlDataAdapter sda = new SqlDataAdapter();
        //        DataTable dt = new DataTable();
        //        conn.ConnectionString = connectionstringtxt;
        //        cmd.Connection = conn;
        //        conn.Open();
        //        cmd.Parameters.Clear();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "select EmpName from vw_emp_details_dotnet  where 1=1 and empname = @empname order by empname asc";
        //        cmd.Parameters.AddWithValue("@empname", empname_insert.Text);
        //        sda.SelectCommand = cmd;
        //        sda.Fill(dt);
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("Please enter a valid Colleague Name from the selection");
        //            conn.Close();
        //            insert.Enabled = false;
        //        }

        //        else
        //        {
        //            insert.Enabled = true;
        //        }
        //    }

        //    else if (!string.IsNullOrEmpty(empname_insert.Text) && !string.IsNullOrEmpty(requestid.Text))
        //    {
        //        if (conn.State == ConnectionState.Open)
        //        {
        //            conn.Close();
        //        }
        //        SqlDataAdapter sda = new SqlDataAdapter();
        //        DataTable dt = new DataTable();
        //        conn.ConnectionString = connectionstringtxt;
        //        cmd.Connection = conn;
        //        conn.Open();
        //        cmd.Parameters.Clear();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "select EmpName from vw_emp_details_dotnet  where 1=1 empname = @empname order by empname asc";
        //        cmd.Parameters.AddWithValue("@empname", empname_insert.Text);
        //        sda.SelectCommand = cmd;
        //        sda.Fill(dt);
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("Please enter a valid Colleague Name from the selection");
        //            conn.Close();
        //            insert.Enabled = false;

        //        }
        //        else
        //        {
        //            insert.Enabled = true;

        //        }
        //    }

        //}

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
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.usp_roster_carryforwardleaves_insert_dotnet";
                    if (empname_insert.CheckedItems.Count != 0)
                    {
                        string qualityitems2 = string.Empty;
                        foreach (var checkeditem in this.empname_insert.CheckedItems)
                        {
                            qualityitems2 += "," + checkeditem.ToString();
                        }
                        qualityitems2 = qualityitems2.Substring(1);
                        cmd.Parameters.AddWithValue("@EmpName", qualityitems2);
                    }
                    cmd.Parameters.AddWithValue("@Year", year.Value);
                    cmd.Parameters.AddWithValue("NoOfCarryForwardLeaves", carryforwardleaves_insert.Value);
                    cmd.Parameters.AddWithValue("@IsDeleted", 0);
                    cmd.Parameters.AddWithValue("@LastUpdatedDateTime", DateTime.Now.ToLocalTime());
                    cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());
                    cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName.ToString());
                    cmd.Parameters.AddWithValue("@ReportingManager", reportingmanager_insert.Text);
                    cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 2000);
                    cmd.Parameters["@Message"].Direction = ParameterDirection.Output;

                    //If Conditions
                    if (empname_insert.CheckedItems.Count == 0)
                    {
                        MessageBox.Show("Please select Colleague Names");
                    }
                    else if (year.Text == string.Empty)
                    {
                        MessageBox.Show("Please update the value for Year");
                    }
                    else if (carryforwardleaves_insert.Value > 25)
                    {
                        MessageBox.Show("Carry forward leaves cannot be more than 25 during a particular year");
                    }
                    else if (string.IsNullOrEmpty(reportingmanager_insert.Text))
                    {
                        MessageBox.Show("Please update Reporting Manager Name");
                    }
                    else
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        string message1 = cmd.Parameters["@Message"].Value.ToString();
                        if (!string.IsNullOrEmpty(message1))
                        {
                            MessageBox.Show("" + message1.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Records Inserted Successfully");
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
            else
            {
                insert.Focus();
            }


        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset_overall();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string messsage = "Do you want to update the record?";
            //string title = "Message Box";
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //DialogResult result = MessageBox.Show(messsage, title, buttons);
            //if (result == DialogResult.Yes)
            //{
            //    if (e.RowIndex >= 0)
            //    {
            //        DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
            //        requestid.Text = row.Cells["txtrequestID"].Value.ToString();
            //        empname_update.Text = row.Cells["txtEmpName"].Value.ToString();
            //        carryforwardleaves_update.Text = row.Cells["txtNoOfCarryForwardLeaves"].ToString();
            //    }
            //}
            //else
            //{
            //    requestid.Focus();
            //}
        }

        private void reportingmanager_SelectedIndexChanged(object sender, EventArgs e)
        {
            empname_load();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                for (int i = 0; i < empname_insert.Items.Count; i++)
                {
                    empname_insert.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < empname_insert.Items.Count; i++)
                {
                    empname_insert.SetItemChecked(i, false);
                }
            }
        }

        


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://A20-CB-DBSE01P/Reports/report/DRD%20MI%20Mumbai/DRD%20Reports/rpt_SSRS_Roster_CarryForwardLeaves_RawData_DotNet");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            if (dataGridView2.CurrentRow != null)
            {
                try
                {
                    DataGridViewRow dgvrow = dataGridView2.CurrentRow;
                    conn.ConnectionString = connectionstringtxt;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "usp_roster_carryforwardleaves_update_dotnet";
                    cmd.Parameters.AddWithValue("@EmpName", dgvrow.Cells["txtEmpName"].Value);
                    cmd.Parameters.AddWithValue("@Year", dgvrow.Cells["txtYear"].Value.ToString());
                    cmd.Parameters.AddWithValue("@NoOfCarryForwardLeaves", dgvrow.Cells["txtNoOfCarryForwardLeaves"].Value);
                    cmd.Parameters.AddWithValue("@LastUpdatedDateTime", DateTime.Now.ToLocalTime());
                    cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());
                    cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName.ToString());
                    cmd.Parameters.AddWithValue("@RequestID", dgvrow.Cells["txtRequestID"].Value);
                    cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 500);
                    cmd.Parameters["@Message"].Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    string leavemessage2 = cmd.Parameters["@Message"].Value.ToString();
                    if (!string.IsNullOrEmpty(leavemessage2))
                    {
                        MessageBox.Show("" + leavemessage2.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Records Updated Successfully");
                    }
                    datagridview_display_overall();
                }

                catch (Exception ab)
                {
                    MessageBox.Show("Error Generated Details :" + ab.ToString());
                    datagridview_display_overall();
                }
                //datagridview_rosterupdate_overall();
            }
        }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentRow.Cells["txtRequestID"].Value != DBNull.Value)
                {
                    if (MessageBox.Show("Are you sure to delete this record ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataGridViewRow dgvrow = dataGridView2.CurrentRow;
                        conn.ConnectionString = connectionstringtxt;
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.Parameters.Clear();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "usp_roster_carryforwardleaves_delete_dotnet";
                        cmd.Parameters.AddWithValue("@RequestID", Convert.ToInt32(dgvrow.Cells["txtRequestID"].Value));
                        cmd.Parameters.AddWithValue("@LastUpdatedDateTime", DateTime.Now.ToLocalTime());
                        cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());
                        cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Row(s) deleted successfully ");

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
                datagridview_display_overall();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details :" + ab.ToString());
                datagridview_display_overall();
            }
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

                if (string.IsNullOrEmpty(searchby_reportingmanager.Text) && string.IsNullOrEmpty(searchby_year.Text))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select RequestID,EmpName,Year,NoOfCarryForwardLeaves,LastUpdatedDateTime,ReportingManager from dbo.vw_roster_carryforwardleaves_dotnet where year >= 2020  order by Year,EmpName asc";
                    //cmd.Parameters.AddWithValue("@getdate", DateTime.Now.Date);
                }
                else
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.usp_carryforwardleaves_datagridview_search_dotnet";

                    if (string.IsNullOrEmpty(searchby_reportingmanager.Text))
                    {
                        cmd.Parameters.AddWithValue("@reportingmanager", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@reportingmanager", searchby_reportingmanager.Text);
                    }
                    if (string.IsNullOrEmpty(searchby_year.Text))
                    {
                        cmd.Parameters.AddWithValue("@year", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@year",searchby_year.Text);
                    }
                }
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

       

        private void searchby_reportingmanager_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridview_display_overall();
        }

        private void searchby_year_TextChanged(object sender, EventArgs e)
        {
            datagridview_display_overall();
        }

       

    }
}
