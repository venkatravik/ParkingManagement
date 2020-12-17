using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingManagement.Interfaces
{
    public interface ICarService
    {
        Task<Car> NoOfTransactions();
        Task<Car> CancelParking(int id);
        Task<Car> UpdateParking(int Id);
    }
}
