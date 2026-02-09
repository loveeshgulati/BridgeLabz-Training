public class ECommerceMenu
{
    
    public void DisplayMenu()
    {
          ECommerceServices services = new ECommerceServices();
        bool isRunning = true;
    while(isRunning){
        Console.WriteLine("Welcome to ECommerce - System");
        Console.WriteLine("1. Add Order Details");
        Console.WriteLine("2. Get Order Details");
        Console.WriteLine("3. Remove Order Details");
        Console.WriteLine("4. Exit");

        int choice = Convert.ToInt32(Console.ReadLine());
      
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter Order ID");
                int orderId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Customer Name");
                string customerName = Console.ReadLine();
                Console.WriteLine("Enter Item");
                string item = Console.ReadLine();
                services.AddOrderDetails(orderId, customerName, item);
                break;

            case 2:
                Console.WriteLine(services.GetOrderDetails());
                break;

            case 3:
                services.RemoveOrderDetails();
                break;
            
            case 4:
                Console.WriteLine("Thank You");
                isRunning = false;
                break;
        }
    }
    }
}