using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.SmartHomeAutomationSystem
{
    public class Fan:Appliance
    {
        public Fan() : base("Fan") { }
        public override void TurnOff()
        {
            Console.WriteLine("Fan turned on.");
        }
        public override void TurnOn()
        {
            Console.WriteLine("Fan turned on medium speed");
        }
    }
}
