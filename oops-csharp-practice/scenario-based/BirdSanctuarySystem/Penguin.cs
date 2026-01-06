using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.BirdSanctuarySystem
{
    public class Penguin:Bird,ISwimmable
    {
        public Penguin(string NameOfBird) : base(NameOfBird, "Penguin") { }
        public void Swim()
        {
            Console.WriteLine("Penguin swim swiftly on water");
        }

    }
}
