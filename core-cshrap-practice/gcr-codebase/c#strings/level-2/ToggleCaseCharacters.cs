using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings
{
    public class ToggleCaseCharacters
    {

        //main method
        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string mssg = Console.ReadLine();

            Console.WriteLine("Toggled string: " + Toggle(mssg));
        }

//-------------------------------
        static string Toggle(string text)
        {

            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (ch >= 'A' && ch <= 'Z')
                {
                    result += (char)(ch + 32);
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    result += (char)(ch - 32);
                }
                else
                {
                    result += ch;
                }
            }

            return result;
        }

       
    }
}
