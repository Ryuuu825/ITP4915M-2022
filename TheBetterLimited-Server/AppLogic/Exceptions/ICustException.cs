
namespace TheBetterLimited_Server.AppLogic.Exceptions;

using System.Net;
using Newtonsoft.Json.Linq;

public abstract class ICustException : Exception
{
     public int ReturnCode;

     public ICustException(string msg, HttpStatusCode code) : base(msg)
     {
          this.ReturnCode = (int) code;
     }
     abstract public JObject GetHttpResult();
}