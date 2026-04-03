 using System;
 
 public class FactorialUsingWhileloop{
    public static void Main(string[] args){
	
	//input number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
		
        // Check for positive integer
        if (number <= 0){
            Console.WriteLine("Please enter a positive integer");
            return;
        }
		
        long factorial = 1;
        int i = 1;
        while (i <= number){
            factorial = factorial * i;
            i++;
        }
        Console.WriteLine("The factorial of " + number + " is " + factorial);
    }
}
