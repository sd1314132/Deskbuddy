namespace Deskbuddy.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Occupancy> Occupancies { get; set; }
        public int RoomId { get; internal set; }
    }
}
