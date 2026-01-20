using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Generics.AI_DrivenResumeScreeningSystem
{
    public class SoftwareEngineer : JobRole
    {
        public SoftwareEngineer(string name, int exp)
            : base(name, exp)
        {
        }

        public override void Check()
        {
            Console.WriteLine($"Software Engineer: {name}, Exp: {exp} yrs");
        }
    }
}
