using ApplicationContractingBlazorApp.Models;
using System.Runtime.CompilerServices;

namespace ApplicationContractingBlazorApp.Services;

public class ApplicationContractingApiService(HttpClient httpClient)
{
    private HttpClient _httpClient { get; set; } = httpClient;

    public async void SubmitApplication(ApplicationSubmissionRequest request)
    {
        // TODO: move url to config and implement authentication.
        await _httpClient.PostAsJsonAsync("https://localhost:7195", request);
    }
}
