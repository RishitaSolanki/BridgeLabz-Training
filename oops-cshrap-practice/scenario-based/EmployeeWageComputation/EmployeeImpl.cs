using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.EmployeeWageComputation
{

    public class EmployeeImpl : IEmployee
    {
        private Employee[] employees = new Employee[15];

        private int count = 0;

        private Random random = new Random();

        private const int Wage_Per_Hour = 20;

        private const int Full_Day_Hour = 8;

        private const int Part_Time_Hour = 4;




        public void AddEmployee(Employee emp)
        {
            if (count < employees.Length)
            {
                employees[count++] = emp;
            }
            else
            {
                Console.WriteLine("Employee array is full.");
            }
        }

      //UC1  
        public void CheckAttendance()
        {
            for (int i = 0; i < count; i++)
            {
                employees[i].IsPresent = random.Next(0, 2) == 1;

                if (employees[i].IsPresent)
                {
                    employees[i].IsPartTime = random.Next(0, 2) == 1;
                }


            }
        }

        //UC2
        public void CalculateDailyWage()
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].IsPresent)
                {
                    employees[i].DailyWage = Wage_Per_Hour * Full_Day_Hour;
                }
                else
                {
                    employees[i].DailyWage = 0;
                }
            }
        }
        //UC3
        public void CalculatePartTime()
        {
            for (int i = 0; i < count; i++)
            {

                if (employees[i].IsPresent && employees[i].IsPartTime)
                {

                    employees[i].CalculatePartTime = Wage_Per_Hour * Part_Time_Hour;

                }

            }
        }

        public void DisplayEmployees()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
