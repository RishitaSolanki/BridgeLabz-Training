using System;

 public class SumOfNNaturalNumberUsingForLoop{
   public static void Main(string [] args)
    {
	//input nummber
        Console.Write("Enter a number ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            int total = 0;
           

            for(int i=1;i <= n;i++)
            {
                total = total+ i;
                
            }

            int sumByFormula = n * (n + 1) / 2;

            Console.WriteLine("Sum using while loop: " + total);
            Console.WriteLine("Sum using formula: " + sumByFormula);

            if (total == sumByFormula)
            {
                Console.WriteLine("Both results are correct and equal.");
            }
            else
            {
                Console.WriteLine("Results are not equal.");
            }
        }
        else
        {
            Console.WriteLine("The number " + n + " is not a natural number.");
        }
    }
}