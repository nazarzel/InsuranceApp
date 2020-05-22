using InsuranceApp.Data;
using InsuranceApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceApp.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext context;

        public CarRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async void CreateNewCarAsync(Car car)
        {
            await context.Cars.AddAsync(car);
            SaveAsync();
        }

        public void DeleteCar(Car carToDelete)
        {
            context.Cars.Remove(carToDelete);
            SaveAsync();
        }

        public async Task<IEnumerable<Car>> GetAllCarsAsync()
        {
            return await context.Cars.OrderBy(c => c.Brand).ToListAsync();
        }

        public async Task<Car> GetCarByIdAsync(Guid carId)
        {
            return await context.Cars.Where(c => c.Id == carId).FirstOrDefaultAsync();
        }

        public async void SaveAsync()
        {
            if (await context.SaveChangesAsync()>0)
                throw new Exception("Saving the data has failed on save");
        }

        public void UpdateCar(Car carToUpdate)
        {
            context.Cars.Update(carToUpdate);
            SaveAsync();
        }

    }
}
