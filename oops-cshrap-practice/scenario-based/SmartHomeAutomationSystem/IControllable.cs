using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.SmartHomeAutomationSystem
{
    public interface IControllable
    {
        //Interface: IControllable(TurnOn, TurnOff)
        void TurnOn();
        void TurnOff();
    }
}
