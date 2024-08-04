using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ApiRateLimit.Resolvers
{
    public interface IClientResolveContributor
    {
        Task<string> ResolveClientAsync(HttpContext httpContext);
    }
}
