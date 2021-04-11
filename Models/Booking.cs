using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoomBookingMVC.Models
{
    public class Booking
    {

        public int Bookingid { get; set; }

        [Display(Name = "Room ID ")]
        public int Room_ID { get; set; }

        [Display(Name = "Customer ID ")]
        public int Customer_ID { get; set; }



        [Display(Name = "Total Amount  ")]
        public int Total_Amount { get; set; }

        [Display(Name = "Booking Date ")]
        public string Booking_Date { get; set; }
    }
}
