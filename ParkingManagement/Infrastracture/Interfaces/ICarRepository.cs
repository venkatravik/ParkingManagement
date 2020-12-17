using ParkingManagement.Infrastracture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingManagement.Infrastracture.Interfaces
{
    public interface ICarRepository
    {

        Task<Car> NoOfTransactions();
        Task<Car> CreateParking(Car car);
        Task<Car> CancelParking(int id);
        Task<Car> UpdateParking(int Id);
    }
}
