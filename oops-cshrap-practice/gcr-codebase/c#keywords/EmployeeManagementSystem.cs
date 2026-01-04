using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.Keywords
{
    // employee class
    public class Employee
    {
        //attributes

        public static string CompanyName = "Capgemini";
        private static int totalEmployees = 0;


        public readonly int Id;
        public string Name;
        public string Designation;


        //Constructor
        public Employee(string enterName, int enterId, string enterDesignation)
        {
            this.Name = enterName;
            this.Id = enterId;
            this.Designation =enterDesignation;
            totalEmployees++;
        }

        //method to show total employee
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employees: " + totalEmployees);
        }


        //method to see employee details

        public void ShowEmployeeDetails(object employees)
        {

            if (employees is Employee)
            {
                Console.WriteLine("Company Name : " + CompanyName);

                Console.WriteLine("Employee Name: " + Name);

                Console.WriteLine("Employee ID  : " + Id);

                Console.WriteLine("Designation  : " + Designation);
            }

            else
            {
                Console.WriteLine("Invalid employee ");
            }
        }
    }

    //MAIN CLASS
    class EmployeeManagementSystem
    {
        //MAIN METHOD
        public static void Main(string[] args)
        {


            Employee em1 = new Employee("Rishita", 201, "Software Engineer");
            Employee em2 = new Employee("Monty", 202, "Software Engineer");


            em1.ShowEmployeeDetails(em1);
            Console.WriteLine();

            em2.ShowEmployeeDetails(em2);
            Console.WriteLine();

            Employee.DisplayTotalEmployees();
        }
    }
}
