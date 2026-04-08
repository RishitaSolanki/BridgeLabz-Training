using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectFive.regex
{
    public class ExtractCurrency
    {
        public static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string p = @"\$?\s?\d+(\.\d{2})?";

            foreach (Match m in Regex.Matches(t, p))
                Console.WriteLine(m.Value.Trim());
        }
    }
}
