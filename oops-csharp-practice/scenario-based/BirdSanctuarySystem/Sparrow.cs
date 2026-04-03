using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.BirdSanctuarySystem
{
    public class Sparrow:Bird,IFlyable
    {
        public Sparrow(string NameOfBird):base(NameOfBird,"Species") { }
        public void Fly()
        {
            Console.WriteLine("Sparrow flies low to the ground");
        }
    }
}
