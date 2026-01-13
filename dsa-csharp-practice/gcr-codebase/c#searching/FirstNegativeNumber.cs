using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.Searching
{
    //A program that performs Linear Search to find the first negative number in the array.

    public class FirstNegativeNumber
    {
        //Main Method
        
         public static void Main(string[] args)
        {
            int[] array = { 2, 5, 8, -1, 6, -9 };

            bool foundnum = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Console.WriteLine("First negative number is : " + array[i]);
                    foundnum = true;
                    break;
                }
            }

            if (!foundnum)
            {
                Console.WriteLine("No negative number found");
            }
        }
    }

}

