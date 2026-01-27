using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFive.Reflection.AccessPrivate
{
    public class Person
    {
        private int age = 20;

        public void ShowAge()
        {
            Console.WriteLine("Age (inside class): " + age);
        }
    }
}

