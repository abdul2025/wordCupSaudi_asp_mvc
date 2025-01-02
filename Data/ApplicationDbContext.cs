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
            modelBuilder.Entity<ScheduleTeam>()
                .HasOne(st => st.Schedule)
                .WithMany()
                .HasForeignKey(st => st.ScheduleId)
                .OnDelete(DeleteBehavior.NoAction);  // No cascading delete

            modelBuilder.Entity<ScheduleTeam>()
                .HasOne(st => st.Stadium)
                .WithMany()
                .HasForeignKey(st => st.StadiumId)
                .OnDelete(DeleteBehavior.NoAction);  // No cascading delete
        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<CategoriesTransport> CategoriesTransport { get; set; }
        public DbSet<Stadiums> Stadiums { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Provinces> Provinces { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<ScheduleTeam> ScheduleTeam { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Transport> Transport { get; set; }
    }
}
