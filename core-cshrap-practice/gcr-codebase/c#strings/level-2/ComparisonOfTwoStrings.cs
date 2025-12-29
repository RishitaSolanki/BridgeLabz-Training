using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings
{
    public class ComparisonOfTwoStrings
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter String 1: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter String 2: ");
            string str2 = Console.ReadLine();

            int result = CompareStrings(str1, str2);

            if (result < 0)
            {
                Console.WriteLine($"\"{str1}\" comes before \"{str2}\" in lexicographical order");
            }
            else if (result > 0)
            {
                Console.WriteLine($"\"{str1}\" comes after \"{str2}\" in lexicographical order");
            }
            else
            {
                Console.WriteLine("Both strings are equal");
            }
        }

//-------------------------------
        static int CompareStrings(string s1, string s2)
        {
            int minLength = s1.Length < s2.Length ? s1.Length : s2.Length;

            for (int i = 0; i < minLength; i++)
            {
                if (s1[i] != s2[i])
                {
                    return s1[i] - s2[i];
                }
            }

            return s1.Length - s2.Length;
        }

        


    }
}
