namespace CIP_Tool
{
    partial class TrainingDetails
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
            this.txtSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtTraining_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAttendees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAttendance_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTrainer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProgram_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatelist = new System.Windows.Forms.CheckedListBox();
            this.nominate = new System.Windows.Forms.Button();
            this.attended = new System.Windows.Forms.Button();
            this.notattended = new System.Windows.Forms.Button();
            this.deleteattendee = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.trainingid = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchby_programname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchby_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.searchby_trainingid = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtSelect,
            this.txtTraining_ID,
            this.txtAttendees,
            this.txtAttendance_Status,
            this.txtTrainer_Name,
            this.txtProgram_Name,
            this.txtDate,
            this.txtRequestID});
            this.dataGridView1.Location = new System.Drawing.Point(332, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1364, 812);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // txtSelect
            // 
            this.txtSelect.HeaderText = "Select";
            this.txtSelect.Name = "txtSelect";
            // 
            // txtTraining_ID
            // 
            this.txtTraining_ID.DataPropertyName = "Training_ID";
            this.txtTraining_ID.HeaderText = "Training_ID";
            this.txtTraining_ID.Name = "txtTraining_ID";
            // 
            // txtAttendees
            // 
            this.txtAttendees.DataPropertyName = "Attendees";
            this.txtAttendees.HeaderText = "Attendees";
            this.txtAttendees.Name = "txtAttendees";
            // 
            // txtAttendance_Status
            // 
            this.txtAttendance_Status.DataPropertyName = "Attendance_Status";
            this.txtAttendance_Status.HeaderText = "Attendance_Status";
            this.txtAttendance_Status.Name = "txtAttendance_Status";
            // 
            // txtTrainer_Name
            // 
            this.txtTrainer_Name.DataPropertyName = "Trainer_Name";
            this.txtTrainer_Name.HeaderText = "Trainer_Name";
            this.txtTrainer_Name.Name = "txtTrainer_Name";
            // 
            // txtProgram_Name
            // 
            this.txtProgram_Name.DataPropertyName = "Program_Name";
            this.txtProgram_Name.HeaderText = "Program_Name";
            this.txtProgram_Name.Name = "txtProgram_Name";
            // 
            // txtDate
            // 
            this.txtDate.DataPropertyName = "Date";
            this.txtDate.HeaderText = "Date";
            this.txtDate.Name = "txtDate";
            // 
            // txtRequestID
            // 
            this.txtRequestID.DataPropertyName = "RequestID";
            this.txtRequestID.HeaderText = "RequestID";
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.Visible = false;
            // 
            // associatelist
            // 
            this.associatelist.FormattingEnabled = true;
            this.associatelist.Location = new System.Drawing.Point(14, 118);
            this.associatelist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.associatelist.Name = "associatelist";
            this.associatelist.ScrollAlwaysVisible = true;
            this.associatelist.Size = new System.Drawing.Size(278, 802);
            this.associatelist.TabIndex = 1;
            // 
            // nominate
            // 
            this.nominate.BackColor = System.Drawing.Color.Purple;
            this.nominate.ForeColor = System.Drawing.Color.White;
            this.nominate.Location = new System.Drawing.Point(14, 56);
            this.nominate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nominate.Name = "nominate";
            this.nominate.Size = new System.Drawing.Size(126, 41);
            this.nominate.TabIndex = 7;
            this.nominate.Text = "Nominate";
            this.nominate.UseVisualStyleBackColor = false;
            this.nominate.Click += new System.EventHandler(this.nominate_Click);
            // 
            // attended
            // 
            this.attended.BackColor = System.Drawing.Color.Purple;
            this.attended.ForeColor = System.Drawing.Color.White;
            this.attended.Location = new System.Drawing.Point(1211, 5);
            this.attended.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attended.Name = "attended";
            this.attended.Size = new System.Drawing.Size(130, 51);
            this.attended.TabIndex = 8;
            this.attended.Text = "Attended";
            this.attended.UseVisualStyleBackColor = false;
            this.attended.Click += new System.EventHandler(this.attended_Click);
            // 
            // notattended
            // 
            this.notattended.BackColor = System.Drawing.Color.Purple;
            this.notattended.ForeColor = System.Drawing.Color.White;
            this.notattended.Location = new System.Drawing.Point(1211, 56);
            this.notattended.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.notattended.Name = "notattended";
            this.notattended.Size = new System.Drawing.Size(130, 51);
            this.notattended.TabIndex = 9;
            this.notattended.Text = "Not Attended";
            this.notattended.UseVisualStyleBackColor = false;
            this.notattended.Click += new System.EventHandler(this.notattended_Click);
            // 
            // deleteattendee
            // 
            this.deleteattendee.BackColor = System.Drawing.Color.Purple;
            this.deleteattendee.ForeColor = System.Drawing.Color.White;
            this.deleteattendee.Location = new System.Drawing.Point(1347, 5);
            this.deleteattendee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteattendee.Name = "deleteattendee";
            this.deleteattendee.Size = new System.Drawing.Size(130, 51);
            this.deleteattendee.TabIndex = 10;
            this.deleteattendee.Text = "Delete Attendee";
            this.deleteattendee.UseVisualStyleBackColor = false;
            this.deleteattendee.Click += new System.EventHandler(this.deleteattendee_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Purple;
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(1347, 56);
            this.reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(130, 51);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // trainingid
            // 
            this.trainingid.Location = new System.Drawing.Point(192, 56);
            this.trainingid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trainingid.Name = "trainingid";
            this.trainingid.Size = new System.Drawing.Size(100, 26);
            this.trainingid.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Training ID";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1098, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 40);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View Training\r\nReport";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Home Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1524, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 51);
            this.button2.TabIndex = 16;
            this.button2.Text = "Export to Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search by Program Name";
            // 
            // searchby_programname
            // 
            this.searchby_programname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchby_programname.FormattingEnabled = true;
            this.searchby_programname.Location = new System.Drawing.Point(537, 54);
            this.searchby_programname.Name = "searchby_programname";
            this.searchby_programname.Size = new System.Drawing.Size(256, 28);
            this.searchby_programname.TabIndex = 18;
            this.searchby_programname.SelectedIndexChanged += new System.EventHandler(this.searchby_programname_SelectedIndexChanged);
            this.searchby_programname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchby_programname_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(855, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search by Date";
            // 
            // searchby_date
            // 
            this.searchby_date.CustomFormat = " ";
            this.searchby_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchby_date.Location = new System.Drawing.Point(806, 56);
            this.searchby_date.Name = "searchby_date";
            this.searchby_date.Size = new System.Drawing.Size(225, 26);
            this.searchby_date.TabIndex = 20;
            this.searchby_date.ValueChanged += new System.EventHandler(this.searchby_date_ValueChanged);
            this.searchby_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchby_date_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Search by Training ID";
            // 
            // searchby_trainingid
            // 
            this.searchby_trainingid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchby_trainingid.FormattingEnabled = true;
            this.searchby_trainingid.Location = new System.Drawing.Point(332, 54);
            this.searchby_trainingid.Name = "searchby_trainingid";
            this.searchby_trainingid.Size = new System.Drawing.Size(188, 28);
            this.searchby_trainingid.TabIndex = 22;
            this.searchby_trainingid.SelectedIndexChanged += new System.EventHandler(this.searchby_trainingid_SelectedIndexChanged);
            this.searchby_trainingid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchby_trainingid_KeyDown);
            // 
            // TrainingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1722, 996);
            this.Controls.Add(this.searchby_trainingid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchby_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchby_programname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trainingid);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.deleteattendee);
            this.Controls.Add(this.notattended);
            this.Controls.Add(this.attended);
            this.Controls.Add(this.nominate);
            this.Controls.Add(this.associatelist);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TrainingDetails";
            this.Text = "CIP_TrainingDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox associatelist;
        private System.Windows.Forms.Button nominate;
        private System.Windows.Forms.Button attended;
        private System.Windows.Forms.Button notattended;
        private System.Windows.Forms.Button deleteattendee;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.NumericUpDown trainingid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn txtSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTraining_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAttendees;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAttendance_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTrainer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProgram_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRequestID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchby_programname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker searchby_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox searchby_trainingid;
    }
}