namespace SuperCarBookingSystem.Models
{
    public class ChangeRecord
    {
        public DateTime ChangeDate { get; set; }

        public User User { get; set; }
        public string Description { get; set; }
    }
}
