using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarGallery.Models;
using CarGallery.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CarGallery.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;
        public CarController(ICarRepository carRepository)
        {
            this._carRepository = carRepository;
        }

        public IActionResult Index(string search)
        {
            IEnumerable<Car> cars;
            string category;

            if (string.IsNullOrEmpty(search))
            {
                cars = _carRepository.GetAllCars();
                category = "All Cars";
            }
            else
            {
                cars = _carRepository.GetAllCars().Where(p => p.CategoryName == search).ToList();
                category = cars.FirstOrDefault().CategoryName;
            }

            ViewBag.CategoryName = category;

            return View(cars);
        }

        [Route("car/details/{id}")]
        public IActionResult Details(Guid id)
        {
            var car = this._carRepository.GetCarById(id);
            
            return View(car);
        }
       
    }
}