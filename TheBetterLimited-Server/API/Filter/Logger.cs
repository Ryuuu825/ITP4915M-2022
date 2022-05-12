using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TheBetterLimited_Server.Helpers;
using TheBetterLimited_Server.Helpers.LogHelper;

namespace TheBetterLimited_Server.API.Filters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class LogAccessAttribute : Attribute, IAsyncResultFilter
{
    public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
    {
        if (context.HttpContext.Response.StatusCode == (int) HttpStatusCode.Unauthorized)
            FileLogger.InvalidAcceccLog(
                HttpReader.GetClientSocket(context.HttpContext),
                HttpReader.GetURL(context.HttpContext.Request),
                HttpReader.GetHeaderString(context.HttpContext.Request)
            );
        await next();
    }

}