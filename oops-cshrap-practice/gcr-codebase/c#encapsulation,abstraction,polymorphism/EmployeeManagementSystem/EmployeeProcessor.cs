using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.EmployeeManagementSystem
{
    class EmployeeProcessor
    {
        public void DisplayEmployees(Employe[] employees)
        {

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].showDetails();
            }

        }
    }
}
