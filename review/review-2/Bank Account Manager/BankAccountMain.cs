using System;
using System.Collections.Generic;
using System.Text;

namespace Review.Bank_Account_Manager
{
    internal class BankAccountMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the account Number: ");
            string AccountNumber = Console.ReadLine();

            Console.WriteLine("Enter initial balance");
            int Balance = Convert.ToInt32(Console.ReadLine());
            BankAccount account = new BankAccount(AccountNumber, Balance);

            IBankOperations service = new BankAccountImpl(account);
            BankAccountMenu menu = new BankAccountMenu(service);

            menu.ShowMenu();
        }
    }
}
