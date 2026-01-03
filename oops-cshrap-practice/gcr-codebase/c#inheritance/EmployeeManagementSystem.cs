using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.Inheritence
{
    public class EmployeeManagementSystem
    {
        public string empName;
        public int empCode;
        public double empPay;

        public EmployeeManagementSystem(string Name, int Code, double Pay)
        {
            this.empName = Name;
            this.empCode = Code;
            this.empPay =  Pay;
        }

        public virtual void showInfo()
        {
            Console.WriteLine("Employee Name : " + empName);
            Console.WriteLine("Employee Code : " + empCode);
            Console.WriteLine("Monthly Pay   : " + empPay);
        }
    }

    class TeamLead : EmployeeManagementSystem
    {
        public int TeamMemberCount;

        public TeamLead(string Name, int Code, double Pay, int memberCount)
            : base(Name, Code, Pay)
        {
            this.TeamMemberCount = memberCount;
        }

        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine("Total Team Members : " + TeamMemberCount);
        }
    }

    class SoftwareEngineer : EmployeeManagementSystem
    {
        public string techStack;

        public SoftwareEngineer(string empName, int empCode, double empPay, string techStack)
            : base(empName, empCode, empPay)
        {
            this.techStack = techStack;
        }

        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine("Technology Used : " + techStack);
        }
    }

    class Trainee : EmployeeManagementSystem
    {
        public string trainingPeriod;

        public Trainee(string empName, int empCode, double empPay, string trainingPeriod)
            : base(empName, empCode, empPay)
        {
            this.trainingPeriod = trainingPeriod;
        }

        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine("Training Period : " + trainingPeriod);
        }
    }

    class CompanySystem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Team Lead details Name, Code, Salary, Team Count");
            string leadName = Console.ReadLine();
            int leadCode = Convert.ToInt32(Console.ReadLine());

            double leadSalary = Convert.ToDouble(Console.ReadLine());

            int teamCount = Convert.ToInt32(Console.ReadLine());

            TeamLead lead = new TeamLead(leadName, leadCode, leadSalary, teamCount);


            Console.WriteLine("Enter Software Engineer details Name, Code, Salary, Technology");
            string engName = Console.ReadLine();

            int engCode = Convert.ToInt32(Console.ReadLine());

            double engSalary = Convert.ToDouble(Console.ReadLine());

            string technology = Console.ReadLine();

            SoftwareEngineer engineer = new SoftwareEngineer(engName, engCode, engSalary, technology);


            Console.WriteLine("Enter Trainee details Name, Code, Salary, Duration");
            string traineeName = Console.ReadLine();

            int traineeCode = Convert.ToInt32(Console.ReadLine());

            double traineeSalary = Convert.ToDouble(Console.ReadLine());

            string period = Console.ReadLine();


            Trainee trainee = new Trainee(traineeName, traineeCode, traineeSalary, period);

            Console.WriteLine("\n--TEAM LEAD INFO--");
            lead.showInfo();

            Console.WriteLine("\n--ENGINEER INFO--");
            engineer.showInfo();

            Console.WriteLine("\n--TRAINEE INFO--");
            trainee.showInfo();
        }
    }
}
