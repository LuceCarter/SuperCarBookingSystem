using MongoDB.Driver;
using SuperCarBookingSystem.Models;

namespace SuperCarBookingSystem.Services
{
    public interface ICarService
    {
        IEnumerable<Car> GetAllCars();

        IEnumerable<Car> GetUnbookedCars();
        Car? GetCarByIdAsync(string id);
        Task UpdateCarPartialAsync(string id, UpdateDefinition<Car> update);
    }
}
