using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
        public class AddressableImpl : IAddressable
        {
            int maxLen = 1000;
            public AddressBook FindBook(AddressBook[] books, String bookName)
            {
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i] != null)
                    {
                        if (books[i].bookName == bookName)
                        {
                            return books[i];
                        }
                    }

                }
                return null;
            }

            public EContact[] FindByCity(AddressBook[] books, String searchCity)
            {
                EContact[] result = new EContact[1000];
                int count = 0;
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i] != null)
                    {
                        for (int j = 0; j < maxLen; j++)
                        {
                            if (books[i].contacts[j] != null)
                            {
                                if (books[i].contacts[j].city == searchCity)
                                {
                                    result[count] = books[i].contacts[j];
                                    count++;
                                }
                            }
                        }
                    }
                }

                return result;
            }

            public EContact[] FindByState(AddressBook[] books, String searchState)
            {
                EContact[] result = new EContact[1000];
                int count = 0;
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i] != null)
                    {
                        for (int j = 0; j < maxLen; j++)
                        {
                            if (books[i].contacts[j] != null)
                            {
                                if (books[i].contacts[j].state == searchState)
                                {
                                    result[count] = books[i].contacts[j];
                                    count++;
                                }
                            }
                        }
                    }
                }

                return result;
            }

            public EContact FindByCityAndName(AddressBook[] books, String searchCity, String searchName)
            {
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i] != null)
                    {
                        for (int j = 0; j < maxLen; j++)
                        {
                            if (books[i].contacts[j] != null)
                            {
                                if (books[i].contacts[j].city == searchCity && books[i].contacts[j].firstName + " " + books[i].contacts[j].lastName == searchName)
                                {
                                    return books[i].contacts[j];
                                }
                            }
                        }
                    }
                }
                return null;
            }

        public EContact FindByStateAndName(AddressBook[] books, string searchState, string searchName)
        {
            throw new NotImplementedException();
        }

        public int CountByCity(AddressBook[] books, string searchCity)
        {
            throw new NotImplementedException();
        }

        public int CountByState(AddressBook[] books, string searchState)
        {
            throw new NotImplementedException();
        }
    }
    }

