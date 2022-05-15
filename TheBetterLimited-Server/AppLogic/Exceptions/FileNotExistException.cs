namespace TheBetterLimited_Server.AppLogic.Exceptions
{
    public class FileNotExistException : ICustException
    {
        public FileNotExistException(string msg, HttpStatusCode code) : base(msg, code )
        {
        }
    
        public override JObject GetHttpResult()
        {
            return IExceptionHttpResponseBuilder.Create(ReturnCode,  this.Message);
        }
    }
}