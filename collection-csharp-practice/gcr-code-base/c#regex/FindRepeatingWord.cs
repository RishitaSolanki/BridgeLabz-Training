using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectFive.regex
{
    public class FindRepeatingWord
    {
        public static void Main(string[]  args)
        {
            string t = Console.ReadLine();
            string p = @"\b(\w+)\s+\1\b";

            foreach (Match m in Regex.Matches(t, p))
                Console.WriteLine(m.Groups[1].Value);
        }
    }
}
