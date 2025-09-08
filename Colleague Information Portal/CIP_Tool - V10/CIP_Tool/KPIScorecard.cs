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

namespace CIP_Tool
{
    public partial class KPIScorecard : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        
        public KPIScorecard()
        {
            InitializeComponent();
        }

        private void KPIScorecard_Load(object sender, EventArgs e)
        {
            rest_overall();
        }

        public void rest_overall()
        {
            //scorecard_data_associates();
            associate_list();
            reportingmanger_list();
            notmet.ReadOnly = true;
            partiallymet.ReadOnly = true;
            met.ReadOnly = true;
            exceeds.ReadOnly = true;
            farexceeds.ReadOnly = true;
            //year_list();
            //year.SelectedIndex = -1;
            year.CustomFormat = "yyyy";
            year.ShowUpDown = true;
            year.Value = DateTime.Now;
            accesslevel_list();
        }

        public void scorecard_data_associates()
        {
            try
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
                cmd.CommandText = "exec usp_monthlyscorecard_dotnet @intidparam,@associatenameparam,@yearparam";
                cmd.Parameters.AddWithValue("@intidparam", Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@associatenameparam", associatename.Text);
                if (year.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@yearparam", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@yearparam", year.Text);
                }
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error generated details :" + ab.ToString());
            }
        }

        public void associate_list()
        {
            try
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
                cmd.CommandText = "exec usp_associatelist_monthlyscorecard_dotnet @intidparam, @reportingmanagerparam";
                cmd.Parameters.AddWithValue("@intidparam", Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@reportingmanagerparam", reportingmanagername.Text);
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                associatename.DataSource = dt;
                associatename.DisplayMember = "EmpName";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details :" + ab.ToString());
            }
        }

        public void accesslevel_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                accesslevel.Visible = false;
                Emp_Details obj_empdetails = new Emp_Details();
                DataTable dtaa = new DataTable();
                //string intid = Environment.UserName.ToString();
                obj_empdetails.check_accesslevel(dtaa);
                accesslevel.DataSource = dtaa;
                accesslevel.DisplayMember = "AccessLevel";
                conn.Close();
                //accesslevel.SelectedIndex = -1;
                if (accesslevel.Text == "Read")
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        //public void accesslevel_list() --------------old code
        //{
        //    if (conn.State == ConnectionState.Open)
        //    {
        //        conn.Close();
        //    }

        //    try
        //    {
        //        accesslevel.Visible = false;
        //        Emp_Details obj_empdetails = new Emp_Details();
        //        DataTable dtaa = new DataTable();
        //        string intid = Environment.UserName.ToString();
        //        obj_empdetails.check_accesslevel(dtaa, intid);
        //        accesslevel.DataSource = dtaa;
        //        accesslevel.DisplayMember = "AccessLevel";
        //        conn.Close();
        //        //accesslevel.SelectedIndex = -1;
        //        if (accesslevel.Text == "Read")
        //        {
        //            button1.Enabled = false;
        //        }
        //        else
        //        {
        //            button1.Enabled = true;
        //        }
        //    }
        //    catch (Exception ab)
        //    {
        //        MessageBox.Show("Error Generated Details: " + ab.ToString());
        //    }
        //}

        public void reportingmanger_list()
        {
            try
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
                cmd.CommandText = "exec usp_reportingmanagerlist_monthlyscorecard_dotnet @intidparam";
                cmd.Parameters.AddWithValue("@intidparam", Environment.UserName.ToString());
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                reportingmanagername.DataSource = dt;
                reportingmanagername.DisplayMember = "ReportingManager";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error generated details :" + ab.ToString());
            }

        }

        private void associatename_SelectedIndexChanged(object sender, EventArgs e)
        {
            scorecard_data_associates();
        }

        private void reportingmanagername_SelectedIndexChanged(object sender, EventArgs e)
        {
            associate_list();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow myrow in dataGridView1.Rows)
            {


                if ((myrow.Cells[3].Value is int) && ((int)myrow.Cells[3].Value > 89.99))
                {
                    myrow.Cells[3].Style.BackColor = Color.Green;
                }
                else if ((myrow.Cells[3].Value is int) && ((int)myrow.Cells[3].Value == 0))
                {
                    myrow.Cells[3].Style.BackColor = Color.Lavender;
                }
                else if (myrow.Cells[3].Value == null)
                {
                    myrow.Cells[3].Style.BackColor = Color.WhiteSmoke;
                }
                else
                {
                    myrow.Cells[3].Style.BackColor = Color.Orange;
                }

                if ((myrow.Cells[4].Value is int) && ((int)myrow.Cells[4].Value > 99.99))
                {
                    myrow.Cells[4].Style.BackColor = Color.Green;
                }
                else if ((myrow.Cells[4].Value is int) && ((int)myrow.Cells[4].Value == 0))
                {
                    myrow.Cells[4].Style.BackColor = Color.Lavender;
                }
                else if (myrow.Cells[4].Value == null)
                {
                    myrow.Cells[4].Style.BackColor = Color.WhiteSmoke;
                }
                else
                {
                    myrow.Cells[4].Style.BackColor = Color.Orange;
                }

                if ((myrow.Cells[5].Value is int) && ((int)myrow.Cells[5].Value > 84.99))
                {
                    myrow.Cells[5].Style.BackColor = Color.Green;
                }
                else if ((myrow.Cells[5].Value is int) && ((int)myrow.Cells[5].Value == 0))
                {
                    myrow.Cells[5].Style.BackColor = Color.Lavender;
                }
                else if (myrow.Cells[5].Value == null)
                {
                    myrow.Cells[5].Style.BackColor = Color.WhiteSmoke;
                }
                else
                {
                    myrow.Cells[5].Style.BackColor = Color.Orange;
                }

                if ((myrow.Cells[8].Value is int) && ((int)myrow.Cells[8].Value > 97.99))
                {
                    myrow.Cells[8].Style.BackColor = Color.Green;
                }
                else if ((myrow.Cells[8].Value is int) && ((int)myrow.Cells[8].Value == 0))
                {
                    myrow.Cells[8].Style.BackColor = Color.Lavender;
                }
                else if (myrow.Cells[8].Value == null)
                {
                    myrow.Cells[8].Style.BackColor = Color.WhiteSmoke;
                }
                else
                {
                    myrow.Cells[8].Style.BackColor = Color.Orange;
                }

                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void year_ValueChanged(object sender, EventArgs e)
        {
            year.CustomFormat = "yyyy";
            scorecard_data_associates();
        }

        private void year_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                year.CustomFormat = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkflowAndEscalationErrors obj_workflow = new WorkflowAndEscalationErrors();
            obj_workflow.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomePage obj_homepage = new HomePage();
            obj_homepage.Show();
        }



    }
}
