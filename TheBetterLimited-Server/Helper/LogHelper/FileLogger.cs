namespace TheBetterLimited_Server.Helper.LogHelper
{
    public class FileLogger 
    {
        private readonly static string _LogPath = AppDomain.CurrentDomain.BaseDirectory + "/var/log/";

        public static void Log(string msg)
        {
            System.IO.File.AppendAllText(_LogPath + "tmp.log" , msg + "\r\n");
        }

        public static void AcceccLog(string user , string url )
        {
            System.IO.File.AppendAllText(_LogPath + $"{LogLevel.Access.ToString()}.log", $"[{DateTime.Now.ToString()}]:{user} {url}\r\n");

        }

        public static void InvalidAcceccLog(string socket , string url , string header)
        {
            System.IO.File.AppendAllText(_LogPath + $"{LogLevel.InvalidAccess.ToString()}.log", $"[{DateTime.Now.ToString()}]: {socket} -- {url}\r\n\r\n[Header]:\r\n{header}\r\n-----\r\n\r\n");

        }

    }
}

