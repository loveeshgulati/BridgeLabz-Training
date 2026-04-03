using BridgeLabz_Training.OOPS.LoanBuddy;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.AadharCardNumber
{
    internal class AadharServicesMain
    {
        static void Main(string[] args)
        {
            IAadharService service = new AadharServiceImpl(20); 
            AadharServiceMenu menu = new AadharServiceMenu(service);
            menu.ShowMenu();
        }
    }
}
