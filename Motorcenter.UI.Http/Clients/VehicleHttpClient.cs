



using Motorcenter.API.DTO;

namespace eShop.UI.Http.Clients;

public class VehicleHttpClient
{
    private readonly HttpClient _httpClient;
    string _baseAddress = "https://localhost:7222/api/";
  
    public VehicleHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri($"{_baseAddress}Vehicles");
    }

    public async Task<List<VehicleGetDTO>> GetVehiclesAsync(int TypeId)
    {
        try
        {
            // Use the relative path, not the base address here
            string relativePath = $"VehiclesbyType/{TypeId}";
            using HttpResponseMessage response = await _httpClient.GetAsync(relativePath);
            response.EnsureSuccessStatusCode();

            var resultStream = await response.Content.ReadAsStreamAsync();
            var result = await JsonSerializer.DeserializeAsync<List<VehicleGetDTO>>(resultStream,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result ?? [];
        }
        catch (Exception ex)
        {
            return [];
        }


    }
}