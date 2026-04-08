using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProjectThree.Searching
{

//A program that compares the performance of StringBuilder for concatenating strings multiple times.

    public class StringPerformanceTest
    {
        //Main Method
       public static void Main(string[] args)
        {
            int iterations =5000;

            Stopwatch sw1 = Stopwatch.StartNew();

            string result = "";

            for (int i = 0; i < iterations; i++)
            {
                result += "a";
            }

            sw1.Stop();
            Console.WriteLine("String Time: " + sw1.ElapsedMilliseconds + " ms");

            
            Stopwatch sw2 = Stopwatch.StartNew();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < iterations; i++)
            {
                sb.Append("a");
            }

            sw2.Stop();

            Console.WriteLine("StringBuilder Time: " + sw2.ElapsedMilliseconds + " ms");
        }
    }

}

