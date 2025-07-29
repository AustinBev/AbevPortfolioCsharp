using AbevPortfolioCsharp.Models;

namespace AbevPortfolioCsharp.Services
{
    public interface IContactService
    {
        Task<bool> SendAsync(MinimalContactRequest req, CancellationToken ct = default);
    }
}
