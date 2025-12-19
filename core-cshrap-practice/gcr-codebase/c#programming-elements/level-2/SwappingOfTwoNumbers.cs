
  using System;
  
  public class SwappingOfTwoNumbers{
  
  public static void Main(string[] args){
  
  //Create a variable number1 and number2 and take user input.
    Console.Write("Enter First Number ");
  
    int n1=Convert.ToInt32(Console.ReadLine());
  
    Console.Write("Enter Second Number ");
	
	int n2=Convert.ToInt32(Console.ReadLine());
	
	//Swap number1 and number2 and print the swapped output.
	   int temp = n1;
        n1 = n2;
        n2 = temp;
		
		Console.WriteLine("The swapped numbers are " + n1 + " and " + n2);
		
  }
  }