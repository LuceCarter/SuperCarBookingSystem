using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.EntityFrameworkCore;

namespace SuperCarBookingSystem.Models
{
    [Collection("cars")]
    
    public class Car : EntityBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string? Model { get; set; }
        public string? Location { get; set; }
        public bool IsBooked { get; set; }
    }
}
