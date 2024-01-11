namespace Motorcenter.Data.Entities;

public class VehicleType : IEntity
{
    public int Id { get; set; }
    public string Car { get; set; }
    public string Bike { get; set; }
    public string Snowmobile { get; set; }
    public string Moped { get; set; }
    public string Boat { get; set; }
    public string Jetski { get; set; }
    public List<Vehicle>? Vehicles { get; set; }
    public List<Filter> Filters { get; set; }
}
