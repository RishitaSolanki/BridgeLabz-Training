using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo
{
    public class EmployeeDetails
    {
        string name;
        int id;
        double salary;

        //Parameterized constructor
        public EmployeeDetails(string enterName, int enterId, double enterSalary)
        {
            this.name = enterName;
            this.id = enterId;
            this.salary = enterSalary;
        }

        //Method to show employee details
        public void ShowDetails()
        {
            Console.WriteLine("Employee Details are given below:");
            Console.WriteLine("Employee name is " + name);
            Console.WriteLine("Employee id is " + id);
            Console.WriteLine("Employee salary is " + salary);
        }

        //MAIN METHOD
        static void Main(string[] args)
        {
            EmployeeDetails employee1 = new EmployeeDetails("Rishita", 1466, 28000);
            employee1.ShowDetails();
        }


    }
}
