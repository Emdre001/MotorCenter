namespace Motorcenter.API.DTO;

public class VehicleColorPostDTO
{
    public int VehicleId { get; set; }
    public int ColorId { get; set; }
}

public class VehicleColorDeleteDTO : VehicleColorPostDTO
{

}
