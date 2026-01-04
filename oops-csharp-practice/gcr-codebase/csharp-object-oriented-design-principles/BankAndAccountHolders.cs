using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.object_modeling
{
    class Customer
    {
        public string CustomerName;
        public double Balance;

        //parameterized constructor
        public Customer(string entercustomerName)
        {
            this.CustomerName = entercustomerName;
            this.Balance = 0;
        }
        public void ViewBalance()
        {
            Console.WriteLine(CustomerName + " Balance: " + Balance);
        }
    }

    class Bank
    {
        public string BankName;
        public List<Customer> Customers;

        //paramterized constructor
        public Bank(string enterbankName)
        {
            this.BankName = enterbankName;
            this.Customers = new List<Customer>();
        }

        public void OpenYourAccount(Customer customer, double initialAmount)
        {
            customer.Balance = initialAmount;
            Customers.Add(customer);

            Console.WriteLine("Account opened for " + customer.CustomerName +" in " + BankName);
        }
    }

    // Main class
    class Association
    {
        //Main Method
        public static void Main(String[] args)
        {

            Bank bank = new Bank("RBI");
            Customer customer1 = new Customer("Amit");
            Customer customer2 = new Customer("Amir");
            bank.OpenYourAccount(customer1, 15000);
            bank.OpenYourAccount(customer2, 8000);
            customer1.ViewBalance();
            customer2.ViewBalance();
        }
    }
}
