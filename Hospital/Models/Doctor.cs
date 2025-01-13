using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Doctor:BaseEntity
    {
        [MaxLength (32)]
        public string Name { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
