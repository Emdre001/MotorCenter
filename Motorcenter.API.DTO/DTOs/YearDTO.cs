using Motorcenter.Data.Entities;
using Motorcenter.Data.Shared.Interfaces;

namespace Motorcenter.API.DTO;



public class YearPostDTO
{
    public string name { get; set; } = string.Empty;
}

public class YearPutDTO : YearPostDTO
{
    public int id { get; set; }
}

public class YearGetDTO : YearPutDTO
{
    public OptionType? OptionType { get; set; }
    public List<Vehicle> Vehicles { get; } = [];

}

public class YearSmallGetDTO : YearPutDTO
{

}



