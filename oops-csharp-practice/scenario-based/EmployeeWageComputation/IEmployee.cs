using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.EmployeeWageComputation
{
    interface IEmployee
    {
        void AddEmployee(Employee employee);
        void CalculateMonthlyWageWithCondition(); // UC6
        void DisplayEmployees();
        }
}
