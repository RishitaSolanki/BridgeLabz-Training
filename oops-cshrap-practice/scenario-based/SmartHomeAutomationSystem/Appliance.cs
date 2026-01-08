using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.SmartHomeAutomationSystem
{
    //abstract class
    public abstract class Appliance : IControllable
    {
        public string Name { set; get; }

        //constructor
        protected Appliance(string name)
        {
            this.Name = name;
        }

        //abstract method
        public abstract void TurnOn();
        public abstract void TurnOff();

    }
}
