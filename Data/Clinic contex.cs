using Microsoft.EntityFrameworkCore;
public class ClinicContext : DbContext {
    public ClinicContext(DbContextOptions<ClinicContext> options) : base(options) {}
    public DbSet<Doctor> Doctors => Set<Doctor>();
    public DbSet<Patient> Patients => Set<Patient>();
    public DbSet<Appointment> Appointments => Set<Appointment>();
    public DbSet<User> Users => Set<User>();
}
