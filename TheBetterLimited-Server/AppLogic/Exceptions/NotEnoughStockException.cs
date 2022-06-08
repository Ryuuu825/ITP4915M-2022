namespace TheBetterLimited_Server.AppLogic.Exceptions
{
    public class NotEnoughStockException : BadArgException
    {
        public NotEnoughStockException() : base("Stock is not enough for sale")
        {
        }

        public override JObject GetHttpResult()
        {
            return IExceptionHttpResponseBuilder.Create(ReturnCode, this.Message);
        }
    }
}