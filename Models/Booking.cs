using MongoDB.Bson;
using MongoDB.EntityFrameworkCore;

namespace SuperCarBookingSystem.Models
{
    [Collection("bookings")]
    public class Booking : EntityBase
    {
        public ObjectId Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string UserId { get; set; }
        public ObjectId CarId { get; set; }
    }
}
