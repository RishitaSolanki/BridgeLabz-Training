using System;
using System.Collections.Generic;

namespace projectTwo.ObjectModeling
{
    
    //class faculty
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

 //another class named as department
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

    //another class named as university
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine( UniversityName);
            Console.ResetColor();

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
           
            Faculty fac1 = new Faculty("Shail kumar");
            Faculty fac2 = new Faculty("Chirag kumar");

            
            University uni = new University("GLA University");
            
            
            uni.AddDepartment("Computer Science and Engineering");
            uni.AddDepartment("Civil Engineering");

            
            uni.AddFaculty(fac1);
            uni.AddFaculty(fac2);

           
            uni.ShowUniversityDetails();

            Console.WriteLine("University is deleted...");

           
            uni = null;

           
            fac1.DisplayFaculty();
            fac2.DisplayFaculty();
        }
    }
}
