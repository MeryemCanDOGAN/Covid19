using Microsoft.EntityFrameworkCore;

namespace CovidApp
{
    public class CovidAppDbContext : DbContext
    {
        public DbSet<Account>? Accounts { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Address>? Addresses { get; set; }
        public DbSet<City>? Cities { get; set; }
        public DbSet<District>? Districts { get; set; }
        public DbSet<Notify>? Notifies { get; set; }
        public DbSet<Passport>? Passports { get; set; }
        public DbSet<VaccinationInformation>? VaccinationInformations { get; set; }
        public DbSet<ViolationType>? ViolationTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
            optionsBuilder.UseMySql("server=localhost;database=CovidAppDb;user=root;port=3306;password=toortoor", serverVersion);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
