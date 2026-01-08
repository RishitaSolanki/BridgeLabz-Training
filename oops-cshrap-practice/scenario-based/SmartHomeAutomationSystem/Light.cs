using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.SmartHomeAutomationSystem
{
    public class Light : Appliance
    {
      //constructor      //calling parent constructor
        public Light() : base("Light") { }


        public override void TurnOn()
        {
            Console.WriteLine("Light turned On");
        }


        public override void TurnOff()
        {
            Console.WriteLine("Light Turned Off");
        }
    }
}
