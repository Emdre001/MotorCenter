using Motorcenter.Data.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;

public class VehiclePostDTO
{
   
    public string Name { get; set; }
   
}

public class VehiclePutDTO : VehiclePostDTO
{
    public int Id { get; set; }
}

public class VehicleGetDTO : VehiclePutDTO
{

}
