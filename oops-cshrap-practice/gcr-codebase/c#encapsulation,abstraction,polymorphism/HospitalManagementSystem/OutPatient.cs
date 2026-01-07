using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.HospitalManagementSystem
{
    // Outpatient class
    class OutPatient : Patient
    {
        private int consultationCount;

        //constructor
        public int ConsultationCount { get { return consultationCount; } set { consultationCount = value; } }

        public OutPatient(int id, string name, int age, int consultations) : base(id, name, age)
        {
            this.consultationCount = consultations;
        }

        public override double CalculateBill()
        {
            double consultationFee = 500;
            return consultationCount * consultationFee;
        }
    }
}
