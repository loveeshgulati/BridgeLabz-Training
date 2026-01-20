using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.AadharCardNumber
{
    public class Aadhar
    {
        private long aadharNumber;
        private string holderName;

        public Aadhar(long aadharNumber, string holderName)
        {
            this.aadharNumber = aadharNumber;
            this.holderName = holderName;
        }

        public long GetAadharNumber()
        {
            return aadharNumber;
        }

        public string GetHolderName()
        {
            return holderName;
        }
    }

}
