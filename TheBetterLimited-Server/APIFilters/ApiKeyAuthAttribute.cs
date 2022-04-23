﻿/**
 * This class is used to auth the API key sent by user 
 * Link: https://www.youtube.com/watch?v=Zo3T_See7iI&t=10s
 *
 */


using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TheBetterLimited_Server.APIFilters
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Method)]
    public class ApiKeyAuthAttribute : Attribute, IAsyncActionFilter
    {

        private const string ApiKeyHeaderName = "Auth";


        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.HttpContext.Request.Headers.TryGetValue(ApiKeyHeaderName, out var potentialApiKey))
            {
                context.Result = new UnauthorizedResult();
            }

            var config = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
            var ApiKey = config.GetValue<string>("ApiKey");

            if (!ApiKey.Equals(potentialApiKey))
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }


}

