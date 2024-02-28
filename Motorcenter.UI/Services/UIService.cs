



using AutoMapper;
using Motorcenter.Data.Entities;

namespace Motorcenter.UI.Services;

public class UIService(CategoryHttpClient categoryHttp, VehicleHttpClient vehicleHttp ,IMapper mapper)
{
   List<TypeGetDTO> TypeVehicle { get; set; } = [];

    public List<VehicleGetDTO> Vehicles { get; private set; } = [];
    public List<LinkGroup> TypeLinkGroups { get; private set; } =
    [
        new LinkGroup { Name ="Categories",

          /* LinkOption = new()
           {
                 new LinkOption { Id  = 1, Name = "Car", IsSelected = true },
                 new LinkOption { Id = 2, Name = "Motorcycle", IsSelected = false },

           }*/
        }
    ];

    public int CurrentTypeId { get; set; }


    public async Task GetLinkGroup()
    {
        TypeVehicle = await categoryHttp.GetTypeAsync();
        TypeLinkGroups[0].LinkOption = mapper.Map<List<LinkOption>>(TypeVehicle);
        var linkOption = TypeLinkGroups[0].LinkOption.FirstOrDefault();
        
        linkOption!.IsSelected = true;

    }

    public async Task OnTypeLinkClick(int id)
    {
        CurrentTypeId = id;
        await GetTypeAsync();
        TypeLinkGroups[0].LinkOption.ForEach(l => l.IsSelected = false);
        TypeLinkGroups[0].LinkOption.Single(l => l.Id.Equals(CurrentTypeId)).IsSelected = true;

    }

    public async Task GetTypeAsync() =>
        Vehicles = await vehicleHttp.GetVehiclesAsync(CurrentTypeId);

}





