using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.EmployeeWageComputation
{
    public class EmployeeMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Employee Wage Computation");

            EmployeeMenu menu = new EmployeeMenu();
            menu.DisplayMenu();
        }
    }
}
