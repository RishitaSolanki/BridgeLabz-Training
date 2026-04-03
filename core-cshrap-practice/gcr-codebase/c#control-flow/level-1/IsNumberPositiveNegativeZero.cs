   using System;

   public class IsNumberPositiveNegativeZero{
    public static void Main()
    {
	
	//input number
        Console.Write("Enter a number ");
        int number = Convert.ToInt32(Console.ReadLine());

//if greater then 0 , num is positive
        if (number > 0)
        {
            Console.WriteLine("positive");
        }
		
//if less than 0,num is negative		
        else if (number < 0)
        {
            Console.WriteLine("negative");
        }
				
        else
        {
            Console.WriteLine("zero");
        }
    }
}