using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings
{
    public class ReverseString
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string mssg = Console.ReadLine();

            string result = ReversetheText(mssg);

            Console.WriteLine("Reversed string: " + result);
        }

//---------------------

        static string ReversetheText(string text)
        {
            string reversed = "";

            // Traverse the string from end to start
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }


            return reversed;
        }
    }

      

    }

