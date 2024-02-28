﻿


namespace eShop.UI.Http.Clients;

public class CategoryHttpClient
{
    private readonly HttpClient _httpClient;
    string _baseAddress = "https://localhost:7054/api/";

    public CategoryHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri($"{_baseAddress}categorys");
    }

    public async Task<List<TypeGetDTO>> GetTypeAsync()
    {
        try
        {
            using HttpResponseMessage response = await _httpClient.GetAsync("");
            response.EnsureSuccessStatusCode();
            var result = JsonSerializer.Deserialize<List<TypeGetDTO>>(await response.Content.ReadAsStreamAsync(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
           return result ?? [];
        }
        catch (Exception ex)
        {

            return[];
        }
    }
}