using System;
using System.Collections.Generic;
using System.Text;

namespace scneariobased.EduResults
{
    public class EduResultMain
    {
        public static void Main(string[] args)
        {
            List<Student> districtA = new List<Student>
        {
            new Student { Name = "janvi", Score = 95, District = "District A" },
            new Student { Name = "Rishi", Score = 88, District = "District A" },
            new Student { Name = "Rama", Score = 82, District = "District A" }
        };

            List<Student> districtB = new List<Student>
        {
            new Student { Name = "Dev", Score = 98, District = "District B" },
            new Student { Name = "Lovish", Score = 91, District = "District B" },
            new Student { Name = "Gavindar", Score = 88, District = "District B" }
        };

            List<Student> allStudents = new List<Student>();
            allStudents.AddRange(districtA);
            allStudents.AddRange(districtB);

            RankGenerator generator = new RankGenerator();
            List<Student> rankList = generator.Sort(allStudents);

            Console.WriteLine("Final Rank Sheet:");
            int rank = 1;
            foreach (var student in rankList)
            {
                Console.WriteLine($"Rank {rank++}: {student}");
            }
        }
    }
}
}
