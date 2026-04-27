namespace CIP_Tool
{
    partial class OneDrive_Audit_Tracker
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
            this.status = new System.Windows.Forms.ComboBox();
            this.audit_quarter = new System.Windows.Forms.ComboBox();
            this.empname = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Audit_Quarter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Attachment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchby_empname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.audit_quarter);
            this.groupBox1.Controls.Add(this.empname);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1777, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(419, 221);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(120, 49);
            this.reset.TabIndex = 14;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(275, 221);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(120, 49);
            this.update.TabIndex = 13;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(127, 221);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(120, 49);
            this.insert.TabIndex = 12;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // comments
            // 
            this.comments.Location = new System.Drawing.Point(127, 106);
            this.comments.Multiline = true;
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(494, 90);
            this.comments.TabIndex = 9;
            // 
            // status
            // 
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Pass",
            "Fail"});
            this.status.Location = new System.Drawing.Point(1037, 23);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(175, 28);
            this.status.TabIndex = 7;
            // 
            // audit_quarter
            // 
            this.audit_quarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audit_quarter.FormattingEnabled = true;
            this.audit_quarter.Location = new System.Drawing.Point(697, 23);
            this.audit_quarter.Name = "audit_quarter";
            this.audit_quarter.Size = new System.Drawing.Size(240, 28);
            this.audit_quarter.TabIndex = 5;
            // 
            // empname
            // 
            this.empname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empname.FormattingEnabled = true;
            this.empname.Location = new System.Drawing.Point(275, 23);
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(276, 28);
            this.empname.TabIndex = 3;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(61, 26);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 26);
            this.id.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Comments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(959, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Audit Quarter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "EmpName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
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
            this.txt_EmpName,
            this.txt_Audit_Quarter,
            this.txt_Status,
            this.txt_Comments,
            this.txt_Attachment});
            this.dataGridView1.Location = new System.Drawing.Point(13, 474);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1460, 422);
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
            // txt_EmpName
            // 
            this.txt_EmpName.DataPropertyName = "EmpName";
            this.txt_EmpName.HeaderText = "EmpName";
            this.txt_EmpName.MinimumWidth = 8;
            this.txt_EmpName.Name = "txt_EmpName";
            this.txt_EmpName.ReadOnly = true;
            this.txt_EmpName.Width = 150;
            // 
            // txt_Audit_Quarter
            // 
            this.txt_Audit_Quarter.DataPropertyName = "Audit_Quarter";
            this.txt_Audit_Quarter.HeaderText = "Audit_Quarter";
            this.txt_Audit_Quarter.MinimumWidth = 8;
            this.txt_Audit_Quarter.Name = "txt_Audit_Quarter";
            this.txt_Audit_Quarter.ReadOnly = true;
            this.txt_Audit_Quarter.Width = 150;
            // 
            // txt_Status
            // 
            this.txt_Status.DataPropertyName = "Status";
            this.txt_Status.HeaderText = "Status";
            this.txt_Status.MinimumWidth = 8;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Width = 150;
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
            // txt_Attachment
            // 
            this.txt_Attachment.DataPropertyName = "Attachment";
            this.txt_Attachment.HeaderText = "Attachment";
            this.txt_Attachment.MinimumWidth = 8;
            this.txt_Attachment.Name = "txt_Attachment";
            this.txt_Attachment.ReadOnly = true;
            this.txt_Attachment.Width = 150;
            // 
            // searchby_empname
            // 
            this.searchby_empname.Location = new System.Drawing.Point(202, 381);
            this.searchby_empname.Name = "searchby_empname";
            this.searchby_empname.Size = new System.Drawing.Size(221, 26);
            this.searchby_empname.TabIndex = 2;
            this.searchby_empname.TextChanged += new System.EventHandler(this.searchby_empname_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Search By EmpName";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 34;
            this.button1.Text = "Home Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // raw_data
            // 
            this.raw_data.Location = new System.Drawing.Point(12, 381);
            this.raw_data.Name = "raw_data";
            this.raw_data.Size = new System.Drawing.Size(116, 47);
            this.raw_data.TabIndex = 35;
            this.raw_data.Text = "Raw Data";
            this.raw_data.UseVisualStyleBackColor = true;
            this.raw_data.Click += new System.EventHandler(this.raw_data_Click);
            // 
            // OneDrive_Audit_Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1828, 932);
            this.Controls.Add(this.raw_data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchby_empname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "OneDrive_Audit_Tracker";
            this.Text = "OneDrive_Audit_Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OneDrive_Audit_Tracker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox comments;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.ComboBox audit_quarter;
        private System.Windows.Forms.ComboBox empname;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Audit_Quarter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Attachment;
        private System.Windows.Forms.TextBox searchby_empname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button raw_data;
    }
}