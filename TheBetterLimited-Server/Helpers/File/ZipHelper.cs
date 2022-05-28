using System;
using System.IO;
using System.IO.Compression;

namespace TheBetterLimited_Server.Helpers.File
{
    public static class ZipHelper
    {
        public static string Compress(string TargetFolderPath , string Destination = "/var/tmpTmp.zip")
        {
            string zipFileName = AppDomain.CurrentDomain.BaseDirectory + Destination;
            string StartzFilePath = AppDomain.CurrentDomain.BaseDirectory + TargetFolderPath;
            ZipFile.CreateFromDirectory(StartzFilePath , zipFileName);
            return zipFileName;
        }

        public static string Decompress(string SourceFilePath , string Destination = "/var" , string FolderName = "tmp")
        {
            string FolderPath = AppDomain.CurrentDomain.BaseDirectory + SourceFilePath;
            string DestinationPath = AppDomain.CurrentDomain.BaseDirectory + Destination;
            try
            {
                if (Directory.Exists(DestinationPath + FolderName))
                {
                    Directory.Delete(DestinationPath + FolderName , true);
                }
                if (System.IO.File.Exists(Destination + ".DS_Store"))
                {
                    System.IO.File.Delete(Destination + ".DS_Store");
                }
                if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/__MACOSX"))
                {
                    Directory.Delete(AppDomain.CurrentDomain.BaseDirectory + "/__MACOSX" , true);
                }
            }catch(FileNotFoundException)
            {
                // do nothing
            }
            ZipFile.ExtractToDirectory(FolderPath , DestinationPath);
            return FolderPath;
        }
    }
}