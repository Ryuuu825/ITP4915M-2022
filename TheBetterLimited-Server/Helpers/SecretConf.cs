using System;
using System.Collections;

namespace TheBetterLimited_Server.Helpers
{
	public class SecretConf
	{
		public static SecretConf Instance = new SecretConf("etc/secret.conf");
		private Hashtable table;

		public SecretConf(string path)
		{
			String[] buffer = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + path);
			table = new Hashtable();

			for (int i = 0; i < buffer.Length; i++)
            {
				if (buffer[i].StartsWith("#") || buffer[i].Equals("")) // ignore the comment
					continue;

				else
                {
					String[] tmp = buffer[i].Split("=" , 2);
					
					table.Add(tmp[0], tmp[1].Trim('"'));
				}
            }
		}


		public string GetValue(string key)
        {
			if (table.ContainsKey(key))
				return (string) table[key];

			throw new KeyNotFoundException();
        }

		public string this[string key]
        {
			get { return GetValue(key); }
			private set { }
        }
	}
}

