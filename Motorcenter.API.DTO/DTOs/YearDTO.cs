
namespace Motorcenter.API.DTO;

public class YearPostDTO
{
    public string Name { get; set; } = string.Empty;
}

public class YearPutDTO : YearPostDTO
{
    public int Id { get; set; }
}

public class YearGetDTO : YearPutDTO
{
    public OptionType? OptionType { get; set; }
    public List<Vehicle> Vehicles { get; } = [];

}

public class YearSmallGetDTO : YearPutDTO
{

}



