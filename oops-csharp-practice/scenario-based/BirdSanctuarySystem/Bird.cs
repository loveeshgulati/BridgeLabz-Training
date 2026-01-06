using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.BirdSanctuarySystem
{
    public class Bird
    {
        public string NameOfBird { get; set; }
        public string Species { get; set; }
        public Bird(string NameOfBird, string Species)
        {
            this.NameOfBird = NameOfBird;
            this.Species = Species;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Name of the bird : "+NameOfBird+", species : "+Species);
        }
    }
}
