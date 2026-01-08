using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.EmployeeWageComputation
{
    public interface IEmployee
    {
        void LoadPredefinedEmployees();
        void AddEmployee(Employee employee);
        void CheckAttendance();
        void DisplayEmployees();
    }
}
