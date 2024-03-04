

namespace Motorcenter.API.DTO;

public class YearPostDTO
{
    public string Name { get; set; }
    public OptionType OptionType { get; set; }
}
public class YearPutDTO : YearPostDTO
{
    public int Id { get; set; }
}
public class YearGetDTO : YearPutDTO
{
    public bool IsSelected { get; set; }
}