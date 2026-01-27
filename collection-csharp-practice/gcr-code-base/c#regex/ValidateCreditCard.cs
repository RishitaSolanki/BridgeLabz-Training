using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectFive.regex
{
    public class ValidateCreditCard
    {
       public static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            string c = Console.ReadLine();

            string visa = @"^4\d{15}$";
            string mc = @"^5\d{15}$";

            if (Regex.IsMatch(c, visa))
                Console.WriteLine("Visa Card");
            else if (Regex.IsMatch(c, mc))
                Console.WriteLine("MasterCard");
            else
                Console.WriteLine("Invalid");
        }
    }
}
