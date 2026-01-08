using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.EmployeeWageComputation
{

    class Employee
    {
        public int EmployeeId { get; private set; }
        public bool IsPresent { get; set; }
        public bool IsPartTime { get; set; }   // BASIC flag
        public int DailyWage { get; set; }

        public Employee(int employeeId)
        {
            EmployeeId = employeeId;
        }

        public override string ToString()
        {
            string type = IsPartTime ? "Part-Time" : "Full-Time";
            return $"Employee {EmployeeId} | Present: {IsPresent} | Type: {type} | Daily Wage: {DailyWage}";
        }
    }

}
