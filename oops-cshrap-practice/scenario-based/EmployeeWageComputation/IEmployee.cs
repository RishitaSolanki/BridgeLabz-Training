using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.EmployeeWageComputation
{

    public interface IEmployee
    {
        void AddEmployee(Employee employee);
        void CheckAttendance();
        void CalculateDailyWage();
        void CalculatePartTime();
        void DisplayEmployees();
    }
}
