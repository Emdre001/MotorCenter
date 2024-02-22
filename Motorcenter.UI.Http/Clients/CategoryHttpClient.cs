namespace Motorcenter.UI.Http.Clients;

public class CategoryHttpClient
{
    private readonly HttpClient _httpClient;
    string _BaseAddress = "https://localhost:7054/api/";

    public CategoryHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri($"{_BaseAddress}");
    }

}
