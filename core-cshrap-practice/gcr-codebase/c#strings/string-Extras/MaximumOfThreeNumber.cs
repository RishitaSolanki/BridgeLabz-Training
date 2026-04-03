using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings.stringExtras
{
    public class MaximumOfThreeNumber
    {
        
        public static void Main(string[] args)
        {
            //input values
            Console.Write("Input three numbers: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());


            //finding maximum
            Console.WriteLine("Maximum: " + FindMax(n1, n2, n3));
        }
        static int FindMax(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

    }
}
