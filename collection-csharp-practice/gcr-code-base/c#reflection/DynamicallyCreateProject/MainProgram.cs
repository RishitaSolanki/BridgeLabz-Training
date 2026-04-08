using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFive.Reflection.DynamicallyCreateProject
{
    public class MainProgram
    {
       public static void Main(string[] args)
        {
           
            Type type = typeof(Student);

            
            object obj = Activator.CreateInstance(type);

          
            Student student = (Student)obj;

            student.Id = 101;
            student.Name = "Rama";

            student.Display();
        }
    }
}
