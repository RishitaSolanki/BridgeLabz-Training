  using System;

 public class Counter{
   public static void Main(string[] args)
    {
	//input countdown  number
        Console.Write("Enter countdown number  ");
		
        int counter = Convert.ToInt32(Console.ReadLine());

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter = counter - 1;
        }
    }
}