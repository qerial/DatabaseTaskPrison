using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Aircraft> Aircraft { get; set; }
        public DbSet<Airline> Airline { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Airport> Airport { get; set; }
        public DbSet<Baggage> Baggage { get; set; }
        public DbSet<BaggageType> BaggageType { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<FlightStatus> FlightStatus { get; set; }
        public DbSet<Gate> Gate { get; set; }
        public DbSet<Passenger> Passenger { get; set; }
        public DbSet<Registration> Registration { get; set; }
        public DbSet<Terminal> Terminal { get; set; }
    }
}
