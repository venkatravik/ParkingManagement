using ParkingManagement.Infrastracture.Entities;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingManagement.Infrastracture.Interfaces
{
    public interface IParkingRepository
    {
        Task<List<Entities.Parking>> AvvaibleSlots();
        Task<Entities.Parking> AvailableSlots(DateTime fromdate, DateTime todate);
        Task<Entities.Parking> AvailableSlots(DateTime fromdate);

        Task CreateParking(Entities.Parking parking);
    }
}
