using BankingLib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDatabase
{
    public class PersistenceManager
    {
        public static void SaveToDB(AccountHolder ah)
        {

            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder
            {
                ConnectionString = @"Integrated Security=SSPI;
                                    Persist Security Info=False;Initial Catalog=AcmeBanking;
                                    Data Source=STUDENT03\SQLEXPRESS"
            };
            using (SqlConnection conn = new SqlConnection(sb.ConnectionString))
            {
                String cmdText = $@"insert into AcmeBanking.dbo.TransactionLog(name,details,TransactionDate)
                                    values('New Account', '{ah.ToString()}', getdate()); ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static bool SaveToFile(AccountHolder ah)
        {
            SaveToDB(ah);
            String timeStamp = DateTime.Now.Millisecond.ToString();
            File.WriteAllText(@"C:\Sandbox\AccountHolder" + timeStamp + ".dat", ah.ToString());
            return true;
        }
    }
}
