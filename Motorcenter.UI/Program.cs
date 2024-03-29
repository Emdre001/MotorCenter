using Blazored.LocalStorage;
using Motorcenter.UI.Storage.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<UIService>();
builder.Services.AddBlazoredLocalStorageAsSingleton();
//builder.Services.AddBlazoredSessionStorageAsSingleton();
builder.Services.AddSingleton<IStorageService, LocalStorage>();
builder.Services.AddHttpClient<TypeHttpClient>();
builder.Services.AddHttpClient<VehicleHttpClient>();
ConfigureAutoMapper();

await builder.Build().RunAsync();

void ConfigureAutoMapper()
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<TypeGetDTO,LinkOption>().ReverseMap();
        cfg.CreateMap<VehicleGetDTO, CartItemDTO>().ReverseMap();


    });
    var mapper = config.CreateMapper();
    builder.Services.AddSingleton(mapper);
}
