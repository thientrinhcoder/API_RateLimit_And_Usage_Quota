using ApiRateLimit.Models;
using Microsoft.Extensions.Caching.Distributed;

namespace ApiRateLimit.Store.DistributedCache
{
    public class DistributedCacheRateLimitCounterStore : DistributedCacheRateLimitStore<RateLimitCounter?>, IRateLimitCounterStore
    {
        public DistributedCacheRateLimitCounterStore(IDistributedCache cache) : base(cache)
        {
        }
    }
}