using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings
{
    public class RemoveDuplicatesFromString
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string  mssg = Console.ReadLine();

            string result = RemoveDuplicateCharacters(mssg);

            Console.WriteLine("String after removing duplicates: " + result);
        }

        static string RemoveDuplicateCharacters(string text)
        {
            string ans = "";

            for (int i = 0; i < text.Length; i++)
            {

                char currentChar =text [i]; 

                // Check if character already exists in result
                if (!ans.Contains(currentChar))
                {
                    ans += currentChar;
                }
            }

            return ans;
        }


    }
}
