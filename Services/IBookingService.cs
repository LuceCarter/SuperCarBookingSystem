using SuperCarBookingSystem.Models;

namespace SuperCarBookingSystem.Services
{
    public interface IBookingService
    {
        IEnumerable<Booking> GetAllBookings();

        void CreatingBooking(Booking booking);
    }
}
