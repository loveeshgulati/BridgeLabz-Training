using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.object_modeling
{
    class Faculty
    {
        public string Name { get; set; }

        //constructor
        public Faculty(string entername)
        {
            this.Name = entername;
        }

        public void DisplayFaculty()
        {
            Console.WriteLine("Faculty Name: " + Name);
        }
    }

    class Department
    {
        public string DepartmentName { get; set; }

        //constructor
        public Department(string enterdepartmentName)
        {
            this.DepartmentName = enterdepartmentName;
        }

        public void DisplayDepartment()
        {
            Console.WriteLine("Department name : " + DepartmentName);
        }
    }
    class University
    {
        public string UniversityName { get; set; }

        private List<Department> departments = new List<Department>();
        private List<Faculty> facultyMembers = new List<Faculty>();

        //constructor
        public University(string enteruniversityName)
        {
            this.UniversityName = enteruniversityName;
        }
        public void AddDepartment(string departmentName)
        {
            departments.Add(new Department(departmentName));
        }

        public void AddFaculty(Faculty faculty)
        {
            facultyMembers.Add(faculty);
        }

        public void ShowUniversityDetails()
        {
            Console.WriteLine(UniversityName);

            Console.WriteLine("Departments: ");
            foreach (Department D in departments)
            {
                D.DisplayDepartment();
            }

            Console.WriteLine("Faculty Members: ");
            foreach (Faculty F in facultyMembers)
            {
                F.DisplayFaculty();
            }
        }
    }

    //Main class
    class CompositionaAndAggregation
    {
        //MAIN METHOD
        public static void Main(String[] args)
        {

            Faculty faculty1 = new Faculty("Shail kumar");
            Faculty faculty2 = new Faculty("Chirag kumar");

            University university1 = new University("GLA University");

            university1.AddDepartment("Computer Science and Engineering");
            university1.AddDepartment("Civil Engineering");

            university1.AddFaculty(faculty1);
            university1.AddFaculty(faculty2);

            university1.ShowUniversityDetails();

            Console.WriteLine("University is deleted...");

            university1 = null;

            faculty1.DisplayFaculty();
            faculty2.DisplayFaculty();
        }
    }
}
