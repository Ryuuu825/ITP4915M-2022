using System.Net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace TheBetterLimited_Server.AppLogic.Exceptions;


public class BadArgException : ICustException
{
    public BadArgException(string msg ):base(msg, HttpStatusCode.BadRequest)
    {
    }

    public override JObject GetHttpResult()
    {
        return IExceptionHttpResponseBuilder.Create( ReturnCode, this.Message);
    }
    



}