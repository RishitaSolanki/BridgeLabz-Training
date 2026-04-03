  using System;

  public class ChocolateDistributionInChildern{
  public static void Main(string[] args) {
 
      //Get an integer value from the user for numberOfChocolates and numberOfChildren.
        Console.Write("Enter number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int  numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculations
        int chocolatesEach = numberOfChocolates / numberOfChildren;
        int  remainingChocolates = numberOfChocolates % numberOfChildren;

        Console.WriteLine("The number of chocolates each child gets is " +    chocolatesEach +
		" and the number of remaining chocolates is " + remainingChocolates );
    }
}
