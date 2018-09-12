using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingDatabase;

namespace BankingLib
{
    public class NewAccountController
    {
        public static bool Process(AccountHolder accHolder)
        {
            
            PersistenceManager.SaveToFile(accHolder);
            return true;
        }

        private static void SavetoDB(AccountHolder ah)
        {
            //need to set up database in ssms.
        }
        private static void SaveToFile(AccountHolder ah)
        {
            String timeStamp = DateTime.Now.ToString();
            File.WriteAllText(@"C:\Sandbox\AccountHolder" + timeStamp + ".dat",ah.ToString());
        }
    }
}
