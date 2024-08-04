using System.Linq;
using System.Net;
using ApiRateLimit.Net;
using Microsoft.AspNetCore.Http;

namespace ApiRateLimit.Resolvers
{
    public class IpHeaderResolveContributor : IIpResolveContributor
    {
        private readonly string _headerName;

        public IpHeaderResolveContributor(
            string headerName)
        {
            _headerName = headerName;
        }

        public string ResolveIp(HttpContext httpContext)
        {
            IPAddress clientIp = null;

            if (httpContext.Request.Headers.TryGetValue(_headerName, out var values))
            {
                clientIp = IpAddressUtil.ParseIp(values.Last());
            }

            return clientIp?.ToString();
        }
    }
}