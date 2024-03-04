
using System.Drawing;
using System.Reflection;

namespace Motorcenter.Data.Contexts;

// DbContext är en del av Entity Framework Core och hanterar databasåtkomst
public class MotorcenterContext(DbContextOptions<MotorcenterContext> Builder) : DbContext(Builder)
{
 
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();
    public DbSet<Entities.Type> Types => base.Set<Entities.Type>();
    public DbSet<TypeVehicle> TypeVehicles => Set<TypeVehicle>();
    public DbSet<Year> Years => Set<Year>();
    public DbSet<Entities.Color> Colors => base.Set<Entities.Color>();
    public DbSet<TypeVehicle> TypeVehicle => Set<TypeVehicle>();
    public DbSet<VehicleYear> VehicleYear => Set<VehicleYear>();
    public DbSet<VehicleColor> VehicleColor => Set<VehicleColor>();
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Composite Keys
        builder.Entity<VehicleColor>()
            .HasKey(pc => new { pc.VehicleId, pc.ColorId });
        builder.Entity<VehicleYear>()
            .HasKey(ps => new { ps.VehicleId, ps.YearId });
        builder.Entity<TypeVehicle>()
            .HasKey(pc => new { pc.VehicleId, pc.TypeId });
        #endregion

        #region TypeVehicle Many-to-Many Relationship
        builder.Entity<Vehicle>()
            .HasMany(p => p.Types)
            .WithMany(c => c.Vehicles)
            .UsingEntity<TypeVehicle>();
        #endregion

        #region VehicleYear Many-to-Many Relationship
        builder.Entity<Vehicle>()
            .HasMany(p => p.Years)
            .WithMany(c => c.Vehicles)
            .UsingEntity<VehicleYear>();
        #endregion

        #region VehicleColor Many-to-Many Relationship
        builder.Entity<Vehicle>()
            .HasMany(p => p.Colors)
            .WithMany(c => c.Vehicles)
            .UsingEntity<VehicleColor>();
        #endregion

    }
}