
  using System;
  
  public class DoubleOperation{
  
  public static void Main(string[] args){
  
  //take 3 number from users
      Console.Write("Enter First Number ");
	  
	  double a=Convert.ToDouble(Console.ReadLine());
	  
	  Console.Write("Enter Second Number ");
	  
	  double b=Convert.ToDouble(Console.ReadLine());
	  
	  Console.Write("Enter Third Number ");
	  
	  double c=Convert.ToDouble(Console.ReadLine());
	  
	  double operation1=a + b * c;
	  
	  double operation2=a * b + c;
	  
	  double operation3=c + a / b;
	  
	  double operation4=a % b + c;
	  
	  Console.WriteLine("The results of Double Operations are " + operation1 + "," + operation2 + "," + operation3 + " and " + operation4 );
	  
  }
  }
