using System.Net;
using System.Security.Principal;
using MimeKit;
using Newtonsoft.Json.Linq;

namespace TheBetterLimited_Server.AppLogic.Exceptions;

using System.Web;
public abstract class ICustException : Exception
{
     public int ReturnCode;

     public ICustException(string msg, HttpStatusCode code) : base(msg)
     {
          this.ReturnCode = (int) code;
     }
     abstract public JObject GetHttpResult();
}