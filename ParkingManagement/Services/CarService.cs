using ParkingManagement.Interfaces;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingManagement.Services
{
    public class CarService : ICarService
    {
        public Task<Car> CancelParking(int id)
        {
            throw new NotImplementedException();
        }

        //public Task<Car> CreateParking(Car car)
        //{
        //    throw new NotImplementedException();
        //}

        public Task<Car> NoOfTransactions()
        {
            throw new NotImplementedException();
        }

        public Task<Car> UpdateParking(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
