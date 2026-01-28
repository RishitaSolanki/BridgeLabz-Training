using System;
using System.Collections.Generic;
using System.Text;

namespace scneariobased.SmartCheckout
{
   public class Customer
    {
       
        public string Name { get; set; }
        public List<string> Cart { get; set; } = new List<string>();

        public Customer(string name, params string[] items)
        {
            Name = name;
            Cart.AddRange(items);
        }
    }
}

