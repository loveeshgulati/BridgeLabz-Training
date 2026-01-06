using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.BirdSanctuarySystem
{
    public class Seagull:Bird,ISwimmable,IFlyable
    {
        public Seagull(string NameOfBird) : base(NameOfBird, "Seagull") { }
        public void Fly()
        {
            Console.WriteLine("Seagull fly in the sky");
        }
        public void Swim()
        {
            Console.WriteLine("Seagull swim in the water");
        }
    }
}
