using System;

 public class SumOfNumber{
    public static void Main(string []args)
    {
        double total = 0.0;
		
//Input number
        Console.Write("Enter a number press 0 to stop the the program ");
        double value = Convert.ToDouble(Console.ReadLine());

        while (value != 0)
        {
            total = total + value;

            Console.Write("Enter a number (0 to stop): ");
            value = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("The total is " + total);
    }
}