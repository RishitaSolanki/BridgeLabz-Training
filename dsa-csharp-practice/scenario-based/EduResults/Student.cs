using System;
using System.Collections.Generic;
using System.Text;

namespace scneariobased.EduResults
{
    public class Student
    {
       
        public string Name { get; set; }
        public int Score { get; set; }
        public string District { get; set; }

        public override string ToString()
        {
            return $"{Name} ({District}) - {Score}";
        }
    }
}

