using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.EmployeeWageComputation
{
    class Employee
    {
        public int EmployeeId { get; private set; }
        public bool IsPresent { get; set; }
        public bool IsPartTime { get; set; }
        public int DailyWage { get; set; }

        public Employee(int employeeId)
        {
            EmployeeId = employeeId;
        }

        public override string ToString()
        {
            string type = IsPresent
                ? (IsPartTime ? "Part-Time" : "Full-Time")
                : "Absent";

            return $"Employee {EmployeeId} | Status: {type} | Daily Wage: {DailyWage}";
        }
    }


}
