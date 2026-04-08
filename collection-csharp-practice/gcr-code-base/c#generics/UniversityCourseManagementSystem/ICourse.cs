using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Generics.UniversityCourseManagementSystem
{
    public interface ICourse<T> where T : CourseType
    {
        void Add(T course);
        void Show();
    }
}
