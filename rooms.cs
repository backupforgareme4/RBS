using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ErskineRoomBookingSystem.Models
{
    public class rooms
    {
        public int ID { get; set; }
        public string building { get; set; }
        public string area { get; set; }
        public string name { get; set; }
        public string coords { get; set; }

    }

    public class RoomsDBContext: DbContext
    {
        public DbSet<rooms> Rooms { get; set; }
    }

}