using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Collection.realworldproblem.InsuranceManagementSystem
{
    public class Policy
    {
        public int PolicyNumber { get; set; }
        public string CoverageType { get; set; }
        public DateTime ExpiryDate { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Policy p && PolicyNumber == p.PolicyNumber;
        }

        public override int GetHashCode()
        {
            return PolicyNumber.GetHashCode();
        }
    }
}
