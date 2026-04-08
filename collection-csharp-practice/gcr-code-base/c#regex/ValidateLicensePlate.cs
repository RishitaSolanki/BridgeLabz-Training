using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectFive.regex
{
    public class ValidateLicensePlate
    {

        public static void Main(string[] args)
        {
            Console.Write("Enter the Licence number: ");
            string s = Console.ReadLine();
            string p = @"^[A-Z]{2}\d{4}$";

            Console.WriteLine(Regex.IsMatch(s, p) ? "Valid Licence Plate" : "Invalid Licence Plate");
        }
    }
}
