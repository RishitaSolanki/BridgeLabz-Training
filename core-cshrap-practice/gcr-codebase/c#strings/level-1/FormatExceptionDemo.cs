using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings
{
    public class FormatExceptionDemo
    {
      public static void Main(string[] args)
        {
            HandleFormatException();

            Console.WriteLine("Program execution continues safely.");

        }
        public static void DemonstrateFormatException()
        {
            string text = "ABC123"; 

            // This will throw FormatException
            int number = Convert.ToInt32(text);

            Console.WriteLine("Converted number: " + number);
        }

        // It handles the exception
        public static void HandleFormatException()
        {
            try
            {
                DemonstrateFormatException();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Exception Caught: FormatException");
                Console.WriteLine("Message: " + ex.Message);
            }
        }

      




    }
}
