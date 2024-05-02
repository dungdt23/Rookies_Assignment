using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay3
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MyCustomMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment _webEnvironment;

        public MyCustomMiddleware(RequestDelegate next, IWebHostEnvironment webEnvironment)
        {
            _next = next;
            _webEnvironment = webEnvironment;
        }

        public async Task InvokeAsync(HttpContext httpContext, IMessageWriter messageWriter)
        {
            string directoryPath = _webEnvironment.ContentRootPath;
            string schema = httpContext.Request.Scheme;
            string host = httpContext.Request.Host.ToString();
            string path = httpContext.Request.Path;
            string queryString = httpContext.Request.QueryString.ToString();
            string requestBody = await ReadRequestBody(httpContext.Request);

            string logMessage = $"{DateTime.Now}: Schema={schema}, Host={host}, Path={path}, QueryString={queryString}, RequestBody={requestBody}\n";
            //write into log file
            messageWriter.WriteLog(logMessage, directoryPath);
            //log in ouput
            messageWriter.Log(logMessage);
            await _next(httpContext);
        }
        private async Task<string> ReadRequestBody(HttpRequest request)
        {
            using (StreamReader reader = new StreamReader(request.Body, Encoding.UTF8, true, 1024, true))
            {
                string body = await reader.ReadToEndAsync();
                return body;
            }
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
