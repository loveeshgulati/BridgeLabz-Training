using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.VehicalRentalApplication
{
    public class Truck : Vehical
    {
        public Truck(string vehicalNumber, int manufacturingYear, string conditionOfVehical) : base(vehicalNumber, "Diesel", 1200, manufacturingYear, conditionOfVehical) { }
        public override double CalculateRent(int days)
        {
            return (days * rentForADay) + 2000;//security deposit 
        }

    }
}
