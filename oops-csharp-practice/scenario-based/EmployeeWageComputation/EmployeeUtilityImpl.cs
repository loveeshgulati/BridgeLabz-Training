using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.EmployeeWageComputation
{
    class EmployeeUtilityImpl : IEmployee
    {
        private Employee[] employees = new Employee[15];
        private int count = 0;
        private Random randomAttendance = new Random();

        public void LoadPredefinedEmployees()
        {
            for (int i = 0; i < 10; i++)
            {
                employees[count++] = new Employee(100 + i);
            }
        }

        public void AddEmployee(Employee employee)
        {
            if (count < employees.Length)
            {
                employees[count++] = employee;
            }
            else
            {
                Console.WriteLine("No more employees can be added.");
            }
        }

        // UC1: Attendance using RANDOM
        public void CheckAttendance()
        {
            for (int i = 0; i < count; i++)
            {
                employees[i].IsPresent = randomAttendance.Next(0, 2) == 1;
            }
        }

        public void DisplayEmployees()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
