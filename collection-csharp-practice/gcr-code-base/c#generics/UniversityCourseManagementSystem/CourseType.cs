using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Generics.UniversityCourseManagementSystem
{
    public abstract class CourseType
    {
        public string title;
        public int credit;

        public CourseType(string title, int credit)
        {
            this.title = title;
            this.credit = credit;
        }

        public abstract void Evaluate();
    }
}
