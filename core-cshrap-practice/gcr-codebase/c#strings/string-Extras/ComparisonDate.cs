using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings.stringExtras
{
    public class ComparisonDate
    {
        public static void Main(string[] args)
        {
            //input dates
            Console.Write("Enter first date in format (yyyy-MM-dd): ");
            DateTime inputDate1 = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter second date in format (yyyy-MM-dd): ");
            DateTime inputDate2 = DateTime.Parse(Console.ReadLine());


            //Comparison
            int Comparisonresult = DateTime.Compare(inputDate1, inputDate2);

            if (Comparisonresult < 0)
                Console.WriteLine("First date is BEFORE second date");

            else if (Comparisonresult > 0)
                Console.WriteLine("First date is AFTER second date");

            else
                Console.WriteLine("Both dates are the SAME");
        }
    }
}
