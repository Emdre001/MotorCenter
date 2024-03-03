namespace Motorcenter.Data.Entities;

public class Vehicle : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } = string.Empty;
    public string PictureURL { get; set; } = string.Empty;
    public List<Type>? VehicleTypes { get; set; }
}
