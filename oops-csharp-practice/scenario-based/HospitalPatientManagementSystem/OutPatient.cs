using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.HospitalPatientManagementSystem
{
    public class OutPatient:Patient,IPayable
    {
        public int ConsultationFee {  get; private set; }
        public OutPatient(int ConsultationFee,int PatientId, string PatientName):base(PatientId, PatientName)
        {
            this.ConsultationFee = ConsultationFee;
        }
        public double CalculateBill()
        {
            return ConsultationFee; 
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Name of the patient is : "+PatientName+" and patient id : "+PatientID+" and fee is : "+CalculateBill());
        }
    }
}
