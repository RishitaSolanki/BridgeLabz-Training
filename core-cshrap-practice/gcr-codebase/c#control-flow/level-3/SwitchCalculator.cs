using System;

  public class SwitchCalculator{
    public static void Main(string[] args)
    {
	//input Number
        Console.WriteLine("Enter first number:");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double second = Convert.ToDouble(Console.ReadLine());

    //Enter Operation
        Console.WriteLine("Enter operator (+, -, *, /):");
        string operation = Console.ReadLine();

        double res = 0;
        bool isValid = true;

        switch (operation)
        {
            case "+":
                res = first + second;
                break;
            case "-":
                res = first - second;
                break;
            case "*":
                res = first * second;
                break;
            case "/":
                res = first / second;
                break;
            default:
                Console.WriteLine("Invalid Operator");
                isValid = false;
                break;
        }

        if (isValid)
        {
            Console.WriteLine("Result: " + res);
        }
    }
}