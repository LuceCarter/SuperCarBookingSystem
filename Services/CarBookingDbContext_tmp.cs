using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SuperCarBookingSystem.Models;

namespace SuperCarBookingSystem.Services
{
    public class CarBookingDbContextOld : DbContext
    {
        public readonly IMongoCollection<User> Users;
        public readonly IMongoCollection<Car> Cars;
        public readonly IMongoCollection<Booking> Bookings;
        

        public CarBookingDbContextOld(DbContextOptions<CarBookingDbContext> options, IOptions<MongoDBSettings> mongodbSettings)       
        {
            //Rita there must be another way
            
            MongoClient client = new MongoClient(mongodbSettings.Value.AtlasURI);
            IMongoDatabase database = client.GetDatabase(mongodbSettings.Value.DatabaseName);

            //Rita they should be automatically mapped to the collection
            Users = database.GetCollection<User>("users");
            Cars = database.GetCollection<Car>("cars");
            Bookings = database.GetCollection<Booking>("bookings");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>((e) =>
            {
                e.HasKey((a) => new { a.Id });
                e.HasIndex((a) => new { a.Email });                
            });

            modelBuilder.Entity<Car>((e) =>
            {
                e.HasKey((a) => new { a.Id });
            });

            modelBuilder.Entity<Booking>((e) =>
            {
                e.HasKey((a) => new { a.Id });
            });
        }
    }
}
