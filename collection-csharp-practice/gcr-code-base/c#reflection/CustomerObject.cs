using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProjectFive.Reflection
{
    public class CustomerObject
    {

            // Model class
            class Student
            {
                public int Id;
                public string Name;
                public int Age;
            }

            
            public static T ToObject<T>(Type clazz, Dictionary<string, object> properties)
            {
               
                object obj = Activator.CreateInstance(clazz);

                foreach (var item in properties)
                {
                    
                    FieldInfo field = clazz.GetField(
                        item.Key,
                        BindingFlags.Public | BindingFlags.Instance
                    );

                    if (field != null)
                    {
                        field.SetValue(obj,
                            Convert.ChangeType(item.Value, field.FieldType));
                    }
                }

                return (T)obj;
            }


        //main method
           public static void Main(string[] args)
            {
                Dictionary<string, object> data = new Dictionary<string, object>
                {
                    { "Id", 101 },
                    { "Name", "Rama" },
                    { "Age", 23 }
                };

                Student student = ToObject<Student>(typeof(Student), data);

                Console.WriteLine(
                    $"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}"
                );
            }
        }

    }


