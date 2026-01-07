using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.HospitalManagementSystem
{
    public class HospitalManagementMain
    {
        public static void Main(String[] args)
        {

            // create different patient types
            List<Patient> patients = new List<Patient>();
            patients.Add(new InPatient(201, "Rishita", 22, 4, 5000));
            patients.Add(new OutPatient(202, "Rama", 23, 3));

           
            foreach (Patient p in patients)
            {
                p.GetPatientDetails();
                p.AddRecord("Full Body CheckUp done");
                p.AddRecord("Blood test done");

                double bill = p.CalculateBill();
                Console.WriteLine("Total Bill: $" + bill);

                p.ViewRecords();
               
            }

            
        }
    }
}
