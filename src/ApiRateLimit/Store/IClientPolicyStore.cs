using System.Threading.Tasks;
using ApiRateLimit.Models;

namespace ApiRateLimit.Store
{
    public interface IClientPolicyStore : IRateLimitStore<ClientRateLimitPolicy>
    {
        Task SeedAsync();
    }
}