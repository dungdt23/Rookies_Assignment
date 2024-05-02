using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AssignmentDay3
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MyCustomMiddleware
    {
        private readonly RequestDelegate _next;

        public MyCustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext, IMessageWriter messageWriter)
        {
            messageWriter.Write("Date Time: " + DateTime.Now.ToString());
            messageWriter.Write("Scheme: " + httpContext.Request.Scheme);
            messageWriter.Write("Host: " + httpContext.Request.Host.ToString());
            messageWriter.Write("Path: " + httpContext.Request.Path);
            messageWriter.Write("Request Header: " + httpContext.Request.Headers);
            messageWriter.Write("Query String: " + httpContext.Request.QueryString.ToString());
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MyCustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyCustomMiddleware>();
        }
    }
}
