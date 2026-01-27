using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectFive.regex
{
     public class ValidateUsername
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the username: ");
            string u = Console.ReadLine();
            string p = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";

            Console.WriteLine(Regex.IsMatch(u, p) ? "Valid" : "Invalid");
        }
    }
}
