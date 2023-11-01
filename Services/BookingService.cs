using MongoDB.Driver;
using MongoDB.Driver.Linq;
using SuperCarBookingSystem.Models;

namespace SuperCarBookingSystem.Services
{
    public class BookingService : BaseService, IBookingService
    {
        public BookingService(IServiceProvider serviceProvider) : base(serviceProvider) { }
      
        public void CreatingBooking(Booking booking)
        {
            booking.CreatedAt = DateTime.Now;
          
            _carBookingDbContext.SaveChanges();
        }

        public IEnumerable<Booking> GetAllBookings()
        {
            return _carBookingDbContext.Bookings.ToList();
            
        }
    }
}
