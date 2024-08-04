using ApiRateLimit.Models;
using ApiRateLimit.Store;

namespace ApiRateLimit
{
    public interface IRateLimitCounterStore : IRateLimitStore<RateLimitCounter?>
    {
    }
}