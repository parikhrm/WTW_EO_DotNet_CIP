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
        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset_overall();
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
                cmd.Parameters.AddWithValue("@Application",application.Text);
                cmd.Parameters.AddWithValue("@Date",date.Value.Date);
                cmd.Parameters.AddWithValue("@StartTime",starttime.Value.ToLongTimeString());
                cmd.Parameters.AddWithValue("@Endtime",endtime.Value.ToLongTimeString());
                cmd.Parameters.AddWithValue("@Impacted_Users",impacted_users.Text);
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
    }
}
