using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings
{
    public class NullreferencExceptionDemo
    {
        //Main method
        public static void Main(string[] args)
        {

            try
            {
                DemonstrateNullReference();
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("Exception Caught: NullReferenceException");
                Console.WriteLine("Message: " + ex.Message);
            }

            Console.WriteLine("\nProgram execution continues safely.");
        }


        public static void DemonstrateNullReference()
        {
            string mssg = null;

            // This line will throw NullReferenceException
            Console.WriteLine("Length of string: " + mssg.Length);
        }


    }
}
