using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings
{
    public class ConvertToLowerCase
    {
       public static void Main(string[] args)
        {
            Console.Write("Enter the text: ");
            string text = Console.ReadLine();

            string customLowerCase = ConvertUsingAscii(text);
            string builtInLowerCase = text.ToLower();

            Console.WriteLine("\nResults:");
            Console.WriteLine("Using ASCII logic : " + customLowerCase);
            Console.WriteLine("Using ToLower()  : " + builtInLowerCase);
        }
        public static string ConvertUsingAscii(string input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                // ASCII logic: A-Z → a-z
                if (ch >= 'A' && ch <= 'Z')
                {
                    ch = (char)(ch + 32);
                }

                result.Append(ch);
            }

            return result.ToString();
        }

    


    }
}
