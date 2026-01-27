using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProjectFive.Reflection.InvokeCalculatorPrivate
{
    public class InvokePrivate
    {
        //main method
       public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

         
            Type type = typeof(Calculator);

          
            MethodInfo multiplyMethod = type.GetMethod(
                "Multiply",
                BindingFlags.NonPublic | BindingFlags.Instance
            );

           
            object result = multiplyMethod.Invoke(
                calculator,
                new object[] { 5, 4 }
            );

            Console.WriteLine("Result of Multiply (via Reflection): " + result);
        }
    }
}

