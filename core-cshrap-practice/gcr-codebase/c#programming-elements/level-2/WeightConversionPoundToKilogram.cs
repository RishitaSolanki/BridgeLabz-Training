 using System;

  public class WeightConversionPoundToKilogram{
  public static void Main(string[] args) {
   
        Console.Write("Enter weight in pounds ");
        double pounds = Convert.ToDouble(Console.ReadLine());

        // Conversion
		//1 pound = 2.2 kg
       double kilograms = pounds / 2.2;

        Console.WriteLine("The weight of the person in pounds is " + pounds + " and in kg is " +kilograms );
    }
}
