using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.EmployeeWageComputation
{

    class EmployeeUtilityImpl : IEmployee
    {
        private Employee[] employees = new Employee[15];
        private int count = 0;
        private Random employeeRandom = new Random();

        private const int WAGE_PER_HOUR = 20;
        private const int FULL_TIME_HOURS = 8;
        private const int PART_TIME_HOURS = 8;

        public void AddEmployee(Employee employee)
        {
            if (count < employees.Length)
            {
                employees[count++] = employee;
            }
        }

        // UC4: Switch Case Statement
        public void CalculateDailyWageUsingSwitch()
        {
            for (int i = 0; i < count; i++)
            {
                int empCheck = employeeRandom.Next(0, 3); // 0,1,2

                switch (empCheck)
                {
                    case 0: // Absent
                        employees[i].IsPresent = false;
                        employees[i].DailyWage = 0;
                        break;

                    case 1: // Full-Time
                        employees[i].IsPresent = true;
                        employees[i].IsPartTime = false;
                        employees[i].DailyWage = WAGE_PER_HOUR * FULL_TIME_HOURS;
                        break;

                    case 2: // Part-Time
                        employees[i].IsPresent = true;
                        employees[i].IsPartTime = true;
                        employees[i].DailyWage = WAGE_PER_HOUR * PART_TIME_HOURS;
                        break;
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
