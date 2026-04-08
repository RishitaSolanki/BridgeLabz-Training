using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.Searching
{

    // a program that uses StringBuilder to remove all duplicate characters from a given string while maintaining the original order.
    public class RemoveDuplicates
    {
        //Main method
        public static void Main()
        {
            string input = "Hellllloooo";
            StringBuilder sBuilder = new StringBuilder();

            foreach (char ch in input)
            {
                if (!sBuilder.ToString().Contains(ch))
                {
                    sBuilder.Append(ch);
                }
            }

            Console.WriteLine("after removing duplicates: " + sBuilder.ToString());
        }
    }
}