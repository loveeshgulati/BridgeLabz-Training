using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.VehicalRentalApplication
{
    public class Bike:Vehical
    {
        public Bike(string vehicalNumber,int manufacturingYear,string conditionOfVehical):base(vehicalNumber,"Petrol",1200,manufacturingYear,conditionOfVehical){ }
        public override double CalculateRent(int days)
        {
            return (days * rentForADay) + 2000;//security deposit 
        }

    }
}
