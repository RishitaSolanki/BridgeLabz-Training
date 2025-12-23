using System;

 public class SumOfNNaturalNumber{
 
    public static void Main(string [] args)
    {
	//input number
        Console.Write("Enter a number ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            int total = 0;
            int i = 1;

            while (i <= num)
            {
                total = total+ i;
                i++;
            }

            int sumByFormula = num * (num + 1) / 2;

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
            Console.WriteLine("The number " + num + " is not a natural number.");
        }
    }
}