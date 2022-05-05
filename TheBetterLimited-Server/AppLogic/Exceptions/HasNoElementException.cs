namespace TheBetterLimited_Server.AppLogic.Exceptions;

public class HasNoElementException : Exception
{
    public HasNoElementException(string msg) : base(msg)
    {
    }
    
    public HasNoElementException() : base()
    {
    }
}