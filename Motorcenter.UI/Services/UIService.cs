using Motorcenter.UI.Storage.Services;

namespace Motorcenter.UI.Services;

public class UIService(TypeHttpClient categoryHttp, 
    VehicleHttpClient vehicleHttp ,IMapper mapper, IStorageService storage)
{
   List<TypeGetDTO> TypeVehicle { get; set; } = [];
    public List<VehicleGetDTO> Vehicles { get; private set; } = [];
    public List<CartItemDTO > CartItems { get; set; } = [];
    public List<LinkGroup> TypeLinkGroups { get; private set; } =
    [
        new LinkGroup { Name ="Categories",

          
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
        Vehicles.ForEach(v =>  v.Colors!.First().IsSelected = true);
        TypeLinkGroups[0].LinkOption.ForEach(l => l.IsSelected = false);
        TypeLinkGroups[0].LinkOption.Single(l => l.Id.Equals(CurrentTypeId)).IsSelected = true;

    }

    public async Task GetTypeAsync() =>
        Vehicles = await vehicleHttp.GetVehiclesAsync(CurrentTypeId);

    public async Task<T> ReadStorage<T>(string key)// where T : class
    {
       
        return await storage.GetAsync<T>(key);
    }
    public async Task<T> ReadSingleStorage<T>(string key)// where T : class
    {    
        return await storage.GetAsync<T>(key);
    }

    public async Task SaveToStorage<T>(string key, T value)// where T : class
    {
        if (string.IsNullOrEmpty(key) || storage is null) return;
        await storage.SetAsync<T>(key, value);
    }
    public async Task RemoveFromStorage(string key)// where T : class
    {
        if (string.IsNullOrEmpty(key) || storage is null) return;
        await storage.RemoveAsync(key);
    }


}





