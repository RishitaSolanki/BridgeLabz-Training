using System;
using System.Collections.Generic;
using System.Text;

namespace scneariobased.AmbulanceRoute
{
    public class HospitalUnit
    {

            public string Name { get; private set; }
            public bool IsAvailable { get; set; }
            public HospitalUnit Next { get; set; }

            public HospitalUnit(string name, bool isAvailable = true)
            {
                Name = name;
                IsAvailable = isAvailable;
            }
        }

    }

