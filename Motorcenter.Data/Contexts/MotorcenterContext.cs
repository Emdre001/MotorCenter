using Microsoft.EntityFrameworkCore;
using Motorcenter.Data.Entities;

namespace Motorcenter.Data.Contexts;

public class MotorcenterContext(DbContextOptions<MotorcenterContext> Builder) : DbContext(Builder)
{
    public DbSet<Brand> Brands => Set<Brand>();
    public DbSet<Color> Colors => Set<Color>();
    public DbSet<Filter> Filters => Set<Filter>();
    public DbSet<Fuel> Fuels => Set<Fuel>();
    public DbSet<Mileage> Mileages => Set<Mileage>();
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();
    public DbSet<VehicleColor> VehicleColors => Set<VehicleColor>();
    public DbSet<VehicleFuel> VehicleFuels => Set<VehicleFuel>();
    public DbSet<VehicleType> VehicleTypes => Set<VehicleType>();
    public DbSet<VehicleTypeFilter> VehicleTypeFilers => Set<VehicleTypeFilter>();
    public DbSet<VehicleTypeVehicle> vehicleTypeVehicles => Set<VehicleTypeVehicle>();
    public DbSet<Year> Years => Set<Year>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Composite Keys
        builder.Entity<VehicleColor>()
            .HasKey(pc => new { pc.VehicleId, pc.ColorId });
        builder.Entity<VehicleTypeFilter>()
            .HasKey(ps => new { ps.VehicleTypeId, ps.FilterId });
        builder.Entity<VehicleTypeVehicle>()
            .HasKey(pc => new { pc.VehicleId, pc.VehicleTypeId });
        builder.Entity<VehicleFuel>()
            .HasKey(cf => new { cf.FuelId, cf.VehicleId });
        #endregion

        #region VehicleTypeFilter Many-to-Many Relationship

        builder.Entity<VehicleType>()
            .HasMany(c => c.Filters)
            .WithMany(f => f.VehicleTypes)
            .UsingEntity<VehicleTypeFilter>();
        #endregion

        #region VehicleVehicleType Many-to-Many Relationship
        builder.Entity<Vehicle>()
            .HasMany(p => p.VehicleTypes)
            .WithMany(c => c.Vehicles)
            .UsingEntity<VehicleTypeVehicle>();
        #endregion

        #region VehicleFuel Many-to-Many Relationship
        builder.Entity<Vehicle>()
            .HasMany(p => p.Fuels)
            .WithMany(c => c.Vehicles)
            .UsingEntity<VehicleFuel>();
        #endregion

        #region VehicleColor Many-to-Many Relationship
        builder.Entity<Vehicle>()
            .HasMany(p => p.Colors)
            .WithMany(c => c.Vehicles)
            .UsingEntity<VehicleColor>();
        #endregion

        #region VehicleBrand One-to-Many Relationship
        builder.Entity<Vehicle>()
            .HasOne(p => p.Brand)
            .WithMany(c => c.Vehicles)
            .HasForeignKey(b => b.BrandId);
        #endregion

        #region VehicleMileage One-to-Many Relationship
        builder.Entity<Vehicle>()
            .HasOne(p => p.Mileage)
            .WithMany(c => c.Vehicles)
            .HasForeignKey(b => b.MileageId);
        #endregion

        #region VehicleYear One-to-Many Relationship
        builder.Entity<Vehicle>()
            .HasOne(p => p.Year)
            .WithMany(c => c.Vehicles)
            .HasForeignKey(b => b.YearId);
        #endregion

    }
}