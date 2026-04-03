using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.EmployeeWageComputation
{

    class EmployeeMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee");
            Console.WriteLine("Wage Computation");
            Console.WriteLine("Program on Master Branch");

            EmployeeMenu menu = new EmployeeMenu();
            menu.ShowMenu();
        }
    }


}
