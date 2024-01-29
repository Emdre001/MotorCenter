
using System.Reflection;

namespace Motorcenter.Data.Contexts;

// DbContext är en del av Entity Framework Core och hanterar databasåtkomst
public class MotorcenterContext(DbContextOptions<MotorcenterContext> Builder) : DbContext(Builder)
{
    public DbSet<Brand> Brands => Set<Brand>();
    public DbSet<Color> Colors => Set<Color>();
    public DbSet<Filter> Filters => Set<Filter>();
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();
    public DbSet<VehicleColor> VehicleColors => Set<VehicleColor>();
    public DbSet<Entities.Type> Types => base.Set<Entities.Type>();
    public DbSet<FilterType> Filtertypes => Set<FilterType>();
    public DbSet<TypeVehicle> TypeVehicles => Set<TypeVehicle>();
    public DbSet<Year> Years => Set<Year>();
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Composite Keys
        builder.Entity<VehicleColor>()
            .HasKey(pc => new { pc.VehicleId, pc.ColorId });
        builder.Entity<FilterType>()
            .HasKey(ps => new { ps.TypeId, ps.FilterId });
        builder.Entity<TypeVehicle>()
            .HasKey(pc => new { pc.VehicleId, pc.TypeId });
        #endregion

        #region TypeFilter Many-to-Many Relationship

        builder.Entity<Entities.Type>()
            .HasMany(c => c.Filters)
            .WithMany(f => f.VehicleTypes)
            .UsingEntity<FilterType>();
        #endregion

        #region TypeVehicle Many-to-Many Relationship
        builder.Entity<Vehicle>()
            .HasMany(p => p.VehicleTypes)
            .WithMany(c => c.Vehicles)
            .UsingEntity<TypeVehicle>();
        #endregion

        #region VehicleColor Many-to-Many Relationship
        builder.Entity<Vehicle>()
            .HasMany(p => p.Colors)
            .WithMany(c => c.Vehicles)
            .UsingEntity<VehicleColor>();
        #endregion

        #region BrandVehicle One-to-Many Relationship
        builder.Entity<Vehicle>()
            .HasOne(p => p.Brand)
            .WithMany(c => c.Vehicles)
            .HasForeignKey(b => b.BrandId);
        #endregion

        #region YearVehicle One-to-Many Relationship
        builder.Entity<Vehicle>()
            .HasOne(p => p.Year)
            .WithMany(c => c.Vehicles)
            .HasForeignKey(b => b.YearId);
        #endregion
    }
}