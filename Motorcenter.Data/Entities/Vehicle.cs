namespace Motorcenter.Data.Entities;

public class Vehicle : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int YearId { get; set; }
    public int BrandId { get; set; }
    public Brand Brand { get; set; }
    public Year Year { get; set; }
    public List<Type>? VehicleTypes { get; set; }
    public List<Color>? Colors { get; set; }
}
