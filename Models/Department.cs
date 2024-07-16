namespace Deskbuddy.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Chief { get; set; }
        // Navigation property zu den Mitarbeitenden
        public ICollection<EmployeeId> Employees { get; set; }
    }
}
