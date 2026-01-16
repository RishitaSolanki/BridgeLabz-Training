using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
        public interface IAddressBook
        {
        void TakeInput();     
        void EditContact();   
        void DeleteContact();  // UC3
        void DisplayContact();
    }
    }

