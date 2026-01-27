using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectFive.regex
{
    public class ExtractDates
    {

       public static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string p = @"\b\d{2}/\d{2}/\d{4}\b";

            foreach (Match m in Regex.Matches(t, p))
                Console.WriteLine(m.Value);
        }
    }
}
