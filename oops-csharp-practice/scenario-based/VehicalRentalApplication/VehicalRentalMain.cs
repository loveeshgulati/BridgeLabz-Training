using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.VehicalRentalApplication
{
    public class VehicalRentalMain
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Rama");
            Customer customer2 = new Customer("DEV");
            Customer customer3 = new Customer("Amit");
            Vehical bike = new Bike("HR30H5253", 2024, "MODERATE");
            Vehical car = new Car("HR51C7949", "PETROL", 2025, "EXCELLENT");
            Vehical truck = new Truck("HR52AC2233", 2004, "BAD");


            customer1.RentVehical(bike, 6);
            Console.WriteLine();
            customer2.RentVehical(car, 10);
            Console.WriteLine();
            customer3.RentVehical(truck, 30);
            Console.WriteLine();

        }
    }
}
