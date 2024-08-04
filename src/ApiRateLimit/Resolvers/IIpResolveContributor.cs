using Microsoft.AspNetCore.Http;

namespace ApiRateLimit.Resolvers
{
    public interface IIpResolveContributor
    {
        string ResolveIp(HttpContext httpContext);
    }
}