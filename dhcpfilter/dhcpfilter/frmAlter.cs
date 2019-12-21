using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using System.Data.SqlClient;
using System.Management.Automation;
using System.Collections.ObjectModel;

namespace dhcpfilter
{
    public partial class frmAlter : Form
    {
        public frmAlter()
        {
            InitializeComponent();
        }
        private void btnAlter_Click(object sender, EventArgs e)
        {
            frmMain frmmain = (frmMain)this.Owner;
            string alterList = string.Empty;
            if (ValidInfo.IsAllowOrDeny(cbbAlterList.Text) == true)
            {
                alterList = cbbAlterList.Text;
            }
            else
            {
                MessageBox.Show("LIST必须为Allow或者Deny", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string currentMAC = frmmain.dgvData.CurrentRow.Cells[1].Value.ToString();
            string alterDes = txtAlterDescription.Text;
            string alterFrom = dtpAlterValidFrom.Text;
            string alterThru = dtpAlterValidThru.Text;
            string ATsql = "update DhcpFilterStatus set LIST=@alterList, DESCRIPTION=@alterDes, VALIDFROM=@alterFrom, VALIDTHRU=@alterThru, STATUS='altering' where MACADDRESS=@currentMAC";
            SqlParameter[] paras = {
                new SqlParameter("@currentMAC", currentMAC),
                new SqlParameter("@alterList",alterList),
                new SqlParameter("@alterDes", alterDes),
                new SqlParameter("@alterFrom", Convert.ToDateTime(alterFrom)),
                new SqlParameter("@alterThru", Convert.ToDateTime(alterThru))
            };
            try
            {
                SqlHelpers.ExecuteNonQuery(CommandType.Text, ATsql, paras);
                MessageBox.Show("修改成功", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string sql = "select LIST,MACADDRESS,DESCRIPTION,VALIDFROM,VALIDTHRU from DhcpFilterStatus where STATUS !='deleting'";
                frmmain.dt = SqlHelpers.ExecuteDataTable(CommandType.Text, sql);
                frmmain.dgvData.DataSource = frmmain.dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改到数据库失败,原因:" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAlterCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void frmAlter_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }
        private void frmAlter_Load(object sender, EventArgs e)
        {
            frmMain frmmain = (frmMain)this.Owner;
            txtAlterMAC.Enabled = false;
            if (frmmain.dgvData.Rows.Count == 0) return;
            else if (frmmain.dgvData.CurrentRow.Selected == false) return;
            else
            {
                cbbAlterList.Text = frmmain.dgvData.CurrentRow.Cells[0].Value.ToString();
                txtAlterMAC.Text = frmmain.dgvData.CurrentRow.Cells[1].Value.ToString();
                txtAlterDescription.Text = frmmain.dgvData.CurrentRow.Cells[2].Value.ToString();

                if (frmmain.dgvData.CurrentRow.Cells[3].Value.ToString() == string.Empty)
                    dtpAlterValidFrom.Text = DateTime.Today.ToString();
                else
                    dtpAlterValidFrom.Text = frmmain.dgvData.CurrentRow.Cells[3].Value.ToString();

                if(frmmain.dgvData.CurrentRow.Cells[4].Value.ToString() == string.Empty)
                    dtpAlterValidThru.Text = DateTime.Today.AddYears(10).ToString();
                else
                    dtpAlterValidThru.Text = frmmain.dgvData.CurrentRow.Cells[4].Value.ToString();
            }
        }
    }
}
