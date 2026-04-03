using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.HospitalManagementSystem
{
    //abstract class
  // Create an abstract class Patient with fields: patientId, name, and age.
 //Add an abstract method CalculateBill().
    public abstract class Patient : IMedicalRecord
    {
        private int patientId;
        private string name;
        private int age;
        private string diagnosis;
        private List<string> medicalHistory;

        public int PatientId { get { return patientId; } set { patientId = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        protected string Diagnosis { get { return diagnosis; } set { diagnosis = value; } }

        public Patient(int id, string patientName, int patientAge)
        {
            this.patientId = id;
            this.name = patientName;
            this.age = patientAge;
            this.medicalHistory = new List<string>();
        }

        // abstract method
        public abstract double CalculateBill();

        public void GetPatientDetails()
        {
            Console.WriteLine("Patient ID: " + patientId + " | Name: " + name + " | Age: " + age);
        }

        public void AddRecord(string record)
        {
            medicalHistory.Add(record);
            Console.WriteLine("Medical record added");
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical History:");
            foreach (string record in medicalHistory)
            {
                Console.WriteLine("- " + record);
            }
        }
    }
}
