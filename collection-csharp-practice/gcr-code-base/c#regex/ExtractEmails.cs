using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectFive.regex
{
    public class ExtractEmails
    {
        public static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string p = @"\b[\w.-]+@[\w.-]+\.\w+\b";

            foreach (Match m in Regex.Matches(t, p))
                Console.WriteLine(m.Value);
        }
    }
}
