using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using System.Management.Automation.Runspaces;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace dhcpfilter
{
    public partial class frmImportFile : Form
    {
        private string fileName = string.Empty;//文件地址
        private DataTable csv = new DataTable();
        string conflict = string.Empty;
        private string TableName = "DhcpFilterStatus";//要插入的表名
        public frmImportFile()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string fileName = string.Empty;
            string duplicate = string.Empty;
            List<string> database = new List<string>();
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "CSV文件(*.csv)|*.csv|TXT文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openfile.ShowDialog() == DialogResult.OK)
                fileName = openfile.FileName;
            else return;
            try
            {
                int k = 0;
                int t = 0;
                csv = ValidInfo.GetDataTabletFromCSVFile(fileName);
                for (int i = 0; i < csv.Columns.Count; i++)
                {
                    csv.Columns[i].ColumnName = csv.Columns[i].ColumnName.ToUpper();
                }//将列名大写
                for (int i = 0; i < csv.Rows.Count; i++)///////////添加对于CSV文件中数据的验证
                {
                    if (ValidInfo.IsAllowOrDeny(csv.Rows[i][0].ToString()) == true && ValidInfo.IsMAC(csv.Rows[i][1].ToString()) == true)//验证allow和macaddress的正确性
                    {
                        k += 1;
                    }
                    else
                    {
                        MessageBox.Show($"读取数据失败!{csv.Rows[i][1].ToString()}有误", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvFileData.DataSource = null;
                        return;
                    }
                    for (int j = i+1; j < csv.Rows.Count; j++)
                    {
                        if(csv.Rows[i][1].ToString() == csv.Rows[j][1].ToString())
                        {
                            duplicate = duplicate + csv.Rows[j][1].ToString() + " ,";
                            csv.Rows.RemoveAt(j);
                            t += 1;
                        }
                    }//去除重复项
                    database.Add(csv.Rows[i][1].ToString());//获取dt csv的macaddress列，方便下一步进行数据库去重
                }
                int pre = csv.Rows.Count;
                DistinctFromDatabase(csv);//和数据库比对进行去重
                int aft = csv.Rows.Count;
                int total = pre - aft;

                if ((duplicate == string.Empty) && (total==0))
                {
                    MessageBox.Show($"读取数据成功，共{k}条", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"读取{k-total}条数据,原文件中与数据库冲突的有{total}项，{conflict.TrimEnd(',')}" + "\n" +
                        $"原文件中重复项有{t}项，{duplicate.TrimEnd(',')}", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conflict = string.Empty;
                dgvFileData.AutoGenerateColumns = false;
                dgvFileData.DataSource = null;
                dgvFileData.DataSource = csv;
                csv.Columns.Add("STATUS", Type.GetType("System.String"));
                for (int i = 0; i < csv.Rows.Count; i++)
                {
                    csv.Rows[i][csv.Columns.Count - 1] += "uploading";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取数据失败,原因:" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnUploadToDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                InsertData insertdata = new InsertData();
                string errorInfo = insertdata.InsertDataIntoSQLServerUsingSQLBulkCopy(csv, TableName);
                if (errorInfo == "")
                    MessageBox.Show("上传到数据库成功", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show($"上传到数据库失败,{errorInfo}", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);           
            }
            catch (Exception ex)
            {
                MessageBox.Show("上传到数据库失败,原因:" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmMain frmmain = (frmMain)this.Owner;
            string sql = "select LIST,MACADDRESS,DESCRIPTION,VALIDFROM,VALIDTHRU from DhcpFilterStatus where STATUS !='deleting'";
            frmmain.dt = SqlHelpers.ExecuteDataTable(CommandType.Text, sql);
            frmmain.dgvData.DataSource = frmmain.dt;
            dgvFileData.DataSource = null;
        }
        //private void InsertDataIntoSQLServerUsingSQLBulkCopy(DataTable csvFileData, string TableName)
        //{
            
        //    using (SqlConnection dbConnection = new SqlConnection(SqlHelpers.ConnectionString))
        //    {
        //        dbConnection.Open();
                
        //        using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
        //        {
        //            try
        //            {
        //                s.DestinationTableName = TableName;
        //                foreach (var column in csvFileData.Columns)
        //                    s.ColumnMappings.Add(column.ToString(), column.ToString());
        //                s.WriteToServer(csvFileData);
        //                if(errorMAC =="")
        //                {
        //                    MessageBox.Show("上传到数据库成功", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //            }
        //            catch (Exception e)
        //            {
        //                if (errorMAC == "")
        //                {
        //                    errorMAC = errorMAC + e.Message.ToString();
        //                }
        //                else if (errorMAC == e.Message.ToString())
                            
        //                //如果出现异常，SqlBulkCopy 会使数据库回滚，所有Table中的记录都不会插入到数据库中，此时，把Table折半插入，先插入一半，再插入一半。如此递归，直到只有一行时，如果插入异常，则返回。
        //                if (csvFileData.Rows.Count == 1)
        //                    return;
        //                int middle = csvFileData.Rows.Count / 2;
        //                DataTable table = csvFileData.Clone();
        //                for (int i = 0; i < middle; i++)
        //                    table.ImportRow(csvFileData.Rows[i]);

        //                InsertDataIntoSQLServerUsingSQLBulkCopy(table, TableName);

        //                table.Clear();
        //                for (int i = middle; i < csvFileData.Rows.Count; i++)
        //                    table.ImportRow(csvFileData.Rows[i]);
        //                InsertDataIntoSQLServerUsingSQLBulkCopy(table, TableName);

        //            }
        //            finally
        //            {
        //                //MessageBox.Show($"上传到数据库失败,{errorMAC}", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                s.Close();
        //            }
                    
        //            //catch (Exception ex)
        //            //{
        //            //    MessageBox.Show("上传到数据库失败,原因:" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            //}
        //        }
        //    }

        //}
        private void frmImportFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }

        private void btnImportCancel_Click(object sender, EventArgs e)
        {
            dgvFileData.DataSource = null;
            this.Visible = false;
        }

        //我的方法
        public DataTable DistinctFromDatabase(DataTable csv)
        {
            DataTable mac = new DataTable();
            string sql = "select LIST,MACADDRESS,DESCRIPTION,VALIDFROM,VALIDTHRU from DhcpFilterStatus where MACADDRESS in (";
            for (int i = 0; i < csv.Rows.Count; i++)
            {
                sql += $"'{csv.Rows[i][1].ToString()}',";
            }
            sql = sql.TrimEnd(',');
            sql += ")";
            mac = SqlHelpers.ExecuteDataTable(CommandType.Text, sql);
            for (int i = csv.Rows.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < mac.Rows.Count; j++)
                {
                    if (csv.Rows[i][1].ToString() == mac.Rows[j][1].ToString())
                    {
                        conflict = conflict + mac.Rows[j][1].ToString() + " ,";
                        csv.Rows.RemoveAt(i);
                        break;
                    }
                }
            }
            return csv;
        }
    }
}
