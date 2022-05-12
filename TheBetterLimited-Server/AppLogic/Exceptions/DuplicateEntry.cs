using System.Net;
using Newtonsoft.Json.Linq;

namespace TheBetterLimited_Server.AppLogic.Exceptions;

public class DuplicateEntryException :  ICustException
{
    public DuplicateEntryException(string msg) : base(msg, HttpStatusCode.BadRequest)
    {
    }
    
    public override JObject GetHttpResult()
    {
        return IExceptionHttpResponseBuilder.Create(ReturnCode, this.Message);
    }
}