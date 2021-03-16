using System.Collections.Generic;
using CarGallery.Models;

namespace CarGallery.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int carId);
    }

}