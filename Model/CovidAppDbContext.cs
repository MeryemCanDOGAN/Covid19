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
            modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.PhoneNumber).IsRequired();
            entity.Property(e=> e.Blocked);
            entity.Property(e=>e.IsVisibility);
            entity.HasOne(b => b.User).WithOne(i => i.Account).HasForeignKey<User>(b => b.AccountId);
        });
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.FirstName).IsRequired();
            entity.Property(e => e.LastName).IsRequired();
            entity.Property(e => e.Gender).IsRequired();
            entity.Property(e => e.IsCorona).IsRequired();
            entity.Property(e => e.Birthdate).IsRequired();
            entity.Property(e => e.AccountId).IsRequired();
            entity.HasMany(e=>e.Passports).WithOne(r=>r.User).HasForeignKey(e=> e.UserId);
            entity.HasMany(e=> e.Notifies).WithOne(e=>e.User).HasForeignKey(e=>e.UserId);
            entity.HasMany(e=> e.VaccinationInformation).WithOne(e=>e.User).HasForeignKey(e=>e.UserId);
            entity.HasOne(e=>e.City).WithMany().HasForeignKey(e=>e.CityId);
        });
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.OpenAddress).IsRequired();
            entity.HasOne(e=> e.City).WithMany().HasForeignKey(e=>e.CityId);
            entity.HasOne(e=> e.District).WithMany().HasForeignKey(e=>e.DistrcitId);
        });
        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.HasMany(e=> e.District).WithOne(e=>e.City).HasForeignKey(e=> e.CityId);

        });
        modelBuilder.Entity<District>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
        });
        modelBuilder.Entity<Notify>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).IsRequired();
            entity.Property(e => e.ViolationSubject).IsRequired();
            entity.Property(e => e.ViolationDetail).IsRequired();
            entity.HasOne(e=>e.ViolationType).WithOne(e=>e.Notify).HasForeignKey<ViolationType>(e=>e.NotifyId);
            entity.HasOne(e=>e.Address).WithOne(e=>e.Notify).HasForeignKey<Address>(e=>e.NotifyId);
        });
        modelBuilder.Entity<Passport>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.No).IsRequired();
            entity.Property(e => e.CountryCode).IsRequired();
        });
        modelBuilder.Entity<VaccinationInformation>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.VacinationName).IsRequired();
            entity.Property(e => e.VaccinationDate).IsRequired();

        });
        modelBuilder.Entity<ViolationType>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.IsMaskedUsed).IsRequired();
            entity.Property(e => e.IsHygienic).IsRequired();
            entity.Property(e => e.IsSocialDistanceViolated).IsRequired();
        });

        }

    }
}
