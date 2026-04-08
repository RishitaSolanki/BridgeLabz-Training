using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ProjectThree.Linkedlist
{
        class TicketNode
        {
            public int TicketId;
            public string CustomerName;
            public string MovieName;
            public string SeatNumber;
            public string BookingTime;
            public TicketNode Next;

        //constructor
            public TicketNode(int id, string customer, string movie, string seat, string time)
            {
                this.TicketId = id;
                this.CustomerName = customer;
                this.MovieName = movie;
                this.SeatNumber = seat;
                this.BookingTime = time;
                this.Next = null;
            }
        }

        class TicketSystem
        {
            private TicketNode head = null;

        //Add a new ticket reservation at the end of the circular list.

        public void AddTicket(int id, string customer, string movie, string seat, string time)
            {
                TicketNode newNode = new TicketNode(id, customer, movie, seat, time);

                if (head == null)
                {
                    head = newNode;
                    newNode.Next = head;
                    return;
                }

                TicketNode temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }

                temp.Next = newNode;
                newNode.Next = head;
            }


        //Remove a ticket by Ticket ID.
        public void RemoveTicket(int id)
            {
                if (head == null)
                {
                    Console.WriteLine("No tickets to remove.");
                    return;
                }

                TicketNode curr = head;
                TicketNode prev = null;

                do
                {
                    if (curr.TicketId == id)
                    {
                        if (prev == null) // removing head
                        {
                            TicketNode last = head;
                            while (last.Next != head)
                                last = last.Next;

                            head = head.Next;
                            last.Next = head;
                        }
                        else
                        {
                            prev.Next = curr.Next;
                        }

                        Console.WriteLine("Ticket removed successfully.");
                        return;
                    }

                    prev = curr;
                    curr = curr.Next;

                } while (curr != head);

                Console.WriteLine("Ticket not found.");
            }


        //Display the current tickets in the list
        public void DisplayTickets()
            {
                if (head == null)
                {
                    Console.WriteLine("No tickets booked.");
                    return;
                }

                TicketNode temp = head;
                do
                {
                    Console.WriteLine(
                        $"ID:{temp.TicketId}, Name:{temp.CustomerName}, Movie:{temp.MovieName}, Seat:{temp.SeatNumber}, Time:{temp.BookingTime}"
                    );
                    temp = temp.Next;
                } while (temp != head);
            }

         
            public void SearchTicket(string key)
            {
                if (head == null)
                {
                    Console.WriteLine("No tickets available.");
                    return;
                }

                bool found = false;
                TicketNode temp = head;

                do
                {
                    if (temp.CustomerName.Equals(key, StringComparison.OrdinalIgnoreCase) ||
                        temp.MovieName.Equals(key, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(
                            $"ID:{temp.TicketId}, Name:{temp.CustomerName}, Movie:{temp.MovieName}, Seat:{temp.SeatNumber}"
                        );
                        found = true;
                    }
                    temp = temp.Next;
                } while (temp != head);

                if (!found)
                    Console.WriteLine("No matching ticket found.");
            }


        //Calculate the total number of booked tickets.
        public int CountTickets()
            {
                if (head == null) return 0;

                int count = 0;
                TicketNode temp = head;

                do
                {
                    count++;
                    temp = temp.Next;
                } while (temp != head);

                return count;
            }
        }

    //Main class
        class OnlineTicketReservationSystem
        {

        //main method
            public static void Main(string[] args)
            {
                TicketSystem ts = new TicketSystem();

                ts.AddTicket(1, "Rishita", "Dhrunandar", "A1", "9:00 AM");
                ts.AddTicket(2, "Rama", "Conjuring", "A1", "12:05 PM");
                ts.AddTicket(3, "Janvi", "Hehe", "A2", "10:10 AM");

                Console.WriteLine("All Tickets:");
                ts.DisplayTickets();
                Console.WriteLine();

                Console.WriteLine("Search by Movie:");
                ts.SearchTicket("Avatar");
                Console.WriteLine();

                Console.WriteLine("Total Tickets: " + ts.CountTickets());
                ts.RemoveTicket(2);
                Console.WriteLine();

                Console.WriteLine("After Removal..final displaying");
                ts.DisplayTickets();
            }
        }
    }


