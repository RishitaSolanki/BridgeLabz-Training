 using System;

 public class SumOfNumberTrue{
 
    public static void Main(String []args)
    {
        double total = 0.0;
        double val;

        Console.Write("Enter a number press 0 to stop the the program ");
        val = Convert.ToDouble(Console.ReadLine());

        while (true)
        {
			if(val<=0) break;
            total = total + val;

            Console.Write("Enter a number (0 to stop): ");
            val = Convert.ToDouble(Console.ReadLine());
			
        }

        Console.WriteLine("The total is " + total);
    }
}