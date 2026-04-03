using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings.stringExtras
{
    public class BasicCalculator
    {
        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b) => a / b;

       public static void Main(string[] args)
        {
            //input values
            Console.Write("Enter two numbers: ");

            double n1 = Convert.ToDouble(Console.ReadLine());

            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose operation (+ - * /): ");
            char op = Console.ReadLine()[0];

            if (op == '+') Console.WriteLine(Add(n1, n2));

            else if (op == '-') Console.WriteLine(Subtract(n1, n2));

            else if (op == '*') Console.WriteLine(Multiply(n1, n2));

            else if (op == '/') Console.WriteLine(Divide(n1, n2));
        }
    }
}
