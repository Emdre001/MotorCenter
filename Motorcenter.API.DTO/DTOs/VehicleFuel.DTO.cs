using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;

public class VehicleFuelPostDTO
{
    public int FuelId { get; set; }
    public int VehicleId { get; set; }
}
public class VehicleFuelPutDTO : VehicleFuelPostDTO
{

}
public class VehicleFuelGetDTO : VehicleFuelPostDTO
{
}



