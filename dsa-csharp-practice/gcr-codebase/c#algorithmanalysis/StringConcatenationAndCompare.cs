using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProjectThree.Sorting
{
    //Compare the performance of string (O(N²)), StringBuilder (O(N)), and StringBuffer (O(N)) when concatenating a million strings.
    public class StringConcatenationAndCompare
    {
        //Main Method
        public static void Main(string[] args)
        {
            int size = 5000;

            string[] names = { "Dev", "Loveesh", "Priyanshu" };

            Stopwatch sw = Stopwatch.StartNew();
            string s = "";

            for (int i = 0; i < size; i++)
            {
                s += names[i % 3];

            }

            sw.Stop();
            Console.WriteLine($"String Concatenation Time: {sw.Elapsed.TotalMilliseconds} ms");


            sw.Restart();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < size; i++)
            {
                sb.Append(names[i % 3]);
            }
            sw.Stop();

            Console.WriteLine($"StringBuilder Time: {sw.Elapsed.TotalMilliseconds} ms");
        }
    }
}

