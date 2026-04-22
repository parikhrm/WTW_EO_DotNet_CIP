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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.application = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.starttime = new System.Windows.Forms.DateTimePicker();
            this.endtime = new System.Windows.Forms.DateTimePicker();
            this.impacted_users = new System.Windows.Forms.TextBox();
            this.comments = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(1673, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Application";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(900, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Time\r\n(Issue)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1244, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Time \r\n(Resolved Time)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Impacted \r\nUsers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comments";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(63, 29);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(114, 26);
            this.id.TabIndex = 7;
            // 
            // application
            // 
            this.application.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.application.FormattingEnabled = true;
            this.application.Items.AddRange(new object[] {
            "AVD",
            "Maxsight",
            "WiFi - Office",
            "WFT - Bulk Upload"});
            this.application.Location = new System.Drawing.Point(310, 32);
            this.application.Name = "application";
            this.application.Size = new System.Drawing.Size(253, 28);
            this.application.TabIndex = 8;
            // 
            // date
            // 
            this.date.CustomFormat = " ";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(648, 33);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(246, 26);
            this.date.TabIndex = 9;
            // 
            // starttime
            // 
            this.starttime.CustomFormat = " ";
            this.starttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.starttime.Location = new System.Drawing.Point(1001, 34);
            this.starttime.Name = "starttime";
            this.starttime.ShowUpDown = true;
            this.starttime.Size = new System.Drawing.Size(227, 26);
            this.starttime.TabIndex = 10;
            // 
            // endtime
            // 
            this.endtime.CustomFormat = " ";
            this.endtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endtime.Location = new System.Drawing.Point(1384, 34);
            this.endtime.Name = "endtime";
            this.endtime.ShowUpDown = true;
            this.endtime.Size = new System.Drawing.Size(242, 26);
            this.endtime.TabIndex = 11;
            // 
            // impacted_users
            // 
            this.impacted_users.Location = new System.Drawing.Point(125, 109);
            this.impacted_users.Name = "impacted_users";
            this.impacted_users.Size = new System.Drawing.Size(126, 26);
            this.impacted_users.TabIndex = 12;
            // 
            // comments
            // 
            this.comments.Location = new System.Drawing.Point(419, 108);
            this.comments.Multiline = true;
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(891, 108);
            this.comments.TabIndex = 13;
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
            // update
            // 
            this.update.Location = new System.Drawing.Point(234, 237);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(119, 44);
            this.update.TabIndex = 15;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
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
            // DownTime_Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1735, 752);
            this.Controls.Add(this.groupBox1);
            this.Name = "DownTime_Tracker";
            this.Text = "DownTime_Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DownTime_Tracker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}