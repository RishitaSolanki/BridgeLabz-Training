using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AadharNumber
{
    public interface IAadhar
    {

        void Add(long aadhar);
        void Search(long aadhar);
        void Sort();
        void Display();
    }
}
