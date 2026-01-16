using BridgeLabz_Training.OOPS.LoanBuddy;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.TrafficManager
{
    internal class TrafficManagerMain
    {
        static void Main(string[] args)
        {
            ITrafficManagerOperations traffic = new VehicleImpl();
            TrafficManagerMenu.Display(traffic);
        }
    }
}
