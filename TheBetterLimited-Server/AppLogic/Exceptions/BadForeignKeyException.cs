namespace TheBetterLimited_Server.AppLogic.Exceptions
{
    public class BadForeignKeyException : BadArgException
    {
        public BadForeignKeyException(string msg ):base(msg)
        {
        }

        public override JObject GetHttpResult()
        {
            return IExceptionHttpResponseBuilder.Create( ReturnCode, this.Message);
        }
    }
}