using System;
using System.Collections.Generic;

#nullable disable

namespace ParkingManagement.Infrastracture.Entities
{
    public partial class Parking
    {
        //public Parking()
        //{
        //    Cars = new HashSet<Car>();
        //}

        //public Guid Pid { get; set; }
        //public int? NumberOfslots { get; set; }
        //public DateTime? Date { get; set; }
        //public int? BookedSlots { get; set; }

        //public virtual ICollection<Car> Cars { get; set; }

        public Parking()
        {
            Cars = new HashSet<Car>();
        }

        public Guid Pid { get; set; }
        public int? NumberOfslots { get; set; }
        public DateTime? Date { get; set; }
        public int? BookedSlots { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
