namespace TheBetterLimited_Server.Helper.Logger
{
    public class FileLogger 
    {
        private readonly static string _LogPath = AppDomain.CurrentDomain.BaseDirectory + "/var/log/";


        public static void Log(LogLevel level, string header, string message)
        {
            System.IO.File.AppendAllText(_LogPath + level.ToString() + ".log", $"[{level.ToString()}]\t{header}\n\t\t{message}\n");
        }

        public static void AcceccLog(string user , string url )
        {
            System.IO.File.AppendAllText(_LogPath + $"{LogLevel.Access.ToString()}.log", $"[{DateTime.Now.ToString()}]:{user} {url}");

        }

        public static void InvalidAcceccLog(string socket , string url , string header)
        {
            System.IO.File.AppendAllText(_LogPath + $"{LogLevel.InvalidAccess.ToString()}.log", $"[{DateTime.Now.ToString()}]: {socket} -- {url}\n\n[Header]:\n{header}\n-----\n\n");

        }

    }
}

