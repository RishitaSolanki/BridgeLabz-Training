using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProjectFive.Reflection.MathOperation
{
   public class MainProgram
    {
        //Main method
        public static void Main(string[] args)
        {
            MathOperation math = new MathOperation();
            Type type = typeof(MathOperation);

            Console.Write("Enter method name (Add / Subtract / Multiply): ");
            string methodName = Console.ReadLine();

            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            
            MethodInfo method = type.GetMethod(methodName);

            if (method == null)
            {
                Console.WriteLine("Invalid method name!");
                return;
            }

            
            object result = method.Invoke(math, new object[] { a, b });

            Console.WriteLine($"Result: {result}");
        }
    }
}

