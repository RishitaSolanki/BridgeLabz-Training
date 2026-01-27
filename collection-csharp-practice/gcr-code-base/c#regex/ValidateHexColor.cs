using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectFive.regex
{
    public class ValidateHexColor
    {
        static void Main()
        {
            Console.Write("Enter the Hex Color Code: ");
            string c = Console.ReadLine();
            string p = @"^#[0-9A-Fa-f]{6}$";

            Console.WriteLine(Regex.IsMatch(c, p) ? "Valid" : "Invalid");
        }

    }
}
