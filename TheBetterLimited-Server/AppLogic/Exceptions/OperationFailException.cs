using System;
namespace TheBetterLimited_Server.AppLogic.Exceptions
{
	public class OperationFailException : Exception
	{
		public OperationFailException(String msg) : base(msg) { }
		
	}
}

