using ScenarioBased.AddressBookSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AadharNumber
{
    public class AadharMenu
    {
            IAadhar util = new AadharUtility();

            public void Start()
            {
                while (true)
                {
                   
                    Console.WriteLine("1 Add Aadhar");
                    Console.WriteLine("2 Search Aadhar");
                    Console.WriteLine("3 Sort Aadhar");
                    Console.WriteLine("4 Display All Aadhar");
                    Console.WriteLine("5 Exit");
                    


                    int ch = int.Parse(Console.ReadLine());

                    if (ch == 1)
                    {
                        Console.Write("Enter Aadhar: ");
                        long adhar = long.Parse(Console.ReadLine());
                        if (adhar <= 99999999999 || adhar > 999999999999)
                        {
                            Console.WriteLine("Invaid adhar number");

                        }
                        else
                            util.Add(adhar);


                    }
                    else if (ch == 2)
                    {
                        Console.Write("Enter Aadhar to Search: ");
                        util.Search(long.Parse(Console.ReadLine()));

                    }
                    else if (ch == 3)
                    {
                        util.Sort();
                        Console.WriteLine("Sorted Successfully");

                    }
                    else if (ch == 4)
                    {
                        util.Display();

                    }
                    else if (ch == 5)
                    {
                        break;
                    }
                }
            }
        }

    }



