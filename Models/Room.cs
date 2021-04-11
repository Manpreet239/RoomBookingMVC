using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoomBookingMVC.Models
{
    public class Room
    {

        public int Roomid { get; set; }

        [Display(Name = "Room Type ")]
        public string RoomType { get; set; }

        [Display(Name = "Specification")]
        public string Specification { get; set; }



        [Display(Name = "Fair ")]
        public int Fair { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
