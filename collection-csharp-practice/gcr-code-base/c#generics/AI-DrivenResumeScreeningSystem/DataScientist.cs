using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ProjectFour.Generics.AI_DrivenResumeScreeningSystem
{
    public class DataScientist : JobRole
    {
        public DataScientist(string name, int exp)
            : base(name, exp)
        {
        }

        public override void Check()
        {
            Console.WriteLine($"Data Scientist: {name}, Exp: {exp} yrs");
        }
    }
}
