  using System;

   public class IsFirstSmallest{
	public static void Main(string []args){
	
	//input Three nummber
	
		Console.WriteLine("Enter three number"); 
		
		int num1=Convert.ToInt32(Console.ReadLine());
		
		int num2=Convert.ToInt32(Console.ReadLine());
		
		int num3=Convert.ToInt32(Console.ReadLine());
		
		if(num1<num2&&num1<num3)
		{
		Console.WriteLine(" Is the first number the smallest? Yes");
		}
		
		else
		{			
	    Console.WriteLine(" Is the first number the smallest? No");
		}
		
		
	}
}