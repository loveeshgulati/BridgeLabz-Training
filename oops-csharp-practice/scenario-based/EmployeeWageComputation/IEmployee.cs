using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.EmployeeWageComputation
{
    interface IEmployee
    {
        void AddEmployee(Employee employee);
        void CheckAttendance();        // UC1
        void CalculateDailyWage();     // UC2 (Full-Time)
        void CalculatePartTimeWage();  // UC3
        void DisplayEmployees();

    }

}
