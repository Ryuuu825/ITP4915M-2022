using System;
namespace TheBetterLimited_Server.AppLogic.Model
{
	public class Accout
	{
		public String Password { get; set; }

		public String Username { get; set; }


		public bool verify(String password)
		{
			return Password.Equals(password);
		}

		public static bool verify(String username, String PasswordEntered)
        {
			return true;
        }

	}
}

