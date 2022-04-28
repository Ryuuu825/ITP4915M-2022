using System;
using System.Text;

namespace TheBetterLimited_Server.Helpers.File
{
	public static class DynamicHtml
	{
		private static readonly string FileDir = AppDomain.CurrentDomain.BaseDirectory + "/resource/template/";



		/** <summary>
		 *	Replace the Data tag key's value passing in. <br></br>
		 *	The argv shoule provide keys and values like {"key":"value"}
		 *  </summary>
		*/
		public static string GetFile(string FileName, string [] argv)
        {
			StringBuilder buffer = new StringBuilder(System.IO.File.ReadAllText(FileDir + FileName));
			for (int i = 0; i < argv.Length; i++)
            {
				string[] para = argv[i].Split(":");
				buffer.Replace($"<datac id=\"{para[0]}\"></datac>" , para[1]);

            }
			return buffer.ToString();

        }

        
    }

}

