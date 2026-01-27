using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectFive.regex
{
    public class ExtractCapitalWord
    {

       public static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string p = @"\b[A-Z][a-z]*\b";

            foreach (Match m in Regex.Matches(t, p))
                Console.WriteLine(m.Value);
        }
    }

}

