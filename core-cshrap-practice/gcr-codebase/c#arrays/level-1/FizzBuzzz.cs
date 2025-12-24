using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.array
{
    public class FizzBuzzz
    {
       public static void Main(string[] args)
        {
            //input number
            Console.WriteLine("Enter Number");

            int n = Convert.ToInt32(Console.ReadLine());


            if (n <= 0)
            {
                Console.Write("Please enter a positive number :");
                return;
            }


            string[] result = new string[n + 1];

            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    result[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    result[i] = "Buzz";
                }
                else
                {
                    result[i] = i.ToString();
                }
            }


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Position " + i + " = " + result[i]);
            }
        }
    }
}
