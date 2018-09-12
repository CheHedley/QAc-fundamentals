using Acme.Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
    public struct AccountHolder
    {
        //Add address properties
        public Address MyAddress
        {
            get; set;
        }
        
        public Account MyAccount
        {
            get; set;
        }
        public String FirstName
        {
            get; set;
        }
        public String LastName
        {
            get; set;
        }
        public String MiddleName
        {
            get; set;
        }
        public String Prefix
        {
            get; set;
        }
        public DateTime DateOfBirth
        {
            get; set;
        }
        public String AccountType
        {
            get; set;
        }
      
        public override string ToString()
        {
            var accountDetails = new StringBuilder(MyAccount.ToString());
                                accountDetails.AppendLine().Append(Prefix.ToString()).Append(" ").Append(FirstName.ToString()).
                                Append(" ").Append(MiddleName.ToString()).Append(" ").
                                Append(LastName.ToString()).AppendLine().Append(MyAddress.ToString());

            return accountDetails.ToString();
        }
    }
}
