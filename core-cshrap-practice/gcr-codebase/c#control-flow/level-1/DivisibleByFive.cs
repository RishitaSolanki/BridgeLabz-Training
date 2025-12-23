 using System;

  public class DivisibleByFive{
  
    public static void Main(string[] args)
    {
	//input number
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
		
  //if number is divisible by 5 then it,s reminder come 0
        if (n % 5 == 0)
        {
            Console.WriteLine("Is the number " + n + " divisible by 5? Yes");
        }
        else
        {
            Console.WriteLine("Is the number " + n + " divisible by 5? No");
        }
    }
}