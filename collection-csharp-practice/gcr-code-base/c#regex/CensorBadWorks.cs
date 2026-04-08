using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectFive.regex
{
    public class CensorBadWorks
    {
       public static void Main(string[] args)
        {
            Console.Write("Enter the Sentence: ");
            string s = Console.ReadLine();
            string p = @"\b(damn|stupid|bitch|)\b";

            string r = Regex.Replace(s, p, "****", RegexOptions.IgnoreCase);
            Console.WriteLine(r);
        }
    }

}

