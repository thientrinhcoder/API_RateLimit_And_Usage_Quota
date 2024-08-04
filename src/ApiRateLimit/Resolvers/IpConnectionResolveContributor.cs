using Microsoft.AspNetCore.Http;

namespace ApiRateLimit.Resolvers
{
    public class IpConnectionResolveContributor : IIpResolveContributor
    {

        public IpConnectionResolveContributor()
        {

        }

        public string ResolveIp(HttpContext httpContext)
        {
            return httpContext.Connection.RemoteIpAddress?.ToString();
        }
    }
}