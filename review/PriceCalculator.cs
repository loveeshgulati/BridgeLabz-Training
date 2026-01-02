using System;

namespace BridgeLabz_Training.Review
{
    public class PriceCalculator
    {
        static void Main(string[] args)
        {
            string[] items = { "Biscuits", "Soap", "Soap", "Liquid detergent", "Chips", "Bread", "Cornflakes", "Sugar", "Maida", "Ketchup" };
            double[] prices = { 40, 50, 30, 800, 30, 50, 60, 90, 50, 120 };
            int[] quantities = new int[items.Length];

            Console.WriteLine(" TOTAL BILL CALCULATOR ");
            Console.WriteLine("Enter your role (customer):");
            string role = Console.ReadLine().ToLower();

            if (role == "customer")
            {
                while (true)
                {
                    Console.WriteLine("\nAvailable Items:");
                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.WriteLine((i + 1) + ". "+ items[i] +" - " + prices[i] +" | Qty in Cart: " + quantities[i]);
                    }

                    Console.WriteLine("\nOptions:");
                    Console.WriteLine("1. Add item with quantity");
                    Console.WriteLine("2. Generate Bill");
                    Console.WriteLine("0. Exit");

                    int option = Convert.ToInt32(Console.ReadLine());

                    if (option == 0)
                        break;

                    switch (option)
                    {
                        case 1:
                            AddItemToCart(quantities);
                            break;

                        case 2:
                            GenerateBill(prices, quantities);
                            break;

                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid role");
            }
        }

        
        static void AddItemToCart(int[] quantities)
        {
            Console.Write("Enter item number: ");
            int itemNumber = Convert.ToInt32(Console.ReadLine()) - 1;

            if (itemNumber < 0 || itemNumber >= quantities.Length)
            {
                Console.WriteLine("Invalid item number");
                return;
            }

            Console.Write("Enter quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            if (qty <= 0)
            {
                Console.WriteLine("Quantity must be greater than zero");
                return;
            }

            quantities[itemNumber] += qty;
            Console.WriteLine("Item added to cart successfully");
        }

       
        static void GenerateBill(double[] prices, int[] quantities)
        {
            double total = 0;
            double discount  = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                total += prices[i] * quantities[i];
            }

            if (total >= 400)
            {
                discount = total * 0.30;
                total -= discount;
            }
            double finalBill = total - discount;

            Console.WriteLine("\n BILL SUMMARY ");
            Console.WriteLine("Total Bill      : " + total);
            Console.WriteLine("Discount        : " + discount);
            Console.WriteLine("Discounted Bill : " + finalBill);
        }

    }
}
