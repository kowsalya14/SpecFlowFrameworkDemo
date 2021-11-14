using Dapper;

using System.Configuration;
using System.Data.OleDb;
using System.Linq;


namespace SpecFlowFrameworkDemo.Resources
{
    public class ExcelDataReader
    {
            public static string TestDataFileConnection()
            {
                string fileName = "C:\\Users\\deepa\\source\\repos\\SpecFlowFrameworkDemo\\SpecFlowFrameworkDemo\\Resources\\TestDataSheet.xlsx";
                var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);
                return con;
            }

            public static UserData GetTestData(string keyName)
            {
                using (var connection = new OleDbConnection(TestDataFileConnection()))
                {
                    connection.Open();
                    var query = string.Format("select * from [Admin$] where key='{0}'", keyName);
                    var value = connection.Query<UserData>(query).FirstOrDefault();
                    connection.Close();
                    return value;
                }
            }
        }
}
