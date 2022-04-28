using System;
using Newtonsoft.Json.Linq;

namespace TheBetterLimited_Server.Helpers
{
	public class SecretConfig
	{
		public static readonly SecretConfig Instance = new SecretConfig(System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "secret.json"));

		private readonly JObject _config;

		public SecretConfig(string FilePath)
		{
			_config = JObject.Parse(FilePath);
		}

		public string GetValue(string key)
        {
			return _config.GetValue(key)?.ToString();
        }

		/**
		 * <summary>
		 * "objKey" : {
		 *	"key" : "value"
		 *	}
		 * </summary>
		 */
        public string GetValue(string objKey, string key)
        {
			return _config[objKey][key]?.ToString();
		}

		public JToken GetEmailDetail()
        {
			return _config["MailAccount"];
        }

		public string GetSection(string target)
        {
			string[] sep = target.Split(":");
			return _config[sep[0]][sep[1]].ToString();
        }

	}
}

