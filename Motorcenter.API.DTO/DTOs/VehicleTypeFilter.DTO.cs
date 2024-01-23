using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;

public class VehicleTypeFilterPostDTO
{
    public int FilterId { get; set; }
    public int VehicleId { get; set; }
}
public class  VehicleTypeFilterPutDTO : VehicleTypePostDTO
{
}
public class VehicleTypeFilterGetDTO : VehicleTypePostDTO
{
}


