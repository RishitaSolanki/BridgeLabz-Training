using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFive.Reflection.DependencyInjection
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine("LOG: " + message);
        }
    }
}
