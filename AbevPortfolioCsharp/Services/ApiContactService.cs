using System.Net.Http.Json;
using AbevPortfolioCsharp.Models;

namespace AbevPortfolioCsharp.Services
{
    public class ApiContactService : IContactService
    {
        private readonly HttpClient _http;
#if DEBUG
        private const string BackendBase = "http://localhost:7071";
#else
  private const string BackendBase = "https://AbevPortfolioAzureFunction.azurewebsites.net";
#endif
        public ApiContactService(HttpClient http) => _http = http;

        public async Task<bool> SendAsync(MinimalContactRequest req, CancellationToken ct = default)
        {
            var resp = await _http.PostAsJsonAsync($"{BackendBase}/api/contact", req, ct);
            return resp.IsSuccessStatusCode;
        }
    }
}
