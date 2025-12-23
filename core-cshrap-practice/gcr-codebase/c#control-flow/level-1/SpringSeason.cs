   using System;

  public class SpringSeason{
   public static void Main(string[] args)
    {
		Console.WriteLine("Enter month and day");
		//input month
        int month = Convert.ToInt32(Console.ReadLine());
		
		//input day
        int day = Convert.ToInt32(Console.ReadLine());

        if ((month == 3 && day >= 20) ||(month == 4) ||(month == 5) ||(month == 6 && day <= 20))
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}