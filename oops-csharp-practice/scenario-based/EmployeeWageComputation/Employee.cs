using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.EmployeeWageComputation
{
    class Employee
    {
        public int EmployeeId { get; private set; }
        public bool IsPresent { get; set; }//UC 1
        public int DailyWage { get; set; }//UC2

        public Employee(int employeeId)
        {
            EmployeeId = employeeId;
        }

        public override string ToString()
        {
            return $"Employee {EmployeeId} | Present: {IsPresent} | Daily Wage: {DailyWage}";
        }
    }

}
