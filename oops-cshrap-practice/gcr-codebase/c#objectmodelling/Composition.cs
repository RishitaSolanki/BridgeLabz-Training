using System;
using System.Collections.Generic;

//Employee class
class Employee
{
    public string EmployeeName;

    public Employee(string entername)
    {
        this.EmployeeName = entername;
    }
}

//another class named as department
class Department
{
    public string DepartmentName;
    public List<Employee> Employees;

    //parameterized constructor
    public Department(string enterdepartmentName)
    {
        this.DepartmentName = enterdepartmentName;
        this.Employees = new List<Employee>();
    }

    public void AddEmployee(string employeeName)
    {
        Employees.Add(new Employee(employeeName));
    }

}

//another class named as company
class Company
{
    public string CompanyName;
    public List<Department> Department;

    //parameterized constructor
    public Company(string entercompanyName)
    {
        this.CompanyName = entercompanyName;
        this.Department = new List<Department>();
    }

    public void AddDepartment(Department department)
    {
        Department.Add(department);
    }

    public void ShowCompanyDetails()
    {
        Console.WriteLine("Company: " + CompanyName);

        foreach (Department dept in Department)
        {
            Console.WriteLine("Department: " + dept.DepartmentName);

            foreach (Employee emp in dept.Employees)
            {
                Console.WriteLine("Employee: " + emp.EmployeeName);
            }
        }
    }
}

// Main class
class Composition
{
    //Main Method
   public static void Main(String[] args)
    {
        
        Company com = new Company("--Capgemini--");

        
        Department itDept = new Department("IT");
        Department hrDept = new Department("HR");

        
        itDept.AddEmployee("Rishita");
        itDept.AddEmployee("Monty");

        hrDept.AddEmployee("Rama");
        hrDept.AddEmployee("Janvi");

        
        com.AddDepartment(itDept);
        com.AddDepartment(hrDept);

      
        com.ShowCompanyDetails();

        
    }
}
