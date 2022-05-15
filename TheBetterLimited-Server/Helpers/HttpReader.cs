namespace TheBetterLimited_Server.Helpers;
using TheBetterLimited_Server.Helpers.LogHelper;

using System.Collections;
public static class HttpReader
{
    public static string GetClientSocket(HttpContext context)
    {
        return $"{context.Connection.RemoteIpAddress}:{context.Connection.RemotePort.ToString()}";
    }

    public static string GetHeaderString(HttpRequest req)
    {
        var sbHeaders = new StringBuilder();
        foreach (var header in req.Headers)
            sbHeaders.Append($"{header.Key}: {header.Value}\n");

        return sbHeaders.ToString();
    }



    public static string GetURL(HttpRequest req, bool withMethod = false)
    {
        if (withMethod)
            return $"{req.Protocol} {req.Method} {req.Scheme}://{req.Host}{req.Path}{req.QueryString.Value}";
        return $"{req.Scheme}://{req.Host}{req.Path}{req.QueryString.Value}";
    }

    public static Hashtable GetClaims(HttpRequest req)
    {
        var principal = Helpers.Secure.JwtToken.ReadToken(req.Headers["Authorization"].ToString().Split(' ')[1]);
        var claims = principal.Claims;
        var s = new Hashtable();
        foreach (var c in claims)
        {
            s.Add(c.Type.Split('/')[c.Type.Split('/').Length - 1] , c.Value);
        }
        
        return s;
    }
}