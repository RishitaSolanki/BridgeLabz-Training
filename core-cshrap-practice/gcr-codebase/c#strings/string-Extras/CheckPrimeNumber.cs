using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings.stringExtras
{
    public class CheckPrimeNumber
    {
        //main method
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsitPrime(num) ? "Prime Number" : "Not a Prime Number");
        }

//--------------------------

        static bool IsitPrime(int n)
        {
            if (n <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;

            return true;
        }

        
    }
}
