using System;
using System.Collections.Generic;

namespace projectTwo.ObjectModeling
{
    //course class
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
            Console.WriteLine("Students enrolled in " + CourseName );
            foreach (Student s in enrolledStudents)
            {
                Console.WriteLine( s.Name);
            }
            Console.WriteLine();
        }
    }

    
    //another class student

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
                Console.WriteLine( c.CourseName);
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
            
            School school = new School("NR Public School");

            
            Student st1 = new Student("Rishita");
            Student st2 = new Student("Monty");

           
            school.AddStudent(st1);
            school.AddStudent(st2);

          
            Course c1 = new Course("Science");
            Course c2 = new Course("S.S.T");

            
            st1.EnrollCourse(c1);
            st1.EnrollCourse(c2);
            st2.EnrollCourse(c2);

            
            school.ShowStudents();

            st1.DisplayCourses();
            st2.DisplayCourses();

            c1.DisplayEnrolledStudents();
            c2.DisplayEnrolledStudents();
        }
    }
}

