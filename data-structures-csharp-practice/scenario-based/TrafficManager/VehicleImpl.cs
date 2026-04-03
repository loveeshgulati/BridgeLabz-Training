using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.TrafficManager
{
    internal class VehicleImpl:ITrafficManagerOperations
    {
        private Vehicle last = null;
        private Queue<string> waitingVehicles = new Queue<string>();
        private const int MAX_QUEUE_SIZE = 5;
        public void VehicleEnterQueue(string vehicleNumber) 
        {
            if(waitingVehicles.Count>=MAX_QUEUE_SIZE)
            {
                Console.WriteLine("Queue overflow. No more vehicles can be added in the queue.");
                return;
            }
            waitingVehicles.Enqueue(vehicleNumber);
            Console.WriteLine("Vehicle number: "+vehicleNumber+" is added to the queue.");

        }
        public void VehicleEnterRoundAbout() 
        {
            if (waitingVehicles.Count == 0)
            {
                Console.WriteLine("No vehicle in the queue, cannot enter round about");
                return;
            }
            string vehicleNumber = waitingVehicles.Dequeue();
            Vehicle newVehicle = new Vehicle(vehicleNumber);
            if (last == null)
            {
                last = newVehicle;
                last.Next = last;
            }
            else
            {
                newVehicle.Next = last.Next;
                last.Next = newVehicle;
                last = newVehicle;
            }

        }
        public void VehicleExitRoundAbout(string vehicleNumber) 
        {
            if (last == null)
            {
                Console.WriteLine("Roundabout is empty.");
                return;
            }

            Vehicle current = last.Next;
            Vehicle prev = last;

            do
            {
                if (current.VehicleNumber == vehicleNumber)
                {
                    if (current == last && current.Next == last)
                    {
                        last = null;
                    }
                    else
                    {
                        prev.Next = current.Next;
                        if (current == last)
                            last = prev;
                    }

                    Console.WriteLine($"Vehicle {vehicleNumber} exited the roundabout.");
                    return;
                }

                prev = current;
                current = current.Next;
            } while (current != last.Next);

            Console.WriteLine("Vehicle not found in roundabout.");
        }
        public void ShowRoundAbout() 
        {
            if (last == null)
            {
                Console.WriteLine("Roundabout is empty.");
                return;
            }

            Console.WriteLine("Vehicles in Roundabout:");
            Vehicle temp = last.Next;
            do
            {
                Console.Write(temp.VehicleNumber + " : ");
                temp = temp.Next;
            } while (temp != last.Next);

            Console.WriteLine("(Back to Start)");
        }
        public void ShowQueue() 
        {
            if (waitingVehicles.Count == 0)
            {
                Console.WriteLine("Waiting queue is empty.");
                return;
            }

            Console.WriteLine("\nVehicles in Waiting Queue:");
            foreach (var v in waitingVehicles)
            {
                Console.WriteLine(v);
            }
        }
    }

    }
