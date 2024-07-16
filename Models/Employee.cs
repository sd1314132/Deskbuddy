using Deskbuddy.Areas.Identity.Data;

namespace Deskbuddy.Models
{
    public class EmployeeId
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public ICollection<Occupancy>? Occupancies { get; set; }

    }
}
