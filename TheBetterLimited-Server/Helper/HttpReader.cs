using System;
using System.Text;

namespace TheBetterLimited_Server.Helper
{
	public static class HttpReader
	{

        public static string GetHeaderString(HttpRequest req)
        {
            StringBuilder sbHeaders = new StringBuilder();
            foreach (var header in req.Headers)
                sbHeaders.Append($"{header.Key}: {header.Value}\n");

            return sbHeaders.ToString();
        }

        public static string GetURL(HttpRequest req , bool withMethod = false)
        {
            if (withMethod)
                return $"{req.Protocol} {req.Method} {req.Scheme}://{req.Host}{req.Path}{req.QueryString.Value}";
            else
                return $"{req.Scheme}://{req.Host}{req.Path}{req.QueryString.Value}";
        }

    }
}

