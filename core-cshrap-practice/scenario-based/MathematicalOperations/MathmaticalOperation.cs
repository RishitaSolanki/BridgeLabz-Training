using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ScenarioBased
{
    public class MathmaticalOperation
    {
        //A method to calculate the factoria
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //l of a number
        public static int GetFactorial(int num)
        {
            if (num < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Input");
                Console.ResetColor();
            }

            int total = 1;
            for (int x = 1; x <= num; x++)
            {

                total *= x;

            }
            return total;
        }

        //A method to check if a number is prime.
        public static bool CheckPrimeNumber(int num)
        {
            if (num <= 1) return false;

            for (int j = 2; j <= Math.Sqrt(num); j++)
            {
                if (num % j == 0) return false;
            }
            return true;
        }

        //A method to find the greatest common divisor(GCD) of two numbers.
        public static int FindGCD(int num1, int num2)
        {
            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);

            while (num2 != 0)
            {
                int remainder = num1 % num2;
                num1 = num2;
                num1 = remainder;
            }
            return num1;
        }

        //A method to find the nth Fibonacci number.

        public static long GetFibonacciValue(int num)
        {
            if (num < 0)
            {
                Console.WriteLine("Invalid Input");
            }


            if (num == 0) return 0;
            if (num == 1) return 1;

            long previous = 0, current = 1;
            for (int k = 2; k <= num; k++)
            {
                long nextTerm = previous + current;
                previous = current;
                current = nextTerm;
            }
            return current;
        }


        static void operationPanel(int num1, int num2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---MATHMATICAL OPERATION---");
            Console.ResetColor();
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Factorial");
                Console.WriteLine("2. Prime Check");
                Console.WriteLine("3. GCD");
                Console.WriteLine("4. Fibonacci");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                Console.Write("Select Option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (option)
                {

                    case 1:
                        Console.WriteLine("Factorial = " + GetFactorial(num1));
                        break;

                    case 2:
                        Console.WriteLine("Is Prime Number = " + CheckPrimeNumber(num1));
                        break;

                    case 3:
                        Console.WriteLine("Greatest Common Factor = " + FindGCD(num1, num2));
                        break;

                    case 4:
                        Console.WriteLine("Fibonaaci Number = " + GetFibonacciValue(num1));
                        break;

                    case 5:
                        Console.WriteLine("Ok Thankyou!...");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Option");
                        Console.ResetColor();
                        break;
                }
            }
        }

            public static void Main(string[] args)
            {
               Console.WriteLine("Enter First Number");
               int num1=Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("Enter Second Number");
               int num2=Convert.ToInt32(Console.ReadLine());

                operationPanel(num1,num2);

            }


        } 
    }


