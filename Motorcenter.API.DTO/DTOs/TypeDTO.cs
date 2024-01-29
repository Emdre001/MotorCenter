namespace Motorcenter.API.DTO;
// DTO-klass för att överföra data om kopplingen mellan VehicleType, Brand och Vehicle
public class TypePostDTO
{
    public string name { get; set; } = string.Empty;
}

public class TypePutDTO : TypePostDTO
{
    public int id { get; set; }
}

public class TypeGetDTO : TypePutDTO
{
    // public List<FilterGetDTO>? Filters { get; set; }
}

public class TypeSmallGetDTO : TypePutDTO
{

}


