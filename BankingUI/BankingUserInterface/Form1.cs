using Acme.Banking;
using BankingLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingUserInterface
{
   

   

    public partial class Banking : Form
    {
        private static Account acc = new CurrentAccount(120m, 1234567890);
        private static Account beneficiary = new CurrentAccount(0m, 2345678901);
         static List<Account> accounts = new List<Account>
            {
                acc, beneficiary
            };
        public Banking()
        {
            InitializeComponent();
        }

        private static Account FindByAccountNumber(long number)
        {
            return accounts.Find(a => a.Number == number);
        }

        private void PersonalDetailsContinueButton_Click(object sender, EventArgs e)
        {
                   
            DateTime.TryParse(dateOfBirth.Text, out DateTime dob);
            Account acc = new CurrentAccount(100m, 1234567890L);
            Address address = new Address
            {
                Line1 = AddressLine1TextBox.Text,
                Line2 = AddressLine2TextBox.Text,
                City = CityTextBox.Text,
                County = CountyTextBox.Text,
                Postcode = PostcodeTextbox.Text
            };
            AccountHolder ah = new AccountHolder
            {
                MyAccount = acc,
                LastName = LastNameTextBox.Text,
                Prefix = TitleTextBox.Text,
                FirstName = FirstNameTextBox.Text,
                MiddleName = MiddleNameTextBox.Text,
                DateOfBirth = dob,
                MyAddress = address,
                AccountType = AccountTypeComboBox.Text
            };

            bool isSuccess = NewAccountController.Process(ah); 
            


        }

        private void FindAccountButton_Click(object sender, EventArgs e)
        {
           // Account acc = FindByAccountNumber(long.Parse(accountNumberTextBox.Text));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
