using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.TrafficManager
{
    internal class Vehicle
    {
        public string VehicleNumber;
        public Vehicle Next;
        public Vehicle(string vehicleNumber)
        {
            VehicleNumber = vehicleNumber;
            Next = null;
        }
    }
}
