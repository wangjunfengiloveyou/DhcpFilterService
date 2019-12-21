namespace dhcpfilter
{
    partial class frmAdd
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
            this.cbbAddList = new System.Windows.Forms.ComboBox();
            this.dtpAddThru = new System.Windows.Forms.DateTimePicker();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpAddFrom = new System.Windows.Forms.DateTimePicker();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddMAC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gboxDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxDetail
            // 
            this.gboxDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxDetail.Controls.Add(this.cbbAddList);
            this.gboxDetail.Controls.Add(this.dtpAddThru);
            this.gboxDetail.Controls.Add(this.btnAddCancel);
            this.gboxDetail.Controls.Add(this.btnAdd);
            this.gboxDetail.Controls.Add(this.dtpAddFrom);
            this.gboxDetail.Controls.Add(this.txtAddDescription);
            this.gboxDetail.Controls.Add(this.txtAddMAC);
            this.gboxDetail.Controls.Add(this.label4);
            this.gboxDetail.Controls.Add(this.label5);
            this.gboxDetail.Controls.Add(this.label8);
            this.gboxDetail.Controls.Add(this.label7);
            this.gboxDetail.Controls.Add(this.label6);
            this.gboxDetail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxDetail.ForeColor = System.Drawing.Color.White;
            this.gboxDetail.Location = new System.Drawing.Point(12, 12);
            this.gboxDetail.Name = "gboxDetail";
            this.gboxDetail.Size = new System.Drawing.Size(802, 178);
            this.gboxDetail.TabIndex = 9;
            this.gboxDetail.TabStop = false;
            this.gboxDetail.Text = "Detail";
            // 
            // cbbAddList
            // 
            this.cbbAddList.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbbAddList.ForeColor = System.Drawing.Color.White;
            this.cbbAddList.FormattingEnabled = true;
            this.cbbAddList.Items.AddRange(new object[] {
            "Allow",
            "Deny"});
            this.cbbAddList.Location = new System.Drawing.Point(65, 37);
            this.cbbAddList.Name = "cbbAddList";
            this.cbbAddList.Size = new System.Drawing.Size(108, 25);
            this.cbbAddList.TabIndex = 7;
            // 
            // dtpAddThru
            // 
            this.dtpAddThru.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpAddThru.CustomFormat = "yyyy/MM/dd";
            this.dtpAddThru.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAddThru.Location = new System.Drawing.Point(537, 81);
            this.dtpAddThru.Name = "dtpAddThru";
            this.dtpAddThru.Size = new System.Drawing.Size(200, 23);
            this.dtpAddThru.TabIndex = 4;
            this.dtpAddThru.Value = new System.DateTime(2019, 11, 4, 14, 53, 5, 0);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddCancel.FlatAppearance.BorderSize = 2;
            this.btnAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddCancel.ForeColor = System.Drawing.Color.Lime;
            this.btnAddCancel.Location = new System.Drawing.Point(510, 116);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(101, 42);
            this.btnAddCancel.TabIndex = 6;
            this.btnAddCancel.Text = "取消";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(225, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 42);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpAddFrom
            // 
            this.dtpAddFrom.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpAddFrom.CustomFormat = "yyyy/MM/dd";
            this.dtpAddFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAddFrom.Location = new System.Drawing.Point(111, 81);
            this.dtpAddFrom.Name = "dtpAddFrom";
            this.dtpAddFrom.Size = new System.Drawing.Size(184, 23);
            this.dtpAddFrom.TabIndex = 3;
            this.dtpAddFrom.Value = new System.DateTime(2019, 11, 4, 14, 53, 1, 0);
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtAddDescription.ForeColor = System.Drawing.Color.White;
            this.txtAddDescription.Location = new System.Drawing.Point(582, 37);
            this.txtAddDescription.MaxLength = 100;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(214, 23);
            this.txtAddDescription.TabIndex = 2;
            // 
            // txtAddMAC
            // 
            this.txtAddMAC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtAddMAC.ForeColor = System.Drawing.Color.White;
            this.txtAddMAC.Location = new System.Drawing.Point(278, 37);
            this.txtAddMAC.MaxLength = 25;
            this.txtAddMAC.Name = "txtAddMAC";
            this.txtAddMAC.Size = new System.Drawing.Size(197, 23);
            this.txtAddMAC.TabIndex = 1;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "MACAddress :";
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
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(831, 207);
            this.Controls.Add(this.gboxDetail);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdd_FormClosing);
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.gboxDetail.ResumeLayout(false);
            this.gboxDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDetail;
        private System.Windows.Forms.DateTimePicker dtpAddThru;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpAddFrom;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.TextBox txtAddMAC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbAddList;
    }
}