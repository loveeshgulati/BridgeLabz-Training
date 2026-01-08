using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.EmployeeWageComputation
{
    interface IEmployee
    {
            void AddEmployee(Employee employee);
            void CalculateMonthlyWage();   // UC5 (uses UC4 switch case)
            void DisplayEmployees();
        }
}
