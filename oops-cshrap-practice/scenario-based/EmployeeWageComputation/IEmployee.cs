using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.EmployeeWageComputation
{

    public interface IEmployee
    {
        void AddEmployee(Employee emp);
        void CalculateMonthlyWageWithCondition();
        void DisplayEmployees();
    }
}
