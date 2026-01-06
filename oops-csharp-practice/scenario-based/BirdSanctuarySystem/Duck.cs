using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.BirdSanctuarySystem
{
    public class Duck:Bird,ISwimmable
    {
        public Duck(string NameOfBird):base(NameOfBird,"Duck") { }
        public void Swim()
        {
            Console.WriteLine("Duck swim slowly on water");
        }
    }
}
