using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.SmartHomeAutomationSystem
{
    public class AC:Appliance
    {
        public AC():base("Air Conditioner") { }
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
