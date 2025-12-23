 using System;

   public class CounterUsingForLoop{
   
   public static void Main(string[] args)
    {
	//enter number
        Console.Write("Enter countdown number");
		
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = num; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}