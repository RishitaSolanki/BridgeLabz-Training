using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings
{
    public class CreateSubstringUsingCharAt
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the string :");
            string mainString = Console.ReadLine();

            Console.WriteLine("Enter the first and last index to create the substring");

            //Taking FirstInput
            Console.Write("first index :");
            int firstIndex = Convert.ToInt32(Console.ReadLine());

            //Taking LastInput
            Console.Write("end index :");
            int endIndex = Convert.ToInt32(Console.ReadLine());

            string custom = CreatingSubstring(mainString, firstIndex, endIndex);

            string built_in = mainString.Substring(firstIndex, endIndex - firstIndex + 1);

            Console.WriteLine("Results");

            Console.WriteLine("Substring created using custom method " + custom);

            Console.WriteLine("substring using built in method " + built_in);

        }

        public static string CreatingSubstring(string mainString, int IndexFirst, int IndexLast)
        {
            string result = "";
            for (int i = IndexFirst; i <= IndexLast; i++)
            {
                result += mainString[i];
            }
            return result;
        }



    }
}
