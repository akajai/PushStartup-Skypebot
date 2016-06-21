using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PushStartup_Skypebot.DB
{
    static public class ExcelDB
    {
       static private  System.Data.OleDb.OleDbConnection oleDbConnection=new OleDbConnection(ConfigurationManager.ConnectionStrings["ExcelConnectionString"].ConnectionString);
        static private System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
        //  string sql = null;
        //   MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='c:\\csharp.net-informations.xls';Extended Properties=Excel 8.0;");
        private static OleDbConnection GetConnection()
        {
            return oleDbConnection;
        }
        private static void CloseConnection(OleDbConnection oleDbConnection)
        {
            try
            {
                oleDbConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Delete(String strquery, string sessionId)
        {

            oleDbConnection.Open();
            OleDbCommand command = new OleDbCommand(strquery, oleDbConnection);
            command.ExecuteNonQuery();
            oleDbConnection.Close();
        }
        private static void FormatQuery(String strquery,String[] strValArray)
        {
            foreach(String strValue in strValArray)
            {
                strquery = String.Format(strquery, strValue);
            }

        }
    }
}
