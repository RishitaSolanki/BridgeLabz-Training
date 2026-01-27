using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectFive.regex
{
    public class ValidateIPaddress
    {
       public static void Main(string[] args)
        {
            string ip = Console.ReadLine();
            string p =
            @"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}
                   (25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)$";

            Console.WriteLine(Regex.IsMatch(ip, p) ? "Valid" : "Invalid");
        }
    }
}
