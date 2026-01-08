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
        private const int WORKING_DAYS = 20;

        public void AddEmployee(Employee employee)
        {
            if (count < employees.Length)
            {
                employees[count++] = employee;
            }
        }

        // UC5: Calculate Monthly Wage (using UC4 switch case logic)
        public void CalculateMonthlyWage()
        {
            for (int i = 0; i < count; i++)
            {
                employees[i].MonthlyWage = 0;

                for (int day = 1; day <= WORKING_DAYS; day++)
                {
                    int employeeCheck = employeeRandom.Next(0, 3); // 0-Absent,1-FullTime,2-PartTime

                    switch (employeeCheck)
                    {
                        case 0: // Absent UC1
                            employees[i].IsPresent = false;
                            employees[i].DailyWage = 0;
                            break;

                        case 1: // Full-Time UC 2
                            employees[i].IsPresent = true;
                            employees[i].IsPartTime = false;
                            employees[i].DailyWage = WAGE_PER_HOUR * FULL_TIME_HOURS;
                            break;

                        case 2: // Part-Time UC 3
                            employees[i].IsPresent = true;
                            employees[i].IsPartTime = true;
                            employees[i].DailyWage = WAGE_PER_HOUR * PART_TIME_HOURS;
                            break;
                    }

                    employees[i].MonthlyWage += employees[i].DailyWage;
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
