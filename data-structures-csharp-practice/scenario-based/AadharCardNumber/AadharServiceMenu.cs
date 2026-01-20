using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.AadharCardNumber
{
    public class AadharServiceMenu
    {
        private IAadharService service;

        public AadharServiceMenu(IAadharService service)
        {
            this.service = service;
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Aadhar Management System");
                Console.WriteLine("1. Add Aadhar Record");
                Console.WriteLine("2. Display All Aadhar Records");
                Console.WriteLine("3. Sort Aadhar Numbers");
                Console.WriteLine("4. Search Aadhar");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddAadharFromUser();
                        break;

                    case 2:
                        service.DisplayAll();
                        break;

                    case 3:
                        service.SortAadharNumbers();
                        Console.WriteLine("Aadhar numbers sorted successfully.");
                        break;

                    case 4:
                        Console.Write("Enter Aadhar number to search: ");
                        long num = long.Parse(Console.ReadLine());
                        int index = service.SearchAadhar(num);

                        if (index != -1)
                            Console.WriteLine("Aadhar Found: Position " + index);
                        else
                            Console.WriteLine("Aadhar Not Found.");
                        break;

                    case 5:
                        Console.WriteLine("Exiting");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private void AddAadharFromUser()
        {
            Console.Write("Enter Holder Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter 12-digit Aadhar Number: ");
            long number = long.Parse(Console.ReadLine());

            Aadhar aadhar = new Aadhar(number, name);
            service.AddAadhar(aadhar);

            Console.WriteLine("Aadhar record added successfully.");
        }
    }

}
