using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.BirdSanctuary
{
    public class Sparrow : EBird, IFlyable
    {
        public Sparrow(string NameOfBird) : base(NameOfBird, "Sparrow") { }
        public void Fly()
        {
            Console.WriteLine("Sparrow fly in the sky");
        }
    }
}
