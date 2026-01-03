using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.accessModifier
{
    //parent class
    public class Student
    {
        public int rollNumber;
        protected string name;
        private double cgpa;

        //parameterized constructor
        public Student(int rollNumber, string name, double cgpa)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.cgpa = cgpa;
        }

        //method to get double CGPA
        public double GetCgpa()
        {
            return cgpa;
        }

        //method to update CGPA
        public void UpdateCgpa(double newCgpa)
        {
            if (newCgpa >= 0.0 && newCgpa <= 10.0)
            {
                cgpa = newCgpa;
            }
            else
            {
                Console.WriteLine("Invalid CGPA");
            }
        }


    }

    //child class
    public class PostGraduateStudent : Student
    {
        private string courseName;

        public PostGraduateStudent(int rollNumber, string name, double cgpa, string courseName) : base(rollNumber, name, cgpa)
        {
            this.courseName = courseName;
        }


        public void ShowStudentDetails()
        {
            Console.WriteLine("Roll number " + rollNumber);
            Console.WriteLine("name " + name);
            Console.WriteLine("cgpa " + GetCgpa());
            Console.WriteLine("Course Name " + courseName);
        }
    }


    public class UniversityManagementSystem
    {

        //MAIN METHOD
        static void Main(string[] args)
        {
            PostGraduateStudent postGraduateStudent1 = new PostGraduateStudent(101, "Anmol", 8.6, "B.Tech");
            postGraduateStudent1.ShowStudentDetails();
            postGraduateStudent1.UpdateCgpa(9.2);
            Console.WriteLine("Update Cgpa " + postGraduateStudent1.GetCgpa());
        }
    }
}
