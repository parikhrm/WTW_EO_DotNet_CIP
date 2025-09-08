namespace CIP_Tool
{
    partial class OneOnOneEmp
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
            this.label1 = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.TextBox();
            this.iacknowledge = new System.Windows.Forms.CheckBox();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.requestid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOneOnOneDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAcknowledgmentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiscussionWith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminlevel = new System.Windows.Forms.ComboBox();
            this.searchby_month = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Home Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Read your comments and acknowledge the same";
            // 
            // summary
            // 
            this.summary.Location = new System.Drawing.Point(11, 168);
            this.summary.Multiline = true;
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(390, 168);
            this.summary.TabIndex = 20;
            // 
            // iacknowledge
            // 
            this.iacknowledge.AutoSize = true;
            this.iacknowledge.Location = new System.Drawing.Point(12, 351);
            this.iacknowledge.Name = "iacknowledge";
            this.iacknowledge.Size = new System.Drawing.Size(139, 24);
            this.iacknowledge.TabIndex = 21;
            this.iacknowledge.Text = "I Acknowledge";
            this.iacknowledge.UseVisualStyleBackColor = true;
            this.iacknowledge.CheckedChanged += new System.EventHandler(this.iacknowledge_CheckedChanged);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Purple;
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(12, 402);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(97, 39);
            this.save.TabIndex = 22;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "RequestID";
            // 
            // requestid
            // 
            this.requestid.Location = new System.Drawing.Point(107, 67);
            this.requestid.Name = "requestid";
            this.requestid.Size = new System.Drawing.Size(158, 26);
            this.requestid.TabIndex = 24;
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
            this.dataGridView1.Location = new System.Drawing.Point(432, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 692);
            this.dataGridView1.TabIndex = 25;
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
            this.txtSummary.Visible = false;
            this.txtSummary.Width = 200;
            // 
            // adminlevel
            // 
            this.adminlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adminlevel.FormattingEnabled = true;
            this.adminlevel.Location = new System.Drawing.Point(1165, 14);
            this.adminlevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminlevel.Name = "adminlevel";
            this.adminlevel.Size = new System.Drawing.Size(180, 28);
            this.adminlevel.TabIndex = 38;
            // 
            // searchby_month
            // 
            this.searchby_month.CustomFormat = " ";
            this.searchby_month.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchby_month.Location = new System.Drawing.Point(490, 26);
            this.searchby_month.Name = "searchby_month";
            this.searchby_month.Size = new System.Drawing.Size(268, 26);
            this.searchby_month.TabIndex = 39;
            this.searchby_month.ValueChanged += new System.EventHandler(this.searchby_month_ValueChanged);
            this.searchby_month.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchby_month_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Search by Month";
            // 
            // OneOnOneEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1773, 828);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchby_month);
            this.Controls.Add(this.adminlevel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.requestid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.iacknowledge);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "OneOnOneEmp";
            this.Text = "OneOnOneEmp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox summary;
        private System.Windows.Forms.CheckBox iacknowledge;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox requestid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOneOnOneDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAcknowledgmentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDiscussionWith;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSummary;
        private System.Windows.Forms.ComboBox adminlevel;
        private System.Windows.Forms.DateTimePicker searchby_month;
        private System.Windows.Forms.Label label3;
    }
}