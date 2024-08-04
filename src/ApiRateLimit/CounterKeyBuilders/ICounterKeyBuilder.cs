using ApiRateLimit.Models;

namespace ApiRateLimit.CounterKeyBuilders
{
    public interface ICounterKeyBuilder
    {
        string Build(ClientRequestIdentity requestIdentity, RateLimitRule rule);
    }
}