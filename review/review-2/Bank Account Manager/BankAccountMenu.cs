using System;
using System.Collections.Generic;
using System.Text;

namespace Review.Bank_Account_Manager
{
    internal class BankAccountMenu
    {
        private IBankOperations Service;

        public BankAccountMenu(IBankOperations service)
        {
            Service = service;
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Bank Account Manager");
                Console.WriteLine("1. Deposit the amount");
                Console.WriteLine("2. Withdraw the amount");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter deposit amount: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        Service.Deposit(depositAmount);
                        break;

                    case 2:
                        Console.Write("Enter withdrawal amount: ");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        Service.Withdraw(withdrawAmount);
                        break;

                    case 3:
                        Service.CheckBalance();
                        break;

                    case 4:
                        Console.WriteLine("Exiting.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
