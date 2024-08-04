using ApiRateLimit.Models;

namespace ApiRateLimit.CounterKeyBuilders
{
    public class PathCounterKeyBuilder : ICounterKeyBuilder
    {
        public string Build(ClientRequestIdentity requestIdentity, RateLimitRule rule)
        {
            return $"_{requestIdentity.HttpVerb}_{requestIdentity.Path}";
        }
    }
}
