using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.SmartHomeAutomationSystem
{
    public class Fan : Appliance
    {

        //constructor
        public Fan() : base("Fan") { }

        public override void TurnOn()
        {
            Console.WriteLine("Fan turned on medium speed");
        }


        public override void TurnOff()
        {
            Console.WriteLine("Fan turned off");
        }

    }
}
