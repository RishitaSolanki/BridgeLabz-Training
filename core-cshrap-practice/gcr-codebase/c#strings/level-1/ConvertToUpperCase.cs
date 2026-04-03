using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings
{
    public class ConvertToUpperCase
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the text: ");
            string text = Console.ReadLine();

            string customUpperCase = ConversionUsingAscii(text);
            string builtInUpperCase = text.ToUpper();

        
            Console.WriteLine("Using ASCII logic : " + customUpperCase);
            Console.WriteLine("Using ToUpper()  : " + builtInUpperCase);
        }

        public static string ConversionUsingAscii(string input)
        {
            StringBuilder ans = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                // ASCII logic:- a-z → A-Z
                if (ch >= 'a' && ch <= 'z')
                {
                    ch = (char)(ch - 32);
                }

                ans.Append(ch);
            }

            return ans.ToString();
        }

       


    }
}
