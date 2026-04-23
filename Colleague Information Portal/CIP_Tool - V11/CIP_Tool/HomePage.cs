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
    public partial class HomePage : Form
    {
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public HomePage()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            reset_overall();
            accesslevel_list();
            access_levels();

        }

        public void access_levels()
        {
            //if (accesslevel.Text != "Admin")
            //{
            //    managementportal.Enabled = false;
            //}
            //else
            //{
            //    managementportal.Enabled = true;
            //}
            
            if (accesslevel.Text == "ReadWrite")
            {
                management_escalations.Enabled = true;
                management_feedbackform.Enabled = false;
                management_skillmatrix.Enabled = false;
                management_oneonone.Enabled = false;
                management_trainingdetails.Enabled = true;
                management_roster.Enabled = false;
                managementportal.Enabled = true;
            }
            else if (accesslevel.Text == "Admin")
            {
                management_escalations.Enabled = true;
                management_feedbackform.Enabled = true;
                management_skillmatrix.Enabled = true;
                management_oneonone.Enabled = true;
                management_trainingdetails.Enabled = true;
                management_roster.Enabled = true;
                managementportal.Enabled = true;
            }
            else
            {
                management_escalations.Enabled = false;
                management_feedbackform.Enabled = false;
                management_skillmatrix.Enabled = false;
                management_oneonone.Enabled = false;
                management_trainingdetails.Enabled = false;
                management_roster.Enabled = false;
                managementportal.Enabled = false;
            }
        }

        public void reset_overall()
        {
            hide();
            accesslevel.Visible = false;
        }

        public void hide()
        {
            //management_feedbackform.Visible = false;
            //management_oneonone.Visible = false;
            //management_skillmatrix.Visible = false;
            //management_trainingdetails.Visible = false;
            //management_escalations.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            //general_teamdetails.Visible = false;
            //general_oneonone.Visible = false;
        }

        public void accesslevel_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                Emp_Details obj_empdetails = new Emp_Details();
                DataTable dtaa = new DataTable();
                obj_empdetails.check_accesslevel(dtaa);
                accesslevel.DataSource = dtaa;
                accesslevel.DisplayMember = "CIPTool_Access";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        private void managementportal_Click(object sender, EventArgs e)
        {
            //management_feedbackform.Visible = true;
            //management_oneonone.Visible = true;
            //management_skillmatrix.Visible = true;
            //management_trainingdetails.Visible = true;
            //management_escalations.Visible = true;
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            //general_teamdetails.Visible = false;
            //general_oneonone.Visible = false;
        }

        private void management_trainingdetails_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TrainingCalendar obj_form1 = new TrainingCalendar();
            obj_form1.Show();
        }

        private void managementportal_Leave(object sender, EventArgs e)
        {
            //hide();
        }

        private void Form3_MouseHover(object sender, EventArgs e)
        {
            hide();
        }

        private void generalinformation_Click(object sender, EventArgs e)
        {
            //management_feedbackform.Visible = false;
            //management_oneonone.Visible = false;
            //management_skillmatrix.Visible = false;
            //management_trainingdetails.Visible = false;
            //management_escalations.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            //general_teamdetails.Visible = true;
            //general_oneonone.Visible = true;
        }

        private void general_teamdetails_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TeamDetails obj_form4 = new TeamDetails();
            obj_form4.Show();
        }

        private void management_feedbackform_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FeedbackForm obj_form5 = new FeedbackForm();
            obj_form5.Show();
        }

        private void management_oneonone_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OneOnOne obj_form6 = new OneOnOne();
            obj_form6.Show();
        }

        private void general_oneonone_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OneOnOneEmp obj_form7 = new OneOnOneEmp();
            obj_form7.Show();
        }

        private void management_escalations_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Escalations obj_form8 = new Escalations();
            obj_form8.Show();
        }

        private void general_ot_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OT obj_ot = new OT();
            obj_ot.Show();
        }

        private void general_kpiscorecard_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            KPIScorecard obj_kpiscorecard = new KPIScorecard();
            obj_kpiscorecard.Show();
        }


        private void general_pkt_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://wtwonlineap.sharepoint.com/sites/tctnonclient_edskycoms/Documents/Forms/All%20Documents.aspx?id=%2Fsites%2Ftctnonclient%5Fedskycoms%2FDocuments%2FWorkflow%2FEDS%20%2D%20Dot%20Net%20Workflows%2FPKT&viewid=9f41f8f4%2Dcfdf%2D4ddb%2Db6fa%2Dc825bd64240c");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }

        private void general_errortracker_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ErrorTracker obj_error = new ErrorTracker();
            obj_error.Show();
        }

        private void management_roster_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Roster obj_roster = new Roster();
            obj_roster.Show();
        }

        private void general_roster_Click(object sender, EventArgs e)
        {
            //this.hide();
            //Roster obj_roster = new Roster();
            //obj_roster.Show();
            try
            {
                System.Diagnostics.Process.Start("http://A20-CB-DBSE01P/Reports/report/DRD%20MI%20Mumbai/DRD%20Reports/rpt_SSRS_RosterView_DotNet");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }

        private void general_trainingdetails_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://A20-CB-DBSE01P/Reports/report/DRD%20MI%20Mumbai/DRD%20Reports/rpt_SSRS_CIPTool_TrainingDetails_dotnet");
            }
            catch (Exception ab)
            {
                MessageBox.Show("Unable to open link that was clicked. Following are the error generated details" + ab.ToString());
            }
        }

        private void management_skillmatrix_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DownTime_Tracker obj_form1 = new DownTime_Tracker();
            obj_form1.Show();
        }
    }
}
