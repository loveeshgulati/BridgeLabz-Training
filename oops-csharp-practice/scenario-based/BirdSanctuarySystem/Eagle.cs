using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.BirdSanctuarySystem
{
    public class Eagle:Bird,IFlyable
    {
        public Eagle(string NameOfBird) : base(NameOfBird, "Eagle"){ }
        public void Fly()
        {
            Console.WriteLine("Eagle fly highest in the sky");
        }
    }
}
