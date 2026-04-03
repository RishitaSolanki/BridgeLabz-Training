
using ScenarioBased.EmployeeWageComputation;

class EmployeeImpl : IEmployee
{
    private Employee[] employees = new Employee[15];
    private int count = 0;
    private Random employeeRandom = new Random();

    private const int WagePerHour = 20;
    private const int FullTimeHours = 8;
    private const int PartTimeHours = 8;

    private const int MaxWorkingDays = 20;
    private const int MaxWorkingHours = 100;

    public void AddEmployee(Employee employee)
    {
        if (count < employees.Length)
        {
            employees[count++] = employee;
        }
    }

    // UC6: Calculate wage till max hours OR max days is reached
    public void CalculateMonthlyWageWithCondition()
    {
        for (int i = 0; i < count; i++)
        {
            int totalDays = 0;
            int totalHours = 0;
            employees[i].MonthlyWage = 0;

            while (totalDays < MaxWorkingDays && totalHours < MaxWorkingHours)
            {
                totalDays++;
                // 0-Absent,1-FullTime,2-PartTime
                int employeeCheck = employeeRandom.Next(0, 3); 

                switch (employeeCheck)
                {
                    case 0: 
                        employees[i].IsPresent = false;
                        employees[i].DailyWage = 0;
                        break;

                    case 1: 
                        employees[i].IsPresent = true;
                        employees[i].IsPartTime = false;
                        totalHours += FullTimeHours;
                        employees[i].DailyWage = WagePerHour * FullTimeHours;
                        break;

                    case 2: 
                        employees[i].IsPresent = true;
                        employees[i].IsPartTime = true;
                        totalHours += PartTimeHours;
                        employees[i].DailyWage = WagePerHour * PartTimeHours;
                        break;
                }

                employees[i].MonthlyWage += employees[i].DailyWage;

                // Stop if hours condition is met
                if (totalHours >= MaxWorkingHours)
                {
                    break;
                }
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





















