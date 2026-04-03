  using System;

  public class BasicCalculator{
    public static void Main(string[] args)
    {
        double n1;
        double n2;
        
        Console.Write("Enter first no: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        
        
        Console.Write("Enter second no: ");
        n2 = Convert.ToDouble(Console.ReadLine());
        

        double add = n1 + n2;
        double sub = n1 - n2;
        double mul = n1 * n2;
        double div = n1 / n2;
        
        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " 
                          + n1 + " and " + n2 + " is " 
                          + add + ", " + sub + ", " 
                          + mul + ", and " + div);
    }
}