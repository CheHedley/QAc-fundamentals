using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
    public abstract class Account
    {
        protected decimal balance;
        protected readonly long accountNumber; 

        public long Number
        {
            get { return accountNumber; }
        }
        public Account(decimal amount, long accountNumber)
        {
            balance = amount;
            this.accountNumber = accountNumber;
        }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        public abstract void Transfer(Account beneficiary, decimal amount);
        public abstract decimal GetBalance();

        public override string ToString()
        {
            return $"The balance for account number {accountNumber} is {balance:C}";
        }
    }
}
