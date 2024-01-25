
namespace Motorcenter.Data.Contexts
{
    // DbContext är en del av Entity Framework Core och hanterar databasåtkomst
    public class MotorcenterContext : DbContext
    {
        // Konstruktorn tar emot inställningar för DbContext och skickar dem vidare till basklassen
        public MotorcenterContext(DbContextOptions<MotorcenterContext> options) : base(options)
        {
        }

        // DbSet representerar varje tabell i databasen, här finns det en för varje entitet
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Mileage> Mileages { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<BrandFilter> BrandFilters { get; set; }
        public DbSet<BrandVehicleType> BrandVehicleTypes { get; set; }

        // OnModelCreating används för att konfigurera databasmodellen
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Kör basklassens OnModelCreating-metod
            base.OnModelCreating(builder);

            // Här sätts sammansatta nycklar för BrandFilter och BrandVehicleType-tabellerna
            builder.Entity<BrandFilter>().HasKey(pc => new { pc.BrandId, pc.FilterId });
            builder.Entity<BrandVehicleType>().HasKey(ps => new { ps.VehicleTypeId, ps.BrandId });

            // Här sätts en många-till-många-relation mellan VehicleType och Filter genom BrandFilter-tabellen
            builder.Entity<VehicleType>().HasMany(c => c.Filters).WithMany(f => f.VehicleTypes).UsingEntity<BrandFilter>();

            // Här sätts en många-till-många-relation mellan VehicleType och Brand genom BrandVehicleType-tabellen
            builder.Entity<VehicleType>().HasMany(p => p.Brands).WithMany(c => c.VehicleTypes).UsingEntity<BrandVehicleType>();
        }
    }
}
