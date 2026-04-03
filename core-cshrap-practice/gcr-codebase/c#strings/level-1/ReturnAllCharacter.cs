using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings;

public class ReturnAllCharacter
{
    //Main method
    public static void Main(string[] args)
    {
        //taking input
        Console.Write("Enter the string");
        string mssg = Console.ReadLine();

        char[] customMethod = GetCharacters(mssg);

        char[] builtinMethod = mssg.ToCharArray();

        Console.WriteLine("\nCharacters using custom method:");
        foreach (char c in customMethod)
        {
            Console.Write(c + " ");
        }

        Console.WriteLine("\n\nCharacters using ToCharArray():");
        foreach (char c in builtinMethod)
        {
            Console.Write(c + " ");
        }
    }

    //-----------------

    public static char[] GetCharacters(string input)
    {
        char[] result = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            result[i] = input[i];
        }
        return result;
    }


}


