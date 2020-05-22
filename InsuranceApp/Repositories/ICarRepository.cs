using InsuranceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceApp.Repositories
{
    public interface ICarRepository
    {
        void CreateNewCarAsync(Car car);
        Task<IEnumerable<Car>> GetAllCarsAsync();
        Task<Car> GetCarByIdAsync(Guid carId);
        void UpdateCar(Car carToUpdate);
        void DeleteCar(Car carToDelete);
        void SaveAsync();
    }
}
