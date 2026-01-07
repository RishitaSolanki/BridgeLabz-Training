using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.EmployeeManagementSystem
{
   public class PartTimeEmployee : Employe
    {
        public int HoursWorked { get; set; }

        public double HourlyRate { get; set; }


        public override double CalculateSalary()
        {

            return HoursWorked * HourlyRate;

        }

    }
}
