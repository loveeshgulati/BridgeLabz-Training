using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.object_modeling
{
    class Patient
    {
        public string Name { get; set; }
        //constructor
        public Patient(string entername)
        {
            this.Name = entername;
        }
    }
    class Doctor
    {
        public string Name { get; set; }
        private List<Patient> patients = new List<Patient>();
        //constructor
        public Doctor(string entername)
        {
            this.Name = entername;
        }

        public void Consult(Patient patient)
        {
            if (!patients.Contains(patient))
            {
                patients.Add(patient);
            }

            Console.WriteLine("Doctor " + Name + " is consulting patient " + patient.Name);
        }

        public void ShowPatients()
        {
            Console.WriteLine("Patients consulted by Dr." + Name);
            foreach (Patient p in patients)
            {
                Console.WriteLine(p.Name);
            }
            Console.WriteLine();
        }
    }
    class Hospital
    {
        public string HospitalName { get; set; }
        private List<Doctor> doctors = new List<Doctor>();
        private List<Patient> patients = new List<Patient>();
   //constructor
        public Hospital(string enterhospitalName)
        {
            this.HospitalName = enterhospitalName;
        }

        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public void DisplayHospitalDetails()
        {
            Console.WriteLine(HospitalName);

            Console.WriteLine("Doctors:");
            foreach (Doctor d in doctors)
            {
                Console.WriteLine("Dr. " + d.Name);
            }

            Console.WriteLine("Patients:");
            foreach (Patient p in patients)
            {
                Console.WriteLine(p.Name);
            }

            Console.WriteLine();
        }
    }

    //Main class
    class AssociationAndComposition
    {
        //MAIN METHOD
        public static void Main(String[] args)
        {

            Hospital hospital = new Hospital("City Hospital");

            Doctor doctor1 = new Doctor("Riki");
            Doctor doctor2 = new Doctor("Karn");


            Patient patient1 = new Patient("Ramen");
            Patient patient2 = new Patient("Janl");


            hospital.AddDoctor(doctor1);
            hospital.AddDoctor(doctor2);


            hospital.AddPatient(patient1);
            hospital.AddPatient(patient2);

            hospital.DisplayHospitalDetails();
            

            doctor1.Consult(patient1);
            doctor2.Consult(patient2);
            doctor2.Consult(patient1);

            Console.WriteLine();

            doctor1.ShowPatients();
            doctor2.ShowPatients();
        }
    }
}

