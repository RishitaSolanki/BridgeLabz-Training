using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings.stringExtras
{

    public class FactorialUsingRecursion
    {
        //main method
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial: " + FindingFactorial(num));
        }

        //------------------------
        static int FindingFactorial(int n)
        {
            if (n == 0) return 1;
            return n * FindingFactorial(n - 1);
        }



    }
}
