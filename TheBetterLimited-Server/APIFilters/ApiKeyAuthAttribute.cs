/**
 * This class is used to auth the API key sent by user 
 * Link: https://www.youtube.com/watch?v=Zo3T_See7iI&t=10s
 *
 */


using System;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TheBetterLimited_Server.Helper;

namespace TheBetterLimited_Server.APIFilters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ApiKeyAuthAttribute : Attribute, IAsyncActionFilter
    {

        private const string ApiKeyHeaderName = "Auth";


        

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var req = context.HttpContext.Request;
            // the context is null
            if (!context.HttpContext.Request.Headers.TryGetValue(ApiKeyHeaderName, out var potentialApiKey))
            {
                Helper.Logger.FileLogger.InvalidAcceccLog(
                    context.HttpContext.Connection.RemoteIpAddress.ToString() + ":" + context.HttpContext.Connection.RemotePort.ToString(),
                    Helper.HttpReader.GetURL(req) ,
                    Helper.HttpReader.GetHeaderString(req)

                   );
                context.Result = new UnauthorizedResult();
            }
            else
            {
                // get API key from the config file
                var config = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
                var ApiKey = config.GetValue<string>("ApiKey");

                if (!ApiKey.Equals(potentialApiKey))
                {

                    context.Result = new UnauthorizedResult();
                }
            }

            

        }
    }


}

//Helper.Logger.FileLogger.InvalidAcceccLog(
//    context.HttpContext.Connection.RemoteIpAddress.ToString() + context.HttpContext.Connection.RemotePort.ToString(),
//    context.HttpContext.Request.Path.ToString(),
//    "DSFD"
//    );