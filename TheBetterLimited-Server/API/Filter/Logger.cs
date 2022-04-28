using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using TheBetterLimited_Server.Helpers;


namespace TheBetterLimited_Server.API.Filters
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class LogAccessAttribute : Attribute, IAsyncActionFilter
	{
		public async Task OnActionExecutionAsync(ActionExecutingContext actionContext , ActionExecutionDelegate next)
		{
			if (actionContext.HttpContext.Request.Headers.TryGetValue("User", out var user))
				Helpers.LogHelper.FileLogger.AcceccLog(user, actionContext.HttpContext.Request.Path.ToString());
            else
            {
                Helpers.LogHelper.FileLogger.InvalidAcceccLog(
                    Helpers.HttpReader.GetClientSocket(actionContext.HttpContext),
                    Helpers.HttpReader.GetURL(actionContext.HttpContext.Request),
                    Helpers.HttpReader.GetHeaderString(actionContext.HttpContext.Request)
                    );
                actionContext.Result = new UnauthorizedResult();
            }
		}
	}
}

