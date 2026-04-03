using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.EmployeeManagementSystem
{
     public class FullTimeEmployee:Employe
    {
        public override double CalculateSalary()
        {

            return BaseSalary;

        }
    }
}
