using Microsoft.EntityFrameworkCore;
using EduMon.Models;

namespace EduMon.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet properties for each entity
        public DbSet<User> Users { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<EduMon.Models.Command> Commands { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure ActivityLog
            modelBuilder.Entity<ActivityLog>()
                .HasKey(a => a.LogId); // Primary key

            modelBuilder.Entity<ActivityLog>()
                .HasOne(a => a.Computer) // Each ActivityLog references one Computer
                .WithMany(c => c.ActivityLogs) // Each Computer can have many ActivityLogs
                .HasForeignKey(a => a.ComputerId) // Foreign key in ActivityLog
                .OnDelete(DeleteBehavior.Cascade); // Delete logs when a computer is deleted

            // Configure Computer
            modelBuilder.Entity<Computer>()
                .HasKey(c => c.ComputerId); // Primary key

            // Configure User
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserId); // Primary key

            // Configure Alert
            modelBuilder.Entity<Alert>()
                .HasKey(al => al.AlertId); // Primary key

            // Configure Report
            modelBuilder.Entity<Report>()
                .HasKey(r => r.ReportId); // Primary key

            // Configure Command
            modelBuilder.Entity<EduMon.Models.Command>()
                .HasKey(cmd => cmd.CommandId); // Primary key
        }
    }
}
