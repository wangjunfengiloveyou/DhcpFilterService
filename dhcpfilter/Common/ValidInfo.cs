using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.FileIO;
using System.Data;

namespace Common
{
    public static class ValidInfo
    {
        public static bool IsAllowOrDeny(string list)
        {

            Regex trueList = new Regex(@"^allow|deny$", RegexOptions.IgnoreCase);
            return trueList.IsMatch(list);
        }
        public static bool IsMAC(string MAC)//检测输入是否为MAC地址 (([A-Fa-f0-9]{2}-)|[*]-){3}
        {
            //Regex trueMAC = new Regex(@"([A-Fa-f0-9]{2}-){2}(([A-Fa-f0-9]{2}-)|[*]-){3}(([A-Fa-f0-9]{2})|[*])");
            //Regex trueMAC = new Regex(@"([A-Fa-f0-9]{2}-){4}(([A-Fa-f0-9]{2}-)|[*]-)(([A-Fa-f0-9]{2})|[*])");
            bool ismatch = false;
            Regex MAC1 = new Regex(@"^[A-Fa-f0-9]{2}(-[*]){5}$");
            Regex MAC2 = new Regex(@"^[A-Fa-f0-9]{2}(-[A-Fa-f0-9]{2})(-[*]){4}$");
            Regex MAC3 = new Regex(@"^[A-Fa-f0-9]{2}(-[A-Fa-f0-9]{2}){2}(-[*]){3}$");
            Regex MAC4 = new Regex(@"^[A-Fa-f0-9]{2}(-[A-Fa-f0-9]{2}){3}(-[*]){2}$");
            Regex MAC5 = new Regex(@"^[A-Fa-f0-9]{2}(-[A-Fa-f0-9]{2}){4}-[*]$");
            Regex MAC6 = new Regex(@"^[A-Fa-f0-9]{2}(-[A-Fa-f0-9]{2}){5}$");
            if (MAC1.IsMatch(MAC)==true || MAC2.IsMatch(MAC) == true || MAC3.IsMatch(MAC) == true || MAC4.IsMatch(MAC) == true || MAC5.IsMatch(MAC) == true || MAC6.IsMatch(MAC) == true)
            {
                ismatch = true;
            }
            return ismatch;
        }
        public static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            using (TextFieldParser csvReader = new TextFieldParser(csv_file_path, Encoding.GetEncoding("GB2312")))
            {
                csvReader.SetDelimiters(new string[] { "," });
                csvReader.HasFieldsEnclosedInQuotes = true;
                string[] colFields = csvReader.ReadFields();
                foreach (string column in colFields)
                {
                    DataColumn datecolumn = new DataColumn(column);
                    datecolumn.AllowDBNull = true;
                    csvData.Columns.Add(datecolumn);
                }
                while (!csvReader.EndOfData)
                {
                    string[] fieldData = csvReader.ReadFields();
                    for (int i = 0; i < fieldData.Length; i++)
                    {
                        if (fieldData[i] == "")
                        {
                            fieldData[i] = null;
                        }
                    }
                    csvData.Rows.Add(fieldData);
                }
            }
            return csvData;
        }
    }
}
