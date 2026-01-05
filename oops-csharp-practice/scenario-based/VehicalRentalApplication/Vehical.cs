using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.VehicalRentalApplication
{
    public abstract class Vehical:IRentable
    {
        protected string vehicalNumber {  get; private set; }
        protected string fuelType {  get; private set; }
        protected double rentForADay {  get; private set; }
        protected int manufacturingYear {  get; private set; }
        protected string conditionOfVehical {  get; private set; }
        public Vehical(string vehicalNumber, string fuelType, double rentForADay, int manufacturingYear, string conditionOfVehical)
        {
            this.vehicalNumber = vehicalNumber;
            this.fuelType = fuelType;
            this.rentForADay = rentForADay;
            this.manufacturingYear = manufacturingYear;
            this.conditionOfVehical = conditionOfVehical;
        }
        public abstract double CalculateRent(int days);
        public void DisplayVehicalInfo()
        {
            Console.WriteLine("Vehical Number : "+vehicalNumber);
            Console.WriteLine("Fuel Type : "+fuelType);
            Console.WriteLine("Rent for a day : "+rentForADay);
            Console.WriteLine("Manufacturing year of the vehicle is : "+manufacturingYear);
            Console.WriteLine("Condition of the vehicle is : "+conditionOfVehical);
        }
    }
}
