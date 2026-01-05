using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.VehicalRentalApplication
{
    public class Car : Vehical
    {
        public Car(string vehicalNumber, string fuelType, int manufacturingYear, string conditionOfVehical) : base(vehicalNumber, fuelType, 2500, manufacturingYear, conditionOfVehical) { }
        public override double CalculateRent(int days)
        {
            return (days * rentForADay) + 5000;//security deposit 
        }

    }
}
