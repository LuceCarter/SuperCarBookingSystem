using MongoDB.Driver;
using SuperCarBookingSystem.Models;

namespace SuperCarBookingSystem.Services
{
    public class CarService : ICarService
    {
        private readonly CarBookingDbContext _carBookingDbContext;
        public CarService(CarBookingDbContext carBookDbContext)
        {
            _carBookingDbContext = carBookDbContext;
        }
        public IEnumerable<Car> GetAllCars()
        {
            Console.WriteLine(_carBookingDbContext.Cars);
            return _carBookingDbContext.Cars.Where(c => true);
        }

        public Car? GetCarByIdAsync(string id)
        {
            return _carBookingDbContext.Cars.Where(car => car.Id == id).FirstOrDefault();
        }

        public IEnumerable<Car> GetUnbookedCars()
        {
            var unbookedCars = _carBookingDbContext.Cars.Where(car => car.IsBooked == false).ToList();
            foreach(var car in unbookedCars)
            {
                Console.WriteLine(car.Model);
            }

            return unbookedCars;
        }

        public async Task UpdateCarPartialAsync(string id, UpdateDefinition<Car> update)
        {
            //await _carBookingDbContext.Cars.UpdateOneAsync(car => car.Id == id, update);

        }
    }
}
