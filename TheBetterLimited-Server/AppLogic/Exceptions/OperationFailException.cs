namespace TheBetterLimited_Server.AppLogic.Exceptions;

public class OperationFailException : Exception
{
    public OperationFailException(string msg) : base(msg)
    {
    }
}