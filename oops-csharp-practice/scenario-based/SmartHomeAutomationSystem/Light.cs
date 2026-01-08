using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.SmartHomeAutomationSystem
{
    public class Light:Appliance
    {
        public Light() : base("Light"){ }
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
