using System;

  public class AbundantNumberCheck{
  
    public static void Main(string[] args)
    {
	
	//input number
        Console.WriteLine("Enter the number:");
		
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }

        if (sum > num)
        {
            Console.WriteLine("Yes, it is an Abundant Number");
        }
        else
        {
            Console.WriteLine("Not an Abundant Number");
        }
    }
}