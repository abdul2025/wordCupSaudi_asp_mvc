using Microsoft.EntityFrameworkCore;
using worldcup.Models;

namespace worldcup.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Cities>()
                    .HasOne(c => c.Province)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(p => p.ProvinceId); // Specify foreign key
                
                modelBuilder.Entity<Schedule>()
                    .HasOne(s => s.Stadium)
                    .WithMany(ss => ss.Schedule)
                    .HasForeignKey(ss => ss.StadiumId); // Specify foreign key

                // Configure Many-to-Many Relationship
                modelBuilder.Entity<Schedule>()
                    .HasMany(s => s.Teams)
                    .WithMany(t => t.Schedules)
                    .UsingEntity(j => j.ToTable("ScheduleTeams")); // Optional: Rename the join table
                        
            }

        

        public DbSet<Categories> Categories { get; set; }
        public DbSet<TransportType> TransportType { get; set; }
        public DbSet<Stadiums> Stadiums { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Provinces> Provinces { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Transport> Transport { get; set; }
    }
}
