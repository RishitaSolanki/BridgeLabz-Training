using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectFive.regex
{
    public class ExtractLanguage
    {

       public static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string p = @"\b(Java|Python|JavaScript|Go)\b";

            foreach (Match m in Regex.Matches(t, p))
                Console.WriteLine(m.Value);
        }
    }
}
