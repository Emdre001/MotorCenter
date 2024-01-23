namespace Motorcenter.Data.Entities;

public class VehicleType : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Filter> Filters { get; set; }

    public List<Vehicle>? Vehicles { get; set; }
    
    public List<Brand> Brands { get; set; }
}
