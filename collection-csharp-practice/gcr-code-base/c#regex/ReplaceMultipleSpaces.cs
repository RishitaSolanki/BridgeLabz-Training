using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectFive.regex
{
    public class ReplaceMultipleSpaces
    {
       public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string r = Regex.Replace(s, @"\s+", " ");

            Console.WriteLine(r);
        }

    }
}
