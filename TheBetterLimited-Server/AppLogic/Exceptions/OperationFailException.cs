using System.Net;
using Newtonsoft.Json.Linq;

namespace TheBetterLimited_Server.AppLogic.Exceptions;

public class OperationFailException : ICustException
{
    public OperationFailException(string msg) : base(msg,HttpStatusCode.InternalServerError)
    {
    }
    
    public override JObject GetHttpResult()
    {
        return IExceptionHttpResponseBuilder.Create(ReturnCode, this.Message);
    }
}