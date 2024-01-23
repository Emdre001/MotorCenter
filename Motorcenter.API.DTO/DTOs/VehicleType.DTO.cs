using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;
public class VehicleTypePostDTO
{
    public int BrandId { get; set; }
    public int VehicleId { get; set; }
}
public class VehicleTypePutDTO : VehicleTypePostDTO
{
}
public class VehicleTypeGetDTO : VehicleTypePostDTO
{
}



