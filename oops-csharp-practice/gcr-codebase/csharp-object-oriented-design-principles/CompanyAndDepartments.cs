using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.object_modeling
{
    class Employee
    {
        public string EmployeeName;

        public Employee(string entername)
        {
            this.EmployeeName = entername;
        }
    }

    class Department
    {
        public string DepartmentName;
        public List<Employee> Employees;

        //parameterized constructor
        public Department(string enterdepartmentName)
        {
            this.DepartmentName = enterdepartmentName;
            this.Employees = new List<Employee>();
        }

        public void AddEmployee(string employeeName)
        {
            Employees.Add(new Employee(employeeName));
        }

    }
    class Company
    {
        public string CompanyName;
        public List<Department> Department;

        //parameterized constructor
        public Company(string entercompanyName)
        {
            this.CompanyName = entercompanyName;
            this.Department = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            Department.Add(department);
        }

        public void ShowCompanyDetails()
        {
            Console.WriteLine("Company: " + CompanyName);

            foreach (Department dept in Department)
            {
                Console.WriteLine("Department: " + dept.DepartmentName);

                foreach (Employee emp in dept.Employees)
                {
                    Console.WriteLine("Employee: " + emp.EmployeeName);
                }
            }
        }
    }

    // Main class
    class Composition
    {
        //Main Method
        public static void Main(String[] args)
        {

            Company company1 = new Company("Capgemini");

            Department itDepartment = new Department("IT");
            Department marketingDepartment = new Department("Marketing");

            itDepartment.AddEmployee("Pawan");
            itDepartment.AddEmployee("Manav");
            marketingDepartment.AddEmployee("Puneet");
            marketingDepartment.AddEmployee("Om");

            company1.AddDepartment(itDepartment);
            company1.AddDepartment(marketingDepartment);

            company1.ShowCompanyDetails();
        }
    }
}
