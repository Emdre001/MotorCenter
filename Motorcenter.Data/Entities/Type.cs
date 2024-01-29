namespace Motorcenter.Data.Entities;

public class Type : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Vehicle>? Vehicles { get; set; }
    public List<Filter> Filters { get; set; }
}
