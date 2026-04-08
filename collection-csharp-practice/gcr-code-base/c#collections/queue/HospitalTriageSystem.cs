using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Collection.queue
{
    //Simulate a hospital triage system using a PriorityQueue where patients with higher severity are treated first.
    public class HospitalTriageSystem
    {
        //main method
        public static void Main(string[] args)
        {

            PriorityQueue<Patient, int> triageQueue =
                new PriorityQueue<Patient, int>();
            triageQueue.Enqueue(new Patient("Rishita", 3), -3);
            triageQueue.Enqueue(new Patient("Rama", 5), -5);
            triageQueue.Enqueue(new Patient("Janvi", 2), -2);
            Console.WriteLine("Treatment Order:");
            while (triageQueue.Count > 0)
            {
                Patient p = triageQueue.Dequeue();
                Console.WriteLine(p.Name);
            }
        }
    }
    class Patient
        {
            public string Name { get; set; }
            public int Severity { get; set; }

            public Patient(string name, int severity)
            {
                Name = name;
                Severity = severity;
            }
        }

      
         
    }

