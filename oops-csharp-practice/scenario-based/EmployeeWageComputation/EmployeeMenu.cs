using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.EmployeeWageComputation
{
    class EmployeeMenu
    {
        private IEmployee employeeService = new EmployeeUtilityImpl();

        public void ShowMenu()
        {
            Console.Write("Enter number of employees (max 15): ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter Employee {i + 1} ID: ");
                int id = int.Parse(Console.ReadLine());
                employeeService.AddEmployee(new Employee(id));
            }

            while (true)
            {
                Console.WriteLine("\n--- Employee Wage Computation Menu ---");
                Console.WriteLine("1. UC5 - Calculate Monthly Wage");
                Console.WriteLine("2. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        employeeService.CalculateMonthlyWage();
                        employeeService.DisplayEmployees();
                        break;

                    case 2:
                        return;
                }
            }
        }
    }
}
