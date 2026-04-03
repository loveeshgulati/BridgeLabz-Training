using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.TrafficManager
{
    internal interface ITrafficManagerOperations
    {
        void VehicleEnterQueue(string vehicleNumber);
        void VehicleEnterRoundAbout();
        void VehicleExitRoundAbout(string vehicleNumber);
        void ShowRoundAbout();
        void ShowQueue();

    }
}
