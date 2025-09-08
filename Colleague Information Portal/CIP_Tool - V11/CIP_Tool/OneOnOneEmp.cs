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
    public partial class OneOnOneEmp : Form
    {
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public OneOnOneEmp()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            reset_overall();
            adminlevel_load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomePage obj_form3 = new HomePage();
            obj_form3.Show();
        }

        public void reset_overall()
        {
            requestid.Text = string.Empty;
            requestid.Enabled = false;
            summary.Text = string.Empty;
            iacknowledge.Checked = false;
            save.Enabled = false;
            datagridview_display();
            summary.Enabled = false;
            searchby_month.CustomFormat = " ";
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
                adminlevel.Visible = false;
                
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
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
                if (searchby_month.Text.Trim() == string.Empty)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //if (adminlevel.Text == "Admin")
                    //{
                    //    cmd.CommandText = "select * from dbo.vw_oneonone_cip_dotnet order by RequestID ";
                    //}
                    //else
                    //{
                    //    cmd.CommandText = "select a.* from dbo.vw_oneonone_cip_dotnet a inner join dbo.vw_emp_details_dotnet b on a.EmpName = b.EmpName where b.INTID_New = @intidparam  order by RequestID";
                    //    cmd.Parameters.AddWithValue("@intidparam", Environment.UserName.ToString());
                    //}
                    //cmd.CommandText = "select * from dbo.vw_oneonone_cip_dotnet  order by RequestID ";
                    cmd.CommandText = "dbo.usp_oneonone_emp_cip_dotnet";
                    cmd.Parameters.AddWithValue("@intid", Environment.UserName.ToString());
                }
                else
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.usp_oneonone_emp_cip_searchbymonth_dotnet";
                    cmd.Parameters.AddWithValue("@intid", Environment.UserName.ToString());
                    cmd.Parameters.AddWithValue("@month",searchby_month.Value.Date);
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
                    summary.Text = row.Cells["txtSummary"].Value.ToString();
                }
            }
            else
            {
                requestid.Focus();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(requestid.Text))
            {
                MessageBox.Show("Please select RequestID");
            }
            else if (iacknowledge.Checked == false)
            {
                MessageBox.Show("Please tickbox I Acknowledge");
            }
            else
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
                    cmd.CommandText = "update dbo.tbl_oneonone_cip_dotnet set IsAcknowledged = 1 where requestid=@requestidparam";
                    cmd.Parameters.AddWithValue("@requestidparam", requestid.Text);

                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records Updated Successfully");
                    cmd.Parameters.Clear();
                    reset_overall();
                    conn.Close();
                }
                catch (Exception ab)
                {
                    MessageBox.Show("Error Generated Details :" + ab.ToString());
                }
            }
            
        }

        private void iacknowledge_CheckedChanged(object sender, EventArgs e)
        {
            if (iacknowledge.Checked == true)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
        }

        private void searchby_month_ValueChanged(object sender, EventArgs e)
        {
            searchby_month.CustomFormat = "dd-MMMM-yyyy";
            datagridview_display();
        }

        private void searchby_month_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                searchby_month.CustomFormat = " ";
            }
            datagridview_display();
        }
    }
}
