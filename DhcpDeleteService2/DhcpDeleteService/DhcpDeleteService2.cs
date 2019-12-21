using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Configuration;
using System.Diagnostics;
using System.Management.Automation;
using System.ServiceProcess;
using System.Threading;

namespace DhcpDeleteService
{
    public partial class DhcpDeleteService2 : ServiceBase
    {
        public DhcpDeleteService2()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("我的服务启动");//在系统事件查看器里的应用程序事件里来源的描述
            try
            {
                string sql_log = "insert into DhcpFilterLog(Status, Action, Object, Time) values('成功', '启动服务_2', 'DhcpDeleteService', getdate())";
                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
            }
            catch (Exception err)
            {
                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '启动服务_2', 'DhcpDeleteService', '{err.Message}', getdate())";
                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
            }
            //System.Timers.Timer t1 = new System.Timers.Timer();
            //t1.Interval = 10000;
            //t1.Elapsed += new System.Timers.ElapsedEventHandler(AutoDelete);//到达时间的时候执行自动删除事件 
            //t1.AutoReset = true;//设置是执行一次（false）还是一直执行(true)； 
            //t1.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件； 

            System.Timers.Timer t2 = new System.Timers.Timer();
            t2.Interval = Convert.ToInt32(ConfigurationManager.AppSettings.Get("Update_Delete_Alter_Add"));
            t2.Elapsed += new System.Timers.ElapsedEventHandler(UpdateDatabase); 
            t2.AutoReset = true;
            t2.Enabled = true;
        }
        /// <summary>
        /// 定时检查，并执行方法
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public void AutoDelete(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                if (DateTime.Now.Hour == Convert.ToInt32(ConfigurationManager.AppSettings.Get("AutoDelete")))
                {
                    System.Timers.Timer t3 = (System.Timers.Timer)source;
                    t3.Enabled = false;
                    ValidThru();
                    t3.Enabled = true;

                }
                else return;
            }
            catch (Exception err)
            {
                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '服务出错_2', 'AutoDelete', '{err.Message}', getdate())";
                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
            }

        }
        public void UpdateDatabase(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                System.Timers.Timer t4 = (System.Timers.Timer)source;
                t4.Enabled = false;
                Upload();//顺序不能改
                Delete();
                Alter();
                Add();
                t4.Enabled = true;
            }
            catch (Exception err)
            {
                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '服务出错_2', 'UpdateDatabase', '{err.Message}', getdate())";
                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
            }
        }

        //我的方法
        public void ValidThru()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select LIST,MACADDRESS from DhcpFilterStatus where STATUS='validthru_1'";
                dt = SqlHelpers.ExecuteDataTable(CommandType.Text, sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    using (PowerShell PowerShellInstance = PowerShell.Create())
                    {
                        string Script = "Remove-DhcpServerv4Filter -MacAddress " + "\"" + dt.Rows[i][1].ToString() + "\"";
                        PowerShellInstance.AddScript(Script);
                        Collection<PSObject> PSOutput = PowerShellInstance.Invoke();
                        Collection<ErrorRecord> errors = PowerShellInstance.Streams.Error.ReadAll();
                        if (errors.Count > 0)
                        {
                            foreach (ErrorRecord er in errors)
                            {
                                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '过期MAC删除_2', '{dt.Rows[i][1].ToString()}', '{er.Exception.Message}', getdate())";
                                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
                            }
                            return;
                        }
                        else if (errors.Count == 0)
                        {
                            try
                            {
                                string Dsql = "delete from DhcpFilterStatus where MACADDRESS=" + "'" + dt.Rows[i][1].ToString() + "'";
                                SqlHelpers.ExecuteNonQuery(CommandType.Text, Dsql);
                                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, Time) values('成功', '过期MAC删除_2', '{dt.Rows[i][1].ToString()}', getdate())";
                                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
                                //writestr($"过期MAC:{dt.Rows[i][1].ToString()}删除成功");
                            }
                            catch (Exception ex)
                            {
                                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '过期MAC删除_2', '{dt.Rows[i][1].ToString()}', '{ex.Message}', getdate())";
                                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
                                //writestr($"过期MAC:{dt.Rows[i][1].ToString()}从Dhcp服务器删除成功，但是从数据库删除失败,原因:" + ex.Message);
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '服务出错_2', 'ValidThru', '{err.Message}', getdate())";
                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
            }
        }
        public void Add()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select LIST,MACADDRESS,DESCRIPTION from DhcpFilterStatus where STATUS = 'add_1'";
                dt = SqlHelpers.ExecuteDataTable(CommandType.Text, sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    using (PowerShell PowerShellInstance = PowerShell.Create())
                    {
                        string Script = "Add-DhcpServerv4Filter -List " + "\"" + dt.Rows[i][0].ToString() + "\"" + " -MacAddress " + "\"" + dt.Rows[i][1].ToString() + "\"" + " -Description " + "\"" + dt.Rows[i][2].ToString() + "\"" + " -Force";
                        PowerShellInstance.AddScript(Script);
                        Collection<PSObject> PSOutput = PowerShellInstance.Invoke();
                        Collection<ErrorRecord> errors = PowerShellInstance.Streams.Error.ReadAll();
                        if (errors.Count > 0)
                        {
                            foreach (ErrorRecord er in errors)
                            {
                                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '添加到dhcp服务器_2', '{dt.Rows[i][1].ToString()}', '{er.Exception.Message}', getdate())";
                                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
                                return;
                            }
                            return;
                        }
                        else if (errors.Count == 0)
                        {
                            string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, Time) values('成功', '添加到dhcp服务器_2', '{dt.Rows[i][1].ToString()}', getdate())";
                            SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
                            //writestr($"添加MAC地址：{dt.Rows[i][1].ToString()}到dhcp服务器成功");
                            string sqlStatus = "update DhcpFilterStatus set STATUS='done' where STATUS = 'add_1'";
                            SqlHelpers.ExecuteNonQuery(CommandType.Text, sqlStatus);
                        }
                    }
                }
                Thread.Sleep(10);
            }
            catch (Exception err)
            {
                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '服务出错_2', 'Add', '{err.Message}', getdate())";
                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
            }
        }
        public void Alter()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select LIST,MACADDRESS,DESCRIPTION from DhcpFilterStatus where STATUS = 'alter_1'";
                dt = SqlHelpers.ExecuteDataTable(CommandType.Text, sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    using (PowerShell PowerShellInstance = PowerShell.Create())
                    {
                        string Script = "Add-DhcpServerv4Filter -List " + "\"" + dt.Rows[i][0].ToString() + "\"" + " -MacAddress " + "\"" + dt.Rows[i][1].ToString() + "\"" + " -Description " + "\"" + dt.Rows[i][2].ToString() + "\"" + " -Force";
                        PowerShellInstance.AddScript(Script);
                        Collection<PSObject> PSOutput = PowerShellInstance.Invoke();
                        Collection<ErrorRecord> errors = PowerShellInstance.Streams.Error.ReadAll();
                        if (errors.Count > 0)
                        {
                            foreach (ErrorRecord er in errors)
                            {
                                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '修改到dhcp服务器_2', '{dt.Rows[i][1].ToString()}', '{er.Exception.Message}', getdate())";
                                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
                                return;
                            }
                            return;
                        }
                        else if (errors.Count == 0)
                        {
                            string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, Time) values('成功', '修改到dhcp服务器_2', '{dt.Rows[i][1].ToString()}', getdate())";
                            SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
                            string sqlStatus = "update DhcpFilterStatus set STATUS='done' where STATUS = 'alter_1'";
                            SqlHelpers.ExecuteNonQuery(CommandType.Text, sqlStatus);
                        }
                    }
                }
                Thread.Sleep(10);
            }
            catch (Exception err)
            {
                //writestr(err.Message);
                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '服务出错_2', 'Alter', '{err.Message}', getdate())";
                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
            }
        }
        public void Delete()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select LIST,MACADDRESS,DESCRIPTION from DhcpFilterStatus where STATUS = 'delete_1'";
                dt = SqlHelpers.ExecuteDataTable(CommandType.Text, sql);
                char[] MyChar = { '_', 'D' };
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //using (PowerShell PowerShellInstance = PowerShell.Create())
                    //{
                    //    string ScriptADD = "Add-DhcpServerv4Filter -List " + "\"" + dt.Rows[i][0].ToString() + "\"" + " -MacAddress " + "\"" + dt.Rows[i][1].ToString().TrimEnd(MyChar) + "\"" + " -Description " + "\"" + dt.Rows[i][2].ToString() + "\"" + " -Force";
                    //    PowerShellInstance.AddScript(ScriptADD);
                    //    Collection<PSObject> PSOutput = PowerShellInstance.Invoke();
                    //    Collection<ErrorRecord> errors = PowerShellInstance.Streams.Error.ReadAll();
                    //    if (errors.Count > 0)
                    //    {
                    //        foreach (ErrorRecord er in errors)
                    //        {
                    //            string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '删除于dhcp服务器_2', '{dt.Rows[i][1].ToString().TrimEnd(MyChar)}', '{er.Exception.Message}', getdate())";
                    //            SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
                    //            return;
                    //        }
                    //    }
                    //}
                    using (PowerShell PowerShellInstance = PowerShell.Create())
                    {
                        string Script = "Remove-DhcpServerv4Filter -MacAddress " + "\"" + dt.Rows[i][1].ToString().Substring(0, dt.Rows[i][1].ToString().Length-2) + "\"";
                        PowerShellInstance.AddScript(Script);
                        Collection<PSObject> PSOutput = PowerShellInstance.Invoke();
                        Collection<ErrorRecord> errors = PowerShellInstance.Streams.Error.ReadAll();
                        if (errors.Count > 0)
                        {
                            foreach (ErrorRecord er in errors)
                            {
                                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '删除于dhcp服务器_2', '{dt.Rows[i][1].ToString().Substring(0, dt.Rows[i][1].ToString().Length - 2)}', '{er.Exception.Message}', getdate())";
                                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
                                return;
                            }
                        }
                        else if (errors.Count == 0)
                        {
                            string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, Time) values('成功', '删除于dhcp服务器_2', '{dt.Rows[i][1].ToString().Substring(0, dt.Rows[i][1].ToString().Length - 2)}', getdate())";
                            SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
                            string sqlStatus = "delete from DhcpFilterStatus where STATUS = 'delete_1'";
                            SqlHelpers.ExecuteNonQuery(CommandType.Text, sqlStatus);
                        }
                    }
                }
                Thread.Sleep(1);
            }
            catch (Exception err)
            {
                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '服务出错_2', 'Delete', '{err.Message}', getdate())";
                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
            }
        }
        public void Upload()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select LIST,MACADDRESS,DESCRIPTION from DhcpFilterStatus where STATUS='upload_1'";
                dt = SqlHelpers.ExecuteDataTable(CommandType.Text, sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    using (PowerShell PowerShellInstance = PowerShell.Create())
                    {
                        string Script = "Add-DhcpServerv4Filter -List " + "\"" + dt.Rows[i][0].ToString() + "\"" + " -MacAddress " + "\"" + dt.Rows[i][1].ToString() + "\"" + " -Description " + "\"" + dt.Rows[i][2].ToString() + "\"" + " -Force";
                        PowerShellInstance.AddScript(Script);
                        Collection<PSObject> PSOutput = PowerShellInstance.Invoke();
                        Collection<ErrorRecord> errors = PowerShellInstance.Streams.Error.ReadAll();
                        if (errors.Count > 0)
                        {
                            foreach (ErrorRecord er in errors)
                            {
                                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '批量添加到dhcp服务器_2', '{dt.Rows[i][1].ToString()}', '{er.Exception.Message}', getdate())";
                                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
                            }
                        }
                        else if (errors.Count == 0)
                        {
                            string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, Time) values('成功', '批量添加到dhcp服务器_2', '{dt.Rows[i][1].ToString()}', getdate())";
                            SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
                            string sqlStatus = "update DhcpFilterStatus set STATUS='done' where STATUS = 'upload_1'";
                            SqlHelpers.ExecuteNonQuery(CommandType.Text, sqlStatus);
                        }
                    }
                }
                Thread.Sleep(10);
            }
            catch (Exception err)
            {
                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '服务出错_2', 'Upload', '{err.Message}', getdate())";
                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
            }
        }
        protected override void OnStop()
        {
            try
            {
                string sql_log = "insert into DhcpFilterLog(Status, Action, Object, Time) values('成功', '停止服务_2', 'DhcpDeleteService', getdate())";
                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
            }
            catch (Exception err)
            {
                string sql_log = $"insert into DhcpFilterLog(Status, Action, Object, ReasonOfFailure, Time) values('失败', '停止服务_2', 'DhcpDeleteService', '{err.Message}', getdate())";
                SqlHelpers.ExecuteNonQuery(CommandType.Text, sql_log);
            }
            EventLog.WriteEntry("我的服务停止");
        }
    }
}
