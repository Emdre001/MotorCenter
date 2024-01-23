namespace Motorcenter.Data.Entities;

public class Vehicle : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
    public int BrandId { get; set; }
    public int MileageId { get; set; }
    public Brand Brand { get; set; }
    public Mileage Mileage { get; set; }
    public int ColorId { get; set; }
    public Color Color { get; set; }

    public int VehicleTypeId { get; set; }

    public VehicleType VehicleType {  get; set; }
}