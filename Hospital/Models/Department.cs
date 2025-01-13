using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Department:BaseEntity
    {
        [MaxLength(128)]
        public string Name { get; set; } = null!;
        public IEnumerable<Doctor>? Doctors{ get; set; }
    }
}
