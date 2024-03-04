using VehicleMaintenanceApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace VehicleMaintenanceApp.Data;
public class AppDbContext : DbContext
{
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Maintenance> Maintenances { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=MaintenanceRecords.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Maintenance>()
            .HasOne(m => m.Vehicle)
            .WithMany(v => v.Maintenances)
            .HasForeignKey(m => m.VehicleId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
