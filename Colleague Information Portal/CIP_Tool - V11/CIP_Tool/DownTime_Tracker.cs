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
    public partial class DownTime_Tracker : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";

        public DownTime_Tracker()
        {
            InitializeComponent();
        }

        private void DownTime_Tracker_Load(object sender, EventArgs e)
        {
            reset_overall();
        }

        public void reset_overall()
        {
            id.Text = string.Empty;
            id.Enabled = false;
            application.SelectedIndex = -1;
            date.CustomFormat = " ";
            starttime.CustomFormat = " ";
            endtime.CustomFormat = " ";
            impacted_users.Text = string.Empty;
            comments.Text = string.Empty;
            insert.Enabled = true;
            update.Enabled = false;
            datagridview_display_overall();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset_overall();
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
            if (string.IsNullOrEmpty(searchby_id.Text))
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.vw_downtime_tracker_dotnet order by ID desc";
            }
            else
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.vw_downtime_tracker_dotnet where ID = @ID order by ID desc";
                cmd.Parameters.AddWithValue("@ID", searchby_id.Text);
            }
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
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
                cmd.CommandText = "dbo.usp_downtime_tracker_insert_dotnet";
                cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 1000);
                cmd.Parameters["@Message"].Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@Application", application.Text);
                cmd.Parameters.AddWithValue("@Date", date.Value.Date);
                cmd.Parameters.AddWithValue("@StartTime", starttime.Value.ToLongTimeString());
                cmd.Parameters.AddWithValue("@Endtime", endtime.Value.ToLongTimeString());
                cmd.Parameters.AddWithValue("@Impacted_Users", impacted_users.Text);
                if (string.IsNullOrEmpty(comments.Text))
                {
                    cmd.Parameters.AddWithValue("@Comments", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Comments", comments.Text);
                }
                cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());

                if (string.IsNullOrEmpty(application.Text))
                {
                    MessageBox.Show("Please update Application Name");
                }
                else if (date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Date");
                }
                else if (starttime.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Start Time");
                }
                else if (endtime.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update End Time");
                }
                else if (string.IsNullOrEmpty(impacted_users.Text))
                {
                    MessageBox.Show("Please update Impacted Users");
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

        private void starttime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                starttime.CustomFormat = " ";
            }
        }

        private void starttime_MouseDown(object sender, MouseEventArgs e)
        {
            starttime.Text = DateTime.Now.ToLongTimeString();
            starttime.CustomFormat = "HH:mm:ss";
        }

        private void endtime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                endtime.CustomFormat = " ";
            }
        }

        private void endtime_MouseDown(object sender, MouseEventArgs e)
        {
            endtime.Text = DateTime.Now.ToLongTimeString();
            endtime.CustomFormat = "HH:mm:ss";
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
                cmd.CommandText = "dbo.usp_downtime_tracker_update_dotnet";
                cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 1000);
                cmd.Parameters["@Message"].Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@ID", id.Text);
                cmd.Parameters.AddWithValue("@Application", application.Text);
                cmd.Parameters.AddWithValue("@Date", date.Value.Date);
                cmd.Parameters.AddWithValue("@StartTime", starttime.Value.ToLongTimeString());
                cmd.Parameters.AddWithValue("@Endtime", endtime.Value.ToLongTimeString());
                cmd.Parameters.AddWithValue("@Impacted_Users", impacted_users.Text);

                if (string.IsNullOrEmpty(comments.Text))
                {
                    cmd.Parameters.AddWithValue("@Comments", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Comments", comments.Text);
                }
                cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());

                if (string.IsNullOrEmpty(application.Text))
                {
                    MessageBox.Show("Please update Application Name");
                }
                else if (date.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Date");
                }
                else if (starttime.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update Start Time");
                }
                else if (endtime.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please update End Time");
                }
                else if (string.IsNullOrEmpty(impacted_users.Text))
                {
                    MessageBox.Show("Please update Impacted Users");
                }
                else if (string.IsNullOrEmpty(id.Text))
                {
                    MessageBox.Show("Please update ID number");
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
                    application.Text = row.Cells["txt_Application"].Value.ToString();
                    date.Text = row.Cells["txt_Date"].Value.ToString();
                    date.CustomFormat = "dd-MMMM-yyyy";
                    starttime.Text = row.Cells["txt_StartTime"].Value.ToString();
                    starttime.CustomFormat = "HH:mm:ss";
                    endtime.Text = row.Cells["txt_EndTime"].Value.ToString();
                    endtime.CustomFormat = "HH:mm:ss";
                    impacted_users.Text = row.Cells["txt_Impacted_Users"].Value.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomePage obj_form3 = new HomePage();
            obj_form3.Show();
        }

        private void raw_data_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://app.powerbi.com/groups/81c3ab7d-0a2a-46f2-b54f-38eb239011a1/rdlreports/0d5774ba-fea8-4a58-bf0a-b71bd8252a8f?experience=power-bi");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }

        private void searchby_id_TextChanged(object sender, EventArgs e)
        {
            datagridview_display_overall();
        }
    }
}
