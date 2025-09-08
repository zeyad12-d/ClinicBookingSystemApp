using ClinicBookingSystemAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicBookingSystemAPP.Data;

public class ClinicDbContext : DbContext // Ensure ClinicDbContext inherits from DbContext
{
    public ClinicDbContext(DbContextOptions<ClinicDbContext> options) : base(options)
    {
    }

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure the relationships and constraints here if needed
        base.OnModelCreating(modelBuilder);
    }
}
