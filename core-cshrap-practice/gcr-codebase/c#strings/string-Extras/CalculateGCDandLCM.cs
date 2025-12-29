using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings.stringExtras
{
    public class CalculateGCDandLCM
    {

        //main method
        public static void Main(string[] args)
        {
            Console.Write("Enter two numbers: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("GCD: " + GCD(n1, n2));
            Console.WriteLine("LCM: " + LCM(n1, n2));
        }

//-----------------------
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

//------------------------
        static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }


    }
}
