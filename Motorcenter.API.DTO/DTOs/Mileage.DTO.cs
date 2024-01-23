using Motorcenter.Data.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;
public class MileagePostDTO
{
    public string Name { get; set; } = string.Empty;
    public string Range { get; set; }
    public OptionType OptionType { get; set; }
}

public class MileagePutDTO : MileagePostDTO
{
    public int Id { get; set; }
}

public class MileageGetDTO : MileagePutDTO
{

}


