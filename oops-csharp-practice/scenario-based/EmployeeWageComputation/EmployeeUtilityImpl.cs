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
        private const int FULL_TIME_HOURS = 8;
        private const int PART_TIME_HOURS = 8;   // as per UC3

        public void AddEmployee(Employee employee)
        {
            if (count < employees.Length)
            {
                employees[count++] = employee;
            }
        }

        // UC1 - Attendance
        public void CheckAttendance()
        {
            for (int i = 0; i < count; i++)
            {
                employees[i].IsPresent = random.Next(0, 2) == 1;

                if (employees[i].IsPresent)
                {
                    // 0 = Full-Time, 1 = Part-Time
                    employees[i].IsPartTime = random.Next(0, 2) == 1;
                }
            }
        }

        // UC2 - Full-Time Wage
        public void CalculateDailyWage()
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].IsPresent && !employees[i].IsPartTime)
                {
                    employees[i].DailyWage = WAGE_PER_HOUR * FULL_TIME_HOURS;
                }
                else
                {
                    employees[i].DailyWage = 0;
                }
            }
        }

        // UC3 - Part-Time Wage
        public void CalculatePartTimeWage()
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].IsPresent && employees[i].IsPartTime)
                {
                    employees[i].DailyWage = WAGE_PER_HOUR * PART_TIME_HOURS;
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
