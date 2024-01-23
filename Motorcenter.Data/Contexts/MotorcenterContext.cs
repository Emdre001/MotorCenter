
namespace Motorcenter.Data.Contexts;

public class MotorcenterContext(DbContextOptions<MotorcenterContext> Builder) : DbContext(Builder)
{
    public DbSet<Brand> Brands => Set<Brand>();
    public DbSet<Color> Colors => Set<Color>();
    public DbSet<Filter> Filters => Set<Filter>();
    public DbSet<Fuel> Fuels => Set<Fuel>();
    public DbSet<Mileage> Mileages => Set<Mileage>();
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();
   public DbSet<VehicleType> VehicleTypes => Set<VehicleType>();
    public DbSet<BrandFilter> BrandFilters => Set<BrandFilter>();
    public DbSet<BrandVehicleType> BrandVehicleTypes => Set<BrandVehicleType>();
  
   

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Composite Keys
        builder.Entity<BrandFilter>()
            .HasKey(pc => new { pc.BrandId, pc.FilterId });
        builder.Entity<BrandVehicleType>()
            .HasKey(ps => new { ps.VehicleTypeId, ps.BrandId });

        #endregion

        #region VehicleTypeFilter Many-to-Many Relationship

        builder.Entity<VehicleType>()
            .HasMany(c => c.Filters)
            .WithMany(f => f.VehicleTypes)
            .UsingEntity<BrandFilter>();
        #endregion

        

    

        
        
        #region BrandVehicleType Many-to-Many Relationship
        builder.Entity<VehicleType>()
            .HasMany(p => p.Brands)
            .WithMany(c => c.VehicleTypes)
            .UsingEntity<BrandVehicleType>();
        #endregion

      

    

    }
}