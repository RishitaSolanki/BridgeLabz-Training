using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.Keywords;

//student class

public class Student
{
    public static string UniversityName = "GLA University";
    private static int totalStudents = 0;
    public readonly int RollNumber;
    public string Name;
    public char Grade;

    //constructor
    public Student(string enterName, int enterRollNumber, char enterGrade)
    {
        this.Name = enterName;
        this.RollNumber = enterRollNumber;
        this.Grade = enterGrade;
        totalStudents++;
    }


    public static void showTotalStudents()
    {

        Console.WriteLine("Total Students Enrolled in University: " + totalStudents);

    }


    public void showStudentDetails(object student)
    {
        if (student is Student)
        {
            Console.WriteLine("University Name : " + UniversityName);

            Console.WriteLine("Student Name    : " + Name);

            Console.WriteLine("Roll Number     : " + RollNumber);

            Console.WriteLine("Grade           : " + Grade);
        }
        else
        {
            Console.WriteLine("Invalid student ");
        }
    }

    public void UpdatingGrade(object student, char newGrade)
    {
        if (student is Student)
        {
            Grade = newGrade;
            Console.WriteLine("Grade updated successfully.");
        }
        else
        {
            Console.WriteLine("Grade update failed.");
        }
    }
}
class UniversityStudentManagement
{
    static void Main(string[] args)
    {
        Student stu1 = new Student("Rishita", 201, 'C');
        Student stu2 = new Student("Monty", 202, 'D');


        stu1.showStudentDetails(stu1);
        Console.WriteLine();


        stu2.showStudentDetails(stu2);
        Console.WriteLine();


    //updating grade
        stu1.UpdatingGrade(stu1, 'A');
        stu1.showStudentDetails(stu1);
        Console.WriteLine();

        Student.showTotalStudents();
    }
}
