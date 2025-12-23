  using System;

 public class FactorialUsingForloop{
    public static void Main(string[] args){
	
	//input number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
		
        // Check for natural number
        if (number <= 0){
            Console.WriteLine("Please enter a natural number");
            return;
        }
		
        long fact = 1;
        for (int i = 1; i <= number; i++){
            fact = fact * i;
        }
        Console.WriteLine("The factorial of " + number + " is " + fact);
    }
}