using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.RideHailingApplication
{
    //Implement an interface IGPS.
       public interface IGPS
        {
            string GetCurrentLocation();

            void UpdateLocation(string location);
        }
    }

