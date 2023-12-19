using Space_Booking_System.Models;
using Space_Booking_System.myDbContext;
using System;
namespace Space_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext myDB = new ApplicationDbContext();
            string spaceName = "Creativity Hall";
            int capacity = 20;
            Space space = new Space
            {
                SpaceName = spaceName,
                Capacity = capacity
            };
            myDB.Spaces.Add(space);
            myDB.SaveChanges();

            
            Booking booking = new Booking
            {
                SpaceID = 1,
                BookingDate = DateTime.Now.Date,
                BookingTime = DateTime.Now.TimeOfDay,
                UserName = "salim juma"
            };
            Booking booking1 = new Booking
            {
                SpaceID = 3,
                BookingDate = DateTime.Now.Date,
                BookingTime = DateTime.Now.TimeOfDay,
                UserName = "akram juma"
            };

            myDB.Bookings.Add(booking);
            myDB.Bookings.Add(booking1);
            myDB.SaveChanges();

        }
    }
}