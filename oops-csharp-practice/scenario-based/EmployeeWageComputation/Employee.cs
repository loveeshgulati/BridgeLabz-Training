using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.EmployeeWageComputation
{
    class Employee
    {
        public int EmployeeId { get; private set; }
        public bool IsPresent { get; set; }// uc 1
        public bool IsPartTime { get; set; }// uc 3
        public int DailyWage { get; set; }// uc 2
        public int MonthlyWage { get; set; }// uc 5
        public int TotalWorkingHours {  get; set; }

        public Employee(int employeeId)
        {
            EmployeeId = employeeId;
        }

        public override string ToString()
        {
            string status = IsPresent
                ? (IsPartTime ? "Part-Time" : "Full-Time"): "Absent";
            return $"Employee {EmployeeId} | Status: {status} | Daily Wage: {DailyWage} | Monthly Wage: {MonthlyWage}| Total Hours Employee Worked :{TotalWorkingHours}";
        }
    }

}
