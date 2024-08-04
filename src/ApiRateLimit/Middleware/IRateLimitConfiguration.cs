using System;
using System.Collections.Generic;
using ApiRateLimit.CounterKeyBuilders;
using ApiRateLimit.Resolvers;

namespace ApiRateLimit.Middleware
{
    public interface IRateLimitConfiguration
    {
        IList<IClientResolveContributor> ClientResolvers { get; }

        IList<IIpResolveContributor> IpResolvers { get; }

        ICounterKeyBuilder EndpointCounterKeyBuilder { get; }

        Func<double> RateIncrementer { get; }

        void RegisterResolvers();
    }
}