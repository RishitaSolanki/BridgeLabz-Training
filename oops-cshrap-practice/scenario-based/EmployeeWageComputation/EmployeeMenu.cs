using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.EmployeeWageComputation
{
    class EmployeeMenu
    {
        private IEmployee employeeService = new EmployeeImpl();

        public void DisplayMenu()
        {
            Console.Write("Enter number of employees (min 1 - max 15): ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter Employee " + (i + 1) + " ID: ");

                int yourid = Convert.ToInt32(Console.ReadLine());

                employeeService.AddEmployee(new Employee(yourid));
            }
            while (true)
            {
                Console.WriteLine("Employee Wage Computation Menu");
                Console.WriteLine("1. Display Employee");
                Console.WriteLine("2. Calculate Monthly Wage with condition");
                Console.WriteLine("3. Exit");
                Console.Write("What you want to see:  ");

                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        employeeService.DisplayEmployees();
                        break;

                    case 2:
                        employeeService.CalculateMonthlyWageWithCondition();
                        employeeService.DisplayEmployees();
                        break;

                    case 3:
                        Console.WriteLine("Ok Thankyou!..");
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Choice");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}
