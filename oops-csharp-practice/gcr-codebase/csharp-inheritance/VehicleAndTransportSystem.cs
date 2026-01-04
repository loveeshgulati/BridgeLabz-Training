using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.inheritance
{
        class Transport
        {
            public int topSpeed;
            public string energySource;

            public Transport(int topSpeed, string energySource)
            {
                this.topSpeed = topSpeed;
                this.energySource = energySource;
            }

            public virtual void ShowDetails()
            {
                Console.WriteLine("Top Speed        : " + topSpeed);
                Console.WriteLine("Energy Source    : " + energySource);
            }
        }

        class Sedan : Transport
        {
            public int seatCount;

            public Sedan(int topSpeed, string energySource, int seatCount)
                : base(topSpeed, energySource)
            {
                this.seatCount = seatCount;
            }

            public override void ShowDetails()
            {
                base.ShowDetails();
                Console.WriteLine("Total Seats      : " + seatCount);
            }
        }

        class CargoTruck : Transport
        {
            public int loadLimit;

            public CargoTruck(int topSpeed, string energySource, int loadLimit)
                : base(topSpeed, energySource)
            {
                this.loadLimit = loadLimit;
            }

            public override void ShowDetails()
            {
                base.ShowDetails();
                Console.WriteLine("Load Limit (kg)  : " + loadLimit);
            }
        }

        class TwoWheeler : Transport
        {
            public bool sideAttachment;

            public TwoWheeler(int topSpeed, string energySource, bool sideAttachment)
                : base(topSpeed, energySource)
            {
                this.sideAttachment = sideAttachment;
            }

            public override void ShowDetails()
            {
                base.ShowDetails();
                Console.WriteLine("Side Attachment  : " + sideAttachment);
            }
        }

        class TransportRunner
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Provide Sedan info (Speed, Fuel, Seat Count)");
                int sedanSpeed = int.Parse(Console.ReadLine());
                string sedanFuel = Console.ReadLine();
                int sedanSeats = int.Parse(Console.ReadLine());

                Console.WriteLine("\nProvide Cargo Truck info (Speed, Fuel, Load Limit)");
                int truckSpeed = int.Parse(Console.ReadLine());
                string truckFuel = Console.ReadLine();
                int loadKg = int.Parse(Console.ReadLine());

                Console.WriteLine("\nProvide Two Wheeler info (Speed, Fuel, Side Attachment true/false)");
                int bikeSpeed = int.Parse(Console.ReadLine());
                string bikeFuel = Console.ReadLine();
                bool hasAttachment = bool.Parse(Console.ReadLine());

                Transport[] fleet = new Transport[3];
                fleet[0] = new Sedan(sedanSpeed, sedanFuel, sedanSeats);
                fleet[1] = new CargoTruck(truckSpeed, truckFuel, loadKg);
                fleet[2] = new TwoWheeler(bikeSpeed, bikeFuel, hasAttachment);

                Console.WriteLine("TRANSPORT DETAILS");

                foreach (Transport item in fleet)
                {
                    item.ShowDetails();
                    Console.WriteLine();
                }
            }
        }
    }
