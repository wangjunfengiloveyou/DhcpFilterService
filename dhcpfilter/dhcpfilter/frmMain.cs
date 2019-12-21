using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace dhcpfilter
{
    public partial class frmMain : Form
    {
        public DataTable dt = new DataTable();
        frmImportFile frmimportFile = new frmImportFile();
        frmAdd frmadd = new frmAdd();
        frmAlter frmalter = new frmAlter();
        public frmMain()
        {
            InitializeComponent();
            frmimportFile.Owner = this;
            frmadd.Owner = this;
            frmalter.Owner = this;
            dtpQueryFrom.Value = DateTime.Today;
            dtpQueryThru.Value = DateTime.Today.AddYears(10);
            string sql = "select LIST,MACADDRESS,DESCRIPTION,VALIDFROM,VALIDTHRU from DhcpFilterStatus where STATUS !='deleting'";
            dt = SqlHelpers.ExecuteDataTable(CommandType.Text, sql);
            dgvData.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string queryList = cbbList.Text + "%";
            string queryMac = txtQueryMAC.Text + "%";
            string queryDes = txtQueryDescription.Text + "%";
            string queryFrom = dtpQueryFrom.Text;
            string queryThru = dtpQueryThru.Text;
            string sql = @"select LIST,MACADDRESS,DESCRIPTION,VALIDFROM,VALIDTHRU from DhcpFilterStatus where convert(varchar,VALIDFROM,111) >= convert(varchar,@queryFrom,111) and STATUS !='deleting'";
            sql += queryList != "" ? " and LIST like @queryList" : "";
            sql += queryMac != "" ? " and MACADDRESS like @queryMac" : "";
            sql += queryDes != "" ? " and DESCRIPTION like @queryDes" : "";
            sql += queryThru != "" ? " and convert(varchar,VALIDTHRU,111) <= convert(varchar,@queryThru,111)" : "";
            SqlParameter[] paras = {
                new SqlParameter("@queryList",queryList),
                new SqlParameter("@queryMac", queryMac),
                new SqlParameter("@queryDes", queryDes),
                new SqlParameter("@queryFrom", Convert.ToDateTime(queryFrom)),
                new SqlParameter("@queryThru", Convert.ToDateTime(queryThru))
            };
            dgvData.DataSource = null;
            try
            {
                dgvData.DataSource = SqlHelpers.ExecuteDataTable(CommandType.Text, sql, paras);
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询数据失败,原因:" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            frmimportFile.ShowDialog();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmadd.ShowDialog();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            frmalter.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0) return;
            else if (dgvData.CurrentRow.Selected == false) return;
            else
            {
                string info = "确定要删除吗？";
                DialogResult result = MessageBox.Show(info, "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string currentMAC = dgvData.CurrentRow.Cells[1].Value.ToString();
                    SqlParameter[] paras = {
                            new SqlParameter("@currentMAC",currentMAC),
                        };
                    try
                    {
                        string Dsql = "update DhcpFilterStatus set MACADDRESS=@currentMAC+'_D', STATUS='deleting' where MACADDRESS=@currentMAC";
                        SqlHelpers.ExecuteNonQuery(CommandType.Text, Dsql, paras);
                        MessageBox.Show("删除成功", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("从数据库删除失败,原因:" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    string sql = "select LIST,MACADDRESS,DESCRIPTION,VALIDFROM,VALIDTHRU from DhcpFilterStatus where STATUS !='deleting'";
                    dt = SqlHelpers.ExecuteDataTable(CommandType.Text, sql);
                    dgvData.DataSource = dt;
                }
                else return;
            }
        }
    }
}
