namespace Hospital.ViewModels.Doctor
{
    public class DoctorCreateVM
    {
        public string Name { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public int? DepartmentId { get; set; }
    }
}
