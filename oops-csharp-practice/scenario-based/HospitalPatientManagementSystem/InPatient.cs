using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.HospitalPatientManagementSystem
{
    public class InPatient:Patient, IPayable
    {
        public int DaysAdmitted {  get; private set; }
        public double DailyCharge {  get; private set; }
        public InPatient(int PatientId, string PatientName,  int DaysAdmitted, double DailyCharge) : base(PatientId, PatientName)
        {
            this.DaysAdmitted = DaysAdmitted;
            this.DailyCharge = DailyCharge;
        }
        public double CalculateBill()
        {
            return DailyCharge * DaysAdmitted;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Name of the patient is : "+ PatientName+" patient id is : " +PatientID+" where bill is :"+ CalculateBill());
        }
    }
}
