 using System;
 
 public class EmployeeBonus{
	public static void Main(string[] args){
	
	 //input salary
		Console.Write("Enter employee salary");	
		int salary = Convert.ToInt32(Console.ReadLine());
	
     //input year of service	
		Console.Write("Enter years of service");
		int yearsOfService = Convert.ToInt32(Console.ReadLine());
		
		double bonus =0;
		
		if(yearsOfService > 5){
		
			bonus = salary * 0.05;
		}
		Console.WriteLine("The bonus amount is :" + bonus);
	}
}	