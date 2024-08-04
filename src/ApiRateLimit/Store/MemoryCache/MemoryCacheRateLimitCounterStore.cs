using ApiRateLimit.Models;
using Microsoft.Extensions.Caching.Memory;

namespace ApiRateLimit.Store.MemoryCache
{
    public class MemoryCacheRateLimitCounterStore : MemoryCacheRateLimitStore<RateLimitCounter?>, IRateLimitCounterStore
    {
        public MemoryCacheRateLimitCounterStore(IMemoryCache cache) : base(cache)
        {
        }
    }
}