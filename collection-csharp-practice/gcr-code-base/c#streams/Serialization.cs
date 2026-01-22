using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ProjectFour.Stream
{
    //Serialization - Save and Retrieve an Object 
    public class Serialization
    {
        public class Employee
        {
            public int id;
            public string name;
            public string dept;
            public double sal;
        }

        public static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
        {
            new Employee{ id=1, name="Amit", dept="IT", sal=45000 },
            new Employee{ id=2, name="Neha", dept="HR", sal=40000 }
        };

            string path = "emp.json";

            File.WriteAllText(path, JsonSerializer.Serialize(list));

            var data = JsonSerializer.Deserialize<List<Employee>>(File.ReadAllText(path));

            foreach (var e in data)
                Console.WriteLine(e.id + " " + e.name + " " + e.dept + " " + e.sal);
        }
    }
}
