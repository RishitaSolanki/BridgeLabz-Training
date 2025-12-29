using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings.stringExtras
{
    public class GenrateFibonacciSequence
    {
        //main method
        public static void Main(string[] args)
        {
            Console.Write("Enter number of terms: ");
            int terms = Convert.ToInt32(Console.ReadLine());

            GenerateFibonacciSeries(terms);
        }

//----------------------------------
        static void GenerateFibonacciSeries(int terms)
        {
            int a = 0, b = 1;

            for (int i = 0; i < terms; i++)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }
        }

        

    }
}
