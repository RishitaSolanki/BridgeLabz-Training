using System;

namespace CGProject.Bridge
{
    public class StoreTheSum
    {
        static void Main(string[] args)
        {

            //make numbers array
            double[] numbers = new double[10];
            double total = 0.0;
            int index = 0;


            while (true)
            {
                Console.Write("Enter a number: ");
                double num = Convert.ToDouble(Console.ReadLine());  //taking input

                if (num <= 0)
                {
                    break;
                }

                if (index == 10)
                {
                    break;
                }

                numbers[index] = num;
                index++;
            }

            Console.WriteLine("Stored Numbers:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(numbers[i]);
                total += numbers[i];
            }


            Console.WriteLine("Sum of all numbers: " + total);
        }
    }
}
