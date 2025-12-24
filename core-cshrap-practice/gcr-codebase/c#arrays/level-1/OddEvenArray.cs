using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.array
{
    public class OddEvenArray
    {
        public static void Main(string[] args)
        {
            //Enter  number

            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("Not a natural number");
                return;
            }


            int size = (num / 2) + 1;
            int[] even = new int[size];
            int[] odd = new int[size];

            int EIndex = 0;
            int OIndex = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    even[EIndex] = i;
                    EIndex++;
                }

                else
                {
                    odd[OIndex] = i;
                   OIndex++;
                }
            }


            for (int i = 0; i < OIndex; i++)
            {
                Console.Write(odd[i] + " ");
            }


            for (int i = 0; i < EIndex; i++)
            {
                Console.Write(even[i] + " ");
            }


        }
    }
}
