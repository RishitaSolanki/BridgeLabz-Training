using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.BirdSanctuary
{
    public class Seagull : EBird, ISwimmable, IFlyable
    {
        public Seagull(string NameOfBird) : base(NameOfBird, "Seagull") { }
        public void Fly()
        {
            Console.WriteLine("Seagull fly in the sky and");
        }

      
        public void Swim()
        {
            Console.Write("Seagull swim in the water");
        }
    }
}
