using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.TrafficManager
{
    internal class TrafficManagerMenu
    {
        public static void Display(ITrafficManagerOperations traffic)
        {
            int choice;
            do
            {
                Console.WriteLine(" Traffic Manager Menu ");
                Console.WriteLine("1. Add Vehicle to Queue");
                Console.WriteLine("2. Enter Roundabout");
                Console.WriteLine("3. Exit Roundabout");
                Console.WriteLine("4. Show Roundabout");
                Console.WriteLine("5. Show Waiting Queue");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Vehicle Number: ");
                        traffic.VehicleEnterQueue(Console.ReadLine());
                        break;
                    case 2:
                        traffic.VehicleEnterRoundAbout();
                        break;
                    case 3:
                        Console.Write("Enter Vehicle Number to Exit: ");
                        traffic.VehicleExitRoundAbout(Console.ReadLine());
                        break;
                    case 4:
                        traffic.ShowRoundAbout();
                        break;
                    case 5:
                        traffic.ShowQueue();
                        break;
                }
            } while (choice != 0);
        }
    }
}
