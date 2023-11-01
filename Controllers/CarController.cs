using Microsoft.AspNetCore.Mvc;
using SuperCarBookingSystem.Models;
using SuperCarBookingSystem.Services;

namespace SuperCarBookingSystem.Controllers
{
   
    public class CarController : Controller
    {
        ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }


        public IActionResult List()
        {
            // Dummy data to bypass current driver issue
            //List<Car> cars = new List<Car>();
            //cars.Add(new Car
            //{
            //    Id = "asadsdada",
            //    Model = "Tesla Model 3",
            //    Location = "Manchester City Centre",
            //    IsBooked = true,
            //});
            //cars.Add(new Car
            //{
            //    Id = "sakdajlkdaj",
            //    Model = "Volkswagen Polo",
            //    Location = "Manchester Airport",
            //    IsBooked = false,
            //});

            return View(_carService.GetAllCars());
        }
    }
}
