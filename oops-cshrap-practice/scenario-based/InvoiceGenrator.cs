using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioBased
{
    class InvoiceGenrator
    {
        static void startInvoice()
        {
            //Accept input like: "Logo Design - 3000 INR, Web Page - 4500 INR"

            Console.WriteLine("Enter work details ");

            string workDetails = Console.ReadLine();

            string[] workList = BreakInvoice(workDetails);

            double finalSum = CalculateTotalInvoice(workList);

            Console.WriteLine("Total amount is " + finalSum);
        }

        //Split the string to extract task names and amount

        static string[] BreakInvoice(string data)
        {
            string[] items = data.Split(',');

            Console.WriteLine("Bill ");

            foreach (string item in items)
            {
                string[] info = item.Split('-');

                Console.WriteLine("Work : " + info[0].Trim() + " Cost " + info[1].Trim());
            }

            return items;
        }

        //Calculate total invoice amount
        static double CalculateTotalInvoice(string[] itemList)
        {
            double sum = 0;

            foreach (string item in itemList)
            {
                string[] details = item.Split('-');

                string price = details[1].Replace("INR", "").Trim();

                sum += Convert.ToInt32(price);
            }

            return sum;
        }

        //MAIN METHOD
        static void Main(string[] args)
        {
            startInvoice();
        }
    }
}
