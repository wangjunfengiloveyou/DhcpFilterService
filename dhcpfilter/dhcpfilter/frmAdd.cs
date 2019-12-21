using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Management.Automation;
using System.Collections.ObjectModel;

namespace dhcpfilter
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMain frmmain = (frmMain)this.Owner;
            string addList = string.Empty;
            string addMac = string.Empty;
            if (ValidInfo.IsAllowOrDeny(cbbAddList.Text) == true)
            {
                addList = cbbAddList.Text;
            }
            else
            {
                MessageBox.Show("LIST必须为Allow或者Deny", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ValidInfo.IsMAC(txtAddMAC.Text) == true)
            {
                addMac = txtAddMAC.Text;
            }
            else
            {
                MessageBox.Show("MACADDRESS必须是MAC地址", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string addDes = txtAddDescription.Text;
            string addFrom = dtpAddFrom.Text;
            string addThru = dtpAddThru.Text;
            string ADsql = "insert into DhcpFilterStatus(LIST, MACADDRESS, DESCRIPTION, VALIDFROM, VALIDTHRU, STATUS) values(@addList, @addMac, @addDes, @addFrom, @addThru, 'adding')";
            SqlParameter[] paras = {
                new SqlParameter("@addList",addList),
                new SqlParameter("@addMac", addMac),
                new SqlParameter("@addDes", addDes),
                new SqlParameter("@addFrom", Convert.ToDateTime(addFrom)),
                new SqlParameter("@addThru", Convert.ToDateTime(addThru))
            };
            try
            {
                SqlHelpers.ExecuteNonQuery(CommandType.Text, ADsql, paras);
                MessageBox.Show("添加成功", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string sql = "select LIST,MACADDRESS,DESCRIPTION,VALIDFROM,VALIDTHRU from DhcpFilterStatus where STATUS !='deleting'";
                frmmain.dt = SqlHelpers.ExecuteDataTable(CommandType.Text, sql);
                frmmain.dgvData.DataSource = frmmain.dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加到数据库失败,原因:" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            dtpAddFrom.Value = DateTime.Today;
            dtpAddThru.Value = DateTime.Today.AddYears(10);
        }
    }
}
