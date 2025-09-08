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
    public partial class TeamDetails : Form
    {
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public TeamDetails()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            reportingmanager_list();
            designation_list();
            process_list();
            reset_overall();
            accesslevel_list();
        }

        public void reset_overall()
        {
            empid.Text = string.Empty;
            empname.Text = string.Empty;
            workemailaddress.Text = string.Empty;
            loginid.Text = string.Empty;
            reportingmanager.SelectedIndex = -1;
            process.SelectedIndex = -1;
            sub_process.Text = string.Empty;
            gender.SelectedIndex = -1;
            dateofjoining.CustomFormat = " ";
            designation.SelectedIndex = -1;
            address.Text = string.Empty;
            relationshipwithalternatecontactnumber.SelectedIndex = -1;
            dateofbirth.CustomFormat = " ";
            desknumber.Text = string.Empty;
            extension.Text = string.Empty;
            pcathome.SelectedIndex = -1;
            internetconnection.SelectedIndex = -1;
            secureid.SelectedIndex = -1;
            secureidserialnumber.Text = string.Empty;
            secureidexpirydate.CustomFormat = " ";
            personalemailid.Text = string.Empty;
            busroute.Text = string.Empty;
            busstopname.Text = string.Empty;
            passportstatus.SelectedIndex = -1;
            headsetstaus.SelectedIndex = -1;
            secureidtype.SelectedIndex = -1;
            webcam.SelectedIndex = -1;
            wfhaccess.SelectedIndex = -1;
            wfhtestdate.CustomFormat = " ";
            internetspeed.Text = string.Empty;
            educationalqualification1.Text = string.Empty;
            educationalqualification2.Text = string.Empty;
            professionalcertificate.SelectedIndex = -1;
            certificatename.Text = string.Empty;
            contactnumber.Text = string.Empty;
            alternatecontactnumber.Text = string.Empty;
            datagridview_display();
            insert.Enabled = true;
            update.Enabled = false;
            resigned.Enabled = false;
            empid.Enabled = true;
            loginid.Enabled = true;
            accesslevel.SelectedIndex = -1;
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
                accesslevel.DisplayMember = "CIPTool_Access";
                conn.Close();
                //accesslevel.SelectedIndex = -1;
                if (accesslevel.Text != "Admin")
                {
                    insert.Enabled = false;
                    update.Enabled = false;
                    resigned.Enabled = false;
                }
                else
                {
                    insert.Enabled = true;
                    update.Enabled = true;
                    resigned.Enabled = true;
                }
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void reportingmanager_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                Emp_Details obj_empdetails = new Emp_Details();
                DataTable dtaa = new DataTable();
                obj_empdetails.reportingmanager_list(dtaa);
                reportingmanager.DataSource = dtaa;
                reportingmanager.DisplayMember = "Reporting Manager";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        public void designation_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                Emp_Details obj_empdetails = new Emp_Details();
                DataTable dtaa = new DataTable();
                obj_empdetails.designation_list (dtaa);
                designation.DataSource = dtaa;
                designation.DisplayMember = "Designation";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        public void process_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                Emp_Details obj_empdetails = new Emp_Details();
                DataTable dtaa = new DataTable();
                obj_empdetails.process_list(dtaa);
                process.DataSource = dtaa;
                process.DisplayMember = "Process";
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }

        private void dateofjoining_ValueChanged(object sender, EventArgs e)
        {
            dateofjoining.CustomFormat = "dd-MMMM-yyyy";
        }

        private void dateofjoining_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                dateofjoining.CustomFormat = " ";
            }
        }

        private void dateofbirth_ValueChanged(object sender, EventArgs e)
        {
            dateofbirth.CustomFormat = "dd-MMMM-yyyy";
        }

        private void dateofbirth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                dateofbirth.CustomFormat = " ";
            }
        }

        private void secureidexpirydate_ValueChanged(object sender, EventArgs e)
        {
            secureidexpirydate.CustomFormat = "dd-MMMM-yyyy";
        }

        private void secureidexpirydate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                secureidexpirydate.CustomFormat = " ";
            }
        }

        private void wfhtestdate_ValueChanged(object sender, EventArgs e)
        {
            wfhtestdate.CustomFormat = "dd-MMMM-yyyy";
        }

        private void wfhtestdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                wfhtestdate.CustomFormat = " ";
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
                cmd.CommandText = "dbo.usp_empdetails_insert_cip_dotnet";
                cmd.Parameters.AddWithValue("@EmpID",empid.Text);
                cmd.Parameters.AddWithValue("@EmpName",empname.Text);
                cmd.Parameters.AddWithValue("@WorkEmailAddress",workemailaddress.Text);
                cmd.Parameters.AddWithValue("@LoginID",loginid.Text);
                cmd.Parameters.AddWithValue("@ReportingManager",reportingmanager.Text);
                cmd.Parameters.AddWithValue("@Process",process.Text);
                if (string.IsNullOrEmpty(sub_process.Text))
                {
                    cmd.Parameters.AddWithValue("@Sub_Process", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Sub_Process", sub_process.Text);
                }
                cmd.Parameters.AddWithValue("@Gender",gender.Text);
                if (dateofjoining.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@DateOfJoining", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DateOfJoining", dateofjoining.Value.Date);
                }
                if (string.IsNullOrEmpty(designation.Text))
                {
                    cmd.Parameters.AddWithValue("@Designation", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Designation", designation.Text);
                }
                if (string.IsNullOrEmpty(address.Text))
                {
                    cmd.Parameters.AddWithValue("@Address", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Address", address.Text);
                }
                if (string.IsNullOrEmpty(relationshipwithalternatecontactnumber.Text))
                {
                    cmd.Parameters.AddWithValue("@Relationshipwithalternatecontactnumber",DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Relationshipwithalternatecontactnumber", relationshipwithalternatecontactnumber.Text);
                }
                if (dateofbirth.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@DateOfBirth",DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateofbirth.Value.Date);
                }
                if (string.IsNullOrEmpty(desknumber.Text))
                {
                    cmd.Parameters.AddWithValue("@DeskNumber", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DeskNumber", desknumber.Text);
                }
                if (string.IsNullOrEmpty(extension.Text))
                {
                    cmd.Parameters.AddWithValue("@Extension", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Extension", extension.Text);
                }
                if (string.IsNullOrEmpty(pcathome.Text))
                {
                    cmd.Parameters.AddWithValue("@PCateHome", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PCateHome", pcathome.Text);
                }
                if (string.IsNullOrEmpty(internetconnection.Text))
                {
                    cmd.Parameters.AddWithValue("@InternetConnection", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@InternetConnection", internetconnection.Text);
                }
                if (string.IsNullOrEmpty(secureid.Text))
                {
                    cmd.Parameters.AddWithValue("@SecureID", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SecureID", secureid.Text);
                }
                if (string.IsNullOrEmpty(secureidserialnumber.Text))
                {
                    cmd.Parameters.AddWithValue("@SecureIDSerialNumber",DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SecureIDSerialNumber", secureidserialnumber.Text);
                }
                if (secureidexpirydate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@SecureIDExpiryDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SecureIDExpiryDate", secureidexpirydate.Value.Date);
                }
                if (string.IsNullOrEmpty(personalemailid.Text))
                {
                    cmd.Parameters.AddWithValue("@PersonalEmailID", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PersonalEmailID", personalemailid.Text);
                }
                if (string.IsNullOrEmpty(busroute.Text))
                {
                    cmd.Parameters.AddWithValue("@BusRoute",DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@BusRoute", busroute.Text);
                }
                if (string.IsNullOrEmpty(busstopname.Text))
                {
                    cmd.Parameters.AddWithValue("@BusStopName", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@BusStopName", busstopname.Text);
                }
                if (string.IsNullOrEmpty(passportstatus.Text))
                {
                    cmd.Parameters.AddWithValue("@PassportStatus",DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PassportStatus", passportstatus.Text);
                }
                if (string.IsNullOrEmpty(headsetstaus.Text))
                {
                    cmd.Parameters.AddWithValue("@HeadSetStatus", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@HeadSetStatus", headsetstaus.Text);
                }
                if (string.IsNullOrEmpty(secureidtype.Text))
                {
                    cmd.Parameters.AddWithValue("@SecureIDType", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SecureIDType", secureidtype.Text);
                }
                if (string.IsNullOrEmpty(webcam.Text))
                {
                    cmd.Parameters.AddWithValue("@WebCam",DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@WebCam", webcam.Text);
                }
                if (string.IsNullOrEmpty(wfhaccess.Text))
                {
                    cmd.Parameters.AddWithValue("@WFHAccess", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@WFHAccess", wfhaccess.Text);
                }
                if (wfhtestdate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@WFHTestDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@WFHTestDate", wfhtestdate.Value.Date);
                }
                if (string.IsNullOrEmpty(internetspeed.Text))
                {
                    cmd.Parameters.AddWithValue("@InternetSpeed", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@InternetSpeed", internetspeed.Text);
                }
                if (string.IsNullOrEmpty(educationalqualification1.Text))
                {
                    cmd.Parameters.AddWithValue("@EducationalQualification1", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@EducationalQualification1", educationalqualification1.Text);
                }
                if (string.IsNullOrEmpty(educationalqualification2.Text))
                {
                    cmd.Parameters.AddWithValue("@EducationalQualification2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@EducationalQualification2", educationalqualification2.Text);
                }
                if (string.IsNullOrEmpty(professionalcertificate.Text))
                {
                    cmd.Parameters.AddWithValue("@ProfessionalCertificate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ProfessionalCertificate", professionalcertificate.Text);
                }
                if (string.IsNullOrEmpty(certificatename.Text))
                {
                    cmd.Parameters.AddWithValue("@CertificateName",DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CertificateName", certificatename.Text);
                }
                if (string.IsNullOrEmpty(contactnumber.Text))
                {
                    cmd.Parameters.AddWithValue("@ContactNumber", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ContactNumber", contactnumber.Text);
                }
                if (string.IsNullOrEmpty(alternatecontactnumber.Text))
                {
                    cmd.Parameters.AddWithValue("@AlternateContactNumber", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@AlternateContactNumber", alternatecontactnumber.Text);
                }
                cmd.Parameters.AddWithValue("@LastUpdateBy",Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@MachineName",Environment.MachineName.ToString());
                cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 2000);
                cmd.Parameters["@Message"].Direction = ParameterDirection.Output;

                //if conditions
                if (string.IsNullOrEmpty(empid.Text))
                {
                    MessageBox.Show("Please update EmpID");
                }
                else if (string.IsNullOrEmpty(empname.Text))
                {
                    MessageBox.Show("Please update EmpName");
                }
                else if (string.IsNullOrEmpty(workemailaddress.Text))
                {
                    MessageBox.Show("Please update Work Email Address");
                }
                else if (string.IsNullOrEmpty(loginid.Text))
                {
                    MessageBox.Show("Please update Login ID");
                }
                else if (string.IsNullOrEmpty(reportingmanager.Text))
                {
                    MessageBox.Show("Please update Reporting Manager");
                }
                else if (string.IsNullOrEmpty(process.Text))
                {
                    MessageBox.Show("Please update Process");
                }
                else if (string.IsNullOrEmpty(gender.Text))
                {
                    MessageBox.Show("Please update Gender");
                }
                //else if (dateofjoining.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please update Date Of Joining");
                //}
                //else if (string.IsNullOrEmpty(designation.Text))
                //{
                //    MessageBox.Show("Please update Designation");
                //}
                else
                {

                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    string message = cmd.Parameters["@Message"].Value.ToString();
                    if (!string.IsNullOrEmpty(message))
                    {
                        MessageBox.Show("" + message.ToString());

                    }
                    else
                    {
                        MessageBox.Show("Records Inserted Successfully");
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
                if (!string.IsNullOrEmpty(searchby_empname.Text))
                {
                    cmd.CommandText = "select [EmpId - New] as Empid,EmpName,EmailAddress,substring(INTID,5,len(INTID)) as INTID,[Reporting Manager],Process,Sub_Process,Gender,DOJ,Designation,Address,RelationshipWithAlternateContactNumber,DOB,DeskNumber,Extension,PCatHome,InternetConnection,SecureID,SecureIDSerialNo,SecureIDExpiryDate,PersonalEmailID,BusRoute,BusStopName,PassportStatus,Headsetsatus,SecureIDType,webcam,[WFH Access],[WFH Test Date],[Internet Speed],[Education Qualification1],[Education Qualification2],[Professional Certificate],[Certificate Name],contactnumber,alternatecontactnumber from dbo.tbl_emp_details with(nolock) where IsDeleted = 0 and empname like @empnameparam order by empname asc";
                    cmd.Parameters.AddWithValue("@empnameparam","%"+ searchby_empname.Text + "%");
                }
                else
                {
                    cmd.CommandText = "select [EmpId - New] as Empid,EmpName,EmailAddress,substring(INTID,5,len(INTID)) as INTID,[Reporting Manager],Process,Sub_Process,Gender,DOJ,Designation,Address,RelationshipWithAlternateContactNumber,DOB,DeskNumber,Extension,PCatHome,InternetConnection,SecureID,SecureIDSerialNo,SecureIDExpiryDate,PersonalEmailID,BusRoute,BusStopName,PassportStatus,Headsetsatus,SecureIDType,webcam,[WFH Access],[WFH Test Date],[Internet Speed],[Education Qualification1],[Education Qualification2],[Professional Certificate],[Certificate Name],contactnumber,alternatecontactnumber from dbo.tbl_emp_details with(nolock) where IsDeleted = 0 order by empname asc";
                }
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                dataGridView1.ClearSelection();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }


        }

        private void searchby_empname_TextChanged(object sender, EventArgs e)
        {
            datagridview_display();
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
                    resigned.Enabled = true;
                    empid.Enabled = false;
                    loginid.Enabled = false;
                    empid.Text = row.Cells["txtEmpid"].Value.ToString();
                    empname.Text = row.Cells["txtEmpName"].Value.ToString();
                    workemailaddress.Text = row.Cells["txtEmailAddress"].Value.ToString();
                    loginid.Text = row.Cells["txtINTID"].Value.ToString();
                    reportingmanager.Text = row.Cells["txtReportingManager"].Value.ToString();
                    process.Text = row.Cells["txtProcess"].Value.ToString();
                    if (string.IsNullOrEmpty(row.Cells["txtSub_Process"].Value.ToString()))
                    {
                        sub_process.Text = string.Empty;
                    }
                    else
                    {
                        sub_process.Text = row.Cells["txtSub_Process"].Value.ToString();
                    }
                    gender.Text = row.Cells["txtGender"].Value.ToString();
                    if (string.IsNullOrEmpty(row.Cells["txtDOJ"].Value.ToString()))
                    {
                        dateofjoining.CustomFormat = " ";
                    }
                    else
                    {
                        dateofjoining.Text = row.Cells["txtDOJ"].Value.ToString();
                        dateofjoining.CustomFormat = "dd-MMMM-yyyy";
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtDesignation"].Value.ToString()))
                    {
                        designation.SelectedIndex = -1;
                    }
                    else
                    {
                        designation.Text = row.Cells["txtDesignation"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtAddress"].Value.ToString()))
                    {
                        address.Text = string.Empty;
                    }
                    else
                    {
                        address.Text = row.Cells["txtAddress"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtRelationshipWithAlternateContactNumber"].Value.ToString()))
                    {
                        relationshipwithalternatecontactnumber.Text = string.Empty;
                    }
                    else
                    {
                        relationshipwithalternatecontactnumber.Text = row.Cells["txtRelationshipWithAlternateContactNumber"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtDOB"].Value.ToString()))
                    {
                        dateofbirth.CustomFormat = " ";
                        
                    }
                    else
                    {
                        dateofbirth.Text = row.Cells["txtDOB"].Value.ToString();
                        dateofbirth.CustomFormat = "dd-MMMM-yyyy";
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtDeskNumber"].Value.ToString()))
                    {
                        desknumber.Text = string.Empty;
                    }
                    else
                    {
                        desknumber.Text = row.Cells["txtDeskNumber"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtExtension"].Value.ToString()))
                    {
                        extension.Text = string.Empty;
                    }
                    else
                    {
                        extension.Text = row.Cells["txtExtension"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtPCatHome"].Value.ToString()))
                    {
                        pcathome.SelectedIndex = -1;
                    }
                    else
                    {
                        pcathome.Text = row.Cells["txtPCatHome"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtInternetConnection"].Value.ToString()))
                    {
                        internetconnection.SelectedIndex = -1;
                    }
                    else
                    {
                        internetconnection.Text = row.Cells["txtInternetConnection"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtSecureID"].Value.ToString()))
                    {
                        secureid.Text = string.Empty;
                    }
                    else
                    {
                        secureid.Text = row.Cells["txtSecureID"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtSecureIDSerialNo"].Value.ToString()))
                    {
                        secureidserialnumber.Text = string.Empty;
                    }
                    else
                    {
                        secureidserialnumber.Text = row.Cells["txtSecureIDSerialNo"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtSecureIDExpiryDate"].Value.ToString()))
                    {
                        secureidexpirydate.CustomFormat = " ";
                    }
                    else
                    {
                        secureidexpirydate.Text = row.Cells["txtSecureIDExpiryDate"].Value.ToString();
                        secureidexpirydate.CustomFormat = "dd-MMMM-yyyy";
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtPersonalEmailID"].Value.ToString()))
                    {
                        personalemailid.Text = string.Empty;
                    }
                    else
                    {
                        personalemailid.Text = row.Cells["txtPersonalEmailID"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtBusRoute"].Value.ToString()))
                    {
                        busroute.Text = string.Empty;
                    }
                    else
                    {
                        busroute.Text = row.Cells["txtBusRoute"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtBusStopName"].Value.ToString()))
                    {
                        busstopname.Text = string.Empty;
                    }
                    else
                    {
                        busstopname.Text = row.Cells["txtBusStopName"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtPassportStatus"].Value.ToString()))
                    {
                        passportstatus.SelectedIndex = -1;
                    }
                    else
                    {
                        passportstatus.Text = row.Cells["txtPassportStatus"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtHeadsetsatus"].Value.ToString()))
                    {
                        headsetstaus.SelectedIndex = -1;
                    }
                    else
                    {
                        headsetstaus.Text = row.Cells["txtHeadsetsatus"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtSecureIDType"].Value.ToString()))
                    {
                        secureidtype.SelectedIndex = -1;
                    }
                    else
                    {
                        secureidtype.Text = row.Cells["txtSecureIDType"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtwebcam"].Value.ToString()))
                    {
                        webcam.SelectedIndex = -1;
                    }
                    else
                    {
                        webcam.Text = row.Cells["txtwebcam"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtWFHAccess"].Value.ToString()))
                    {
                        wfhaccess.SelectedIndex = -1;
                    }
                    else
                    {
                        wfhaccess.Text = row.Cells["txtWFHAccess"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtWFHTestDate"].Value.ToString()))
                    {
                        wfhtestdate.CustomFormat = " ";
                    }
                    else
                    {
                        wfhtestdate.Text = row.Cells["txtWFHTestDate"].Value.ToString();
                        wfhtestdate.CustomFormat = "dd-MMMM-yyyy";
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtInternetSpeed"].Value.ToString()))
                    {
                        internetspeed.Text = string.Empty;
                    }
                    else
                    {
                        internetspeed.Text = row.Cells["txtInternetSpeed"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtEducationQualification1"].Value.ToString()))
                    {
                        educationalqualification1.Text = string.Empty;
                    }
                    else
                    {
                        educationalqualification1.Text = row.Cells["txtEducationQualification1"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtEducationQualification2"].Value.ToString()))
                    {
                        educationalqualification2.Text = string.Empty;
                    }
                    else
                    {
                        educationalqualification2.Text = row.Cells["txtEducationQualification2"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtProfessionalCertificate"].Value.ToString()))
                    {
                        professionalcertificate.Text = string.Empty;
                    }
                    else
                    {
                        professionalcertificate.Text = row.Cells["txtProfessionalCertificate"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtCertificateName"].Value.ToString()))
                    {
                        certificatename.Text = string.Empty;
                    }
                    else
                    {
                        certificatename.Text = row.Cells["txtCertificateName"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtcontactnumber"].Value.ToString()))
                    {
                        contactnumber.Text = string.Empty;
                    }
                    else
                    {
                        contactnumber.Text = row.Cells["txtcontactnumber"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(row.Cells["txtalternatecontactnumber"].Value.ToString()))
                    {
                        alternatecontactnumber.Text = string.Empty;
                    }
                    else
                    {
                        alternatecontactnumber.Text = row.Cells["txtalternatecontactnumber"].Value.ToString();
                    }
                }
            }
            else
            {
                empid.Focus();
                insert.Enabled = true;
                update.Enabled = false;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset_overall();
        }

        private void resigned_Click(object sender, EventArgs e)
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
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "update dbo.tbl_emp_details set isdeleted = 1 where [EmpId - New] = @empidparam";
                //cmd.Parameters.AddWithValue("@empidparam",empid.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.usp_empdetails_resigned_cip_dotnet";
                cmd.Parameters.AddWithValue("@empidparam", empid.Text);
                cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 2000);
                cmd.Parameters["@Message"].Direction = ParameterDirection.Output;

                conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                string uploadmessage = cmd.Parameters["@Message"].Value.ToString();
                MessageBox.Show("" + uploadmessage.ToString());
                cmd.Parameters.Clear();
                reset_overall();
                conn.Close();
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
                cmd.CommandText = "usp_empdetails_update_cip_dotnet";
                cmd.Parameters.AddWithValue("@EmpID", empid.Text);
                cmd.Parameters.AddWithValue("@EmpName", empname.Text);
                cmd.Parameters.AddWithValue("@WorkEmailAddress", workemailaddress.Text);
                //cmd.Parameters.AddWithValue("@LoginID", loginid.Text);
                cmd.Parameters.AddWithValue("@ReportingManager", reportingmanager.Text);
                cmd.Parameters.AddWithValue("@Process", process.Text);
                if (string.IsNullOrEmpty(sub_process.Text))
                {
                    cmd.Parameters.AddWithValue("@Sub_Process", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Sub_Process", sub_process.Text);
                }
                cmd.Parameters.AddWithValue("@Gender", gender.Text);
                if (dateofjoining.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@DateOfJoining", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DateOfJoining", dateofjoining.Value.Date);
                }
                if (string.IsNullOrEmpty(designation.Text))
                {
                    cmd.Parameters.AddWithValue("@Designation", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Designation", designation.Text);
                }
                if (string.IsNullOrEmpty(address.Text))
                {
                    cmd.Parameters.AddWithValue("@Address", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Address", address.Text);
                }
                if (string.IsNullOrEmpty(relationshipwithalternatecontactnumber.Text))
                {
                    cmd.Parameters.AddWithValue("@Relationshipwithalternatecontactnumber", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Relationshipwithalternatecontactnumber", relationshipwithalternatecontactnumber.Text);
                }
                if (dateofbirth.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@DateOfBirth", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateofbirth.Value.Date);
                }
                if (string.IsNullOrEmpty(desknumber.Text))
                {
                    cmd.Parameters.AddWithValue("@DeskNumber", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DeskNumber", desknumber.Text);
                }
                if (string.IsNullOrEmpty(extension.Text))
                {
                    cmd.Parameters.AddWithValue("@Extension", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Extension", extension.Text);
                }
                if (string.IsNullOrEmpty(pcathome.Text))
                {
                    cmd.Parameters.AddWithValue("@PCateHome", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PCateHome", pcathome.Text);
                }
                if (string.IsNullOrEmpty(internetconnection.Text))
                {
                    cmd.Parameters.AddWithValue("@InternetConnection", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@InternetConnection", internetconnection.Text);
                }
                if (string.IsNullOrEmpty(secureid.Text))
                {
                    cmd.Parameters.AddWithValue("@SecureID", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SecureID", secureid.Text);
                }
                if (string.IsNullOrEmpty(secureidserialnumber.Text))
                {
                    cmd.Parameters.AddWithValue("@SecureIDSerialNumber", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SecureIDSerialNumber", secureidserialnumber.Text);
                }
                if (secureidexpirydate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@SecureIDExpiryDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SecureIDExpiryDate", secureidexpirydate.Value.Date);
                }
                if (string.IsNullOrEmpty(personalemailid.Text))
                {
                    cmd.Parameters.AddWithValue("@PersonalEmailID", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PersonalEmailID", personalemailid.Text);
                }
                if (string.IsNullOrEmpty(busroute.Text))
                {
                    cmd.Parameters.AddWithValue("@BusRoute", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@BusRoute", busroute.Text);
                }
                if (string.IsNullOrEmpty(busstopname.Text))
                {
                    cmd.Parameters.AddWithValue("@BusStopName", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@BusStopName", busstopname.Text);
                }
                if (string.IsNullOrEmpty(passportstatus.Text))
                {
                    cmd.Parameters.AddWithValue("@PassportStatus", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PassportStatus", passportstatus.Text);
                }
                if (string.IsNullOrEmpty(headsetstaus.Text))
                {
                    cmd.Parameters.AddWithValue("@HeadSetStatus", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@HeadSetStatus", headsetstaus.Text);
                }
                if (string.IsNullOrEmpty(secureidtype.Text))
                {
                    cmd.Parameters.AddWithValue("@SecureIDType", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SecureIDType", secureidtype.Text);
                }
                if (string.IsNullOrEmpty(webcam.Text))
                {
                    cmd.Parameters.AddWithValue("@WebCam", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@WebCam", webcam.Text);
                }
                if (string.IsNullOrEmpty(wfhaccess.Text))
                {
                    cmd.Parameters.AddWithValue("@WFHAccess", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@WFHAccess", wfhaccess.Text);
                }
                if (wfhtestdate.Text.Trim() == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@WFHTestDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@WFHTestDate", wfhtestdate.Value.Date);
                }
                if (string.IsNullOrEmpty(internetspeed.Text))
                {
                    cmd.Parameters.AddWithValue("@InternetSpeed", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@InternetSpeed", internetspeed.Text);
                }
                if (string.IsNullOrEmpty(educationalqualification1.Text))
                {
                    cmd.Parameters.AddWithValue("@EducationalQualification1", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@EducationalQualification1", educationalqualification1.Text);
                }
                if (string.IsNullOrEmpty(educationalqualification2.Text))
                {
                    cmd.Parameters.AddWithValue("@EducationalQualification2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@EducationalQualification2", educationalqualification2.Text);
                }
                if (string.IsNullOrEmpty(professionalcertificate.Text))
                {
                    cmd.Parameters.AddWithValue("@ProfessionalCertificate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ProfessionalCertificate", professionalcertificate.Text);
                }
                if (string.IsNullOrEmpty(certificatename.Text))
                {
                    cmd.Parameters.AddWithValue("@CertificateName", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CertificateName", certificatename.Text);
                }
                if (string.IsNullOrEmpty(contactnumber.Text))
                {
                    cmd.Parameters.AddWithValue("@ContactNumber", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ContactNumber", contactnumber.Text);
                }
                if (string.IsNullOrEmpty(alternatecontactnumber.Text))
                {
                    cmd.Parameters.AddWithValue("@AlternateContactNumber", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@AlternateContactNumber", alternatecontactnumber.Text);
                }
                cmd.Parameters.AddWithValue("@LastUpdateBy", Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName.ToString());
                cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 2000);
                cmd.Parameters["@Message"].Direction = ParameterDirection.Output;

                //if conditions
                if (string.IsNullOrEmpty(empid.Text))
                {
                    MessageBox.Show("Please update EmpID");
                }
                else if (string.IsNullOrEmpty(empname.Text))
                {
                    MessageBox.Show("Please update EmpName");
                }
                else if (string.IsNullOrEmpty(workemailaddress.Text))
                {
                    MessageBox.Show("Please update Work Email Address");
                }
                //else if (string.IsNullOrEmpty(loginid.Text))
                //{
                //    MessageBox.Show("Please update Login ID");
                //}
                else if (string.IsNullOrEmpty(reportingmanager.Text))
                {
                    MessageBox.Show("Please update Reporting Manager");
                }
                else if (string.IsNullOrEmpty(process.Text))
                {
                    MessageBox.Show("Please update Process");
                }
                else if (string.IsNullOrEmpty(gender.Text))
                {
                    MessageBox.Show("Please update Gender");
                }
                //else if (dateofjoining.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please update Date Of Joining");
                //}
                //else if (string.IsNullOrEmpty(designation.Text))
                //{
                //    MessageBox.Show("Please update Designation");
                //}
                else
                {

                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    string message = cmd.Parameters["@Message"].Value.ToString();
                    if (!string.IsNullOrEmpty(message))
                    {
                        MessageBox.Show("" + message.ToString());

                    }
                    else
                    {
                        MessageBox.Show("Records updated Successfully");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomePage obj_form3 = new HomePage();
            obj_form3.Show();
        }
    }
}
