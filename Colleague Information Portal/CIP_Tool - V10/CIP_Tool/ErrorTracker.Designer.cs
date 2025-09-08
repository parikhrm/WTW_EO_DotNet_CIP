namespace CIP_Tool
{
    partial class ErrorTracker
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
            this.button4 = new System.Windows.Forms.Button();
            this.searchbyassociatename = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.completionmonth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAcknowledge = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtRaisedForDispute = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtDisputeResolvedStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQualityCheckerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtErrorDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAssociateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPartyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrincipalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTypeofError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNoofCriticalErrors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNoofMinorErrors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBreaches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTypeofBreaches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAcknowledged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQualityParameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.searchbyassociatename);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.completionmonth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(388, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1056, 149);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(810, 29);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 52);
            this.button4.TabIndex = 69;
            this.button4.Text = "Raise for Dispute";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // searchbyassociatename
            // 
            this.searchbyassociatename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchbyassociatename.FormattingEnabled = true;
            this.searchbyassociatename.Location = new System.Drawing.Point(311, 25);
            this.searchbyassociatename.Name = "searchbyassociatename";
            this.searchbyassociatename.Size = new System.Drawing.Size(278, 28);
            this.searchbyassociatename.TabIndex = 68;
            this.searchbyassociatename.SelectedIndexChanged += new System.EventHandler(this.searchbyassociatename_SelectedIndexChanged);
            this.searchbyassociatename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchbyassociatename_KeyDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(622, 27);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 54);
            this.button3.TabIndex = 67;
            this.button3.Text = "Acknowledge";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Month";
            // 
            // completionmonth
            // 
            this.completionmonth.CalendarTitleBackColor = System.Drawing.Color.Purple;
            this.completionmonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.completionmonth.Location = new System.Drawing.Point(56, 27);
            this.completionmonth.Name = "completionmonth";
            this.completionmonth.Size = new System.Drawing.Size(200, 26);
            this.completionmonth.TabIndex = 10;
            this.completionmonth.ValueChanged += new System.EventHandler(this.completionmonth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search by Associate Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Export to Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 34);
            this.button2.TabIndex = 70;
            this.button2.Text = "Home Page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtAcknowledge,
            this.txtRaisedForDispute,
            this.txtDisputeResolvedStatus,
            this.txtRequestID,
            this.txtQualityCheckerName,
            this.txtErrorDate,
            this.txtAssociateName,
            this.txtPartyName,
            this.txtPrincipalName,
            this.txtTypeofError,
            this.txtNoofCriticalErrors,
            this.txtNoofMinorErrors,
            this.txtComments,
            this.txtBreaches,
            this.txtTypeofBreaches,
            this.txtAcknowledged,
            this.txtQualityParameters});
            this.dataGridView1.Location = new System.Drawing.Point(89, 184);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1568, 758);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // txtAcknowledge
            // 
            this.txtAcknowledge.HeaderText = "Acknowledge";
            this.txtAcknowledge.Name = "txtAcknowledge";
            this.txtAcknowledge.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtAcknowledge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtRaisedForDispute
            // 
            this.txtRaisedForDispute.DataPropertyName = "RaisedForDispute";
            this.txtRaisedForDispute.HeaderText = "RaisedForDispute";
            this.txtRaisedForDispute.Name = "txtRaisedForDispute";
            this.txtRaisedForDispute.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtRaisedForDispute.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtDisputeResolvedStatus
            // 
            this.txtDisputeResolvedStatus.DataPropertyName = "DisputeResolvedStatus";
            this.txtDisputeResolvedStatus.HeaderText = "DisputeResolvedStatus (Editable)";
            this.txtDisputeResolvedStatus.Name = "txtDisputeResolvedStatus";
            this.txtDisputeResolvedStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtDisputeResolvedStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtRequestID
            // 
            this.txtRequestID.DataPropertyName = "RequestID";
            this.txtRequestID.HeaderText = "RequestID";
            this.txtRequestID.Name = "txtRequestID";
            // 
            // txtQualityCheckerName
            // 
            this.txtQualityCheckerName.DataPropertyName = "QualityCheckerName";
            this.txtQualityCheckerName.HeaderText = "QualityCheckerName";
            this.txtQualityCheckerName.Name = "txtQualityCheckerName";
            // 
            // txtErrorDate
            // 
            this.txtErrorDate.DataPropertyName = "ErrorDate";
            this.txtErrorDate.HeaderText = "ErrorDate";
            this.txtErrorDate.Name = "txtErrorDate";
            // 
            // txtAssociateName
            // 
            this.txtAssociateName.DataPropertyName = "AssociateName";
            this.txtAssociateName.HeaderText = "AssociateName";
            this.txtAssociateName.Name = "txtAssociateName";
            // 
            // txtPartyName
            // 
            this.txtPartyName.DataPropertyName = "PartyName";
            this.txtPartyName.HeaderText = "PartyName";
            this.txtPartyName.Name = "txtPartyName";
            // 
            // txtPrincipalName
            // 
            this.txtPrincipalName.DataPropertyName = "PrincipalName";
            this.txtPrincipalName.HeaderText = "PrincipalName";
            this.txtPrincipalName.Name = "txtPrincipalName";
            // 
            // txtTypeofError
            // 
            this.txtTypeofError.DataPropertyName = "TypeofError";
            this.txtTypeofError.HeaderText = "TypeofError";
            this.txtTypeofError.Name = "txtTypeofError";
            // 
            // txtNoofCriticalErrors
            // 
            this.txtNoofCriticalErrors.DataPropertyName = "NoofCriticalErrors";
            this.txtNoofCriticalErrors.HeaderText = "NoofCriticalErrors";
            this.txtNoofCriticalErrors.Name = "txtNoofCriticalErrors";
            // 
            // txtNoofMinorErrors
            // 
            this.txtNoofMinorErrors.DataPropertyName = "NoofMinorErrors";
            this.txtNoofMinorErrors.HeaderText = "NoofMinorErrors";
            this.txtNoofMinorErrors.Name = "txtNoofMinorErrors";
            // 
            // txtComments
            // 
            this.txtComments.DataPropertyName = "Comments";
            this.txtComments.HeaderText = "Comments (Editable)";
            this.txtComments.Name = "txtComments";
            // 
            // txtBreaches
            // 
            this.txtBreaches.DataPropertyName = "Breaches";
            this.txtBreaches.HeaderText = "Breaches";
            this.txtBreaches.Name = "txtBreaches";
            // 
            // txtTypeofBreaches
            // 
            this.txtTypeofBreaches.DataPropertyName = "TypeofBreaches";
            this.txtTypeofBreaches.HeaderText = "TypeofBreaches";
            this.txtTypeofBreaches.Name = "txtTypeofBreaches";
            // 
            // txtAcknowledged
            // 
            this.txtAcknowledged.DataPropertyName = "Acknowledged";
            this.txtAcknowledged.HeaderText = "Acknowledged";
            this.txtAcknowledged.Name = "txtAcknowledged";
            this.txtAcknowledged.Visible = false;
            // 
            // txtQualityParameters
            // 
            this.txtQualityParameters.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.txtQualityParameters.DataPropertyName = "QualityParameters";
            this.txtQualityParameters.HeaderText = "QualityParameters";
            this.txtQualityParameters.Name = "txtQualityParameters";
            this.txtQualityParameters.Width = 521;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1493, 14);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(123, 149);
            this.dataGridView2.TabIndex = 72;
            // 
            // ErrorTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1754, 1024);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ErrorTracker";
            this.Text = "ErrorTracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ErrorTracker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker completionmonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox searchbyassociatename;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn txtAcknowledge;
        private System.Windows.Forms.DataGridViewComboBoxColumn txtRaisedForDispute;
        private System.Windows.Forms.DataGridViewComboBoxColumn txtDisputeResolvedStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQualityCheckerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtErrorDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAssociateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPartyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrincipalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTypeofError;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNoofCriticalErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNoofMinorErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBreaches;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTypeofBreaches;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAcknowledged;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQualityParameters;
    }
}