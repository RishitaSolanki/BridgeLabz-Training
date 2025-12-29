using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings.stringExtras
{
    public class FormattingDate
    {
       public static void Main(string[] args)
        {
            //taking input
            DateTime Inputtoday = DateTime.Now;


            //printing values
            Console.WriteLine(Inputtoday.ToString("dd/MM/yyyy"));
            Console.WriteLine(Inputtoday.ToString("yyyy-MM-dd"));
            Console.WriteLine(Inputtoday.ToString("ddd, MMM dd, yyyy"));
        }
    }
}
