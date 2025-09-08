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
    public partial class ErrorTracker : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";

        public ErrorTracker()
        {
            InitializeComponent();
        }

        private void ErrorTracker_Load(object sender, EventArgs e)
        {
            boolean_load();
            completionmonth.CustomFormat = "MMMM yyyy";
            display_overall_grid1();
            dataGridView2.Visible = false;
            display_overall_grid2();
            associatename_list();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomePage obj_homepage = new HomePage();
            obj_homepage.Show();
        }

        public void boolean_load()
        {
            Boolean obj_boolean = new Boolean();
            DataTable dtaa = new DataTable();
            DataTable dtaa1 = new DataTable();

            obj_boolean.boolean_list(dtaa);
            obj_boolean.boolean_list(dtaa1);
            
            txtDisputeResolvedStatus.DataSource = dtaa;
            txtDisputeResolvedStatus.DisplayMember = "Boolean";

            txtRaisedForDispute.DataSource = dtaa1;
            txtRaisedForDispute.DisplayMember = "Boolean";


            conn.Close();
        }

        public void display_overall_grid1()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            conn.ConnectionString = connectionstringtxt;
            conn.Open();
            cmd.Connection = conn;
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "select [Approval Team] as [Quality Checker Name],[Check Completed Date] as [Error Date],[Associate Name],[Party Name],[Principal Name],[Type of Error],[No#of Critical Errors],[No# of Minor Errors] from tbl_approvals_consolidate a inner join tbl_emp_details b on a.[Associate Name] = b.EmpName where 1=1 and [Type of Error] like '%mat%' and SUBSTRING(b.INTID,5,len(b.intid)) = @INTIDparam and convert(date,dateadd(dd,1,eomonth([Check Completed Date],-1))) = convert(date,dateadd(dd,1,eomonth(@monthparam,-1))) order by [Check Completed Date] asc";
            cmd.CommandText = "dbo.usp_SelfServiceErrorReportTool_dotnet";
            cmd.Parameters.AddWithValue("@INTIDparam", Environment.UserName.ToString());
            cmd.Parameters.AddWithValue("@monthparam", completionmonth.Value.Date);
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        public void display_overall_grid2()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            conn.ConnectionString = connectionstringtxt;
            conn.Open();
            cmd.Connection = conn;
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "select [Approval Team] as [Quality Checker Name],[Check Completed Date] as [Error Date],[Associate Name],[Party Name],[Principal Name],[Type of Error],[No#of Critical Errors],[No# of Minor Errors] from tbl_approvals_consolidate a inner join tbl_emp_details b on a.[Associate Name] = b.EmpName where 1=1 and [Type of Error] like '%mat%' and SUBSTRING(b.INTID,5,len(b.intid)) = @INTIDparam  order by [Check Completed Date] asc";
            cmd.CommandText = "dbo.usp_SelfServiceErrorReportTool_Overall_dotnet";
            cmd.Parameters.AddWithValue("@INTIDparam", Environment.UserName.ToString());
            //cmd.Parameters.AddWithValue("@monthparam",completionmonth.Value.Date);
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        public void display_filter_grid1()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            conn.ConnectionString = connectionstringtxt;
            conn.Open();
            cmd.Connection = conn;
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "select [Approval Team] as [Quality Checker Name],[Check Completed Date] as [Error Date],[Associate Name],[Party Name],[Principal Name],[Type of Error],[No#of Critical Errors],[No# of Minor Errors] from tbl_approvals_consolidate a inner join tbl_emp_details b on a.[Associate Name] = b.EmpName where 1=1 and [Type of Error] like '%mat%' and SUBSTRING(b.INTID,5,len(b.intid)) = @INTIDparam and convert(date,dateadd(dd,1,eomonth([Check Completed Date],-1))) = convert(date,dateadd(dd,1,eomonth(@monthparam,-1))) order by [Check Completed Date] asc";
            cmd.CommandText = "dbo.usp_SelfServiceErrorReportTool_associatefilter_dotnet";
            cmd.Parameters.AddWithValue("@INTIDparam", Environment.UserName.ToString());
            cmd.Parameters.AddWithValue("@monthparam", completionmonth.Value.Date);
            if (string.IsNullOrEmpty(searchbyassociatename.Text))
            {
                cmd.Parameters.AddWithValue("@textboxparam", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@textboxparam", searchbyassociatename.Text);
            }
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        public void display_filter_grid2()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            conn.ConnectionString = connectionstringtxt;
            conn.Open();
            cmd.Connection = conn;
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "select [Approval Team] as [Quality Checker Name],[Check Completed Date] as [Error Date],[Associate Name],[Party Name],[Principal Name],[Type of Error],[No#of Critical Errors],[No# of Minor Errors] from tbl_approvals_consolidate a inner join tbl_emp_details b on a.[Associate Name] = b.EmpName where 1=1 and [Type of Error] like '%mat%' and SUBSTRING(b.INTID,5,len(b.intid)) = @INTIDparam and convert(date,dateadd(dd,1,eomonth([Check Completed Date],-1))) = convert(date,dateadd(dd,1,eomonth(@monthparam,-1))) order by [Check Completed Date] asc";
            cmd.CommandText = "dbo.usp_SelfServiceErrorReportTool_associatefilter_overall_dotnet";
            cmd.Parameters.AddWithValue("@INTIDparam", Environment.UserName.ToString());
            cmd.Parameters.AddWithValue("@monthparam", completionmonth.Value.Date);
            if (string.IsNullOrEmpty(searchbyassociatename.Text))
            {
                cmd.Parameters.AddWithValue("@textboxparam", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@textboxparam", searchbyassociatename.Text);
            }
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        public void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "export.xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //ToCsV(dataGridView1, @"c:\export.xls");
                    ToCsV(dataGridView2, sfd.FileName); // Here dataGridview1 is your grid view name
                }
                MessageBox.Show("Export completed successfully");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details:" + ab.ToString());
            }
        }

        private void completionmonth_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchbyassociatename.Text))
            {
                display_overall_grid1();
                display_overall_grid2();
            }
            else
            {
                display_filter_grid1();
                display_filter_grid2();
            }
        }

     

        public void update_acknowledged()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    if (row.Cells["txtAcknowledge"].Value != null)
                    {
                        if (Convert.ToBoolean(row.Cells["txtAcknowledge"].Value) == true)
                        {
                            //DataGridViewRow dgvrow = dataGridView1.CurrentRow;
                            conn.ConnectionString = connectionstringtxt;
                            cmd.Connection = conn;
                            conn.Open();
                            cmd.Parameters.Clear();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update dbo.tbl_approvals_daily_dotnet set acknowledged = @IntID where requestid = @requestid";
                            cmd.Parameters.AddWithValue("@IntID", Environment.UserName.ToString());
                            cmd.Parameters.AddWithValue("requestid", row.Cells["txtRequestID"].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Acknowledged successfully");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details :" + ab.ToString());
            }
        }

        public void update_raisedfordispute()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    if (row.Cells["txtRaisedForDispute"].Value != null)
                    {
                        if (Convert.ToBoolean(row.Cells["txtRaisedForDispute"].Value) == true)
                        {
                            //DataGridViewRow dgvrow = dataGridView1.CurrentRow;
                            conn.ConnectionString = connectionstringtxt;
                            cmd.Connection = conn;
                            conn.Open();
                            cmd.Parameters.Clear();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update dbo.tbl_approvals_daily_dotnet set RaisedForDispute = @IntID where requestid = @requestid";
                            cmd.Parameters.AddWithValue("@IntID", Environment.UserName.ToString());
                            cmd.Parameters.AddWithValue("requestid", row.Cells["txtRequestID"].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Raised For Dispute successfully");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details :" + ab.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update_acknowledged();
            display_overall_grid1();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow myrow in dataGridView1.Rows)
            {
                if (!string.IsNullOrEmpty(myrow.Cells["txtAcknowledged"].Value.ToString()))
                {
                    myrow.DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    myrow.DefaultCellStyle.BackColor = Color.Orange;
                }
            }
        }

        private void searchbyassociatename_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchbyassociatename.Text))
            {
                display_overall_grid1();
                display_overall_grid2();
            }
            else
            {
                display_filter_grid1();
                display_filter_grid2();
            }
        }

        public void associatename_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                Emp_Details obj_empdetails = new Emp_Details();
                DataTable dtaa = new DataTable();
                obj_empdetails.associate_list_overall (dtaa);
                searchbyassociatename.DataSource = dtaa;
                searchbyassociatename.DisplayMember = "EmpName";
                conn.Close();
                searchbyassociatename.SelectedIndex = -1;

            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        private void searchbyassociatename_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                searchbyassociatename.SelectedIndex = -1;
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
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update dbo.tbl_approvals_daily_dotnet set comments = @comments, raisedfordispute = @raisedfordispute, DisputeResolvedStatus = @DisputeResolvedStatus where requestid = @requestid";
                    cmd.Parameters.AddWithValue("@requestid", dgvrow.Cells["txtRequestID"].Value);
                    //cmd.Parameters.AddWithValue("@comments", dgvrow.Cells["txtComments"].Value);
                    //cmd.Parameters.AddWithValue("@DisputeResolvedStatus", dgvrow.Cells["txtDisputeResolvedStatus"].Value);
                    if (string.IsNullOrEmpty(dgvrow.Cells["txtComments"].Value.ToString()))
                    {
                        cmd.Parameters.AddWithValue("@comments", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@comments", dgvrow.Cells["txtComments"].Value.ToString());
                    }
                    if (string.IsNullOrEmpty(dgvrow.Cells["txtDisputeResolvedStatus"].Value.ToString()))
                    {
                        cmd.Parameters.AddWithValue("@DisputeResolvedStatus", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@DisputeResolvedStatus", dgvrow.Cells["txtDisputeResolvedStatus"].Value.ToString());
                    }
                    if (string.IsNullOrEmpty(dgvrow.Cells["txtRaisedForDispute"].Value.ToString()))
                    {
                        cmd.Parameters.AddWithValue("@raisedfordispute", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@raisedfordispute", dgvrow.Cells["txtRaisedForDispute"].Value.ToString());
                    }
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Records Updated Successfully");
                    display_overall_grid1();
                }

                catch (Exception ab)
                {
                    MessageBox.Show("Records Updated Unsuccessfully");
                    MessageBox.Show("Error Generated Details :" + ab.ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //update_raisedfordispute();
            //display_overall_grid1(); 
            EmailNotification obj_email = new EmailNotification();
            obj_email.Show();
        }


    }
}
