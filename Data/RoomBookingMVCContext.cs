using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RoomBookingMVC.Models;

namespace RoomBookingMVC.Data
{
    public class RoomBookingMVCContext : DbContext
    {
        public RoomBookingMVCContext (DbContextOptions<RoomBookingMVCContext> options)
            : base(options)
        {
        }

        public DbSet<RoomBookingMVC.Models.Booking> Booking { get; set; }

        public DbSet<RoomBookingMVC.Models.Customer> Customer { get; set; }

        public DbSet<RoomBookingMVC.Models.Room> Room { get; set; }
    }
}
