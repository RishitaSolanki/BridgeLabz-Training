using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.EmployeeManagementSystem
{
    public class EmployeeManagementSystem
    {
        public static void Main(string[] args) {

            Employe[] employees = new Employe[4];

            employees[0] = EmployeeUtility.CreateFullTimeEmployee(
                    201, "Rishita", 40000, "HR");

           
            employees[1] = EmployeeUtility.CreatePartTimeEmployee(
                203, "Rama", 80,38000, "IT");


            employees[2] = EmployeeUtility.CreatePartTimeEmployee(
               204, "Loveesh", 80, 34000, "CS");


            employees[3] = EmployeeUtility.CreatePartTimeEmployee(
               205, "Dev", 80, 35000, "HR");



            EmployeeProcessor Eprocessor = new EmployeeProcessor();

            Eprocessor.DisplayEmployees(employees);
        }
    }
}

