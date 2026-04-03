using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.object_modeling
{
    class Student
    {
        public string Name { get; set; }
        private List<Course> courses = new List<Course>();

        //Constructor
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

                Console.WriteLine(Name + " enrolled in " + course.CourseName);
            }
        }

        public void ShowCourses()
        {
            Console.WriteLine("Courses enrolled by " + Name);
            foreach (Course c in courses)
            {
                Console.WriteLine("- " + c.CourseName);
            }
            Console.WriteLine();
        }
    }

    class Professor
    {
        public string Name { get; set; }

        //constructor
        public Professor(string entername)
        {
            this.Name = entername;
        }

        public void ShowProfessor()
        {
            Console.WriteLine("Professor: " + Name);
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        private List<Student> students = new List<Student>();
        private Professor professor;

        //constructor
        public Course(string entercourseName)
        {
            this.CourseName = entercourseName;
        }


        public void AddStudent(Student student)
        {
            if (!students.Contains(student))
            {
                students.Add(student);
            }
        }

        public void AssignProfessor(Professor prof)
        {
            professor = prof;
            Console.WriteLine(prof.Name + " is assigned to teach " + CourseName);
        }


        public void DisplayCourseDetails()
        {
            Console.WriteLine("Course: " + CourseName);

            if (professor != null)
                Console.WriteLine("Professor: " + professor.Name);

            Console.WriteLine("Students:");
            foreach (Student s in students)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
        }
    }

    class University
    {
        public string UniversityName { get; set; }

        private List<Student> students = new List<Student>();

        private List<Professor> professors = new List<Professor>();

        private List<Course> courses = new List<Course>();

        public University(string universityName)
        {
            UniversityName = universityName;
        }

        public void AddStudent(Student student) => students.Add(student);
        public void AddProfessor(Professor professor) => professors.Add(professor);
        public void AddCourse(Course course) => courses.Add(course);

        public void DisplayUniversityDetails()
        {
            Console.WriteLine("University: " + UniversityName);

            Console.WriteLine("Students:");
            foreach (Student s in students)
                Console.WriteLine(s.Name);

            Console.WriteLine("Professors:");
            foreach (Professor p in professors)
                Console.WriteLine(p.Name);

            Console.WriteLine("Courses:");
            foreach (Course c in courses)
                Console.WriteLine(c.CourseName);

            Console.WriteLine();
        }
    }

    class UniManagementSystem
    {
        public static void Main(String[] args)
        {

            University university1 = new University("GLA University");

            Student student1 = new Student("Rishita");
            Student student2 = new Student("Monty");

            Professor professor1 = new Professor("Shail Kumar");
            Professor professor2 = new Professor("Chirag Patil");

            Course course1 = new Course("Science");
            Course course2 = new Course("Electronics");


            university1.AddStudent(student1);
            university1.AddStudent(student2);

            university1.AddProfessor(professor1);
            university1.AddProfessor(professor2);

            university1.AddCourse(course1);
            university1.AddCourse(course2);

            university1.DisplayUniversityDetails();


            student1.EnrollCourse(course1);
            student2.EnrollCourse(course1);
            student2.EnrollCourse(course2);

            course1.AssignProfessor(professor1);
            course2.AssignProfessor(professor2);

            Console.WriteLine();

            student1.ShowCourses();
            student2.ShowCourses();

            course1.DisplayCourseDetails();
            course2.DisplayCourseDetails();
        }
    }
}
