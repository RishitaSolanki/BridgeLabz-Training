using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace projectTwo
{
    public class Person
    {
        public string Naam;
        public int Age;

        // PARAMETERIZED CONSTRUCTOR
        public Person(string name, int age)
        {
            Naam = name;
            Age = age;
        }

        //COPY CONSTRUCTOR
        public Person(Person other)
        {
            Naam = other.Naam;

            Age = other.Age;
        }

        //MAIN METHOD

        public static void Main(string[] args)
        {
            Person P = new Person("Rishita", 18);

            Person copy = new Person(P);


            Console.WriteLine("Parameterized Constructor");
            Console.WriteLine(P.Naam + " " + P.Age);


            Console.WriteLine("Copy Constructor");
            Console.WriteLine(copy.Naam + " " + copy.Age);
        }



    }
}
