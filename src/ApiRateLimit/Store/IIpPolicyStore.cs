using System.Threading.Tasks;
using ApiRateLimit.Models;

namespace ApiRateLimit.Store
{
    public interface IIpPolicyStore : IRateLimitStore<IpRateLimitPolicies>
    {
        Task SeedAsync();
    }
}