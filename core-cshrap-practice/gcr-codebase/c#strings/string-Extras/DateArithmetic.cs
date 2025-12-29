using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings.stringExtras
{
    public class DateArithmetic
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a date in format (yyyy-MM-dd): ");

            //input date
            DateTime date = DateTime.Parse(Console.ReadLine());

            DateTime result = date
                .AddDays(6)
                .AddMonths(2)
                .AddYears(5)
                .AddDays(-21);

            //printing values
            Console.WriteLine("Final Date: " + result.ToShortDateString());
        }
    }
}
