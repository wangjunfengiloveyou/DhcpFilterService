using System;
using System.Data;
using System.Data.SqlClient;

namespace Common
{
    public class InsertData
    {
        string errorMAC = string.Empty;
        public string InsertDataIntoSQLServerUsingSQLBulkCopy(DataTable csvFileData, string TableName)
        {
            using (SqlConnection dbConnection = new SqlConnection(SqlHelpers.ConnectionString))
            {
                dbConnection.Open();
                using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
                {
                    try
                    {
                        s.DestinationTableName = TableName;
                        foreach (var column in csvFileData.Columns)
                            s.ColumnMappings.Add(column.ToString(), column.ToString());
                        s.WriteToServer(csvFileData);
                    }
                    catch (Exception e)
                    {
                        if (errorMAC == "")
                            errorMAC = errorMAC + e.Message.ToString();
                        else if (errorMAC.Contains(e.Message.ToString()) == false)
                            errorMAC = errorMAC + e.Message.ToString();
                        //如果出现异常，SqlBulkCopy 会使数据库回滚，所有Table中的记录都不会插入到数据库中，此时，把Table折半插入，先插入一半，再插入一半。如此递归，直到只有一行时，如果插入异常，则返回。
                        if (csvFileData.Rows.Count == 1)
                        return errorMAC;
                        int middle = csvFileData.Rows.Count / 2;
                        DataTable table = csvFileData.Clone();
                        for (int i = 0; i < middle; i++)
                            table.ImportRow(csvFileData.Rows[i]);

                        InsertDataIntoSQLServerUsingSQLBulkCopy(table, TableName, "");

                        table.Clear();
                        for (int i = middle; i < csvFileData.Rows.Count; i++)
                            table.ImportRow(csvFileData.Rows[i]);
                        InsertDataIntoSQLServerUsingSQLBulkCopy(table, TableName, "");
                    }
                    finally
                    {
                        s.Close();
                    }
                }
            }
            return errorMAC;
        }
        public void InsertDataIntoSQLServerUsingSQLBulkCopy(DataTable csvFileData, string TableName, string empty)
        {
            using (SqlConnection dbConnection = new SqlConnection(SqlHelpers.ConnectionString))
            {
                dbConnection.Open();
                using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
                {
                    try
                    {
                        s.DestinationTableName = TableName;
                        foreach (var column in csvFileData.Columns)
                            s.ColumnMappings.Add(column.ToString(), column.ToString());
                        s.WriteToServer(csvFileData);
                    }
                    catch (Exception e)
                    {
                        if (errorMAC == "")
                            errorMAC = errorMAC + e.Message.ToString();
                        else if (errorMAC.Contains(e.Message.ToString()) == false)
                            errorMAC = errorMAC + e.Message.ToString();
                        //如果出现异常，SqlBulkCopy 会使数据库回滚，所有Table中的记录都不会插入到数据库中，此时，把Table折半插入，先插入一半，再插入一半。如此递归，直到只有一行时，如果插入异常，则返回。
                        if (csvFileData.Rows.Count == 1)
                        return;
                        int middle = csvFileData.Rows.Count / 2;
                        DataTable table = csvFileData.Clone();
                        for (int i = 0; i < middle; i++)
                            table.ImportRow(csvFileData.Rows[i]);

                        InsertDataIntoSQLServerUsingSQLBulkCopy(table, TableName, "");

                        table.Clear();
                        for (int i = middle; i < csvFileData.Rows.Count; i++)
                            table.ImportRow(csvFileData.Rows[i]);
                        InsertDataIntoSQLServerUsingSQLBulkCopy(table, TableName, "");
                    }
                    finally
                    {
                        s.Close();
                    }
                }
            }
        }
    }
}
