using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BridgeLabz_Training.OOPS.VehicalRentalApplication
{
    public class Customer
    {
        private string customerName { set; get; }
        public Customer(string customerName)
        {
            this.customerName = customerName;
        }
        public void RentVehical(Vehical vehical, int days)
        {
            Console.WriteLine("Customer name : "+customerName);
            vehical.DisplayVehicalInfo();
            Console.WriteLine("Days Rented :"+days);
            Console.WriteLine("Total Rent :"+vehical.CalculateRent(days));
            Console.WriteLine();
        }
    }
}
