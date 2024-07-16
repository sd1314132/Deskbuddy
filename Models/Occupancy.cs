using System.ComponentModel.DataAnnotations;
using Deskbuddy.Areas.Identity.Data;

namespace Deskbuddy.Models
{
    public class Occupancy
    {
        public int Id { get; set; }
        public int RoomId { get; set; }  
        public int? EmployeeId { get; set; }
        public string? UserId { get; set; }
        public enum FeaturesType
        {
            None,
            Ruheraum,
            Partyraum,
            Schlafraum,
        }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        // Navigation properties
        public Room? Room { get; set; }

        public FeaturesType Features { get; set; }
        public EmployeeId? Employee { get; set; }

        public DeskbuddyUser? User { get; set; }   
    }

}
