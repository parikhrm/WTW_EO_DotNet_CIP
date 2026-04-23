namespace CIP_Tool
{
    partial class DownTime_Tracker
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.comments = new System.Windows.Forms.TextBox();
            this.impacted_users = new System.Windows.Forms.TextBox();
            this.endtime = new System.Windows.Forms.DateTimePicker();
            this.starttime = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.application = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Application = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Impacted_Users = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchby_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.raw_data = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.comments);
            this.groupBox1.Controls.Add(this.impacted_users);
            this.groupBox1.Controls.Add(this.endtime);
            this.groupBox1.Controls.Add(this.starttime);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.application);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1673, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(381, 237);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(119, 44);
            this.reset.TabIndex = 16;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(234, 237);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(119, 44);
            this.update.TabIndex = 15;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(88, 237);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(119, 44);
            this.insert.TabIndex = 14;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // comments
            // 
            this.comments.Location = new System.Drawing.Point(419, 108);
            this.comments.Multiline = true;
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(891, 108);
            this.comments.TabIndex = 13;
            // 
            // impacted_users
            // 
            this.impacted_users.Location = new System.Drawing.Point(125, 109);
            this.impacted_users.Name = "impacted_users";
            this.impacted_users.Size = new System.Drawing.Size(126, 26);
            this.impacted_users.TabIndex = 11;
            // 
            // endtime
            // 
            this.endtime.CustomFormat = " ";
            this.endtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endtime.Location = new System.Drawing.Point(1384, 34);
            this.endtime.Name = "endtime";
            this.endtime.ShowUpDown = true;
            this.endtime.Size = new System.Drawing.Size(242, 26);
            this.endtime.TabIndex = 9;
            this.endtime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.endtime_KeyDown);
            this.endtime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.endtime_MouseDown);
            // 
            // starttime
            // 
            this.starttime.CustomFormat = " ";
            this.starttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.starttime.Location = new System.Drawing.Point(1001, 34);
            this.starttime.Name = "starttime";
            this.starttime.ShowUpDown = true;
            this.starttime.Size = new System.Drawing.Size(227, 26);
            this.starttime.TabIndex = 7;
            this.starttime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.starttime_KeyDown);
            this.starttime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.starttime_MouseDown);
            // 
            // date
            // 
            this.date.CustomFormat = " ";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(648, 33);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(246, 26);
            this.date.TabIndex = 5;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            this.date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_KeyDown);
            // 
            // application
            // 
            this.application.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.application.FormattingEnabled = true;
            this.application.Items.AddRange(new object[] {
            "AVD",
            "D&B",
            "Global Protect",
            "KYC RDC login page",
            "KYC WFT",
            "Mailbox",
            "Maxsight",
            "Workpulse",
            "WiFi - Office"});
            this.application.Location = new System.Drawing.Point(310, 32);
            this.application.Name = "application";
            this.application.Size = new System.Drawing.Size(253, 28);
            this.application.TabIndex = 3;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(63, 29);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(114, 26);
            this.id.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Comments";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "Impacted \r\nUsers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1244, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "End Time \r\n(Resolved Time)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(900, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "Start Time\r\n(Issue)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_ID,
            this.txt_Application,
            this.txt_Date,
            this.txt_StartTime,
            this.txt_EndTime,
            this.txt_Impacted_Users,
            this.txt_Comments});
            this.dataGridView1.Location = new System.Drawing.Point(24, 463);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1673, 342);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_ID
            // 
            this.txt_ID.DataPropertyName = "ID";
            this.txt_ID.HeaderText = "ID";
            this.txt_ID.MinimumWidth = 8;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Width = 150;
            // 
            // txt_Application
            // 
            this.txt_Application.DataPropertyName = "Application";
            this.txt_Application.HeaderText = "Application";
            this.txt_Application.MinimumWidth = 8;
            this.txt_Application.Name = "txt_Application";
            this.txt_Application.ReadOnly = true;
            this.txt_Application.Width = 150;
            // 
            // txt_Date
            // 
            this.txt_Date.DataPropertyName = "Date";
            this.txt_Date.HeaderText = "Date";
            this.txt_Date.MinimumWidth = 8;
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.ReadOnly = true;
            this.txt_Date.Width = 150;
            // 
            // txt_StartTime
            // 
            this.txt_StartTime.DataPropertyName = "StartTime";
            this.txt_StartTime.HeaderText = "StartTime";
            this.txt_StartTime.MinimumWidth = 8;
            this.txt_StartTime.Name = "txt_StartTime";
            this.txt_StartTime.ReadOnly = true;
            this.txt_StartTime.Width = 150;
            // 
            // txt_EndTime
            // 
            this.txt_EndTime.DataPropertyName = "EndTime";
            this.txt_EndTime.HeaderText = "EndTime";
            this.txt_EndTime.MinimumWidth = 8;
            this.txt_EndTime.Name = "txt_EndTime";
            this.txt_EndTime.ReadOnly = true;
            this.txt_EndTime.Width = 150;
            // 
            // txt_Impacted_Users
            // 
            this.txt_Impacted_Users.DataPropertyName = "Impacted_Users";
            this.txt_Impacted_Users.HeaderText = "Impacted_Users";
            this.txt_Impacted_Users.MinimumWidth = 8;
            this.txt_Impacted_Users.Name = "txt_Impacted_Users";
            this.txt_Impacted_Users.ReadOnly = true;
            this.txt_Impacted_Users.Width = 150;
            // 
            // txt_Comments
            // 
            this.txt_Comments.DataPropertyName = "Comments";
            this.txt_Comments.HeaderText = "Comments";
            this.txt_Comments.MinimumWidth = 8;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.ReadOnly = true;
            this.txt_Comments.Width = 150;
            // 
            // searchby_id
            // 
            this.searchby_id.Location = new System.Drawing.Point(175, 386);
            this.searchby_id.Name = "searchby_id";
            this.searchby_id.Size = new System.Drawing.Size(100, 26);
            this.searchby_id.TabIndex = 2;
            this.searchby_id.TextChanged += new System.EventHandler(this.searchby_id_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Search by ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Home Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // raw_data
            // 
            this.raw_data.Location = new System.Drawing.Point(24, 386);
            this.raw_data.Name = "raw_data";
            this.raw_data.Size = new System.Drawing.Size(116, 47);
            this.raw_data.TabIndex = 18;
            this.raw_data.Text = "Raw Data";
            this.raw_data.UseVisualStyleBackColor = true;
            this.raw_data.Click += new System.EventHandler(this.raw_data_Click);
            // 
            // DownTime_Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1735, 827);
            this.Controls.Add(this.raw_data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchby_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DownTime_Tracker";
            this.Text = "DownTime_Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DownTime_Tracker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox application;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DateTimePicker starttime;
        private System.Windows.Forms.DateTimePicker endtime;
        private System.Windows.Forms.TextBox comments;
        private System.Windows.Forms.TextBox impacted_users;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Application;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Impacted_Users;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Comments;
        private System.Windows.Forms.TextBox searchby_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button raw_data;
    }
}