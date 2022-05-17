using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TheBetterLimited_Server.Helpers;
using TheBetterLimited_Server.Helpers.LogHelper;

namespace TheBetterLimited_Server.API.Filters;
public class LogAccessAuthAttribute : Attribute , IAuthorizationFilter 
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        ConsoleLogger.Debug("S");
    }
}