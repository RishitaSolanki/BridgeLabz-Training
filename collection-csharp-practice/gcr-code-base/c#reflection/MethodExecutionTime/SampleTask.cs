using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFive.Reflection.MethodExecutionTime
{
   public class SampleTask
    {
        public void TaskOne()
        {
            Thread.Sleep(500); 
        }

        public void TaskTwo()
        {
            Thread.Sleep(1000);
        }

        public void TaskThree()
        {
            for (int i = 0; i < 1_000_000; i++) { }
        }
    }
}

