namespace TheBetterLimited_Server.AppLogic.Exceptions;

public class DuplicateEntryException : Exception
{
    public DuplicateEntryException(string msg) : base(msg)
    {
    }
}