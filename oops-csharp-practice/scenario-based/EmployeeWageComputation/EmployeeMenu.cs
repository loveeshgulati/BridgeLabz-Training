using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.EmployeeWageComputation
{
    internal class EmployeeMenu
    {
        private IEmployee employeeService = new EmployeeUtilityImpl();
        private bool isInitialized = false;

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n Employee Wage Computation Menu");
                Console.WriteLine("1. UC1 - Check Employee Attendance");
                Console.WriteLine("2. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (!isInitialized)
                        {
                            employeeService.LoadPredefinedEmployees();

                            employeeService.AddEmployee(new Employee(110));
                            employeeService.AddEmployee(new Employee(111));
                            employeeService.AddEmployee(new Employee(112));
                            employeeService.AddEmployee(new Employee(113));
                            employeeService.AddEmployee(new Employee(114));

                            isInitialized = true;
                        }

                        employeeService.CheckAttendance();
                        employeeService.DisplayEmployees();
                        break;

                    case 2:
                        Console.WriteLine("Exit Program");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
