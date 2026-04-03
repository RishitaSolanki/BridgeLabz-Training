using System;

namespace Project1.array
{
    public class FactorsOfNumber
    {
        static void Main(string[] args)
        {

            //input number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int maxFactor = 10;
            int[] fact = new int[maxFactor];
            int index = 0;


            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {

                    if (index == maxFactor)
                    {
                        maxFactor = maxFactor * 2;
                        int[] temp = new int[maxFactor];

                        for (int j = 0; j < fact.Length; j++)
                        {
                            temp[j] = fact[j];
                        }

                        fact = temp;
                    }

                    fact[index] = i;
                    index++;
                }
            }


            Console.WriteLine("Factors of " + number + " are:");
            for (int i = 0; i < index; i++)
            {
                Console.Write(fact[i] + " ");
            }
        }
    }
}
