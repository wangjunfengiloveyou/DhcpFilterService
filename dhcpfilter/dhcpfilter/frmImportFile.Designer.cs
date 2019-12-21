namespace dhcpfilter
{
    partial class frmImportFile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFileData = new System.Windows.Forms.DataGridView();
            this.List = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MacAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidThru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnUploadToDatabase = new System.Windows.Forms.Button();
            this.btnImportCancel = new System.Windows.Forms.Button();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFileData
            // 
            this.dgvFileData.AllowUserToAddRows = false;
            this.dgvFileData.AllowUserToDeleteRows = false;
            this.dgvFileData.AllowUserToResizeRows = false;
            this.dgvFileData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFileData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFileData.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dgvFileData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFileData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFileData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.List,
            this.MacAddress,
            this.Description,
            this.ValidFrom,
            this.ValidThru});
            this.dgvFileData.EnableHeadersVisualStyles = false;
            this.dgvFileData.GridColor = System.Drawing.Color.Gold;
            this.dgvFileData.Location = new System.Drawing.Point(14, 69);
            this.dgvFileData.Name = "dgvFileData";
            this.dgvFileData.ReadOnly = true;
            this.dgvFileData.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvFileData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFileData.RowTemplate.Height = 23;
            this.dgvFileData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFileData.Size = new System.Drawing.Size(705, 412);
            this.dgvFileData.TabIndex = 12;
            // 
            // List
            // 
            this.List.DataPropertyName = "LIST";
            this.List.HeaderText = "LIST";
            this.List.Name = "List";
            this.List.ReadOnly = true;
            // 
            // MacAddress
            // 
            this.MacAddress.DataPropertyName = "MACADDRESS";
            this.MacAddress.HeaderText = "MACADDRESS";
            this.MacAddress.Name = "MacAddress";
            this.MacAddress.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "DESCRIPTION";
            this.Description.HeaderText = "DESCRIPTION";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // ValidFrom
            // 
            this.ValidFrom.DataPropertyName = "VALIDFROM";
            this.ValidFrom.HeaderText = "VALIDFROM";
            this.ValidFrom.Name = "ValidFrom";
            this.ValidFrom.ReadOnly = true;
            // 
            // ValidThru
            // 
            this.ValidThru.DataPropertyName = "VALIDTHRU";
            this.ValidThru.HeaderText = "VALIDTHRU";
            this.ValidThru.Name = "ValidThru";
            this.ValidThru.ReadOnly = true;
            // 
            // btnImport
            // 
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImport.FlatAppearance.BorderSize = 2;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImport.ForeColor = System.Drawing.Color.Lime;
            this.btnImport.Location = new System.Drawing.Point(14, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(136, 51);
            this.btnImport.TabIndex = 15;
            this.btnImport.Text = "选择文件";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnUploadToDatabase
            // 
            this.btnUploadToDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUploadToDatabase.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUploadToDatabase.FlatAppearance.BorderSize = 2;
            this.btnUploadToDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadToDatabase.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUploadToDatabase.ForeColor = System.Drawing.Color.Lime;
            this.btnUploadToDatabase.Location = new System.Drawing.Point(474, 12);
            this.btnUploadToDatabase.Name = "btnUploadToDatabase";
            this.btnUploadToDatabase.Size = new System.Drawing.Size(122, 51);
            this.btnUploadToDatabase.TabIndex = 16;
            this.btnUploadToDatabase.Text = "上传到DHCP";
            this.btnUploadToDatabase.UseVisualStyleBackColor = true;
            this.btnUploadToDatabase.Click += new System.EventHandler(this.btnUploadToDatabase_Click);
            // 
            // btnImportCancel
            // 
            this.btnImportCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImportCancel.FlatAppearance.BorderSize = 2;
            this.btnImportCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportCancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImportCancel.ForeColor = System.Drawing.Color.Lime;
            this.btnImportCancel.Location = new System.Drawing.Point(639, 12);
            this.btnImportCancel.Name = "btnImportCancel";
            this.btnImportCancel.Size = new System.Drawing.Size(79, 51);
            this.btnImportCancel.TabIndex = 15;
            this.btnImportCancel.Text = "取消";
            this.btnImportCancel.UseVisualStyleBackColor = true;
            this.btnImportCancel.Click += new System.EventHandler(this.btnImportCancel_Click);
            // 
            // rtbResult
            // 
            this.rtbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbResult.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rtbResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbResult.ForeColor = System.Drawing.Color.White;
            this.rtbResult.Location = new System.Drawing.Point(7, 22);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(26, 19);
            this.rtbResult.TabIndex = 19;
            this.rtbResult.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbResult);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(157, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(41, 46);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "上传结果";
            this.groupBox1.Visible = false;
            // 
            // frmImportFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(731, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUploadToDatabase);
            this.Controls.Add(this.btnImportCancel);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dgvFileData);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmImportFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上传文件";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmImportFile_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFileData;
        private System.Windows.Forms.DataGridViewTextBoxColumn List;
        private System.Windows.Forms.DataGridViewTextBoxColumn MacAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidThru;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnUploadToDatabase;
        private System.Windows.Forms.Button btnImportCancel;
        public System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}