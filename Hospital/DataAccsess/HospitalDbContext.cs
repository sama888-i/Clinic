using Hospital.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.DataAccsess
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get;set;}



        public HospitalDbContext(DbContextOptions opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HospitalDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }


    }
}
