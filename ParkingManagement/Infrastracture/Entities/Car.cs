using System;
using System.Collections.Generic;

#nullable disable

namespace ParkingManagement.Infrastracture.Entities
{
    public partial class Car
    {
        //public Guid Cid { get; set; }
        //public Guid? Pid { get; set; }
        //public DateTime? Fromdate { get; set; }
        //public DateTime? Todate { get; set; }
        //public string CarNumber { get; set; }

        //public virtual ParkingTable PidNavigation { get; set; }

        public Guid Cid { get; set; }
        public Guid? Pid { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
        public string CarNumber { get; set; }

        public virtual Parking PidNavigation { get; set; }
    }
}
