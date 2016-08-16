using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ErskineRoomBookingSystem.Models
{
    public class Booking
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string room { get; set; }
        public string description { get; set; }
        public DateTime startAt { get; set; }
        public DateTime finishAt { get; set; }
        public int roomID { get; set; }
    }

    public class BookingDBContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
    }
    
}