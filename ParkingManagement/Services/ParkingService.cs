using ParkingManagement.Infrastracture.Entities;
using ParkingManagement.Infrastracture.Interfaces;
using ParkingManagement.Interfaces;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingManagement.Services
{
    public class ParkingService : IParkingService
    {

        private readonly IParkingRepository  _parkingRepository;
        public ParkingService(IParkingRepository parkingRepository)
        {
            _parkingRepository = parkingRepository;
        }

        public Task<Models.Parking> AvailableSlots(DateTime fromdate, DateTime todate)
        {
            throw new NotImplementedException();
        }

        public Task<Models.Parking> AvailableSlots(DateTime fromdate)
        {
            throw new NotImplementedException();
        }

        public Task<Models.Parking> AvvaibleSlots()
        {
            throw new NotImplementedException();
        }

        public Task<Models.Parking> CreateParking(Models.Parking parking)
        {
            Infrastracture.Entities.Parking parkingTable = new Infrastracture.Entities.Parking();
           // parkingTable.Pid = 1;
            parkingTable.Date = parking.Fromdate;
            parkingTable.NumberOfslots = 10;
            parkingTable.BookedSlots = 1;
            parkingTable.Cars.Add(new Infrastracture.Entities.Car()
            {
               // Cid = 1,
                //CarNumber = "ap07",
                //Fromdate = DateTime.UtcNow,
                //Todate=DateTime.UtcNow,
               // Pid= parkingTable.Pid

            });
            var results = _parkingRepository.CreateParking(parkingTable);
            return null;
        }
    }
}
