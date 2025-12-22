
 using System;
 
 public class FizzBuzz {
    public static void Main(string[] args) {
        
        Console.Write("Enter the number");
        int number=Convert.ToInt32(Console.ReadLine());

        // Check if the number is positive
        if (number <= 0) {
            Console.WriteLine("The number must be a positive integer.");
        }

        // FizzBuzz logic
		
        for (int i = 1; i <= number; i++) {
		
            if (i % 3 == 0 && i % 5 == 0) {
			
                Console.WriteLine("FizzBuzz");
            }
			
			else if (i % 3 == 0) {
			
                Console.WriteLine("Fizz");
            }
			
			else if (i % 5 == 0) {
			
              Console.WriteLine("Buzz");
            }
        }


    }
}