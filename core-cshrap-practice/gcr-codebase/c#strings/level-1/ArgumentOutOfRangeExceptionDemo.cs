using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings
{
    //Main method 
    public class ArgumentOutOfRangeExceptionDemo
    {
        public static void Main(string[] args)
        {
            HandleArgumentOutOfRange();
            Console.WriteLine("\nProgram execution continues safely.");
        }

        public static void DemonstrateArgumentOutOfRange()
        {
            string message = "BridgeLabz";

            int FirstIndex = 6;

            int endIndex = 3;

            // This will throw ArgumentOutOfRangeException
            string ans = message.Substring(FirstIndex, endIndex - FirstIndex + 1);

            Console.WriteLine(ans);
        }

        // It handles the exception
        public static void HandleArgumentOutOfRange()
        {
            try
            {
                DemonstrateArgumentOutOfRange();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception:-ArgumentOutOfRangeException");

                Console.WriteLine("Message: " + ex.Message);
            }
        }


    }
}
