  using System;

  public class TotalIncomeOfPerson{
  
  public static void Main(string[] args) {
  
  //Create a variable named salary and take user input.
  Console.Write("Enter salary: ");
  
  double salaryOfperson = Convert.ToDouble(Console.ReadLine());
  
 //Create another variable bonus and take user input.
  Console.Write("Enter bonus: ");
  
  double bonusOfperson = Convert.ToDouble(Console.ReadLine());
  
  double incomeOfperson=salaryOfperson+bonusOfperson;
  
  Console.WriteLine("The salary is INR " + salaryOfperson + " and bonus is INR " + 
  bonusOfperson + " Hence Total Income is INR " + incomeOfperson);
  
  }
  }

  
  
  
  
  
  
  