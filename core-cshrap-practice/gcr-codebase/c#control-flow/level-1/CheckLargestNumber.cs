using System;

 public class CheckLargestNumber{
   public static void Main(string[] args)
    {
	//input Three Number
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        bool firstLargest = (num1 > num2 && num1 > num3);
        bool secondLargest = (num2 > num1 && num2 > num3);
        bool thirdLargest = (num3 > num1 && num3 > num2);

        Console.WriteLine("Is the first number the largest? " + firstLargest);
        Console.WriteLine("Is the second number the largest? " + secondLargest);
        Console.WriteLine("Is the third number the largest? " + thirdLargest);
    }
}