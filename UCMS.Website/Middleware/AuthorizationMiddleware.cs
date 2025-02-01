using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace UCMS.Website.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AuthorizationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthorizationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var endpoint = context.GetEndpoint();
            if (endpoint != null)
            {
                var requiredRole = endpoint.Metadata.GetMetadata<AuthorizeAttribute>()?.Role;
                var userRole = context.Session.GetInt32("Role").ToString();
                if (!string.IsNullOrEmpty(requiredRole) && userRole != requiredRole)
                {
                    context.Response.StatusCode = 403;
                    await context.Response.WriteAsync("Access Denied");
                    return;
                }
            }
            await _next(context);
        }
    }

    public class AuthorizeAttribute : Attribute
    {
        public string Role { get; }

        public AuthorizeAttribute(string role)
        {
            Role = role;
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AuthorizationMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthorizationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthorizationMiddleware>();
        }
    }
}
