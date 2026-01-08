using System;

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
        public void CalculateMonthlyWage()
        {
            int MonthlyWage = 0;
            for (int i = 0; i < 20; i++)
            {
                int employe = random.Next(0, 3);

                if (employe == 0)
                {
                    MonthlyWage += 0;
                }
                else if (employe == 1)
                {
                    MonthlyWage += 80;
                }
                else
                {
                    MonthlyWage += 160;
                }

            }
            Console.Write("Monthly Wage= " + MonthlyWage + " of ");

        }


        // UC1 + UC2 + UC3 combined using switch case
        public void CalculateDailyWage()
        {
            for (int i = 0; i < count; i++)
            {
                // 0 = Absent, 1 = Full Time, 2 = Part Time
                int employeCheck = random.Next(0, 3);

                switch (employeCheck)
                {
                    case 1:
                        //Full time
                        employees[i].IsPresent = true;
                        employees[i].IsPartTime = false;
                        Console.WriteLine("Full Time ");
                        employees[i].DailyWage = Wage_Per_Hour * Full_Day_Hour;
                        break;

                    case 2:
                        //Part time
                        employees[i].IsPresent = true;
                        employees[i].IsPartTime = true;
                        Console.WriteLine("Part Time");
                        employees[i].DailyWage = Wage_Per_Hour * Part_Time_Hour;
                        break;

                    default: 
                        employees[i].IsPresent = false;
                        employees[i].IsPartTime = false;
                        employees[i].DailyWage = 0;
                        break;
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
