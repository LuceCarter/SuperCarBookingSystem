﻿using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore.Extensions;
using SuperCarBookingSystem.Models;

namespace SuperCarBookingSystem.Services
{
    public class CarBookingDbContext : DbContext
    {
        public DbSet<Car> Cars { get; init; }
        public DbSet<Booking> Bookings { get; init; }

        public static CarBookingDbContext Create(IMongoDatabase database) =>
            new(new DbContextOptionsBuilder<CarBookingDbContext>()
                .UseMongoDB(database.Client, database.DatabaseNamespace.DatabaseName)
                .Options);

        public CarBookingDbContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Car>().ToCollection("cars");
            modelBuilder.Entity<Booking>().ToCollection("bookings");
        }
    }
}
