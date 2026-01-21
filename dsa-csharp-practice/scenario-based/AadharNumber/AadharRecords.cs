using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AadharNumber
{
    public class AadharRecords
    {
        private long aadhar;

        public AadharRecords(long a)
        {
            aadhar = a;
        }

        public long GetAadhar()
        {
            return aadhar;
        }
    }
}
