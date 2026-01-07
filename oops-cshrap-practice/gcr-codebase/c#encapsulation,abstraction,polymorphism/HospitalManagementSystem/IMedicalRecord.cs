using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.HospitalManagementSystem
{
    //Implement an interface IMedicalRecord.
   //Define methods AddRecord() and ViewRecords().

    public interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }
}
