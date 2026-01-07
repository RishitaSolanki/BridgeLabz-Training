using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.BirdSanctuary
{
    public class Duck : EBird, ISwimmable
    {
        public Duck(string NameOfBird) : base(NameOfBird, "Duck") { }
        public void Swim()
        {
            Console.WriteLine("Duck swim on water");
        }
    }
}
