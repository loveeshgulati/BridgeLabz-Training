using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.HospitalPatientManagementSystem
{
    public class Doctor
    {
        public string DoctorName {  get; private set; }
        public string Specialization {  get; private set; }

        public Doctor(string DoctorName, string Specialization)
        {
            this.DoctorName = DoctorName;
            this.Specialization = Specialization;
        }
        public void ShowDoctorDetails()
        {
            Console.WriteLine("Name of Doctor : "+DoctorName+" with specialization : "+Specialization);
        }
    }
}
