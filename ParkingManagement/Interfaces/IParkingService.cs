using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingManagement.Interfaces
{
    public interface IParkingService
    {

        Task<Parking> AvvaibleSlots();
        Task<Parking> AvailableSlots(DateTime fromdate, DateTime todate);
        Task<Parking> AvailableSlots(DateTime fromdate);

        Task<Parking> CreateParking(Parking parking);
    }
}
