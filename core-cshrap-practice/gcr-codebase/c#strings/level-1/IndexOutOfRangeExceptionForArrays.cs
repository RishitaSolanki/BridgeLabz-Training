using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings 
{
    public class IndexOutOfRangeExceptionForArrays
    {
        public static void ArrayIndexOutOfRangeDemonstration()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            // if user enter invalid index
            Console.WriteLine("Element at index 10: " + numbers[10]);

        }

        // Method that handles the exception
        public static void HandleArrayIndexOutOfRange()
        {
            try
            {
                ArrayIndexOutOfRangeDemonstration();

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception Caught: IndexOutOfRangeException");
                Console.WriteLine("Message: " + ex.Message);
            }
        }



    }
}
