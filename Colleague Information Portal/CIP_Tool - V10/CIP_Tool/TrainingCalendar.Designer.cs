namespace CIP_Tool
{
    partial class TrainingCalendar
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
            this.txtTraining_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTrainer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProgram_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTrainingProgramComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTraining_Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSeats_Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trainingprogramcomments = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.seatsavailable = new System.Windows.Forms.NumericUpDown();
            this.trainingduration = new System.Windows.Forms.NumericUpDown();
            this.trainingprogram = new System.Windows.Forms.ComboBox();
            this.trainername = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.trainingid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchby_month = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatsavailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingduration)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtTraining_Id,
            this.txtDate,
            this.txtTrainer_Name,
            this.txtProgram_Name,
            this.txtTrainingProgramComments,
            this.txtTraining_Duration,
            this.txtSeats_Available});
            this.dataGridView1.Location = new System.Drawing.Point(29, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1197, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtTraining_Id
            // 
            this.txtTraining_Id.DataPropertyName = "Training_Id";
            this.txtTraining_Id.HeaderText = "Training_Id";
            this.txtTraining_Id.Name = "txtTraining_Id";
            this.txtTraining_Id.ReadOnly = true;
            // 
            // txtDate
            // 
            this.txtDate.DataPropertyName = "Date";
            this.txtDate.HeaderText = "Date";
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            // 
            // txtTrainer_Name
            // 
            this.txtTrainer_Name.DataPropertyName = "Trainer_Name";
            this.txtTrainer_Name.HeaderText = "Trainer_Name";
            this.txtTrainer_Name.Name = "txtTrainer_Name";
            this.txtTrainer_Name.ReadOnly = true;
            // 
            // txtProgram_Name
            // 
            this.txtProgram_Name.DataPropertyName = "Program_Name";
            this.txtProgram_Name.HeaderText = "Program_Name";
            this.txtProgram_Name.Name = "txtProgram_Name";
            this.txtProgram_Name.ReadOnly = true;
            // 
            // txtTrainingProgramComments
            // 
            this.txtTrainingProgramComments.DataPropertyName = "TrainingProgramComments";
            this.txtTrainingProgramComments.HeaderText = "TrainingProgramComments";
            this.txtTrainingProgramComments.Name = "txtTrainingProgramComments";
            this.txtTrainingProgramComments.ReadOnly = true;
            // 
            // txtTraining_Duration
            // 
            this.txtTraining_Duration.DataPropertyName = "Training_Duration";
            this.txtTraining_Duration.HeaderText = "Training_Duration";
            this.txtTraining_Duration.Name = "txtTraining_Duration";
            this.txtTraining_Duration.ReadOnly = true;
            // 
            // txtSeats_Available
            // 
            this.txtSeats_Available.DataPropertyName = "Seats_Available";
            this.txtSeats_Available.HeaderText = "Seats_Available";
            this.txtSeats_Available.Name = "txtSeats_Available";
            this.txtSeats_Available.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trainingprogramcomments);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.seatsavailable);
            this.groupBox1.Controls.Add(this.trainingduration);
            this.groupBox1.Controls.Add(this.trainingprogram);
            this.groupBox1.Controls.Add(this.trainername);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.trainingid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1197, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update Records";
            // 
            // trainingprogramcomments
            // 
            this.trainingprogramcomments.Location = new System.Drawing.Point(176, 171);
            this.trainingprogramcomments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trainingprogramcomments.Multiline = true;
            this.trainingprogramcomments.Name = "trainingprogramcomments";
            this.trainingprogramcomments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.trainingprogramcomments.Size = new System.Drawing.Size(441, 64);
            this.trainingprogramcomments.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 34);
            this.label9.TabIndex = 12;
            this.label9.Text = "Training \r\nProgram Comments";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(585, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Enter in Mins";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Purple;
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(334, 253);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(90, 37);
            this.reset.TabIndex = 16;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Purple;
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(212, 253);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(90, 37);
            this.update.TabIndex = 15;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.Purple;
            this.insert.ForeColor = System.Drawing.Color.White;
            this.insert.Location = new System.Drawing.Point(87, 253);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(90, 37);
            this.insert.TabIndex = 14;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // seatsavailable
            // 
            this.seatsavailable.Location = new System.Drawing.Point(928, 117);
            this.seatsavailable.Name = "seatsavailable";
            this.seatsavailable.Size = new System.Drawing.Size(120, 22);
            this.seatsavailable.TabIndex = 11;
            // 
            // trainingduration
            // 
            this.trainingduration.Location = new System.Drawing.Point(542, 117);
            this.trainingduration.Name = "trainingduration";
            this.trainingduration.Size = new System.Drawing.Size(133, 22);
            this.trainingduration.TabIndex = 9;
            // 
            // trainingprogram
            // 
            this.trainingprogram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainingprogram.FormattingEnabled = true;
            this.trainingprogram.Location = new System.Drawing.Point(101, 117);
            this.trainingprogram.Name = "trainingprogram";
            this.trainingprogram.Size = new System.Drawing.Size(362, 24);
            this.trainingprogram.TabIndex = 7;
            // 
            // trainername
            // 
            this.trainername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainername.FormattingEnabled = true;
            this.trainername.Location = new System.Drawing.Point(928, 36);
            this.trainername.Name = "trainername";
            this.trainername.Size = new System.Drawing.Size(260, 24);
            this.trainername.TabIndex = 5;
            // 
            // date
            // 
            this.date.CustomFormat = " ";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(542, 34);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(245, 22);
            this.date.TabIndex = 3;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            this.date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_KeyDown);
            // 
            // trainingid
            // 
            this.trainingid.Location = new System.Drawing.Point(101, 34);
            this.trainingid.Name = "trainingid";
            this.trainingid.Size = new System.Drawing.Size(146, 22);
            this.trainingid.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(794, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Seats Available";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Training\r\nDuration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Training \r\nProgram";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(791, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trainer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Training ID";
            // 
            // searchby_month
            // 
            this.searchby_month.CustomFormat = " ";
            this.searchby_month.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchby_month.Location = new System.Drawing.Point(171, 48);
            this.searchby_month.Name = "searchby_month";
            this.searchby_month.Size = new System.Drawing.Size(284, 22);
            this.searchby_month.TabIndex = 2;
            this.searchby_month.ValueChanged += new System.EventHandler(this.searchby_month_ValueChanged);
            this.searchby_month.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchby_month_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Search by Training Month";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nominate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(503, 48);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(201, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View Training Calendar Report";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Home Page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1710, 777);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchby_month);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "CIP_TrainingCalendar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatsavailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingduration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox trainingprogram;
        private System.Windows.Forms.ComboBox trainername;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox trainingid;
        private System.Windows.Forms.NumericUpDown seatsavailable;
        private System.Windows.Forms.NumericUpDown trainingduration;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.DateTimePicker searchby_month;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox trainingprogramcomments;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTraining_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTrainer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProgram_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTrainingProgramComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTraining_Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSeats_Available;
    }
}

