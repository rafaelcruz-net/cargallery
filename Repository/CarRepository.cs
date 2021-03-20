using System;
using System.Collections.Generic;
using System.Linq;
using CarGallery.Models;
using CarGallery.Repository.Context;

namespace CarGallery.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return this._appDbContext.Cars.ToList();
        }

        public Car GetCarById(Guid carId)
        {
            return _appDbContext.Cars.FirstOrDefault(p => p.CarId == carId);
        }
    }

}