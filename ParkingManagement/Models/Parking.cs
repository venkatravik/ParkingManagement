using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingManagement.Models
{
    public class Parking
    {
        public string CarNumber { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public int noOfSlots { get; set; }
        public int BokkedSlots { get; set; }


    }
}
