using System;
using Microsoft.EntityFrameworkCore;

namespace TheBetterLimited_Server.AppLogic.Controller
{
	public class LoginController
	{

		public LoginController()
		{
		}

		public static bool Login(String name, String password)
		{
			return true;
		}

		public static void ForgetPW()
		{ }

		public static void ForgetPW(String username , String email)
		{ }

		public static void ChangePW(String usernmae, String oldPW , String newPW)
		{ }

	}
}

