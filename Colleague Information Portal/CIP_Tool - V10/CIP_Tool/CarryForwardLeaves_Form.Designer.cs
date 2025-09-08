namespace CIP_Tool
{
    partial class CarryForwardLeaves_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.empname_insert = new System.Windows.Forms.CheckedListBox();
            this.reportingmanager_insert = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.carryforwardleaves_insert = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.adminlevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchby_reportingmanager = new System.Windows.Forms.ComboBox();
            this.searchby_year = new System.Windows.Forms.TextBox();
            this.txtRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmpName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNoOfCarryForwardLeaves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carryforwardleaves_insert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.empname_insert);
            this.groupBox1.Controls.Add(this.reportingmanager_insert);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.year);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.carryforwardleaves_insert);
            this.groupBox1.Location = new System.Drawing.Point(13, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(496, 557);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert New Records";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 123);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 24);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Select  All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // empname_insert
            // 
            this.empname_insert.CheckOnClick = true;
            this.empname_insert.FormattingEnabled = true;
            this.empname_insert.Location = new System.Drawing.Point(158, 91);
            this.empname_insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empname_insert.Name = "empname_insert";
            this.empname_insert.Size = new System.Drawing.Size(316, 235);
            this.empname_insert.TabIndex = 18;
            // 
            // reportingmanager_insert
            // 
            this.reportingmanager_insert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportingmanager_insert.FormattingEnabled = true;
            this.reportingmanager_insert.Location = new System.Drawing.Point(158, 39);
            this.reportingmanager_insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportingmanager_insert.Name = "reportingmanager_insert";
            this.reportingmanager_insert.Size = new System.Drawing.Size(316, 28);
            this.reportingmanager_insert.TabIndex = 17;
            this.reportingmanager_insert.SelectedIndexChanged += new System.EventHandler(this.reportingmanager_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Reporting Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Associate Name";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(194, 479);
            this.reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(112, 54);
            this.reset.TabIndex = 13;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(158, 365);
            this.year.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(180, 26);
            this.year.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 365);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(51, 479);
            this.insert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(112, 54);
            this.insert.TabIndex = 10;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 417);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "No of Brought \r\nForward Leaves";
            // 
            // carryforwardleaves_insert
            // 
            this.carryforwardleaves_insert.Location = new System.Drawing.Point(158, 417);
            this.carryforwardleaves_insert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carryforwardleaves_insert.Name = "carryforwardleaves_insert";
            this.carryforwardleaves_insert.Size = new System.Drawing.Size(180, 26);
            this.carryforwardleaves_insert.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1261, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 52);
            this.button2.TabIndex = 25;
            this.button2.Text = "Export to Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtRequestID,
            this.txtEmpName,
            this.txtYear,
            this.txtNoOfCarryForwardLeaves});
            this.dataGridView2.Location = new System.Drawing.Point(546, 93);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(870, 718);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView2_UserDeletingRow);
            // 
            // adminlevel
            // 
            this.adminlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adminlevel.FormattingEnabled = true;
            this.adminlevel.Location = new System.Drawing.Point(190, 14);
            this.adminlevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminlevel.Name = "adminlevel";
            this.adminlevel.Size = new System.Drawing.Size(191, 28);
            this.adminlevel.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(872, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Search by Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Search by Reporting Manager";
            // 
            // searchby_reportingmanager
            // 
            this.searchby_reportingmanager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchby_reportingmanager.FormattingEnabled = true;
            this.searchby_reportingmanager.Location = new System.Drawing.Point(546, 12);
            this.searchby_reportingmanager.Name = "searchby_reportingmanager";
            this.searchby_reportingmanager.Size = new System.Drawing.Size(268, 28);
            this.searchby_reportingmanager.TabIndex = 31;
            this.searchby_reportingmanager.SelectedIndexChanged += new System.EventHandler(this.searchby_reportingmanager_SelectedIndexChanged);
            // 
            // searchby_year
            // 
            this.searchby_year.Location = new System.Drawing.Point(850, 12);
            this.searchby_year.Name = "searchby_year";
            this.searchby_year.Size = new System.Drawing.Size(162, 26);
            this.searchby_year.TabIndex = 32;
            this.searchby_year.TextChanged += new System.EventHandler(this.searchby_year_TextChanged);
            // 
            // txtRequestID
            // 
            this.txtRequestID.DataPropertyName = "RequestID";
            this.txtRequestID.HeaderText = "RequestID";
            this.txtRequestID.Name = "txtRequestID";
            // 
            // txtEmpName
            // 
            this.txtEmpName.DataPropertyName = "EmpName";
            this.txtEmpName.HeaderText = "(Editable)EmpName";
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtEmpName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.txtEmpName.Width = 150;
            // 
            // txtYear
            // 
            this.txtYear.DataPropertyName = "Year";
            this.txtYear.HeaderText = "(Editable)Year";
            this.txtYear.Name = "txtYear";
            // 
            // txtNoOfCarryForwardLeaves
            // 
            this.txtNoOfCarryForwardLeaves.DataPropertyName = "NoOfCarryForwardLeaves";
            this.txtNoOfCarryForwardLeaves.HeaderText = "(Editable)BroughtForwardLeaves";
            this.txtNoOfCarryForwardLeaves.Name = "txtNoOfCarryForwardLeaves";
            this.txtNoOfCarryForwardLeaves.Width = 140;
            // 
            // CarryForwardLeaves_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.searchby_year);
            this.Controls.Add(this.searchby_reportingmanager);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adminlevel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "CarryForwardLeaves_Form";
            this.Text = "BroughtForwardLeaves";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CarryForwardLeaves_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carryforwardleaves_insert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckedListBox empname_insert;
        private System.Windows.Forms.ComboBox reportingmanager_insert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown carryforwardleaves_insert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox adminlevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox searchby_reportingmanager;
        private System.Windows.Forms.TextBox searchby_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRequestID;
        private System.Windows.Forms.DataGridViewComboBoxColumn txtEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNoOfCarryForwardLeaves;
    }
}