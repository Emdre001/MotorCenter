using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;

public class VehicleColorPostDTO
{
    public int ColorId { get; set; }
    public int BrandId { get; set; }
}
public class VehicleColorPutDTO : VehicleColorPostDTO
{

}
public class VehicleColorGetDTO : VehicleColorPostDTO
{
}

