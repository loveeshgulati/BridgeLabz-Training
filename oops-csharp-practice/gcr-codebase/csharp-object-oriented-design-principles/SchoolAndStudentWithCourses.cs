using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.object_modeling
{
    class Course
    {
        public string CourseName { get; set; }
        private List<Student> enrolledStudents = new List<Student>();

        //parameterized constructor
        public Course(string entercourseName)
        {
            this.CourseName = entercourseName;
        }

        //method to add student
        public void AddStudent(Student student)
        {
            if (!enrolledStudents.Contains(student))
            {
                enrolledStudents.Add(student);
            }
        }

        public void DisplayEnrolledStudents()
        {
            Console.WriteLine("Students enrolled in " + CourseName);
            foreach (Student s in enrolledStudents)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
        }
    }
    class Student
    {
        public string Name { get; set; }
        private List<Course> courses = new List<Course>();

        //parameterized constructor
        public Student(string entername)
        {
            this.Name = entername;
        }

        public void EnrollCourse(Course course)
        {
            if (!courses.Contains(course))
            {
                courses.Add(course);
                course.AddStudent(this);
            }
        }

        public void DisplayCourses()
        {
            Console.WriteLine(Name + " is enrolled in");
            foreach (Course c in courses)
            {
                Console.WriteLine(c.CourseName);
            }
            Console.WriteLine();
        }
    }


    //another class school
    class School
    {
        public string SchoolName { get; set; }
        private List<Student> students = new List<Student>();

        public School(string schoolName)
        {
            SchoolName = schoolName;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void ShowStudents()
        {
            Console.WriteLine($"Students in {SchoolName}:");
            foreach (Student s in students)
            {
                Console.WriteLine("- " + s.Name);
            }
            Console.WriteLine();
        }
    }

    //Main class
    class AssociationAndAggregation
    {
        //MAIN METHOD
        public static void Main(String[] args)
        {

            School school = new School("KCM School");


            Student student1 = new Student("Amar");
            Student student2 = new Student("Om");


            school.AddStudent(student1);
            school.AddStudent(student2);


            Course course1 = new Course("C#");
            Course course2 = new Course("JAVA");


            student1.EnrollCourse(course1);
            student1.EnrollCourse(course1);
            student2.EnrollCourse(course2);


            school.ShowStudents();

            student1.DisplayCourses();
            student2.DisplayCourses();

            course1.DisplayEnrolledStudents();
            course2.DisplayEnrolledStudents();
        }
    }
}
