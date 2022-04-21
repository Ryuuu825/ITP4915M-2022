using System;
using System.IO;

namespace TheBetterLimited_Server.Helper.File
{
	public class TempFile : IDisposable
	{
		private static readonly string FolderPath = AppDomain.CurrentDomain.BaseDirectory + "/var";

		private String FilePath;
		private FileStream fileStream;
		private StreamWriter writer; 

		public bool IsClose { get; private set; } = false;


		public TempFile()
		{
			FilePath = Path.Combine(FolderPath, Path.GetRandomFileName() );
			fileStream = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite, 4092, FileOptions.DeleteOnClose);
			writer = new StreamWriter(fileStream);
		}



		public void Dispose()
		{
			if (!IsClose)
			{
				Close();
			}
		}

		public void Close()
		{
			writer.Close();
			fileStream.Close();
			IsClose = true;
		}

		public String ReadAllText()
		{
			return System.IO.File.ReadAllText(FilePath);
		}

		public void WriteAllText(string str)
		{
			writer.Write(str);
			writer.Flush();
		}

		public string GetFilePath()
        {
			return FilePath;
        }


	}
}

