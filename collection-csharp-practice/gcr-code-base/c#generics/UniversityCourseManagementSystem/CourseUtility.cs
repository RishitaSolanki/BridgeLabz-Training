using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Generics.UniversityCourseManagementSystem
{
    public class CourseUtility
    {
        public static ExamCourse GetExamCourse()
        {
            return new ExamCourse("Maths", 4, 85);
        }

        public static AssignmentCourse GetAssignCourse()
        {
            return new AssignmentCourse("Software Engg", 3, 90);
        }
    }
}
