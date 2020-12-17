using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingManagement.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string CarNumber { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }        

         
    }
}
