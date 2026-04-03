using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings.stringExtras
{
    public class CheckPalindromeNumber
    {

        //main method
        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string mssg = Console.ReadLine();

            Console.WriteLine(IsitPalindrome(mssg) ? "Palindrome" : "Not a Palindrome");
        }

//--------------------------------------
        static bool IsitPalindrome(string text)
        {
            int start = 0, end = text.Length - 1;

            while (start < end)
            {
                if (text[start] != text[end]) return false;
                start++;
                end--;
            }

            return true;
        }


    }
}
