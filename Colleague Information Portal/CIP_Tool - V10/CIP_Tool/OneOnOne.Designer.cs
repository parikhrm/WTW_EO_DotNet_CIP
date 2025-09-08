namespace CIP_Tool
{
    partial class OneOnOne
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOneOnOneDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAcknowledgmentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiscussionWith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.summary = new System.Windows.Forms.TextBox();
            this.oneononedate = new System.Windows.Forms.DateTimePicker();
            this.discussionwith = new System.Windows.Forms.CheckedListBox();
            this.employeename = new System.Windows.Forms.ComboBox();
            this.requestid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchby_employeename = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Home Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtRequestID,
            this.txtEmpName,
            this.txtOneOnOneDate,
            this.txtAcknowledgmentStatus,
            this.txtDiscussionWith,
            this.txtSummary});
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1468, 303);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtRequestID
            // 
            this.txtRequestID.DataPropertyName = "RequestID";
            this.txtRequestID.HeaderText = "RequestID";
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.ReadOnly = true;
            // 
            // txtEmpName
            // 
            this.txtEmpName.DataPropertyName = "EmpName";
            this.txtEmpName.HeaderText = "EmpName";
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            // 
            // txtOneOnOneDate
            // 
            this.txtOneOnOneDate.DataPropertyName = "OneOnOneDate";
            this.txtOneOnOneDate.HeaderText = "OneOnOneDate";
            this.txtOneOnOneDate.Name = "txtOneOnOneDate";
            this.txtOneOnOneDate.ReadOnly = true;
            // 
            // txtAcknowledgmentStatus
            // 
            this.txtAcknowledgmentStatus.DataPropertyName = "AcknowledgmentStatus";
            this.txtAcknowledgmentStatus.HeaderText = "AcknowledgmentStatus";
            this.txtAcknowledgmentStatus.Name = "txtAcknowledgmentStatus";
            this.txtAcknowledgmentStatus.ReadOnly = true;
            // 
            // txtDiscussionWith
            // 
            this.txtDiscussionWith.DataPropertyName = "DiscussionWith";
            this.txtDiscussionWith.HeaderText = "DiscussionWith";
            this.txtDiscussionWith.Name = "txtDiscussionWith";
            this.txtDiscussionWith.ReadOnly = true;
            this.txtDiscussionWith.Width = 200;
            // 
            // txtSummary
            // 
            this.txtSummary.DataPropertyName = "Summary";
            this.txtSummary.HeaderText = "Summary";
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.summary);
            this.groupBox1.Controls.Add(this.oneononedate);
            this.groupBox1.Controls.Add(this.discussionwith);
            this.groupBox1.Controls.Add(this.employeename);
            this.groupBox1.Controls.Add(this.requestid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1345, 430);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Purple;
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(748, 316);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(118, 48);
            this.reset.TabIndex = 12;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Purple;
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(609, 316);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(118, 48);
            this.update.TabIndex = 11;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.Purple;
            this.insert.ForeColor = System.Drawing.Color.White;
            this.insert.Location = new System.Drawing.Point(469, 316);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(118, 48);
            this.insert.TabIndex = 10;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // summary
            // 
            this.summary.Location = new System.Drawing.Point(533, 106);
            this.summary.Multiline = true;
            this.summary.Name = "summary";
            this.summary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.summary.Size = new System.Drawing.Size(595, 173);
            this.summary.TabIndex = 9;
            // 
            // oneononedate
            // 
            this.oneononedate.CustomFormat = " ";
            this.oneononedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.oneononedate.Location = new System.Drawing.Point(847, 26);
            this.oneononedate.Name = "oneononedate";
            this.oneononedate.Size = new System.Drawing.Size(313, 26);
            this.oneononedate.TabIndex = 8;
            this.oneononedate.ValueChanged += new System.EventHandler(this.oneononedate_ValueChanged);
            this.oneononedate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.oneononedate_KeyDown);
            // 
            // discussionwith
            // 
            this.discussionwith.FormattingEnabled = true;
            this.discussionwith.HorizontalScrollbar = true;
            this.discussionwith.Location = new System.Drawing.Point(135, 106);
            this.discussionwith.Name = "discussionwith";
            this.discussionwith.Size = new System.Drawing.Size(295, 298);
            this.discussionwith.TabIndex = 7;
            // 
            // employeename
            // 
            this.employeename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeename.FormattingEnabled = true;
            this.employeename.Location = new System.Drawing.Point(402, 26);
            this.employeename.Name = "employeename";
            this.employeename.Size = new System.Drawing.Size(286, 28);
            this.employeename.TabIndex = 6;
            // 
            // requestid
            // 
            this.requestid.Location = new System.Drawing.Point(100, 23);
            this.requestid.Name = "requestid";
            this.requestid.Size = new System.Drawing.Size(162, 26);
            this.requestid.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Summary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discussion With";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "OneOneOne\r\nDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RequestID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Search by Employee Name";
            // 
            // searchby_employeename
            // 
            this.searchby_employeename.Location = new System.Drawing.Point(362, 10);
            this.searchby_employeename.Name = "searchby_employeename";
            this.searchby_employeename.Size = new System.Drawing.Size(311, 26);
            this.searchby_employeename.TabIndex = 20;
            this.searchby_employeename.TextChanged += new System.EventHandler(this.searchby_employeename_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(733, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 20);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Export to Excel";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // OneOnOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1756, 838);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.searchby_employeename);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "OneOnOne";
            this.Text = "OneOnOne";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox summary;
        private System.Windows.Forms.DateTimePicker oneononedate;
        private System.Windows.Forms.CheckedListBox discussionwith;
        private System.Windows.Forms.ComboBox employeename;
        private System.Windows.Forms.TextBox requestid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchby_employeename;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOneOnOneDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAcknowledgmentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDiscussionWith;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSummary;
    }
}