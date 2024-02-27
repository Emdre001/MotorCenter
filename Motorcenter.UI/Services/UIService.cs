



namespace Motorcenter.UI.Services;

public class UIService(CategoryHttpClient categoryHttp)
{
   List<TypeGetDTO> TypeVehicle { get; set; } = [];
    public List<LinkGroup> TypeLinkGroups { get; private set; } =
    [
        new LinkGroup { Name ="Categories",

           LinkOption = new()
           {
                 new LinkOption { Id  = 1, Name = "Car", IsSelected = true },
                 new LinkOption { Id = 2, Name = "Motorcycle", IsSelected = false },

           }
        }
    ];

    public int CurrentTypeId { get; set; }
}




