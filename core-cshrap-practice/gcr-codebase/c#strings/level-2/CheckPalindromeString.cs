using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings
{
    public class CheckPalindromeString
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string mssg = Console.ReadLine();

            bool result = Palindrome(mssg);

            if (result)
            {
                Console.WriteLine("string is a palindrome");
            }
            else
            {
                Console.WriteLine("string is NOT a palindrome");
            }
        }
        static bool Palindrome(string input)
        {

            int start = 0;
            int end = input.Length - 1;

            while (start < end)
            {
                if (input[start] != input[end])
                {
                    return false;
                }
                start++;
                end--;
            }

            return true;
        }

      

    }
}
