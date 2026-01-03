using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo
{
    public class HotelBookingSystem
    {
        public string guestName;
        public string roomType;
        public string nights;

        //DEFAULT CONSTRUCTOR
        public HotelBookingSystem()
        {
            guestName = "Rishita";
            roomType = "Basic";
            nights = "2 Night";
        }

        //PARAMETERIZED CONSTRUCTOR AND TAKING USER INPUT
        public HotelBookingSystem(string GuestName, string RoomType, string Nights)
        {
            this.guestName = GuestName;
            this.roomType = RoomType;
            this.nights = Nights;
        }

        //COPY CONSTRUCTOR
        public HotelBookingSystem(HotelBookingSystem other)
        {
            guestName = other.guestName;
            roomType = other.roomType;
            nights = other.nights;
        }

        //MAIN METHOD

        public static void Main(string[] args)
        {
            //defalut constructor calling
            HotelBookingSystem B1=new HotelBookingSystem();

            Console.WriteLine(B1.guestName + "," + B1.roomType + "," + B1.nights);


            //paramterized constructor calling 
            HotelBookingSystem B2 = new HotelBookingSystem("Rama" , "VIP" ,"4 nights");

            Console.WriteLine(B2.guestName + "," + B2.roomType + "," + B2.nights);


            //copy constructor calling
            HotelBookingSystem B3 = new HotelBookingSystem(B2);

            Console.WriteLine(B3.guestName + "," + B3.roomType + "," + B3.nights);

        }

    }
}
