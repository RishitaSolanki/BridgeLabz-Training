using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.Inheritence
{
    //parent class
    class AnimalHeirarchy
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("Animals sound");
        }
    }

    //child class
    class Dog : AnimalHeirarchy
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    //another child class
    class Cat : AnimalHeirarchy
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    //another child class
    class Cow : AnimalHeirarchy

    {
        public override void AnimalSound()
        {
            Console.WriteLine("Cow moah");
        }

//MAIN METHOD
        public static void Main(string[] args)
        {
            AnimalHeirarchy a1 = new Dog();
            AnimalHeirarchy a2 = new Cat();
            AnimalHeirarchy a3 = new Cow();

            a1.AnimalSound();
            a2.AnimalSound();
            a3.AnimalSound();

        }
    }
}