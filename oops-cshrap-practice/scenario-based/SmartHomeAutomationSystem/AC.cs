using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.SmartHomeAutomationSystem
{
    public class AC : Appliance
    {
        //constructor
        public AC() : base("Air Conditioner") { }


        public override void TurnOn()
        {
            Console.WriteLine("Air Conditioner turned on");
        }


        public override void TurnOff()
        {
            Console.WriteLine("Air Conditioner turned off");
        }
    }
}
