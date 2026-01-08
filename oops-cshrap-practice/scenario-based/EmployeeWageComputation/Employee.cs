using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.EmployeeWageComputation
{
   public class Employee
    {
        public int EmployeeId { get; private set; }
        public bool IsPresent { get; set; }
        public int DailyWage { get; set; }

        public bool IsPartTime { get; set; }

        public int CalculatePartTime { get; set; }


        public Employee(int employeeId)
        {
            this.EmployeeId = employeeId;
        }

        public override string ToString()
        {
            return $"Employee {EmployeeId} | Present: {IsPresent} | Daily Wage: {DailyWage} ";
        }
    }
}
