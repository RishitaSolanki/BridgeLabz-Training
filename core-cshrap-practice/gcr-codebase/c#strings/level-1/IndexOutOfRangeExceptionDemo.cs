using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings;

public class IndexOutOfRangeExceptionDemo
{

    //Main method
    public static void Main(string[] args)
    {
        HandleIndexOutOfRange();
        Console.WriteLine("Program execution continues safely ");

    }
    public static void IndexOutOfRange()
    {
        string text = "BridgeLabz";

        Console.WriteLine("Character at index 20: " + text[20]);

    }

    // Method that handles the exception
    public static void HandleIndexOutOfRange()
    {
        try
        {
            IndexOutOfRange();
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Exception Caught: IndexOutOfRangeException");

            Console.WriteLine("Message: " + ex.Message);
        }
    }


}

