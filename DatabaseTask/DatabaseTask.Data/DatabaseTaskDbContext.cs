using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Bookable> Bookable { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Guests> Guests { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Payroll> Payroll { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Services> Service { get; set; }
        public DbSet<ServiceOrder> ServiceOrder { get; set; }
    }
}
