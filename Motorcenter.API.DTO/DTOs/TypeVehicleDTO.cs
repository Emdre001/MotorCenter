namespace Motorcenter.API.DTO;

public class TypeVehiclePostDTO
{
    public int VehicleId { get; set; }
    public int TypeId { get; set; }
}
public class CategoryFilterDeleteDTO : TypeVehiclePostDTO
{
}