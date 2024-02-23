namespace Motorcenter.API.DTO;

public class TypePostDTO
{
    public string name { get; set; } = string.Empty;
}

public class TypePutDTO : TypePostDTO
{
    public int Id { get; set; }
}

public class TypeGetDTO : TypePutDTO
{
     public List<FilterGetDTO>? Filters { get; set; }
}

public class TypeSmallGetDTO : TypePutDTO
{

}


