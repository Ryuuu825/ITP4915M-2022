using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using TheBetterLimited_Server.Helper;


namespace TheBetterLimited_Server.APIFilters
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class LogAccessAttribute : Attribute, IAsyncActionFilter
	{
		public async Task OnActionExecutionAsync(ActionExecutingContext actionContext , ActionExecutionDelegate next)
		{
			if (actionContext.HttpContext.Request.Headers.TryGetValue("User", out var user))
				Helper.Logger.FileLogger.AcceccLog(user, actionContext.HttpContext.Request.Path.ToString());
            else
            {
                Helper.Logger.FileLogger.InvalidAcceccLog(
                    Helper.HttpReader.GetClientSocket(actionContext.HttpContext),
                    Helper.HttpReader.GetURL(actionContext.HttpContext.Request),
                    Helper.HttpReader.GetHeaderString(actionContext.HttpContext.Request)
                    );
                actionContext.Result = new UnauthorizedResult();
            }
		}
	}
}

