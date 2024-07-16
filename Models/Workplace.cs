namespace Deskbuddy.Models
{
    public class Workplace
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string SpecialProperties { get; set; }
        public int RoomId { get; set; }

        // Navigation properties
        public Room Room { get; set; }
        public ICollection<Occupancy> Occupancies { get; set; }
    }
}
