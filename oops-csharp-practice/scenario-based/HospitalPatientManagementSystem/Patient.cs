using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.HospitalPatientManagementSystem
{
    
    public abstract class Patient
    {
        public int PatientID {  get; private set; }
        public string PatientName {  get; private set; }
        protected Patient(int  PatientID, string PatientName)
        {
            this.PatientID = PatientID;
            this.PatientName = PatientName;
        }
        public abstract void DisplayInfo();

    }
}
