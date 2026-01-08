using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.EmployeeWageComputation
{
    class EmployeeUtilityImpl : IEmployee
    {
        private Employee[] employees = new Employee[15];
        private int count = 0;
        private Random random = new Random();

        private const int WAGE_PER_HOUR = 20;
        private const int FULL_DAY_HOURS = 8;

        public void AddEmployee(Employee employee)
        {
            if (count < employees.Length)
            {
                employees[count++] = employee;
            }
            else
            {
                Console.WriteLine("Employee array is full.");
            }
        }

        // UC1
        public void CheckAttendance()
        {
            for (int i = 0; i < count; i++)
            {
                employees[i].IsPresent = random.Next(0, 2) == 1;
            }
        }

        // UC2
        public void CalculateDailyWage()
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].IsPresent)
                {
                    employees[i].DailyWage = WAGE_PER_HOUR * FULL_DAY_HOURS;
                }
                else
                {
                    employees[i].DailyWage = 0;
                }
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
