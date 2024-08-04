using System.Collections.Generic;

namespace ApiRateLimit.Models
{
    public class RateLimitPolicy
    {
        public List<RateLimitRule> Rules { get; set; } = new List<RateLimitRule>();
    }
}
