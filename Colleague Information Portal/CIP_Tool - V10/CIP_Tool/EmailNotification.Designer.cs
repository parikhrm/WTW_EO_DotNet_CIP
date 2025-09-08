namespace CIP_Tool
{
    partial class EmailNotification
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
            this.attachment_path = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.RichTextBox();
            this.requestid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.from_names = new System.Windows.Forms.ComboBox();
            this.to_names = new System.Windows.Forms.ComboBox();
            this.reset = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.subject = new System.Windows.Forms.TextBox();
            this.cc_names = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.attachment_path);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.message);
            this.groupBox1.Controls.Add(this.requestid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.from_names);
            this.groupBox1.Controls.Add(this.to_names);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.send);
            this.groupBox1.Controls.Add(this.subject);
            this.groupBox1.Controls.Add(this.cc_names);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1742, 947);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // attachment_path
            // 
            this.attachment_path.Location = new System.Drawing.Point(110, 274);
            this.attachment_path.Multiline = true;
            this.attachment_path.Name = "attachment_path";
            this.attachment_path.Size = new System.Drawing.Size(1008, 32);
            this.attachment_path.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 32);
            this.button4.TabIndex = 15;
            this.button4.Text = "Attachment";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // message
            // 
            this.message.AutoWordSelection = true;
            this.message.Location = new System.Drawing.Point(109, 332);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(1569, 501);
            this.message.TabIndex = 7;
            this.message.Text = "";
            // 
            // requestid
            // 
            this.requestid.Location = new System.Drawing.Point(1239, 273);
            this.requestid.Name = "requestid";
            this.requestid.Size = new System.Drawing.Size(204, 26);
            this.requestid.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1146, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "RequestID";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1465, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "Populate email format";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "From:";
            // 
            // from_names
            // 
            this.from_names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.from_names.FormattingEnabled = true;
            this.from_names.Location = new System.Drawing.Point(109, 47);
            this.from_names.Name = "from_names";
            this.from_names.Size = new System.Drawing.Size(652, 28);
            this.from_names.TabIndex = 0;
            // 
            // to_names
            // 
            this.to_names.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.to_names.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.to_names.FormattingEnabled = true;
            this.to_names.Location = new System.Drawing.Point(109, 92);
            this.to_names.Name = "to_names";
            this.to_names.Size = new System.Drawing.Size(652, 28);
            this.to_names.TabIndex = 1;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(797, 854);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(239, 59);
            this.reset.TabIndex = 9;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(441, 857);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(239, 59);
            this.send.TabIndex = 8;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(109, 197);
            this.subject.Multiline = true;
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(1569, 60);
            this.subject.TabIndex = 3;
            // 
            // cc_names
            // 
            this.cc_names.Location = new System.Drawing.Point(109, 139);
            this.cc_names.Multiline = true;
            this.cc_names.Name = "cc_names";
            this.cc_names.Size = new System.Drawing.Size(1569, 39);
            this.cc_names.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmailNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 1050);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmailNotification";
            this.Text = "EmailNotification";
            this.Load += new System.EventHandler(this.EmailNotification_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox attachment_path;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox message;
        private System.Windows.Forms.TextBox requestid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox from_names;
        private System.Windows.Forms.ComboBox to_names;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox cc_names;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}