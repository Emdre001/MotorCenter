
using System.Reflection;

namespace Motorcenter.Data.Contexts;

// DbContext är en del av Entity Framework Core och hanterar databasåtkomst
public class MotorcenterContext(DbContextOptions<MotorcenterContext> Builder) : DbContext(Builder)
{
 
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();
    public DbSet<Entities.Type> Types => base.Set<Entities.Type>();
    public DbSet<TypeVehicle> TypeVehicles => Set<TypeVehicle>();
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Composite Keys
        builder.Entity<TypeVehicle>()
            .HasKey(pc => new { pc.VehicleId, pc.TypeId });
        #endregion

        #region TypeVehicle Many-to-Many Relationship
        builder.Entity<Vehicle>()
            .HasMany(p => p.VehicleTypes)
            .WithMany(c => c.Vehicles)
            .UsingEntity<TypeVehicle>();
        #endregion
    }
}