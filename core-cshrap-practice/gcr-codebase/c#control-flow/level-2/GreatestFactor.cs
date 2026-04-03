using System;

   public class GreatestFactor{

   public static void Main(string[] args){
	
        // input user	
		
        Console.Write("Enter a number: ");
		
        int num = Convert.ToInt32(Console.ReadLine());
		

        int greatestFactor = 1;  // initialize with 1

       // for loop
	   
        for (int i = num - 1; i >= 1; i--)
        {
			
            if (num % i == 0)
            {
                greatestFactor = i;
                break;   // break the loop
            }
        }

        Console.WriteLine("The greatest factor is: " + greatestFactor);
    }
}