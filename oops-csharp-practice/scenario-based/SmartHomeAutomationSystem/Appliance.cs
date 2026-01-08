using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.SmartHomeAutomationSystem
{
    public abstract class Appliance:IControllable
    {
        public string Name { set;  get; }
        protected Appliance(string Name)
        {
            this.Name = Name;
        }
        public abstract void TurnOn();
        public abstract void TurnOff();

    }
}
