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
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;
using System.IO;

namespace CIP_Tool
{
    public partial class OneDrive_Audit_Tracker : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";

        public OneDrive_Audit_Tracker()
        {
            InitializeComponent();
        }

        private void OneDrive_Audit_Tracker_Load(object sender, EventArgs e)
        {
            empname_list();
            quarters_list();
            reset_overall();
        }

        public void reset_overall()
        {
            id.Text = string.Empty;
            id.Enabled = false;
            empname.SelectedIndex = -1;
            audit_quarter.SelectedIndex = -1;
            status.SelectedIndex = -1;
            comments.Text = string.Empty;
            attachment.Text = string.Empty;
            insert.Enabled = true;
            update.Enabled = false;
            datagridview_display_overall();
        }

        public void empname_list()
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
                obj_empname.associate_list(dtaa);
                empname.DataSource = dtaa;
                empname.DisplayMember = "EmpName";
                empname.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void quarters_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                Quarters obj_quarter = new Quarters();
                DataTable dtaa = new DataTable();
                DataSet ds = new DataSet();
                obj_quarter.quarters (dtaa);
                audit_quarter.DataSource = dtaa;
                audit_quarter.DisplayMember = "QuarterYear";
                audit_quarter.SelectedIndex = -1;
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
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
                string filePath = attachment.Text;
                byte[] fileData = File.ReadAllBytes(filePath);
                string fileName = Path.GetFileName(filePath);

                cmd.Parameters.Clear();
                conn.ConnectionString = connectionstringtxt;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.usp_onedrive_audit_tracker_insert_dotnet";
                cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 1000);
                cmd.Parameters["@Message"].Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@EmpName", empname.Text);
                cmd.Parameters.AddWithValue("@Audit_Quarter",audit_quarter.Text);
                cmd.Parameters.AddWithValue("@Status", status.Text);
                cmd.Parameters.AddWithValue("@Comments", comments.Text);
                if (string.IsNullOrEmpty(attachment.Text))
                {
                    cmd.Parameters.AddWithValue("@Attachment", DBNull.Value);
                    cmd.Parameters.AddWithValue("@FileName", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Attachment", fileData);
                    cmd.Parameters.AddWithValue("@FileName", fileName);
                }
                cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());
                
                if (string.IsNullOrEmpty(empname.Text))
                {
                    MessageBox.Show("Please update Emp Name");
                }
                else if (string.IsNullOrEmpty(audit_quarter.Text))
                {
                    MessageBox.Show("Please update Audit Quarter");
                }
                else if (string.IsNullOrEmpty(status.Text))
                {
                    MessageBox.Show("Please update Status");
                }
                else if (string.IsNullOrEmpty(comments.Text))
                {
                    MessageBox.Show("Please update Comments");
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
                cmd.CommandText = "dbo.usp_onedrive_audit_tracker_update_dotnet";
                cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 1000);
                cmd.Parameters["@Message"].Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@ID",id.Text);
                cmd.Parameters.AddWithValue("@EmpName", empname.Text);
                cmd.Parameters.AddWithValue("@Audit_Quarter", audit_quarter.Text);
                cmd.Parameters.AddWithValue("@Status", status.Text);
                cmd.Parameters.AddWithValue("@Comments", comments.Text);
                cmd.Parameters.AddWithValue("@Attachment", attachment.Text);
                cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());

                if (string.IsNullOrEmpty(empname.Text))
                {
                    MessageBox.Show("Please update Emp Name");
                }
                else if (string.IsNullOrEmpty(audit_quarter.Text))
                {
                    MessageBox.Show("Please update Audit Quarter");
                }
                else if (string.IsNullOrEmpty(status.Text))
                {
                    MessageBox.Show("Please update Status");
                }
                else if (string.IsNullOrEmpty(comments.Text))
                {
                    MessageBox.Show("Please update Comments");
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
                    id.Text = row.Cells["txt_ID"].Value.ToString();
                    empname.Text = row.Cells["txt_EmpName"].Value.ToString();
                    audit_quarter.Text = row.Cells["txt_Audit_Quarter"].Value.ToString();
                    status.Text = row.Cells["txt_Status"].Value.ToString();
                    comments.Text = row.Cells["txt_Comments"].Value.ToString();
                }
                insert.Enabled = false;
                update.Enabled = true;
            }
            else
            {
                insert.Enabled = true;
                update.Enabled = false;
            }
        }

        public void datagridview_display_overall()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            conn.ConnectionString = connectionstringtxt;
            cmd.Connection = conn;
            conn.Open();
            cmd.Parameters.Clear();
            if (string.IsNullOrEmpty(searchby_empname.Text))
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ID, EmpName, [Reporting Manager], Audit_Quarter, Status, Comments, Attachment, LastUpdatedBy, LastUpdatedDateTime  from dbo.vw_onedrive_audit_tracker_dotnet order by ID desc";
            }
            else
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_onedrive_audit_tracker_datagridview_search_dotnet";
                cmd.Parameters.AddWithValue("@EmpName", searchby_empname.Text);
            }
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void searchby_empname_TextChanged(object sender, EventArgs e)
        {
            datagridview_display_overall();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomePage obj_homepage = new HomePage();
            obj_homepage.Show();
        }

        private void raw_data_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://app.powerbi.com/groups/81c3ab7d-0a2a-46f2-b54f-38eb239011a1/rdlreports/01bb7a88-cc31-4573-b223-4081a6b8b1f9?experience=power-bi");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }

        private void select_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.attachment.Text = openFileDialog1.FileName;
            }
        }
    }
}
