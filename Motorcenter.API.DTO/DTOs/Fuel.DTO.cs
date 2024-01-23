using Motorcenter.API.DTO.DTOs;
using Motorcenter.Data.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;

public class FuelPostDTO
{
    public string Name { get; set; } = string.Empty;
    public string TypeName { get; set; } = string.Empty;
    public OptionType OptionType { get; set; }
}

public class FuelPutDTO : FilterPostDTO
{
    public int Id { get; set; }
}

public class FuelGetDTO : FilterPutDTO
{
  
}


