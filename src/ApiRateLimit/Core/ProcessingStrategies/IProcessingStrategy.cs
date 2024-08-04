using System.Threading;
using System.Threading.Tasks;
using ApiRateLimit.CounterKeyBuilders;
using ApiRateLimit.Models;

namespace ApiRateLimit.Core.ProcessingStrategies
{
    public interface IProcessingStrategy
    {
        Task<RateLimitCounter> ProcessRequestAsync(ClientRequestIdentity requestIdentity, RateLimitRule rule, ICounterKeyBuilder counterKeyBuilder, RateLimitOptions rateLimitOptions, CancellationToken cancellationToken = default);
    }
}