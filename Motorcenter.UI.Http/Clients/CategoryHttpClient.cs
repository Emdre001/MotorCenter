using System.Text.Json;

namespace Motorcenter.UI.Http.Client;

public class CategoryHttpClient
{

    public HttpClient Client { get; }
    string BaseAddress = "https://localhost:7054/api/";


    public CategoryHttpClient(HttpClient httpClient)
    {
        Client = httpClient;
        Client.BaseAddress = new Uri($"{BaseAddress} categorys");

    }






}
