using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Generics.AI_DrivenResumeScreeningSystem
{
    public class ResumeUtility
    {
        public static void AddRole<T>(Resume<T> res, T role)
            where T : JobRole
        {
            res.Add(role);
        }
    }
}
