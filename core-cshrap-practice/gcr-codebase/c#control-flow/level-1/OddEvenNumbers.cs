 using System;
 
 public class OddEvenNumbers{
 
 public static void Main(string[] args){
 
 //input number
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
		
        // Check for natural number
        if (num<= 0){
            Console.WriteLine("Please enter a natural number");
            return;
        }
		
		//check even odd
        for (int i = 1; i <= num; i++){
            if (i % 2 == 0){
                Console.WriteLine(i + " is an even number");
            }
            else{
                Console.WriteLine(i + " is an odd number");
            }
        }
    }
}
