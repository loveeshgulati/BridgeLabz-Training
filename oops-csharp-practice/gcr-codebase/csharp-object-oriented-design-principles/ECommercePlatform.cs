using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.object_modeling
{
    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        //constructor
        public Product(string entername, double enterprice)
        {
            this.ProductName = entername;
            this.Price = enterprice;
        }


        public void ShowProduct()
        {
            Console.WriteLine(ProductName + " - " + Price);
        }
    }

    class Order
    {
        public int OrderId { get; set; }
        private List<Product> products = new List<Product>();

        //constructor
        public Order(int enterorderId)
        {
            this.OrderId = enterorderId;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine("Order ID: " + OrderId);
            Console.WriteLine("Products in this order: ");

            double total = 0;
            foreach (Product P in products)
            {
                P.ShowProduct();
                total += P.Price;
            }

            Console.WriteLine("Total Amount: " + total);
            Console.WriteLine();
        }
    }

    class Customer
    {
        public string Name { get; set; }

        //constructor
        public Customer(string entername)
        {
            this.Name = entername;
        }

        public void PlaceOrder(Order order)
        {
            Console.WriteLine(Name + " placed Order ID " + order.OrderId);
            order.DisplayOrderDetails();
        }
    }

    //Main class
    class EcommercePlatform
    {

        //MAIN METHOD
        public static void Main(String[] args)
        {

            Product product1 = new Product("MAC", 100000);
            Product product2 = new Product("PC", 50000);
            Product product3 = new Product("CPU", 3000);


            Customer customer = new Customer("kritk");


            Order order1 = new Order(99);


            order1.AddProduct(product1);
            order1.AddProduct(product2);
            order1.AddProduct(product3);

            customer.PlaceOrder(order1);
        }
    }
}
