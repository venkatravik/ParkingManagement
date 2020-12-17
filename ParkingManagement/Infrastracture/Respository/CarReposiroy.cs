using ParkingManagement.Infrastracture.Entities;
using ParkingManagement.Infrastracture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingManagement.Infrastracture.Respository
{
    public class CarReposiroy : ICarRepository
    {
        public Task<Car> CancelParking(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Car> CreateParking(Car car)
        {
            throw new NotImplementedException();
        }

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
