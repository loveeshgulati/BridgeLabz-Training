using System;
using System.Collections.Generic;
using System.Text;
namespace Review.Bank_Account_Manager
{
    internal class BankAccountImpl : IBankOperations
    {
        private BankAccount Account;

        public BankAccountImpl(BankAccount account)
        {
            Account = account;
        }

        public void Deposit(double amount)
        {
            Account.Deposit(amount);
        }

        public void Withdraw(double amount)
        {
            Account.Withdraw(amount);
        }

        public void CheckBalance()
        {

            Console.WriteLine("Balance is " + Account.CheckBalance());
        }
    }

}