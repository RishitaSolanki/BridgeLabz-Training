using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.SmartHomeAutomationSystem
{
    public class SmartHomeAutomationSystemMain
    {
        //MAIN METHOD
        public static void Main(string[] args)
        {
            Appliance[] appliances = {
                new Light(),
                new Fan(),
                new AC()
            };


            Console.WriteLine("Turning ON Appliances");

            foreach (Appliance appliance in appliances)
            {
                appliance.TurnOn();
                Console.WriteLine();// Polymorphism
            }

            Console.WriteLine("Turning OFF Appliances");

            foreach (Appliance appliance in appliances)
            {
                appliance.TurnOff();
                Console.WriteLine();// Polymorphism
            }
        }
    }
}
