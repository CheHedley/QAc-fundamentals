using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
    public class CurrentAccount:Account
    {
        public CurrentAccount(decimal amount, long accountNumber) : base(amount, accountNumber)
        {
            balance = 100 + amount;
        }

        public override void Deposit(decimal amount)
        {
            balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {

            }
        }
        public override void Transfer(Account beneficiary, decimal amount)
        {
            Withdraw(amount);
            beneficiary.Deposit(amount);
        }
        public override decimal GetBalance()
        {
            return balance;
        }
    }
}
