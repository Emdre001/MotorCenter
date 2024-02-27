



using Motorcenter.API.DTO;

namespace Motorcenter.UI.Services;

public class UIService(CategoryHttpClient categoryHttp)
{


    List<TypeGetDTO> TypeVehicle { get; set; } = [];
}

