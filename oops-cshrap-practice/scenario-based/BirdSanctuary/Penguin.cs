using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.BirdSanctuary
{
    public class Penguin : EBird, ISwimmable
    {
        public Penguin(string NameOfBird) : base(NameOfBird, "Penguin") { }
        public void Swim()
        {
            Console.WriteLine("Penguin swim on water");
        }
    }
}
