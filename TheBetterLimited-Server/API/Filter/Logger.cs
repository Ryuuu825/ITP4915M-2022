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
            throw new NotImplementedException();
        await next();
    }

    public async Task OnActionExecutionAsync(ActionExecutingContext actionContext, ActionExecutionDelegate next)
    {
        if (actionContext.HttpContext.Request.Headers.TryGetValue("User", out var user))
        {
            FileLogger.AcceccLog(user, actionContext.HttpContext.Request.Path.ToString());
        }
        else
        {
            FileLogger.InvalidAcceccLog(
                HttpReader.GetClientSocket(actionContext.HttpContext),
                HttpReader.GetURL(actionContext.HttpContext.Request),
                HttpReader.GetHeaderString(actionContext.HttpContext.Request)
            );
            actionContext.Result = new UnauthorizedResult();
        }
    }
}