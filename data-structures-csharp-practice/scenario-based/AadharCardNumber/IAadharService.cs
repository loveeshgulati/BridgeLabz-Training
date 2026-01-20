using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.AadharCardNumber
{
    public interface IAadharService
    {
        void AddAadhar(Aadhar aadhar);
        void SortAadharNumbers();
        int SearchAadhar(long number);
        void DisplayAll();
    }

}
