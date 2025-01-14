using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Department:BaseEntity
    {
        
        public string Name { get; set; } = null!;
        public IEnumerable<Doctor>? Doctors{ get; set; }
    }
}
