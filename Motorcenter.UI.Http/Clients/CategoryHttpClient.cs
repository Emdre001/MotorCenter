global using System.Text.Json;
global using System.Net.Http;

namespace Motorcenter.UI.Http.Clients;

public class CategoryHttpClient
{

    public HttpClient Client { get; }
    string BaseAddress = "https://localhost:7054/api/";


    public CategoryHttpClient(HttpClient _httpClient)
    {
        Client = _httpClient;
        Client.BaseAddress = new Uri($"{BaseAddress} categorys");

    }

  /*  public async Task<List<TypeGetDTO>> GetCategoriesAsync()
    {
        try
        {
            using HttpResponseMessage response = await Client.GetAsync("");
            response.EnsureSuccessStatusCode();

            var result = JsonSerializer.Deserialize<List<TypeGetDTO>>(await response.Content.ReadAsStreamAsync(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result ?? [];
        }
        catch (Exception ex)
        {
            return [];
        }
    }

    */




}
