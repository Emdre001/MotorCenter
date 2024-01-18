namespace Motorcenter.Data.Entities;

public class Brand : IEntity 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Vehicle>? Vehicles { get; set; }
}
