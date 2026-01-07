using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.BirdSanctuary
{
     class Eagle : EBird, IFlyable
    {
        public Eagle(string NameOfBird) : base(NameOfBird, "Eagle") { 
        }
        public void Fly()
        {
            Console.WriteLine("Eagle fly in the sky");
        }
    }
}
