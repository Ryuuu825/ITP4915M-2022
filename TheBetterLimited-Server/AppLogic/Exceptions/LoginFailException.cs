namespace TheBetterLimited_Server.AppLogic.Exceptions;
using Newtonsoft.Json.Linq;

public class LoginFailException : ICustException
{
    public LoginFailException(string msg) : base(msg, HttpStatusCode.Unauthorized)
    {
    }
    public override JObject GetHttpResult()
    {
        return IExceptionHttpResponseBuilder.Create(ReturnCode, this.Message);
    }
}