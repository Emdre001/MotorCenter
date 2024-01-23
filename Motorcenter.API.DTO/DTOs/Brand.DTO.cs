using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;

public class BrandPostDTO
{
    public string Name { get; set; } = string.Empty;
}
public class BrandPutDTO : BrandPostDTO
{
    public int Id { get; set; }
}
public class BrandGetDTO : BrandPutDTO
{
    public List<VehicleGetDTO>? Vehicles { get; set; }
}



