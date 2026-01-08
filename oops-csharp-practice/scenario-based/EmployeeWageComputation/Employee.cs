using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.EmployeeWageComputation
{
    public class Employee
    {
        public int EmployeeId { get; private set; }
        public bool IsPresent { get; set; }

        public Employee(int employeeId)
        {
            EmployeeId = employeeId;
        }

        public override string ToString()
        {
            return IsPresent
                ? $"Employee {EmployeeId} is Present"
                : $"Employee {EmployeeId} is Absent";
        }
    }
}
