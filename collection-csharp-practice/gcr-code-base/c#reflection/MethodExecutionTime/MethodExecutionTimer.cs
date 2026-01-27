using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace ProjectFive.Reflection.MethodExecutionTime
{
    public class MethodExecutionTimer
    {
        public static void Main(string[] args)
        {
            Type type = typeof(SampleTask);
            object instance = Activator.CreateInstance(type);

            MethodInfo[] methods = type.GetMethods(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly
            );

            foreach (MethodInfo method in methods)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();

                method.Invoke(instance, null);

                stopwatch.Stop();

                Console.WriteLine(
                    $"Method: {method.Name} | Execution Time: {stopwatch.ElapsedMilliseconds} ms"
                );
            }

        }
    }
}
