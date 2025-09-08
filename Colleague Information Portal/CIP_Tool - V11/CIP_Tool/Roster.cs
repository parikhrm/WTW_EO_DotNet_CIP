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
    public partial class Roster : Form
    {
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        //public string connectionstringtxt = "Data Source=10.137.16.47;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Roster()
        {
            InitializeComponent();
        }

        private void Roster_Load(object sender, EventArgs e)
        {
            //reset_overall();
            status_load();
            //dateroster_load();
            competency_load();
            datagridview_rosterupdate_filters();
            reportingmanager_load();
            empname_searchby.SelectedIndex = -1;
            reportingmanager_searchby.SelectedIndex = -1;
            adminlevel_load();
            //empname_load_searchby();
            empname_searchby.SelectedIndex = -1;
            reset_overall();
        }

        

        public void enable_reportingmanager_empname()
        {
            if (startdate.Text.Trim() != string.Empty && enddate.Text.Trim() != string.Empty)
            {
                reportingmanager_update.Enabled = true;
            }
            else
            {
                reportingmanager_update.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomePage obj_homepage = new HomePage();
            obj_homepage.Show();
        }

        public void reset_overall()
        {

            //empname_load();
            status_load();
            //dateroster_load();
            //datagridview_rosterupdate_overall();
            datagridview_rosterupdate_filters();
            //competency_load();
            label1.Visible = true;
            label2.Visible = true;
            label5.Visible = true;
            requestid.Enabled = false;
            dateroster.Visible = true;
            empname.Visible = true;
            selectmonth.Visible = true;
            competency.SelectedIndex = -1;
            requestid.Text = string.Empty;
            //dateroster_searchby.CustomFormat = " ";
            insert.Enabled = true;
            //reportingmanager_searchby.Text = string.Empty;
            //empname_searchby.Text = string.Empty;
            selectmonth.Text = DateTime.Now.ToLongDateString();
            int year = DateTime.Now.Year;
            DateTime firstday = new DateTime(year, 1, 1);
            DateTime lastday = firstday.AddYears(2).AddTicks(-1);
            //selectmonth.MinDate = firstday;
            //selectmonth.MaxDate = lastday;
            startdate.MinDate = firstday;
            startdate.MaxDate = lastday;
            enddate.MinDate = firstday;
            enddate.MaxDate = lastday;
            adminlevel_load();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            for (int i = 0; i < empname_update.Items.Count; i++)
            {
                empname_update.SetItemChecked(i, false);
            }
            empname_update.Items.Clear();
            competency_update.SelectedIndex = -1;
            //reportingmanager_load();
            startdate.Text = DateTime.Now.ToShortDateString();
            enddate.Text = DateTime.Now.ToShortDateString();
            button5.Visible = true;
            for (int i = 0; i < empname.Items.Count; i++)
            {
                empname.SetItemChecked(i, false);
            }
            empname.Items.Clear();
            reportingmanager_update.SelectedIndex = -1;
            reportingmanager.SelectedIndex = -1;
            enable_reportingmanager_empname();
            reportingmanager_update_load();
            processname.SelectedIndex = -1;
            checkBox4.Checked = false;
        }

        public void empname_load_searchby()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                Emp_Details obj_empname = new Emp_Details();
                DataTable dtaa = new DataTable();
                DataSet ds = new DataSet();
                //obj_empname.associate_list_overall(dtaa); 
                obj_empname.empname_list_basedon_reportingmanager_insert(dtaa,reportingmanager_searchby.Text);
                empname_searchby.DataSource = dtaa;
                empname_searchby.DisplayMember = "EmpName";
                empname_searchby.SelectedIndex = -1;
                //empname_searchby.Text = string.Empty;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void empname_load()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                for (int i = 0; i < empname.Items.Count; i++)
                {
                    empname.SetItemChecked(i, false);
                }
                empname.Items.Clear();
                Emp_Details obj_empname = new Emp_Details();
                DataTable dtaa = new DataTable();
                //DataTable dta = new DataTable();
                DataSet ds = new DataSet();
                if (string.IsNullOrEmpty(processname.Text))
                {
                    obj_empname.empname_list_basedon_reportingmanager_insert(dtaa, reportingmanager.Text);
                }
                else
                {
                    obj_empname.empname_list_basedon_reportingmanager_processname_insert(dtaa, reportingmanager.Text, processname.Text);
                }
                if (reportingmanager.Text != string.Empty)
                {
                    foreach (DataRow datarow in dtaa.Rows)
                    {
                        empname.Items.Add(datarow["Empname"]);
                    }
                }

            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void empname_update_load()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                for (int i = 0; i < empname_update.Items.Count; i++)
                {
                    empname_update.SetItemChecked(i, false);
                }
                empname_update.Items.Clear();
                Emp_Details obj_empname = new Emp_Details();
                DataTable dtaa = new DataTable();
                DataSet ds = new DataSet();
                obj_empname.empname_list_basedon_reportingmanager(dtaa, reportingmanager_update.Text, startdate.Value.Date, enddate.Value.Date);
                if (reportingmanager_update.Text != string.Empty)
                {
                    foreach (DataRow datarow in dtaa.Rows)
                    {
                        empname_update.Items.Add(datarow["Empname"]);
                    }
                }

            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void reportingmanager_update_load()
        {
            //for update records
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                for (int i = 0; i < empname_update.Items.Count; i++)
                {
                    empname_update.SetItemChecked(i, false);
                }
                empname_update.Items.Clear();
                Emp_Details obj_reportmanager = new Emp_Details();
                DataTable dtaa = new DataTable();
                DataTable dta = new DataTable();
                DataSet ds = new DataSet();
                obj_reportmanager.reportingmanager_update_list(dtaa, startdate.Value.Date, enddate.Value.Date);
                //obj_reportmanager.reportingmanager_insert_list(dta);
                reportingmanager_update.DataSource = dtaa;
                reportingmanager_update.DisplayMember = "ReportingManager";
                reportingmanager_update.SelectedIndex = -1;
                
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }

        }

        public void reportingmanager_load()
        {
            //for update records
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                for (int i = 0; i < empname_update.Items.Count; i++)
                {
                    empname_update.SetItemChecked(i, false);
                }
                empname_update.Items.Clear();
                Emp_Details obj_reportmanager = new Emp_Details();
                DataTable dtaa = new DataTable();
                DataTable dta = new DataTable();
                DataSet ds = new DataSet();
                //obj_reportmanager.reportingmanager_update_list (dtaa,startdate.Value.Date, enddate.Value.Date);
                obj_reportmanager.reportingmanager_insert_list(dta);
                //reportingmanager_update.DataSource = dtaa;
                //reportingmanager_update.DisplayMember = "ReportingManager";
                reportingmanager_searchby.DataSource = dta;
                reportingmanager_searchby.DisplayMember = "Reporting Manager";
                reportingmanager_update.SelectedIndex = -1;
                reportingmanager.SelectedIndex = -1;

            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }

            //for insert records
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                for (int i = 0; i < empname.Items.Count; i++)
                {
                    empname.SetItemChecked(i, false);
                }
                empname.Items.Clear();
                Emp_Details obj_reportmanager = new Emp_Details();
                DataTable dtaa = new DataTable();
                DataSet ds = new DataSet();
                obj_reportmanager.reportingmanager_insert_list(dtaa);
                reportingmanager.DataSource = dtaa;
                reportingmanager.DisplayMember = "Reporting Manager";
                reportingmanager.SelectedIndex = -1;

            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void adminlevel_load()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                adminlevel.SelectedIndex = -1;
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();
                Emp_Details obj_empnames = new Emp_Details();
                obj_empnames.check_accesslevel(dt);
                adminlevel.DataSource = dt;
                adminlevel.DisplayMember = "Admin Level";
                accesslevel.DataSource = dt;
                //accesslevel.DisplayMember = "AccessLevel";
                accesslevel.DisplayMember = "CIPTool_Access";
                //conn.ConnectionString = connectionstringtxt;
                //cmd.Connection = conn;
                //conn.Open();
                //cmd.Parameters.Clear();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "select [Admin Level] from tbl_emp_details with(nolock) where substring(INTID,5,len(intid)) = @intidparam";
                //cmd.Parameters.AddWithValue("@intidparam",Environment.UserName.ToString());
                //sda.SelectCommand = cmd;
                //sda.Fill(dt);
                //adminlevel.DataSource = dt;
                //adminlevel.DisplayMember = "Admin Level";
                adminlevel.Visible = false;
                accesslevel.Visible = false;
                //if (adminlevel.Text == "Admin")
                if (accesslevel.Text == "Admin")
                {
                    insert.Enabled = true;
                    update.Enabled = true;
                    dataGridView1.AllowUserToDeleteRows = true;
                    dataGridView1.ReadOnly = false;
                }
                else
                {
                    insert.Enabled = false;
                    update.Enabled = false;
                    dataGridView1.AllowUserToDeleteRows = false;
                    dataGridView1.ReadOnly = true;
                }
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void status_load()
        {
            Status obj_status = new Status();
            DataTable dtaa_insert = new DataTable();
            DataTable dtaa_update = new DataTable();
            obj_status.status_insert_list(dtaa_insert);
            obj_status.status_update_list(dtaa_update);
            status.DataSource = dtaa_insert;
            status.DisplayMember = "Description";
            status.ValueMember = "ID";
            conn.Close();
            txtDescription.DataSource = dtaa_update;
            txtDescription.DisplayMember = "CurrentStatus";
            status_update.DataSource = dtaa_update;
            status_update.DisplayMember = "Description";
            //txtDescription.ValueMember = "ID";
            status_update.SelectedIndex = -1;
            status.SelectedIndex = -1;
        }

        public void competency_load()
        {
            Competency obj_competency = new Competency();
            DataTable dtaa = new DataTable();
            obj_competency.competency_list(dtaa);
            competency.DataSource = dtaa;
            competency_update.DataSource = dtaa;
            competency.DisplayMember = "Competency";
            competency_update.DisplayMember = "Competency";
            conn.Close();
            competency.SelectedIndex = -1;
            competency_update.SelectedIndex = -1;
        }


        public void processname_load()
        {
            ProcessName obj_processname = new ProcessName();
            DataTable dtaa = new DataTable();
            obj_processname.processname_basedon_reportingmanager_list(dtaa,reportingmanager.Text);
            processname.DataSource = dtaa;
            processname.DisplayMember = "Process";
            conn.Close();
            processname.SelectedIndex = -1;
        }

        public void dateroster_load()
        {
            for (int i = 0; i < dateroster.Items.Count; i++)
            {
                dateroster.SetItemChecked(i, false);
            }
            dateroster.Items.Clear();
            DateRoster obj_dates = new DateRoster();
            DataTable dtaa = new DataTable();
            DateTime month = Convert.ToDateTime(selectmonth.Value.ToLongDateString());
            obj_dates.datesroster_list(dtaa, month);
            foreach (DataRow datarow in dtaa.Rows)
            {
                dateroster.Items.Add(datarow["DateRoster"]);
            }
        }

        public void dateroster_weekend_load()
        {
            for (int i = 0; i < dateroster.Items.Count; i++)
            {
                dateroster.SetItemChecked(i, false);
            }
            dateroster.Items.Clear();
            DateRoster obj_dates = new DateRoster();
            DataTable dtaa = new DataTable();
            DateTime month = Convert.ToDateTime(selectmonth.Value.ToLongDateString());
            obj_dates.datesroster_weekend_list (dtaa, month);
            foreach (DataRow datarow in dtaa.Rows)
            {
                dateroster.Items.Add(datarow["DateRoster"]);
            }
        }

        private void selectmonth_ValueChanged(object sender, EventArgs e)
        {
            dateroster_load();
            checkBox2.Checked = false;
            for (int i = 0; i < dateroster.Items.Count; i++)
            {
                dateroster.SetItemChecked(i, false);
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
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.CommandText = "exec usp_roster_insert_dotnet @ReportingManager,@DateRoster,@CurrentStatusID,@IsDeleted,@LastUpdatedDateTime,@LastUpdatedBy,@MachineName,@EmpName,@ProcessName,@Competency";
                    cmd.CommandText = "dbo.usp_roster_insert_dotnet";
                    if (dateroster.CheckedItems.Count != 0)
                    {
                        string qualityitems1 = string.Empty;
                        foreach (var checkeditem in this.dateroster.CheckedItems)
                        {
                            qualityitems1 += "," + checkeditem.ToString();
                        }
                        qualityitems1 = qualityitems1.Substring(1);
                        cmd.Parameters.AddWithValue("@DateRoster", qualityitems1);
                    }
                    cmd.Parameters.AddWithValue("@CurrentStatusID", status.SelectedValue);
                    cmd.Parameters.AddWithValue("@IsDeleted", 0);
                    cmd.Parameters.AddWithValue("@LastUpdatedDateTime", DateTime.Now.ToLocalTime());
                    cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());
                    cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName.ToString());
                    if (empname.CheckedItems.Count != 0)
                    {
                        string qualityitems2 = string.Empty;
                        foreach (var checkeditem in this.empname.CheckedItems)
                        {
                            qualityitems2 += "," + checkeditem.ToString();
                        }
                        qualityitems2 = qualityitems2.Substring(1);
                        cmd.Parameters.AddWithValue("@EmpName", qualityitems2);
                    }
                    if (!string.IsNullOrEmpty(competency.Text))
                    {
                        cmd.Parameters.AddWithValue("@Competency", competency.Text);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Competency", DBNull.Value);
                    }
                    cmd.Parameters.Add("@LeavesMessage", SqlDbType.NVarChar, 500);
                    cmd.Parameters["@LeavesMessage"].Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@SelectMonth", selectmonth.Value.Date);

                    //IF Conditions
                    if (string.IsNullOrEmpty(status.Text))
                    {
                        MessageBox.Show("Please update Shift/Leave details");
                    }
                    //else if (string.IsNullOrEmpty(competency.Text))
                    //{
                    //    MessageBox.Show("Please update Competency%");
                    //}
                    else if (dateroster.CheckedItems.Count == 0)
                    {
                        MessageBox.Show("Please select Roster Dates");
                    }
                    else if (empname.CheckedItems.Count == 0)
                    {
                        MessageBox.Show("Please select Colleague Names");
                    }
                    else if (string.IsNullOrEmpty(reportingmanager.Text))
                    {
                        MessageBox.Show("Please select Reporting Manager");
                    }
                    else
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        string leavemessage = cmd.Parameters["@LeavesMessage"].Value.ToString();
                        if (!string.IsNullOrEmpty(leavemessage))
                        {
                            MessageBox.Show("" + leavemessage.ToString());

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
                    MessageBox.Show("Error Generated Details :" + ab.ToString());
                }
            }
        }

        public void datagridview_rosterupdate_overall()
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
                cmd.CommandText = "select top 50 RequestID,EmpName,ReportingManager,DateRoster,Day,Description,ProcessName,[Competency%],NoOfLeaves,[CoreTime%],Comments,HR_Portal_Uploaded from dbo.vw_roster_dotnet where year(dateroster) = year(getdate()) order by DateRoster,EmpName asc";
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

        private void reset_Click(object sender, EventArgs e)
        {
            reset_overall();
        }

        private void dateroster_searchby_ValueChanged(object sender, EventArgs e)
        {
            startdate_searchby.CustomFormat = "dd-MMMM-yyyy";
            datagridview_rosterupdate_filters();
        }

        private void dateroster_searchby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                startdate_searchby.CustomFormat = " ";
                datagridview_rosterupdate_filters();
            }
        }

       

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    DataGridViewRow dgvrow = dataGridView1.CurrentRow;
                    conn.ConnectionString = connectionstringtxt;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.usp_roster_datagrid_addupdate_dotnet_new";
                    cmd.Parameters.AddWithValue("@RequestID", dgvrow.Cells["txtRequestID"].Value);
                    cmd.Parameters.AddWithValue("@Description", dgvrow.Cells["txtDescription"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Competency", dgvrow.Cells["txtCompetency"].Value);
                    cmd.Parameters.AddWithValue("@LastUpdatedDateTime", DateTime.Now.ToLocalTime());
                    cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());
                    cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName.ToString());
                    cmd.Parameters.AddWithValue("@CoreTime", dgvrow.Cells["txtCoreTime"].Value);
                    cmd.Parameters.AddWithValue("@HR_Portal_Uploaded", dgvrow.Cells["txtHR_Portal_Uploaded"].Value);
                    cmd.Parameters.Add("@LeavesMessage", SqlDbType.NVarChar, 500);
                    cmd.Parameters["@LeavesMessage"].Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    string leavemessage2 = cmd.Parameters["@LeavesMessage"].Value.ToString();
                    if (!string.IsNullOrEmpty(leavemessage2))
                    {
                        MessageBox.Show("" + leavemessage2.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Records Updated Successfully");
                    }
                    datagridview_rosterupdate_filters();
                }

                catch (Exception ab)
                {
                    MessageBox.Show("Error Generated Details :" + ab.ToString());
                    datagridview_rosterupdate_filters();
                }
                //datagridview_rosterupdate_overall();
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Cells["txtRequestID"].Value != DBNull.Value)
                {
                    if (MessageBox.Show("Are you sure to delete this record ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataGridViewRow dgvrow = dataGridView1.CurrentRow;
                        conn.ConnectionString = connectionstringtxt;
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.Parameters.Clear();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "dbo.usp_roster_datagrid_delete_dotnet";
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
                datagridview_rosterupdate_filters();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details :" + ab.ToString());
                datagridview_rosterupdate_filters();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                for (int i = 0; i < empname.Items.Count; i++)
                {
                    empname.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < empname.Items.Count; i++)
                {
                    empname.SetItemChecked(i, false);
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                for (int i = 0; i < dateroster.Items.Count; i++)
                {
                    dateroster.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < dateroster.Items.Count; i++)
                {
                    dateroster.SetItemChecked(i, false);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://A20-CB-DBSE01P/Reports/report/DRD%20MI%20Mumbai/DRD%20Reports/rpt_SSRS_RosterView_DotNet");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                for (int i = 0; i < empname_update.Items.Count; i++)
                {
                    empname_update.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < empname_update.Items.Count; i++)
                {
                    empname_update.SetItemChecked(i, false);
                }
            }
        }

        private void reportingmanager_SelectedIndexChanged(object sender, EventArgs e)
        {
            //empname_update_load();
            empname_load();
            processname_load();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string messsage = "Do you want to update these records?";
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
                    //cmd.CommandText = "exec usp_roster_insert_dotnet @ReportingManager,@DateRoster,@CurrentStatusID,@IsDeleted,@LastUpdatedDateTime,@LastUpdatedBy,@MachineName,@EmpName,@ProcessName,@Competency";
                    cmd.CommandText = "dbo.usp_roster_update_dotnet";
                    if (empname_update.CheckedItems.Count != 0)
                    {
                        string qualityitems3 = string.Empty;
                        foreach (var checkeditem in this.empname_update.CheckedItems)
                        {
                            qualityitems3 += "," + checkeditem.ToString();
                        }
                        qualityitems3 = qualityitems3.Substring(1);
                        cmd.Parameters.AddWithValue("@EmpName", qualityitems3);
                    }
                    cmd.Parameters.AddWithValue("@StartDate", startdate.Value.Date);
                    cmd.Parameters.AddWithValue("@EndDate", enddate.Value.Date);
                    cmd.Parameters.AddWithValue("@Description", status_update.Text);
                    cmd.Parameters.AddWithValue("@LastUpdatedDateTime", DateTime.Now.ToLocalTime());
                    cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());
                    cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName.ToString());
                    if (string.IsNullOrEmpty(coretime_update.Text))
                    {
                        cmd.Parameters.AddWithValue("@CoreTime", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@CoreTime", coretime_update.Text);
                    }
                    if (string.IsNullOrEmpty(competency_update.Text))
                    {
                        cmd.Parameters.AddWithValue("@Competency", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Competency", competency_update.Text);
                    }
                    if (string.IsNullOrEmpty(comments_update.Text))
                    {
                        cmd.Parameters.AddWithValue("@Comments", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Comments", comments_update.Text);
                    }
                    cmd.Parameters.Add("@LeavesMessage", SqlDbType.NVarChar, 500);
                    cmd.Parameters["@LeavesMessage"].Direction = ParameterDirection.Output;


                    //IF Conditions
                    if (string.IsNullOrEmpty(status_update.Text))
                    {
                        MessageBox.Show("Please update Shift/Leave details");
                    }
                    //else if (string.IsNullOrEmpty(competency_update.Text))
                    //{
                    //    MessageBox.Show("Please update Competency%");
                    //}
                    else if (empname_update.CheckedItems.Count == 0)
                    {
                        MessageBox.Show("Please select Colleague Names");
                    }
                    else if (startdate.Value.Year != enddate.Value.Year)
                    {
                        MessageBox.Show("Start Date and End Date should be of the same year");
                    }
                    //else if (string.IsNullOrEmpty(competency_update.Text))
                    //{
                    //    MessageBox.Show("Please update Competency");
                    //}
                    
                    else
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        string leavemessage1 = cmd.Parameters["@LeavesMessage"].Value.ToString();
                        if (!string.IsNullOrEmpty(leavemessage1))
                        {
                            MessageBox.Show("" + leavemessage1.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Records Updated Successfully");
                            cmd.Parameters.Clear();
                            reset_overall();
                            conn.Close();
                        }

                    }
                }
                catch (Exception ab)
                {
                    MessageBox.Show("Error Generated Details :" + ab.ToString());
                }
            }
            else
            {
                requestid.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://A20-CB-DBSE01P/Reports/report/DRD%20MI%20Mumbai/DRD%20Reports/rpt_SSRS_Roster_ShrinkageReport_DotNet");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }

        public void datagridview_rosterupdate_filters()
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

                if (string.IsNullOrEmpty(empname_searchby.Text) && string.IsNullOrEmpty(reportingmanager_searchby.Text) && startdate_searchby.Text.Trim() == string.Empty && enddate_searchby.Text.Trim() == string.Empty)
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select top 20 CurrentStatus as Description,EmpName,DateRoster,Day,[Competency%],ReportingManager,ProcessName,Sub_Process,NoOfLeaves,RequestID,[CoreTime%],Comments,HR_Portal_Uploaded from dbo.vw_roster_dotnet where dateadd(dd,1,eomonth(dateroster,-1)) = dateadd(dd,1,eomonth(@getdate,-1)) order by DateRoster,EmpName asc";
                    cmd.Parameters.AddWithValue("@getdate", DateTime.Now.Date);
                }
                else
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.usp_roster_datagridview_search_dotnet_new";
                    if (string.IsNullOrEmpty(empname_searchby.Text))
                    {
                        cmd.Parameters.AddWithValue("@associatename", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@associatename", empname_searchby.Text);
                    }
                    if (string.IsNullOrEmpty(reportingmanager_searchby.Text))
                    {
                        cmd.Parameters.AddWithValue("@reportingmanager", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@reportingmanager", reportingmanager_searchby.Text);
                    }
                    if (startdate_searchby.Text.Trim() == string.Empty)
                    {
                        cmd.Parameters.AddWithValue("@startdate", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@startdate", startdate_searchby.Text);
                    }
                    if (enddate_searchby.Text.Trim() == string.Empty)
                    {
                        cmd.Parameters.AddWithValue("@enddate", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@enddate", enddate_searchby.Text);
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

        private void empname_searchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridview_rosterupdate_filters();
        }

        private void reportingmanager_searchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridview_rosterupdate_filters();
            empname_load_searchby();
        }

        private void reportingmanager_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            empname_update_load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarryForwardLeaves_Form obj_carryforward = new CarryForwardLeaves_Form();
            obj_carryforward.Show();
        }

        private void enddate_ValueChanged(object sender, EventArgs e)
        {
            reportingmanager_update_load();
        }

        private void startdate_ValueChanged(object sender, EventArgs e)
        {
            reportingmanager_update_load();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow myrow in dataGridView1.Rows)
            {

                //if (myrow.Cells["txtDescription"].Value.ToString() == "Planned Privilege Leave")
                //{
                //    myrow.DefaultCellStyle.BackColor = Color.Green;
                //    myrow.DefaultCellStyle.ForeColor = Color.White;
                //}
                //else if (myrow.Cells["txtDescription"].Value.ToString() == "Planned Casual Leave")
                //{
                //    myrow.DefaultCellStyle.BackColor = Color.Green;
                //    myrow.DefaultCellStyle.ForeColor = Color.White;
                //}
                //else if (myrow.Cells["txtDescription"].Value.ToString() == "Planned Privilege Leave Half Day")
                //{
                //    myrow.DefaultCellStyle.BackColor = Color.Green;
                //    myrow.DefaultCellStyle.ForeColor = Color.White;
                //}
                //else if (myrow.Cells["txtDescription"].Value.ToString() == "Planned Casual Leave Half Day")
                //{
                //    myrow.DefaultCellStyle.BackColor = Color.Green;
                //    myrow.DefaultCellStyle.ForeColor = Color.White;
                //}
                //else if (myrow.Cells["txtDescription"].Value.ToString() == "Unplanned Privilege Leave")
                //{
                //    myrow.DefaultCellStyle.BackColor = Color.Orange;
                //    myrow.DefaultCellStyle.ForeColor = Color.Black;
                //}
                //else if (myrow.Cells["txtDescription"].Value.ToString() == "Unplanned Casual Leave")
                //{
                //    myrow.DefaultCellStyle.BackColor = Color.Orange;
                //    myrow.DefaultCellStyle.ForeColor = Color.Black;
                //}
                //else if (myrow.Cells["txtDescription"].Value.ToString() == "Unplanned Privilege Leave Half Day")
                //{
                //    myrow.DefaultCellStyle.BackColor = Color.Orange;
                //    myrow.DefaultCellStyle.ForeColor = Color.Black;
                //}
                //else if (myrow.Cells["txtDescription"].Value.ToString() == "Unplanned Casual Leave Half Day")
                //{
                //    myrow.DefaultCellStyle.BackColor = Color.Orange;
                //    myrow.DefaultCellStyle.ForeColor = Color.Black;
                //}
                //else if (myrow.Cells["txtDescription"].Value.ToString() == "Sick Leave")
                //{
                //    myrow.DefaultCellStyle.BackColor = Color.SkyBlue;
                //    myrow.DefaultCellStyle.ForeColor = Color.Black;
                //}
                //else if (myrow.Cells["txtDescription"].Value.ToString() == "Sick Leave Half Day")
                //{
                //    myrow.DefaultCellStyle.BackColor = Color.SkyBlue;
                //    myrow.DefaultCellStyle.ForeColor = Color.Black;
                //}
                //else if (myrow.Cells["txtDescription"].Value.ToString() == "Work From Office - 1")
                //{
                //    myrow.DefaultCellStyle.BackColor = Color.Plum;
                //    myrow.DefaultCellStyle.ForeColor = Color.Black;
                //}
                //else if (myrow.Cells["txtDescription"].Value.ToString() == "Work From Office - 2")
                //{
                //    myrow.DefaultCellStyle.BackColor = Color.Plum;
                //    myrow.DefaultCellStyle.ForeColor = Color.Black;
                //}
                //else if (myrow.Cells["txtDescription"].Value.ToString() == "Work From Office - 2")
                //{
                //    myrow.DefaultCellStyle.BackColor = Color.Plum;
                //    myrow.DefaultCellStyle.ForeColor = Color.Black;
                //}
                //else
                //{
                //    //myrow.DefaultCellStyle.BackColor = Color.Orange;
                //}

                if (myrow.Cells["txtDescription"].Value.ToString() == "PL")
                {
                    myrow.DefaultCellStyle.BackColor = Color.Green;
                    myrow.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (myrow.Cells["txtDescription"].Value.ToString() == "PC")
                {
                    myrow.DefaultCellStyle.BackColor = Color.Green;
                    myrow.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (myrow.Cells["txtDescription"].Value.ToString() == "PL-HD")
                {
                    myrow.DefaultCellStyle.BackColor = Color.Green;
                    myrow.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (myrow.Cells["txtDescription"].Value.ToString() == "PC-HD")
                {
                    myrow.DefaultCellStyle.BackColor = Color.Green;
                    myrow.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (myrow.Cells["txtDescription"].Value.ToString() == "UL")
                {
                    myrow.DefaultCellStyle.BackColor = Color.Orange;
                    myrow.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (myrow.Cells["txtDescription"].Value.ToString() == "UC")
                {
                    myrow.DefaultCellStyle.BackColor = Color.Orange;
                    myrow.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (myrow.Cells["txtDescription"].Value.ToString() == "UL-HD")
                {
                    myrow.DefaultCellStyle.BackColor = Color.Orange;
                    myrow.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (myrow.Cells["txtDescription"].Value.ToString() == "UC-HD")
                {
                    myrow.DefaultCellStyle.BackColor = Color.Orange;
                    myrow.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (myrow.Cells["txtDescription"].Value.ToString() == "SL")
                {
                    myrow.DefaultCellStyle.BackColor = Color.SkyBlue;
                    myrow.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (myrow.Cells["txtDescription"].Value.ToString() == "SL-HD")
                {
                    myrow.DefaultCellStyle.BackColor = Color.SkyBlue;
                    myrow.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (myrow.Cells["txtDescription"].Value.ToString() == "WFO-1")
                {
                    myrow.DefaultCellStyle.BackColor = Color.Plum;
                    myrow.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (myrow.Cells["txtDescription"].Value.ToString() == "WFO-2")
                {
                    myrow.DefaultCellStyle.BackColor = Color.Plum;
                    myrow.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (myrow.Cells["txtDescription"].Value.ToString() == "WFO-3")
                {
                    myrow.DefaultCellStyle.BackColor = Color.Plum;
                    myrow.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (myrow.Cells["txtDescription"].Value.ToString() == "CO")
                {
                    myrow.DefaultCellStyle.BackColor = Color.SlateBlue;
                    myrow.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (myrow.Cells["txtDescription"].Value.ToString() == "CO-HD")
                {
                    myrow.DefaultCellStyle.BackColor = Color.SlateBlue;
                    myrow.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    //myrow.DefaultCellStyle.BackColor = Color.Orange;
                }

            }
        }

        private void enddate_searchby_ValueChanged(object sender, EventArgs e)
        {
            enddate_searchby.CustomFormat = "dd-MMMM-yyyy";
            datagridview_rosterupdate_filters();
        }

        private void enddate_searchby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                enddate_searchby.CustomFormat = " ";
                datagridview_rosterupdate_filters();
            }
        }

        private void reportingmanager_searchby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                reportingmanager_searchby.SelectedIndex = -1;
            }
        }

        private void empname_searchby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                empname_searchby.SelectedIndex = -1;
            }
        }

        private void processname_SelectedIndexChanged(object sender, EventArgs e)
        {
            empname_load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                dateroster_weekend_load();
            }
            else
            {
                dateroster_load();
            }
        }

    }
}
