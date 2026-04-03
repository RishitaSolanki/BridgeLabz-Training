using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.Keywords
{
    //patient class
    public class Patient
    {
        public static string HospitalName = "Sudha Hospital";
        private static int totalPatients = 0;
        public readonly int PatientID;
        public string Name;
        public int Age;
        public string Ailment;

        //constructor
        public Patient(string enterName, int enterAge, int enterPatientID, string enterAilment)
        {
            this.Name = enterName;
            this.Age = enterAge;
            this.PatientID = enterPatientID;
            this.Ailment = enterAilment;
            totalPatients++;
        }


        public static int GetTotalPatients()
        {
            return totalPatients;
        }


        public void DisplayPatientDetails(object patient)
        {

            if (patient is Patient)
            {
                Console.WriteLine("Hospital Name : " + HospitalName);
                Console.WriteLine("Patient Name  : " + Name);
                Console.WriteLine("Age           : " + Age);
                Console.WriteLine("Patient ID    : " + PatientID);
                Console.WriteLine("Ailment       : " + Ailment);
            }


            else
            {
                Console.WriteLine("Invalid patient object");
            }


        }
    }

    //MAIN CLASS
    class HospitalManagementSystem
    {
        //MAIN METHOD
       public static void Main(string[] args)
        {


            Patient pat1 = new Patient("Rishita", 23, 5401, "Malaria");
            Patient pat2 = new Patient("Rama", 24, 5402, "Dengue");



            pat1.DisplayPatientDetails(pat1);
            Console.WriteLine();



            pat2.DisplayPatientDetails(pat2);
            Console.WriteLine();



            Console.WriteLine("Total Patients Admitted: " + Patient.GetTotalPatients());
        }
    }
}
