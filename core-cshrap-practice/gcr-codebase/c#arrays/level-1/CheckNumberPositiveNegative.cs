using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.array
{
    public class CheckNumberPositiveNegative
    {
        static void Main(string[] args)
        {
            //input number
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Enter Number " + (i + 1) + " :");
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 0)
                {
                    Console.WriteLine("Positive Number :");
                }
                else if (num[i] < 0)
                {
                    Console.WriteLine("Negative Number :");
                }
                else if (num[i] == 0)
                {
                    Console.WriteLine("Zero");
                }
                else
                {
                    if (num[i] % 2 == 0)
                    {
                        Console.WriteLine("Even Number");
                    }
                    else
                    {
                        Console.WriteLine("Odd Number");
                    }
                }

            }
            if (num[0] == num[num.Length - 1])
            {
                Console.WriteLine("The first element and last number are equal");
            }
            else if (num[0] < num[num.Length - 1])
            {
                Console.WriteLine("The first element is less than last element");
            }
            else
            {
                Console.WriteLine("The first element is greater than last number");
            }

        }
    }
}
