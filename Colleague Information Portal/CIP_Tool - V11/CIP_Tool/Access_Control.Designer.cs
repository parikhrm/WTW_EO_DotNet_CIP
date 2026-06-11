namespace CIP_Tool
{
    partial class Access_Control
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
            this.remove_admin = new System.Windows.Forms.Button();
            this.error_tracker_access = new System.Windows.Forms.CheckBox();
            this.dispute_tracker_access = new System.Windows.Forms.CheckBox();
            this.synthetic_tracker_access = new System.Windows.Forms.CheckBox();
            this.add_admin = new System.Windows.Forms.Button();
            this.admin_access = new System.Windows.Forms.CheckBox();
            this.workpulse_powerbi_admin_access = new System.Windows.Forms.CheckBox();
            this.batch_oms_bulkupload_admin_access = new System.Windows.Forms.CheckBox();
            this.cip_tool_admin_access = new System.Windows.Forms.CheckBox();
            this.batchworkflow_admin_access = new System.Windows.Forms.CheckBox();
            this.batchworkflow_L2_form_access = new System.Windows.Forms.CheckBox();
            this.maxsight_upload_tool_admin_access = new System.Windows.Forms.CheckBox();
            this.termination_tool_admin_access = new System.Windows.Forms.CheckBox();
            this.ot_tool_admin_access = new System.Windows.Forms.CheckBox();
            this.pkt_tool_admin_access = new System.Windows.Forms.CheckBox();
            this.workpulse_admin_access = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.empname = new System.Windows.Forms.ComboBox();
            this.reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "Home Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.remove_admin);
            this.groupBox1.Controls.Add(this.error_tracker_access);
            this.groupBox1.Controls.Add(this.dispute_tracker_access);
            this.groupBox1.Controls.Add(this.synthetic_tracker_access);
            this.groupBox1.Controls.Add(this.add_admin);
            this.groupBox1.Controls.Add(this.admin_access);
            this.groupBox1.Controls.Add(this.workpulse_powerbi_admin_access);
            this.groupBox1.Controls.Add(this.batch_oms_bulkupload_admin_access);
            this.groupBox1.Controls.Add(this.cip_tool_admin_access);
            this.groupBox1.Controls.Add(this.batchworkflow_admin_access);
            this.groupBox1.Controls.Add(this.batchworkflow_L2_form_access);
            this.groupBox1.Controls.Add(this.maxsight_upload_tool_admin_access);
            this.groupBox1.Controls.Add(this.termination_tool_admin_access);
            this.groupBox1.Controls.Add(this.ot_tool_admin_access);
            this.groupBox1.Controls.Add(this.pkt_tool_admin_access);
            this.groupBox1.Controls.Add(this.workpulse_admin_access);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.empname);
            this.groupBox1.Location = new System.Drawing.Point(6, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1673, 460);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Access Control";
            // 
            // remove_admin
            // 
            this.remove_admin.Location = new System.Drawing.Point(740, 35);
            this.remove_admin.Name = "remove_admin";
            this.remove_admin.Size = new System.Drawing.Size(172, 50);
            this.remove_admin.TabIndex = 17;
            this.remove_admin.Text = "Remove as Admin";
            this.remove_admin.UseVisualStyleBackColor = true;
            this.remove_admin.Click += new System.EventHandler(this.remove_admin_Click);
            // 
            // error_tracker_access
            // 
            this.error_tracker_access.AutoSize = true;
            this.error_tracker_access.Location = new System.Drawing.Point(357, 310);
            this.error_tracker_access.Name = "error_tracker_access";
            this.error_tracker_access.Size = new System.Drawing.Size(193, 24);
            this.error_tracker_access.TabIndex = 16;
            this.error_tracker_access.Text = "Error_Tracker_Access";
            this.error_tracker_access.UseVisualStyleBackColor = true;
            // 
            // dispute_tracker_access
            // 
            this.dispute_tracker_access.AutoSize = true;
            this.dispute_tracker_access.Location = new System.Drawing.Point(11, 310);
            this.dispute_tracker_access.Name = "dispute_tracker_access";
            this.dispute_tracker_access.Size = new System.Drawing.Size(213, 24);
            this.dispute_tracker_access.TabIndex = 15;
            this.dispute_tracker_access.Text = "Dispute_Tracker_Access";
            this.dispute_tracker_access.UseVisualStyleBackColor = true;
            // 
            // synthetic_tracker_access
            // 
            this.synthetic_tracker_access.AutoSize = true;
            this.synthetic_tracker_access.Location = new System.Drawing.Point(985, 247);
            this.synthetic_tracker_access.Name = "synthetic_tracker_access";
            this.synthetic_tracker_access.Size = new System.Drawing.Size(224, 24);
            this.synthetic_tracker_access.TabIndex = 14;
            this.synthetic_tracker_access.Text = "Synthetic_Tracker_Access";
            this.synthetic_tracker_access.UseVisualStyleBackColor = true;
            // 
            // add_admin
            // 
            this.add_admin.Location = new System.Drawing.Point(551, 35);
            this.add_admin.Name = "add_admin";
            this.add_admin.Size = new System.Drawing.Size(172, 50);
            this.add_admin.TabIndex = 13;
            this.add_admin.Text = "Add as Admin";
            this.add_admin.UseVisualStyleBackColor = true;
            this.add_admin.Click += new System.EventHandler(this.add_admin_Click);
            // 
            // admin_access
            // 
            this.admin_access.AutoSize = true;
            this.admin_access.Location = new System.Drawing.Point(679, 247);
            this.admin_access.Name = "admin_access";
            this.admin_access.Size = new System.Drawing.Size(141, 24);
            this.admin_access.TabIndex = 12;
            this.admin_access.Text = "Admin_Access";
            this.admin_access.UseVisualStyleBackColor = true;
            // 
            // workpulse_powerbi_admin_access
            // 
            this.workpulse_powerbi_admin_access.AutoSize = true;
            this.workpulse_powerbi_admin_access.Location = new System.Drawing.Point(357, 247);
            this.workpulse_powerbi_admin_access.Name = "workpulse_powerbi_admin_access";
            this.workpulse_powerbi_admin_access.Size = new System.Drawing.Size(295, 24);
            this.workpulse_powerbi_admin_access.TabIndex = 11;
            this.workpulse_powerbi_admin_access.Text = "WorkPulse_PowerBI_Admin_Access";
            this.workpulse_powerbi_admin_access.UseVisualStyleBackColor = true;
            // 
            // batch_oms_bulkupload_admin_access
            // 
            this.batch_oms_bulkupload_admin_access.AutoSize = true;
            this.batch_oms_bulkupload_admin_access.Location = new System.Drawing.Point(11, 247);
            this.batch_oms_bulkupload_admin_access.Name = "batch_oms_bulkupload_admin_access";
            this.batch_oms_bulkupload_admin_access.Size = new System.Drawing.Size(328, 24);
            this.batch_oms_bulkupload_admin_access.TabIndex = 10;
            this.batch_oms_bulkupload_admin_access.Text = "Batch_OMS_BulkUpload_Admin_Access";
            this.batch_oms_bulkupload_admin_access.UseVisualStyleBackColor = true;
            // 
            // cip_tool_admin_access
            // 
            this.cip_tool_admin_access.AutoSize = true;
            this.cip_tool_admin_access.Location = new System.Drawing.Point(985, 185);
            this.cip_tool_admin_access.Name = "cip_tool_admin_access";
            this.cip_tool_admin_access.Size = new System.Drawing.Size(215, 24);
            this.cip_tool_admin_access.TabIndex = 9;
            this.cip_tool_admin_access.Text = "CIP_Tool_Admin_Access";
            this.cip_tool_admin_access.UseVisualStyleBackColor = true;
            // 
            // batchworkflow_admin_access
            // 
            this.batchworkflow_admin_access.AutoSize = true;
            this.batchworkflow_admin_access.Location = new System.Drawing.Point(679, 185);
            this.batchworkflow_admin_access.Name = "batchworkflow_admin_access";
            this.batchworkflow_admin_access.Size = new System.Drawing.Size(257, 24);
            this.batchworkflow_admin_access.TabIndex = 8;
            this.batchworkflow_admin_access.Text = "BatchWorkflow_Admin_Access";
            this.batchworkflow_admin_access.UseVisualStyleBackColor = true;
            // 
            // batchworkflow_L2_form_access
            // 
            this.batchworkflow_L2_form_access.AutoSize = true;
            this.batchworkflow_L2_form_access.Location = new System.Drawing.Point(357, 185);
            this.batchworkflow_L2_form_access.Name = "batchworkflow_L2_form_access";
            this.batchworkflow_L2_form_access.Size = new System.Drawing.Size(276, 24);
            this.batchworkflow_L2_form_access.TabIndex = 7;
            this.batchworkflow_L2_form_access.Text = "BatchWorkflow_L2_Form_Access";
            this.batchworkflow_L2_form_access.UseVisualStyleBackColor = true;
            // 
            // maxsight_upload_tool_admin_access
            // 
            this.maxsight_upload_tool_admin_access.AutoSize = true;
            this.maxsight_upload_tool_admin_access.Location = new System.Drawing.Point(10, 185);
            this.maxsight_upload_tool_admin_access.Name = "maxsight_upload_tool_admin_access";
            this.maxsight_upload_tool_admin_access.Size = new System.Drawing.Size(312, 24);
            this.maxsight_upload_tool_admin_access.TabIndex = 6;
            this.maxsight_upload_tool_admin_access.Text = "Maxsight_Upload_Tool_Admin_Access";
            this.maxsight_upload_tool_admin_access.UseVisualStyleBackColor = true;
            // 
            // termination_tool_admin_access
            // 
            this.termination_tool_admin_access.AutoSize = true;
            this.termination_tool_admin_access.Location = new System.Drawing.Point(985, 127);
            this.termination_tool_admin_access.Name = "termination_tool_admin_access";
            this.termination_tool_admin_access.Size = new System.Drawing.Size(272, 24);
            this.termination_tool_admin_access.TabIndex = 5;
            this.termination_tool_admin_access.Text = "Termination_Tool_Admin_Access";
            this.termination_tool_admin_access.UseVisualStyleBackColor = true;
            // 
            // ot_tool_admin_access
            // 
            this.ot_tool_admin_access.AutoSize = true;
            this.ot_tool_admin_access.Location = new System.Drawing.Point(679, 127);
            this.ot_tool_admin_access.Name = "ot_tool_admin_access";
            this.ot_tool_admin_access.Size = new System.Drawing.Size(210, 24);
            this.ot_tool_admin_access.TabIndex = 4;
            this.ot_tool_admin_access.Text = "OT_Tool_Admin_Access";
            this.ot_tool_admin_access.UseVisualStyleBackColor = true;
            // 
            // pkt_tool_admin_access
            // 
            this.pkt_tool_admin_access.AutoSize = true;
            this.pkt_tool_admin_access.Location = new System.Drawing.Point(357, 127);
            this.pkt_tool_admin_access.Name = "pkt_tool_admin_access";
            this.pkt_tool_admin_access.Size = new System.Drawing.Size(218, 24);
            this.pkt_tool_admin_access.TabIndex = 3;
            this.pkt_tool_admin_access.Text = "PKT_Tool_Admin_Access";
            this.pkt_tool_admin_access.UseVisualStyleBackColor = true;
            // 
            // workpulse_admin_access
            // 
            this.workpulse_admin_access.AutoSize = true;
            this.workpulse_admin_access.Location = new System.Drawing.Point(10, 127);
            this.workpulse_admin_access.Name = "workpulse_admin_access";
            this.workpulse_admin_access.Size = new System.Drawing.Size(216, 24);
            this.workpulse_admin_access.TabIndex = 2;
            this.workpulse_admin_access.Text = "WorkPulse Admin Access";
            this.workpulse_admin_access.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emp Name";
            // 
            // empname
            // 
            this.empname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empname.FormattingEnabled = true;
            this.empname.Location = new System.Drawing.Point(164, 44);
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(336, 28);
            this.empname.TabIndex = 0;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(492, 372);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(172, 50);
            this.reset.TabIndex = 18;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Access_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1765, 760);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Access_Control";
            this.Text = "Access_Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Access_Control_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox empname;
        private System.Windows.Forms.CheckBox pkt_tool_admin_access;
        private System.Windows.Forms.CheckBox workpulse_admin_access;
        private System.Windows.Forms.CheckBox maxsight_upload_tool_admin_access;
        private System.Windows.Forms.CheckBox termination_tool_admin_access;
        private System.Windows.Forms.CheckBox ot_tool_admin_access;
        private System.Windows.Forms.CheckBox batchworkflow_L2_form_access;
        private System.Windows.Forms.CheckBox cip_tool_admin_access;
        private System.Windows.Forms.CheckBox batchworkflow_admin_access;
        private System.Windows.Forms.CheckBox batch_oms_bulkupload_admin_access;
        private System.Windows.Forms.CheckBox workpulse_powerbi_admin_access;
        private System.Windows.Forms.CheckBox admin_access;
        private System.Windows.Forms.Button add_admin;
        private System.Windows.Forms.CheckBox synthetic_tracker_access;
        private System.Windows.Forms.CheckBox dispute_tracker_access;
        private System.Windows.Forms.CheckBox error_tracker_access;
        private System.Windows.Forms.Button remove_admin;
        private System.Windows.Forms.Button reset;
    }
}