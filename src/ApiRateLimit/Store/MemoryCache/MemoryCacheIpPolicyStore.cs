﻿using System.Threading.Tasks;
using ApiRateLimit.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

namespace ApiRateLimit.Store.MemoryCache
{
    public class MemoryCacheIpPolicyStore : MemoryCacheRateLimitStore<IpRateLimitPolicies>, IIpPolicyStore
    {
        private readonly IpRateLimitOptions _options;
        private readonly IpRateLimitPolicies _policies;

        public MemoryCacheIpPolicyStore(
            IMemoryCache cache,
            IOptions<IpRateLimitOptions> options = null,
            IOptions<IpRateLimitPolicies> policies = null) : base(cache)
        {
            _options = options?.Value;
            _policies = policies?.Value;
        }

        public async Task SeedAsync()
        {
            // on startup, save the IP rules defined in appsettings
            if (_options != null && _policies != null)
            {
                await SetAsync($"{_options.IpPolicyPrefix}", _policies).ConfigureAwait(false);
            }
        }
    }
}