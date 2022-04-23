using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using TheBetterLimited_Server.Helper;


namespace TheBetterLimited_Server.APIFilters
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class LoggerAttribute : Attribute, IAsyncActionFilter
	{
		public async Task OnActionExecutionAsync(ActionExecutingContext actionContext , ActionExecutionDelegate next)
		{
			actionContext.HttpContext.Request.Headers.TryGetValue("User", out var user);
			Helper.Logger.FileLogger.AcceccLog(user, actionContext.HttpContext.Request.Path.ToString());
		}
	}
}

