using Microsoft.EntityFrameworkCore;
using ParkingManagement.Infrastracture.Entities;
using ParkingManagement.Infrastracture.Interfaces;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingManagement.Infrastracture.Respository
{
    public class ParkingRepository : IParkingRepository
    {

        private readonly ParkingManegmentContext _parkingManegmentContext;

        public ParkingRepository(ParkingManegmentContext parkingManegmentContext)
        {
            _parkingManegmentContext = parkingManegmentContext;
        }
        public async Task<Entities.Parking> AvailableSlots(DateTime fromdate, DateTime todate)
        {
            //var List = await _parkingManegmentContext.ParkingTables.FirstOrDefaultAsync(
            //    m => m.Cars.FirstOrDefault(e => e.Fromdate == fromdate));
            throw new NotImplementedException();
        }

        public async Task<Entities.Parking> AvailableSlots(DateTime fromdate)
        {
            var List = await _parkingManegmentContext.Parkings.FirstOrDefaultAsync(m => m.Date== fromdate);
            if (List == null && List.BookedSlots <=0)
            {
                return null;
            }

            return List;

        }

        public async Task<List<Entities.Parking>> AvvaibleSlots()
        {
            var List = await _parkingManegmentContext.Parkings.ToListAsync();
            return List;
        }

        public async Task CreateParking(Entities.Parking parking)
        {
            try
            {
                 _parkingManegmentContext.Add(parking);
                await _parkingManegmentContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
