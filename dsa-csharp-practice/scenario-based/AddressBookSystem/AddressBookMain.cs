using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
    public class AddressBookMain
    {
        public static void Main(string[] args)
        {
            Utility.SetupConsole();

            AddressBookMenu menu = new AddressBookMenu();
            menu.Start();
        }
    }


}


