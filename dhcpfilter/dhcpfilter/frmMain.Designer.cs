namespace dhcpfilter
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gboxQuery = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtQueryDescription = new System.Windows.Forms.TextBox();
            this.txtQueryMAC = new System.Windows.Forms.TextBox();
            this.dtpQueryThru = new System.Windows.Forms.DateTimePicker();
            this.dtpQueryFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.LIST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALIDFROM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALIDTHRU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.smtcAuthDataSet = new dhcpfilter.SmtcAuthDataSet();
            this.dhcpFilterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dhcpFilterTableAdapter = new dhcpfilter.SmtcAuthDataSetTableAdapters.DhcpFilterTableAdapter();
            this.cbbList = new System.Windows.Forms.ComboBox();
            this.gboxQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smtcAuthDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dhcpFilterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxQuery
            // 
            this.gboxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxQuery.Controls.Add(this.cbbList);
            this.gboxQuery.Controls.Add(this.btnSearch);
            this.gboxQuery.Controls.Add(this.txtQueryDescription);
            this.gboxQuery.Controls.Add(this.txtQueryMAC);
            this.gboxQuery.Controls.Add(this.dtpQueryThru);
            this.gboxQuery.Controls.Add(this.dtpQueryFrom);
            this.gboxQuery.Controls.Add(this.label3);
            this.gboxQuery.Controls.Add(this.label4);
            this.gboxQuery.Controls.Add(this.label2);
            this.gboxQuery.Controls.Add(this.label9);
            this.gboxQuery.Controls.Add(this.label1);
            this.gboxQuery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxQuery.ForeColor = System.Drawing.Color.White;
            this.gboxQuery.Location = new System.Drawing.Point(13, 11);
            this.gboxQuery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxQuery.Name = "gboxQuery";
            this.gboxQuery.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxQuery.Size = new System.Drawing.Size(868, 113);
            this.gboxQuery.TabIndex = 9;
            this.gboxQuery.TabStop = false;
            this.gboxQuery.Text = "信息查询";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ForeColor = System.Drawing.Color.Lime;
            this.btnSearch.Location = new System.Drawing.Point(717, 74);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 34);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtQueryDescription
            // 
            this.txtQueryDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueryDescription.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtQueryDescription.ForeColor = System.Drawing.Color.White;
            this.txtQueryDescription.Location = new System.Drawing.Point(579, 37);
            this.txtQueryDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQueryDescription.MaxLength = 100;
            this.txtQueryDescription.Name = "txtQueryDescription";
            this.txtQueryDescription.Size = new System.Drawing.Size(254, 23);
            this.txtQueryDescription.TabIndex = 1;
            // 
            // txtQueryMAC
            // 
            this.txtQueryMAC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtQueryMAC.ForeColor = System.Drawing.Color.White;
            this.txtQueryMAC.Location = new System.Drawing.Point(308, 37);
            this.txtQueryMAC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQueryMAC.MaxLength = 25;
            this.txtQueryMAC.Name = "txtQueryMAC";
            this.txtQueryMAC.Size = new System.Drawing.Size(169, 23);
            this.txtQueryMAC.TabIndex = 1;
            // 
            // dtpQueryThru
            // 
            this.dtpQueryThru.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpQueryThru.CustomFormat = "yyyy-MM-dd";
            this.dtpQueryThru.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpQueryThru.Location = new System.Drawing.Point(508, 76);
            this.dtpQueryThru.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpQueryThru.Name = "dtpQueryThru";
            this.dtpQueryThru.Size = new System.Drawing.Size(144, 23);
            this.dtpQueryThru.TabIndex = 3;
            this.dtpQueryThru.Value = new System.DateTime(2019, 11, 7, 0, 0, 0, 0);
            // 
            // dtpQueryFrom
            // 
            this.dtpQueryFrom.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpQueryFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpQueryFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpQueryFrom.Location = new System.Drawing.Point(123, 76);
            this.dtpQueryFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpQueryFrom.Name = "dtpQueryFrom";
            this.dtpQueryFrom.Size = new System.Drawing.Size(144, 23);
            this.dtpQueryFrom.TabIndex = 3;
            this.dtpQueryFrom.Value = new System.DateTime(2019, 11, 7, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "ValidThru :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "MACAddress :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "ValidFrom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "List :";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LIST,
            this.MACADDRESS,
            this.DESCRIPTION,
            this.VALIDFROM,
            this.VALIDTHRU});
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.Color.Gold;
            this.dgvData.Location = new System.Drawing.Point(13, 142);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(747, 414);
            this.dgvData.TabIndex = 11;
            // 
            // LIST
            // 
            this.LIST.DataPropertyName = "LIST";
            this.LIST.HeaderText = "LIST";
            this.LIST.Name = "LIST";
            this.LIST.ReadOnly = true;
            // 
            // MACADDRESS
            // 
            this.MACADDRESS.DataPropertyName = "MACADDRESS";
            this.MACADDRESS.HeaderText = "MACADDRESS";
            this.MACADDRESS.Name = "MACADDRESS";
            this.MACADDRESS.ReadOnly = true;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.DataPropertyName = "DESCRIPTION";
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.ReadOnly = true;
            // 
            // VALIDFROM
            // 
            this.VALIDFROM.DataPropertyName = "VALIDFROM";
            this.VALIDFROM.HeaderText = "VALIDFROM";
            this.VALIDFROM.Name = "VALIDFROM";
            this.VALIDFROM.ReadOnly = true;
            // 
            // VALIDTHRU
            // 
            this.VALIDTHRU.DataPropertyName = "VALIDTHRU";
            this.VALIDTHRU.HeaderText = "VALIDTHRU";
            this.VALIDTHRU.Name = "VALIDTHRU";
            this.VALIDTHRU.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.Lime;
            this.btnDelete.Location = new System.Drawing.Point(767, 351);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 54);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlter.FlatAppearance.BorderSize = 2;
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAlter.ForeColor = System.Drawing.Color.Lime;
            this.btnAlter.Location = new System.Drawing.Point(767, 280);
            this.btnAlter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(116, 54);
            this.btnAlter.TabIndex = 16;
            this.btnAlter.Text = "修改";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImport.FlatAppearance.BorderSize = 2;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImport.ForeColor = System.Drawing.Color.Lime;
            this.btnImport.Location = new System.Drawing.Point(767, 142);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(116, 54);
            this.btnImport.TabIndex = 14;
            this.btnImport.Text = "上传文件";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(767, 211);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 54);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // smtcAuthDataSet
            // 
            this.smtcAuthDataSet.DataSetName = "SmtcAuthDataSet";
            this.smtcAuthDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dhcpFilterBindingSource
            // 
            this.dhcpFilterBindingSource.DataMember = "DhcpFilter";
            this.dhcpFilterBindingSource.DataSource = this.smtcAuthDataSet;
            // 
            // dhcpFilterTableAdapter
            // 
            this.dhcpFilterTableAdapter.ClearBeforeFill = true;
            // 
            // cbbList
            // 
            this.cbbList.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbbList.ForeColor = System.Drawing.Color.White;
            this.cbbList.FormattingEnabled = true;
            this.cbbList.Items.AddRange(new object[] {
            "Allow",
            "Deny"});
            this.cbbList.Location = new System.Drawing.Point(59, 37);
            this.cbbList.Name = "cbbList";
            this.cbbList.Size = new System.Drawing.Size(130, 25);
            this.cbbList.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(909, 567);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.gboxQuery);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DhcpFilterManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.gboxQuery.ResumeLayout(false);
            this.gboxQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smtcAuthDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dhcpFilterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxQuery;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtQueryDescription;
        private System.Windows.Forms.TextBox txtQueryMAC;
        private System.Windows.Forms.DateTimePicker dtpQueryThru;
        private System.Windows.Forms.DateTimePicker dtpQueryFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.DataGridView dgvData;
        private SmtcAuthDataSet smtcAuthDataSet;
        private System.Windows.Forms.BindingSource dhcpFilterBindingSource;
        private SmtcAuthDataSetTableAdapters.DhcpFilterTableAdapter dhcpFilterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIST;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALIDFROM;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALIDTHRU;
        private System.Windows.Forms.ComboBox cbbList;
    }
}

