using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.ParcelTracker
{
    public class ParcelNode
    {
         private string stage;
            private ParcelNode next;

            public ParcelNode(string stage)
            {
                this.stage = stage;
                next = null;
            }

            public string Stage
            {
                get { return stage; }
                set { stage = value; }
            }

            public ParcelNode Next
            {
                get { return next; }
                set { next = value; }
            }
        }
    }

