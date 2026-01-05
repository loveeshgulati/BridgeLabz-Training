using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.HospitalPatientManagementSystem
{
    public class Bill
    {
        public static void PrintBill(IPayable payable)
        {
            Console.WriteLine("Total Bill is : "+ payable.CalculateBill());
        }
    }
}
