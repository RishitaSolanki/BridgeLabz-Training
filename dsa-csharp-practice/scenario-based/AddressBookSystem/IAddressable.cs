using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
    public interface IAddressable
    {
        AddressBook FindBook(AddressBook[] books, String bookName);
        EContact[] FindByCity(AddressBook[] books, String searchCity);
        EContact[] FindByState(AddressBook[] books, String searchState);

        EContact FindByCityAndName(AddressBook[] books, String searchCity, String searchName);
        EContact FindByStateAndName(AddressBook[] books, String searchState, String searchName);

        int CountByCity(AddressBook[] books, String searchCity);
        int CountByState(AddressBook[] books, String searchState);
    }
}
