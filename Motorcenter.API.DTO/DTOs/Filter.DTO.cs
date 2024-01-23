using Motorcenter.Data.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;

public class FilterPostDTO
{
    public string Name { get; set; } = string.Empty;
    public string TypeName { get; set; } = string.Empty; 
    public OptionType OptionType { get; set; }
}

public class FilterPutDTO : FilterPostDTO
{
    public int Id { get; set; }
}

public class FilterGetDTO : FilterPutDTO
{

}
    

