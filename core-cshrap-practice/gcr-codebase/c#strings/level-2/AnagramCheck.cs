using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings
{
    public class AnagramCheck
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            if (Anagrams(str1, str2))
                Console.WriteLine("strings are anagrams.");
            else
                Console.WriteLine("strings are NOT anagrams.");
        }
        static bool Anagrams(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            int[] count = new int[256];

            for (int i = 0; i < s1.Length; i++)
            {
                count[s1[i]]++;
                count[s2[i]]--;
            }

            for (int i = 0; i < 256; i++)
            {
                if (count[i] != 0)
                    return false;
            }

            return true;
        }

       
    }
}
