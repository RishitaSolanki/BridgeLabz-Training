using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings.stringExtras
{
    public class TemperatureConverter
    {
     //main method
        public static void Main(string[] args)
        {
            Console.Write("Enter temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your choice:-");
            Console.Write("Convert to (C/F): ");
            char choice = Console.ReadLine()[0];

            if (choice == 'C')
                Console.WriteLine("Celsius: " + FahrenheitToCelsius(temp));
            else
                Console.WriteLine("Fahrenheit: " + CelsiusToFahrenheit(temp));
        }

//-----------------------------
        static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }

//------------------------------

        static double FahrenheitToCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }

        
    }
}
