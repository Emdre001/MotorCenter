namespace Motorcenter.Data.Entities;

public class Vehicle : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Type>? VehicleTypes { get; set; }
}
