using System;
using System.Reflection;
using System.Text;

namespace TheBetterLimited_Server.Helpers.Sql
{
	public static class QueryStringBuilder
	{

		public static void Create(Object data , string queryString)
        {

			StringBuilder builder = new StringBuilder(
				"SELECT @ATTRIBUTE FROM @TABLE WHERE @CONDITION;"
			);
			StringBuilder condBuilder = new StringBuilder();
			Type type = data.GetType();



			MemberInfo[] infos = type.GetProperties();
			for (int i = 0; i < infos.Length; i++)
			{

				// Display name and type of the member of 'MyClass'.
				Console.WriteLine("'{0}' is a {1}", infos[i].Name, infos[i].MemberType);
			}

			builder.Replace("@TABLE", type.Name);
			builder.Replace("@ATTRIBUTE", "*");
			Console.WriteLine(builder.ToString());
		}

		public static void Create(string table , string queryString)
        {
			String[] argv = queryString.Split(";");
			for (int i = 0; i < argv.Length; i++)
            {
				Console.WriteLine(argv[i]);
            }
			Console.WriteLine(argv[argv.Length - 1].Equals(""));
        }

        
    }
}

