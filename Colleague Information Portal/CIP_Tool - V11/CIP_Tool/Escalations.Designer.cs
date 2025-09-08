namespace CIP_Tool
{
    partial class Escalations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchby_reportingmanager = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchby_associatename = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.datagridview_main = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEscalatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAssociateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReportingManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMailBoxType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubjectLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRDCComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRequestorEmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRequestorBusinessUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.requestoremailaddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.subjectline = new System.Windows.Forms.TextBox();
            this.rdccomments = new System.Windows.Forms.TextBox();
            this.mailboxtype = new System.Windows.Forms.ComboBox();
            this.associatename = new System.Windows.Forms.ComboBox();
            this.escalateddate = new System.Windows.Forms.DateTimePicker();
            this.id = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.summaryreport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_main)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Home Page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchby_reportingmanager);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.searchby_associatename);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.datagridview_main);
            this.groupBox1.Location = new System.Drawing.Point(12, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1574, 560);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // searchby_reportingmanager
            // 
            this.searchby_reportingmanager.Location = new System.Drawing.Point(502, 24);
            this.searchby_reportingmanager.Name = "searchby_reportingmanager";
            this.searchby_reportingmanager.Size = new System.Drawing.Size(305, 26);
            this.searchby_reportingmanager.TabIndex = 5;
            this.searchby_reportingmanager.TextChanged += new System.EventHandler(this.searchby_reportingmanager_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Search by Reporting Manager Name";
            // 
            // searchby_associatename
            // 
            this.searchby_associatename.Location = new System.Drawing.Point(187, 25);
            this.searchby_associatename.Name = "searchby_associatename";
            this.searchby_associatename.Size = new System.Drawing.Size(278, 26);
            this.searchby_associatename.TabIndex = 2;
            this.searchby_associatename.TextChanged += new System.EventHandler(this.searchby_subjectline_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Search by Associate Name";
            // 
            // datagridview_main
            // 
            this.datagridview_main.AllowUserToAddRows = false;
            this.datagridview_main.AllowUserToDeleteRows = false;
            this.datagridview_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.txtEscalatedDate,
            this.txtAssociateName,
            this.txtReportingManager,
            this.txtMailBoxType,
            this.txtSubjectLine,
            this.txtRDCComments,
            this.txtRequestorEmailAddress,
            this.txtRequestorBusinessUnit});
            this.datagridview_main.Location = new System.Drawing.Point(11, 96);
            this.datagridview_main.Name = "datagridview_main";
            this.datagridview_main.ReadOnly = true;
            this.datagridview_main.RowTemplate.Height = 28;
            this.datagridview_main.Size = new System.Drawing.Size(1538, 443);
            this.datagridview_main.TabIndex = 0;
            this.datagridview_main.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_main_CellContentClick);
            // 
            // txtID
            // 
            this.txtID.DataPropertyName = "ID";
            this.txtID.HeaderText = "ID";
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            // 
            // txtEscalatedDate
            // 
            this.txtEscalatedDate.DataPropertyName = "EscalatedDate";
            this.txtEscalatedDate.HeaderText = "EscalatedDate";
            this.txtEscalatedDate.Name = "txtEscalatedDate";
            this.txtEscalatedDate.ReadOnly = true;
            // 
            // txtAssociateName
            // 
            this.txtAssociateName.DataPropertyName = "AssociateName";
            this.txtAssociateName.HeaderText = "AssociateName";
            this.txtAssociateName.Name = "txtAssociateName";
            this.txtAssociateName.ReadOnly = true;
            // 
            // txtReportingManager
            // 
            this.txtReportingManager.DataPropertyName = "ReportingManager";
            this.txtReportingManager.HeaderText = "ReportingManager";
            this.txtReportingManager.Name = "txtReportingManager";
            this.txtReportingManager.ReadOnly = true;
            // 
            // txtMailBoxType
            // 
            this.txtMailBoxType.DataPropertyName = "MailBoxType";
            this.txtMailBoxType.HeaderText = "MailBoxType";
            this.txtMailBoxType.Name = "txtMailBoxType";
            this.txtMailBoxType.ReadOnly = true;
            // 
            // txtSubjectLine
            // 
            this.txtSubjectLine.DataPropertyName = "SubjectLine";
            this.txtSubjectLine.HeaderText = "SubjectLine";
            this.txtSubjectLine.Name = "txtSubjectLine";
            this.txtSubjectLine.ReadOnly = true;
            this.txtSubjectLine.Width = 400;
            // 
            // txtRDCComments
            // 
            this.txtRDCComments.DataPropertyName = "RDCComments";
            this.txtRDCComments.HeaderText = "RCA Comments";
            this.txtRDCComments.Name = "txtRDCComments";
            this.txtRDCComments.ReadOnly = true;
            this.txtRDCComments.Width = 400;
            // 
            // txtRequestorEmailAddress
            // 
            this.txtRequestorEmailAddress.DataPropertyName = "RequestorEmailAddress";
            this.txtRequestorEmailAddress.HeaderText = "EscalatedBy";
            this.txtRequestorEmailAddress.Name = "txtRequestorEmailAddress";
            this.txtRequestorEmailAddress.ReadOnly = true;
            // 
            // txtRequestorBusinessUnit
            // 
            this.txtRequestorBusinessUnit.DataPropertyName = "RequestorBusinessUnit";
            this.txtRequestorBusinessUnit.HeaderText = "RequestorBusinessUnit";
            this.txtRequestorBusinessUnit.Name = "txtRequestorBusinessUnit";
            this.txtRequestorBusinessUnit.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.requestoremailaddress);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.reset);
            this.groupBox2.Controls.Add(this.update);
            this.groupBox2.Controls.Add(this.subjectline);
            this.groupBox2.Controls.Add(this.rdccomments);
            this.groupBox2.Controls.Add(this.mailboxtype);
            this.groupBox2.Controls.Add(this.associatename);
            this.groupBox2.Controls.Add(this.escalateddate);
            this.groupBox2.Controls.Add(this.id);
            this.groupBox2.Controls.Add(this.insert);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1465, 379);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // requestoremailaddress
            // 
            this.requestoremailaddress.Location = new System.Drawing.Point(129, 118);
            this.requestoremailaddress.Multiline = true;
            this.requestoremailaddress.Name = "requestoremailaddress";
            this.requestoremailaddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.requestoremailaddress.Size = new System.Drawing.Size(291, 51);
            this.requestoremailaddress.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Escalated By";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Purple;
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(338, 311);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(108, 49);
            this.reset.TabIndex = 16;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Purple;
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(187, 311);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(108, 49);
            this.update.TabIndex = 15;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // subjectline
            // 
            this.subjectline.Location = new System.Drawing.Point(987, 118);
            this.subjectline.Multiline = true;
            this.subjectline.Name = "subjectline";
            this.subjectline.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.subjectline.Size = new System.Drawing.Size(450, 62);
            this.subjectline.TabIndex = 11;
            // 
            // rdccomments
            // 
            this.rdccomments.Location = new System.Drawing.Point(129, 212);
            this.rdccomments.Multiline = true;
            this.rdccomments.Name = "rdccomments";
            this.rdccomments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rdccomments.Size = new System.Drawing.Size(523, 68);
            this.rdccomments.TabIndex = 13;
            // 
            // mailboxtype
            // 
            this.mailboxtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mailboxtype.FormattingEnabled = true;
            this.mailboxtype.Location = new System.Drawing.Point(572, 118);
            this.mailboxtype.Name = "mailboxtype";
            this.mailboxtype.Size = new System.Drawing.Size(277, 28);
            this.mailboxtype.TabIndex = 9;
            // 
            // associatename
            // 
            this.associatename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.associatename.FormattingEnabled = true;
            this.associatename.Location = new System.Drawing.Point(911, 29);
            this.associatename.Name = "associatename";
            this.associatename.Size = new System.Drawing.Size(317, 28);
            this.associatename.TabIndex = 5;
            // 
            // escalateddate
            // 
            this.escalateddate.CustomFormat = " ";
            this.escalateddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.escalateddate.Location = new System.Drawing.Point(463, 26);
            this.escalateddate.Name = "escalateddate";
            this.escalateddate.Size = new System.Drawing.Size(290, 26);
            this.escalateddate.TabIndex = 3;
            this.escalateddate.ValueChanged += new System.EventHandler(this.escalateddate_ValueChanged);
            this.escalateddate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.escalateddate_KeyDown);
            this.escalateddate.MouseHover += new System.EventHandler(this.escalateddate_MouseHover);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(123, 29);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 26);
            this.id.TabIndex = 1;
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.Purple;
            this.insert.ForeColor = System.Drawing.Color.White;
            this.insert.Location = new System.Drawing.Point(46, 311);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(108, 49);
            this.insert.TabIndex = 14;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 40);
            this.label8.TabIndex = 12;
            this.label8.Text = "RCA\r\nComments";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(876, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Subject Line";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mailbox Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Associate\r\nName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "EscalatedDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // summaryreport
            // 
            this.summaryreport.Location = new System.Drawing.Point(322, 13);
            this.summaryreport.Name = "summaryreport";
            this.summaryreport.Size = new System.Drawing.Size(264, 41);
            this.summaryreport.TabIndex = 12;
            this.summaryreport.Text = "Escalations Summary Report";
            this.summaryreport.UseVisualStyleBackColor = true;
            this.summaryreport.Click += new System.EventHandler(this.summaryreport_Click);
            // 
            // Escalations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1746, 1031);
            this.Controls.Add(this.summaryreport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "Escalations";
            this.Text = "Escalations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form8_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_main)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker escalateddate;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.ComboBox associatename;
        private System.Windows.Forms.TextBox subjectline;
        private System.Windows.Forms.TextBox rdccomments;
        private System.Windows.Forms.ComboBox mailboxtype;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView datagridview_main;
        private System.Windows.Forms.TextBox searchby_associatename;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox requestoremailaddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEscalatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAssociateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtReportingManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMailBoxType;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSubjectLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRDCComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRequestorEmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRequestorBusinessUnit;
        private System.Windows.Forms.TextBox searchby_reportingmanager;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button summaryreport;
    }
}