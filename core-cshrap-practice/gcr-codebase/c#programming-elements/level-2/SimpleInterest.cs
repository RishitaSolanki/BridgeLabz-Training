   using System;

  public class SimpleInterest{
  public static void Main(string[] args){
   
        Console.Write("Enter Principal amount ");
        double p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time in years ");
        double t = Convert.ToDouble(Console.ReadLine());

        // Simple Interest calculation
        double simpleInterest = (p * r * t) / 100;

        Console.WriteLine("The Simple Interest is " + simpleInterest +    " for Principal " + p +
            ", Rate of Interest " + r +  " and Time " + t  );
    }
}
