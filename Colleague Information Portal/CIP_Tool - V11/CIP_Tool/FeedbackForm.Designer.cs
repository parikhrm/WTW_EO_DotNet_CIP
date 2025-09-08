namespace CIP_Tool
{
    partial class FeedbackForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtrequestid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmpname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTypeofError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMailSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMailBody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.mailbody = new System.Windows.Forms.TextBox();
            this.subjectline = new System.Windows.Forms.TextBox();
            this.typeoffeedback = new System.Windows.Forms.ComboBox();
            this.feedbackdate = new System.Windows.Forms.DateTimePicker();
            this.employeename = new System.Windows.Forms.ComboBox();
            this.requestid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtrequestid,
            this.txtEmpname,
            this.txtTypeofError,
            this.txtMailSubject,
            this.txtMailBody,
            this.txtDate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1623, 316);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtrequestid
            // 
            this.txtrequestid.DataPropertyName = "requestid";
            this.txtrequestid.HeaderText = "RequestID";
            this.txtrequestid.Name = "txtrequestid";
            this.txtrequestid.ReadOnly = true;
            // 
            // txtEmpname
            // 
            this.txtEmpname.DataPropertyName = "Empname";
            this.txtEmpname.HeaderText = "Empname";
            this.txtEmpname.Name = "txtEmpname";
            this.txtEmpname.ReadOnly = true;
            // 
            // txtTypeofError
            // 
            this.txtTypeofError.DataPropertyName = "TypeofFeedback";
            this.txtTypeofError.HeaderText = "TypeofError";
            this.txtTypeofError.Name = "txtTypeofError";
            this.txtTypeofError.ReadOnly = true;
            // 
            // txtMailSubject
            // 
            this.txtMailSubject.DataPropertyName = "MailSubject";
            this.txtMailSubject.HeaderText = "SubjectLine";
            this.txtMailSubject.Name = "txtMailSubject";
            this.txtMailSubject.ReadOnly = true;
            // 
            // txtMailBody
            // 
            this.txtMailBody.DataPropertyName = "MailBody";
            this.txtMailBody.HeaderText = "MailBody";
            this.txtMailBody.Name = "txtMailBody";
            this.txtMailBody.ReadOnly = true;
            // 
            // txtDate
            // 
            this.txtDate.DataPropertyName = "FeedbackDate";
            this.txtDate.HeaderText = "FeedbackDate";
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Home Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.mailbody);
            this.groupBox1.Controls.Add(this.subjectline);
            this.groupBox1.Controls.Add(this.typeoffeedback);
            this.groupBox1.Controls.Add(this.feedbackdate);
            this.groupBox1.Controls.Add(this.employeename);
            this.groupBox1.Controls.Add(this.requestid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1622, 350);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Purple;
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(500, 272);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(138, 51);
            this.reset.TabIndex = 14;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Purple;
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(334, 272);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(138, 51);
            this.update.TabIndex = 13;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.Purple;
            this.insert.ForeColor = System.Drawing.Color.White;
            this.insert.Location = new System.Drawing.Point(164, 272);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(138, 51);
            this.insert.TabIndex = 12;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // mailbody
            // 
            this.mailbody.Location = new System.Drawing.Point(821, 126);
            this.mailbody.Multiline = true;
            this.mailbody.Name = "mailbody";
            this.mailbody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mailbody.Size = new System.Drawing.Size(752, 100);
            this.mailbody.TabIndex = 11;
            // 
            // subjectline
            // 
            this.subjectline.Location = new System.Drawing.Point(411, 126);
            this.subjectline.Multiline = true;
            this.subjectline.Name = "subjectline";
            this.subjectline.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.subjectline.Size = new System.Drawing.Size(308, 75);
            this.subjectline.TabIndex = 10;
            // 
            // typeoffeedback
            // 
            this.typeoffeedback.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeoffeedback.FormattingEnabled = true;
            this.typeoffeedback.Location = new System.Drawing.Point(109, 124);
            this.typeoffeedback.Name = "typeoffeedback";
            this.typeoffeedback.Size = new System.Drawing.Size(193, 28);
            this.typeoffeedback.TabIndex = 9;
            // 
            // feedbackdate
            // 
            this.feedbackdate.CustomFormat = " ";
            this.feedbackdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.feedbackdate.Location = new System.Drawing.Point(821, 31);
            this.feedbackdate.Name = "feedbackdate";
            this.feedbackdate.Size = new System.Drawing.Size(264, 26);
            this.feedbackdate.TabIndex = 8;
            this.feedbackdate.ValueChanged += new System.EventHandler(this.feedbackdate_ValueChanged);
            this.feedbackdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.feedbackdate_KeyDown);
            // 
            // employeename
            // 
            this.employeename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeename.FormattingEnabled = true;
            this.employeename.Location = new System.Drawing.Point(399, 29);
            this.employeename.Name = "employeename";
            this.employeename.Size = new System.Drawing.Size(257, 28);
            this.employeename.TabIndex = 7;
            // 
            // requestid
            // 
            this.requestid.Location = new System.Drawing.Point(109, 26);
            this.requestid.Name = "requestid";
            this.requestid.Size = new System.Drawing.Size(138, 26);
            this.requestid.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(725, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mail Body";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subject Line";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type Of\r\nFeedback";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Feedback Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RequestID";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(157, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 20);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Export To Excel";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1686, 733);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FeedbackForm";
            this.Text = "Feedback Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker feedbackdate;
        private System.Windows.Forms.ComboBox employeename;
        private System.Windows.Forms.TextBox requestid;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.TextBox mailbody;
        private System.Windows.Forms.TextBox subjectline;
        private System.Windows.Forms.ComboBox typeoffeedback;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtrequestid;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmpname;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTypeofError;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMailSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMailBody;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDate;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}