using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.HospitalPatientManagementSystem
{
    public class HospitalPatientManagementSystem
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor("Dr. Rama", "Cardiologist");
            doctor.ShowDoctorDetails();

            Patient patient1 = new InPatient(221500094,"Dev",3,50000);
            Patient patient2 = new OutPatient(2000, 221500100, "Priyanshu");

            patient1.DisplayInfo();
            patient2.DisplayInfo();

            Bill.PrintBill((IPayable)patient1);
            Bill.PrintBill((IPayable)patient2);

        }
    }
}
