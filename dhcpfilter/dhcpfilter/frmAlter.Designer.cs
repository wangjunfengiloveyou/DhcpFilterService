namespace dhcpfilter
{
    partial class frmAlter
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
            this.gboxDetail = new System.Windows.Forms.GroupBox();
            this.txtAlterMAC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpAlterValidThru = new System.Windows.Forms.DateTimePicker();
            this.btnAlterCancel = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.dtpAlterValidFrom = new System.Windows.Forms.DateTimePicker();
            this.txtAlterDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbAlterList = new System.Windows.Forms.ComboBox();
            this.gboxDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxDetail
            // 
            this.gboxDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxDetail.Controls.Add(this.cbbAlterList);
            this.gboxDetail.Controls.Add(this.txtAlterMAC);
            this.gboxDetail.Controls.Add(this.label5);
            this.gboxDetail.Controls.Add(this.dtpAlterValidThru);
            this.gboxDetail.Controls.Add(this.btnAlterCancel);
            this.gboxDetail.Controls.Add(this.btnAlter);
            this.gboxDetail.Controls.Add(this.dtpAlterValidFrom);
            this.gboxDetail.Controls.Add(this.txtAlterDescription);
            this.gboxDetail.Controls.Add(this.label4);
            this.gboxDetail.Controls.Add(this.label8);
            this.gboxDetail.Controls.Add(this.label7);
            this.gboxDetail.Controls.Add(this.label6);
            this.gboxDetail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxDetail.ForeColor = System.Drawing.Color.White;
            this.gboxDetail.Location = new System.Drawing.Point(12, 12);
            this.gboxDetail.Name = "gboxDetail";
            this.gboxDetail.Size = new System.Drawing.Size(802, 178);
            this.gboxDetail.TabIndex = 8;
            this.gboxDetail.TabStop = false;
            this.gboxDetail.Text = "Detail";
            // 
            // txtAlterMAC
            // 
            this.txtAlterMAC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtAlterMAC.ForeColor = System.Drawing.Color.White;
            this.txtAlterMAC.Location = new System.Drawing.Point(299, 37);
            this.txtAlterMAC.MaxLength = 25;
            this.txtAlterMAC.Name = "txtAlterMAC";
            this.txtAlterMAC.Size = new System.Drawing.Size(185, 23);
            this.txtAlterMAC.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "MACAddress :";
            // 
            // dtpAlterValidThru
            // 
            this.dtpAlterValidThru.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpAlterValidThru.CustomFormat = "yyyy/MM/dd";
            this.dtpAlterValidThru.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlterValidThru.Location = new System.Drawing.Point(537, 81);
            this.dtpAlterValidThru.Name = "dtpAlterValidThru";
            this.dtpAlterValidThru.Size = new System.Drawing.Size(200, 23);
            this.dtpAlterValidThru.TabIndex = 4;
            this.dtpAlterValidThru.Value = new System.DateTime(2019, 11, 4, 14, 53, 5, 0);
            // 
            // btnAlterCancel
            // 
            this.btnAlterCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterCancel.FlatAppearance.BorderSize = 2;
            this.btnAlterCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterCancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAlterCancel.ForeColor = System.Drawing.Color.Lime;
            this.btnAlterCancel.Location = new System.Drawing.Point(510, 116);
            this.btnAlterCancel.Name = "btnAlterCancel";
            this.btnAlterCancel.Size = new System.Drawing.Size(101, 42);
            this.btnAlterCancel.TabIndex = 6;
            this.btnAlterCancel.Text = "取消";
            this.btnAlterCancel.UseVisualStyleBackColor = true;
            this.btnAlterCancel.Click += new System.EventHandler(this.btnAlterCancel_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlter.FlatAppearance.BorderSize = 2;
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAlter.ForeColor = System.Drawing.Color.Lime;
            this.btnAlter.Location = new System.Drawing.Point(225, 116);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(101, 42);
            this.btnAlter.TabIndex = 5;
            this.btnAlter.Text = "修改";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // dtpAlterValidFrom
            // 
            this.dtpAlterValidFrom.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpAlterValidFrom.CustomFormat = "yyyy/MM/dd";
            this.dtpAlterValidFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlterValidFrom.Location = new System.Drawing.Point(111, 81);
            this.dtpAlterValidFrom.Name = "dtpAlterValidFrom";
            this.dtpAlterValidFrom.Size = new System.Drawing.Size(184, 23);
            this.dtpAlterValidFrom.TabIndex = 3;
            this.dtpAlterValidFrom.Value = new System.DateTime(2019, 11, 4, 14, 53, 1, 0);
            // 
            // txtAlterDescription
            // 
            this.txtAlterDescription.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtAlterDescription.ForeColor = System.Drawing.Color.White;
            this.txtAlterDescription.Location = new System.Drawing.Point(582, 37);
            this.txtAlterDescription.MaxLength = 100;
            this.txtAlterDescription.Name = "txtAlterDescription";
            this.txtAlterDescription.Size = new System.Drawing.Size(214, 23);
            this.txtAlterDescription.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Valid Thru :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Valid From :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "List :";
            // 
            // cbbAlterList
            // 
            this.cbbAlterList.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbbAlterList.ForeColor = System.Drawing.Color.White;
            this.cbbAlterList.FormattingEnabled = true;
            this.cbbAlterList.Items.AddRange(new object[] {
            "Allow",
            "Deny"});
            this.cbbAlterList.Location = new System.Drawing.Point(65, 37);
            this.cbbAlterList.Name = "cbbAlterList";
            this.cbbAlterList.Size = new System.Drawing.Size(129, 25);
            this.cbbAlterList.TabIndex = 9;
            // 
            // frmAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(831, 207);
            this.Controls.Add(this.gboxDetail);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAlter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlter_FormClosing);
            this.Load += new System.EventHandler(this.frmAlter_Load);
            this.gboxDetail.ResumeLayout(false);
            this.gboxDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDetail;
        private System.Windows.Forms.DateTimePicker dtpAlterValidThru;
        private System.Windows.Forms.Button btnAlterCancel;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.DateTimePicker dtpAlterValidFrom;
        private System.Windows.Forms.TextBox txtAlterDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlterMAC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbAlterList;
    }
}