using System;
using System.Collections.Generic;
using System.Text;

namespace Review.Bank_Account_Manager
{
    internal class BankAccount
    {
        public string AccountNumber { get; private set; }
        public double Balance { get; private set; }

        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit greater than zero");
                return;
            }
            Balance += amount;
            Console.WriteLine("amount deposited successfully."+amount);
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw greater than zero");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            Balance -= amount;
            Console.WriteLine("withdrawn successfully: "+amount);
        }

        public double CheckBalance()
        {
            return Balance;
        }
    }
}
