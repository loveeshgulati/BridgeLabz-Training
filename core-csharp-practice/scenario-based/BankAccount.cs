using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Scenario_based.BankAccountManager
{
    public class BankAccount
    {
        public long AccountNumber {  get; set; }
        public double Balance { get; private set; }
        private static Random random = new Random();
        public BankAccount(double initialBalance) {
            AccountNumber = GenerateAccountNumber();
            Balance = initialBalance;

        }
        public void Deposit(double amount) {
            if (amount <= 0)
            {
                Console.WriteLine("Enter amount greater than zero");
                return;
            }
            Balance += amount;
            Console.WriteLine(amount+" has been deposited in your account. Your updated balance is : "+Balance);
            
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0) {
                Console.WriteLine("Withrawal amount should be greater than zero");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance");
                return;
            }
            Balance -= amount;
            Console.WriteLine(amount + " has been withdrawn from your account. Your updated balance is : " + Balance);
        

        }
        private long GenerateAccountNumber()
        {
            long min = 100000000000;
            return min + (long)(random.Next());

        }
        public void CheckBalance() 
            {
                Console.WriteLine("Your balance is : "+ Balance );
            }
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(0);
            account.CheckBalance();
            account.Deposit(20000);
            account.CheckBalance();
            account.Withdraw(1000);
            account.CheckBalance();

        }  
    }
}
